using System;
using System.Drawing;

namespace Peer5
{
    public class PythagoreanTree : Fractal
    {

        /// <summary>
        /// The coefficient by which to decrease the line length in each iteration.
        /// </summary>
        public double Coefficient { get; set; } = 0.5;

        /// <summary>
        /// The first angle.
        /// </summary>
        public double FirstAngle { get; set; } = -45;

        /// <summary>
        /// The second angle.
        /// </summary>
        public double SecondAngle { get; set; } = 45;

        /// <summary>
        /// Draws the Pythagorean Tree.
        /// </summary>
        private void DrawPythagoreanTree(Graphics g, Color firstColour, Color secondColour, int iterationsLeft,
            PointF start, int lineLength, double angle)
        {
            // Draw the lines.
            Color newColour = Constants.GetAverageColour(firstColour, secondColour, iterationsLeft, RecursionDepth);
            Pen pen = new Pen(newColour, 3);

            PointF nextPoint1 = new PointF((float)(start.X - lineLength * Math.Sin((angle - FirstAngle) * Math.PI / 180)),
                (float)(start.Y - lineLength * Math.Cos((angle - FirstAngle) * Math.PI / 180)));
            PointF nextPoint2 = new PointF((float)(start.X + lineLength * Math.Cos((angle + SecondAngle) * Math.PI / 180)),
                (float)(start.Y - lineLength * Math.Sin((angle + SecondAngle) * Math.PI / 180)));
            g.DrawLine(pen, start, nextPoint1);
            g.DrawLine(pen, start, nextPoint2);

            // If need to go deeper, repeat recursively.
            if (iterationsLeft > 0)
            {
                DrawPythagoreanTree(g, firstColour, secondColour, iterationsLeft - 1,
                    nextPoint1, (int)(lineLength * Coefficient), angle - FirstAngle);
                DrawPythagoreanTree(g, firstColour, secondColour, iterationsLeft - 1,
                    nextPoint2, (int)(lineLength * Coefficient), angle - SecondAngle);
            }
        }

        /// <summary>
        /// Draws the Pythagorean Tree Fractal.
        /// </summary>
        public override void Draw(Graphics g, FFractalPainter fp)
        {
            // Drawing the base line.
            Pen pen = new Pen(fp.firstColour, 3);
            PointF root = new PointF(fp.bitmapSize / 2, fp.bitmapSize - fp.distanceFromCorner);
            PointF beginBranch = new PointF(fp.bitmapSize / 2, fp.bitmapSize - fp.distanceFromCorner - fp.bitmapSize / 4);
            g.DrawLine(pen, root, beginBranch);

            // Draws the branches of the tree.
            DrawPythagoreanTree(g, fp.firstColour, fp.secondColour, RecursionDepth - 1,
                beginBranch, (int)((fp.bitmapSize / 4) * Coefficient), 0);
        }

    }
}
