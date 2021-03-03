using System;
using System.Drawing;

namespace Peer5
{
    public class KochCurve : Fractal
    {

        /// <summary>
        /// Draws the Koch Curve.
        /// </summary>
        private void DrawKochCurve(Graphics g, Color startingColour, Color endingColour, int iterationsLeft,
            int x, int y, double angle, int segmentLength)
        {
            // If no more iterations left, stop and draw the curve.
            if (iterationsLeft == 0)
            {
                Color newColour = Constants.GetAverageColour(startingColour, endingColour, iterationsLeft, RecursionDepth);
                Pen pen = new Pen(newColour, 3);
                PointF p0 = new PointF(x, y);
                PointF p1 = new PointF((int)(p0.X + segmentLength * Math.Cos(angle)),
                    (int)(p0.Y - segmentLength * Math.Sin(angle)));
                PointF p2 = new PointF((int)(p1.X + segmentLength * Math.Cos(angle + Math.PI / 3)),
                    (int)(p1.Y - segmentLength * Math.Sin(angle + Math.PI / 3)));
                PointF p3 = new PointF((int)(p2.X + segmentLength * Math.Cos(angle - Math.PI / 3)),
                    (int)(p2.Y - segmentLength * Math.Sin(angle - Math.PI / 3)));
                PointF p4 = new PointF((int)(p3.X + segmentLength * Math.Cos(angle)),
                    (int)(p3.Y - segmentLength * Math.Sin(angle)));
                g.DrawLine(pen, p0, p1);
                g.DrawLine(pen, p1, p2);
                g.DrawLine(pen, p2, p3);
                g.DrawLine(pen, p3, p4);
                return;
            }
            // Else, recursively draw new lines.
            DrawKochCurve(g, startingColour, endingColour, iterationsLeft - 1,
                x, y, angle, segmentLength / 3);
            DrawKochCurve(g, startingColour, endingColour, iterationsLeft - 1,
                (int)(x + segmentLength * Math.Cos(angle)), (int)(y - segmentLength * Math.Sin(angle)),
                angle + Math.PI / 3, segmentLength / 3);
            DrawKochCurve(g, startingColour, endingColour, iterationsLeft - 1,
                (int)((int)(x + segmentLength * Math.Cos(angle)) + segmentLength * Math.Cos(angle + Math.PI / 3)),
                (int)((int)(y - segmentLength * Math.Sin(angle)) - segmentLength * Math.Sin(angle + Math.PI / 3)),
                angle - Math.PI / 3, segmentLength / 3);
            DrawKochCurve(g, startingColour, endingColour, iterationsLeft - 1,
                (int)((int)((int)(x + segmentLength * Math.Cos(angle)) + segmentLength * Math.Cos(angle + Math.PI / 3)) + segmentLength * Math.Cos(angle - Math.PI / 3)),
                (int)((int)((int)(y - segmentLength * Math.Sin(angle)) - segmentLength * Math.Sin(angle + Math.PI / 3)) - segmentLength * Math.Sin(angle - Math.PI / 3)),
                angle, segmentLength / 3);
        }

        /// <summary>
        /// Draws the Koch Curve.
        /// </summary>
        /// <param name="g">The graphics surface.</param>
        /// <param name="fp">The form.</param>
        public override void Draw(Graphics g, FFractalPainter fp)
        {
            DrawKochCurve(g, fp.firstColour, fp.secondColour, RecursionDepth - 1,
                fp.distanceFromCorner, fp.bitmapSize / 2,
                0, (fp.bitmapSize - 2 * fp.distanceFromCorner) / 3);
        }

    }
}
