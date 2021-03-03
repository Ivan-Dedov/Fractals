using System;
using System.Drawing;

namespace Peer5
{
    public class SierpinskiTriangle : Fractal
    {

        /// <summary>
        /// Draws the Sierpinski Triangle Fractal.
        /// </summary>
        private void DrawSierpinskiTriangle(Graphics g, Color startingColour, Color endingColour, int iterationsLeft,
            PointF top, PointF left, PointF right)
        {
            Color newColour = Constants.GetAverageColour(startingColour, endingColour, iterationsLeft, RecursionDepth);
            SolidBrush brush = new SolidBrush(newColour);

            // If reached the bottom, stop and fill the triangle.
            if (iterationsLeft == 0)
            {
                PointF[] points = { top, right, left };
                g.FillPolygon(brush, points);
                return;
            }

            // Find the midpoints of the three sides.
            PointF leftSideMid = new PointF((top.X + left.X) / 2f, (top.Y + left.Y) / 2f);
            PointF rightSideMid = new PointF((top.X + right.X) / 2f, (top.Y + right.Y) / 2f);
            PointF bottomSideMid = new PointF((left.X + right.X) / 2f, (left.Y + right.Y) / 2f);

            // Recursively draw triangles.
            DrawSierpinskiTriangle(g, startingColour, endingColour, iterationsLeft - 1, top, leftSideMid, rightSideMid);
            DrawSierpinskiTriangle(g, startingColour, endingColour, iterationsLeft - 1, leftSideMid, left, bottomSideMid);
            DrawSierpinskiTriangle(g, startingColour, endingColour, iterationsLeft - 1, rightSideMid, bottomSideMid, right);
        }

        /// <summary>
        /// Draws the Sierpinski Triangle.
        /// </summary>
        /// <param name="g">The graphics surface.</param>
        /// <param name="fp">The form.</param>
        public override void Draw(Graphics g, FFractalPainter fp)
        {
            DrawSierpinskiTriangle(g, fp.firstColour, fp.secondColour, RecursionDepth,
                new PointF(fp.bitmapSize / 2, fp.distanceFromCorner),
                new PointF(fp.distanceFromCorner, fp.bitmapSize - fp.distanceFromCorner),
                new PointF(fp.bitmapSize - fp.distanceFromCorner,
                fp.bitmapSize - fp.distanceFromCorner));
        }

    }
}
