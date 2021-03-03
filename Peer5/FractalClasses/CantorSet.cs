using System;
using System.Drawing;

namespace Peer5
{
    public class CantorSet : Fractal
    {

        /// <summary>
        /// The distance between lines drawn on two iterations of the recursion.
        /// </summary>
        public int DistanceBetweenIterations { get; set; }

        /// <summary>
        /// Draws the Cantor Set.
        /// </summary>
        private void DrawCantorSet(Graphics g, Color startingColour, Color endingColour, int rectangleWidth,
            int iterationsLeft, PointF start, int length)
        {
            // If no more iterations left, stop.
            if (iterationsLeft == 0)
            {
                return;
            }
            // Else, recursively draw lines.
            Color newColour = Constants.GetAverageColour(startingColour, endingColour, iterationsLeft, RecursionDepth);
            SolidBrush brush = new SolidBrush(newColour);
            Rectangle rectangle = new Rectangle((int)start.X, (int)start.Y, length, rectangleWidth);
            g.FillRectangle(brush, rectangle);

            start.Y += DistanceBetweenIterations;
            DrawCantorSet(g, startingColour, endingColour, rectangleWidth, iterationsLeft - 1, start, length / 3);
            DrawCantorSet(g, startingColour, endingColour, rectangleWidth, iterationsLeft - 1,
                new Point((int)(start.X + 2 * length / 3), (int)start.Y), length / 3);
        }

        /// <summary>
        /// Draws the Cantor Set Fractal.
        /// </summary>
        public override void Draw(Graphics g, FFractalPainter fp)
        {
            DrawCantorSet(g, fp.firstColour, fp.secondColour, fp.cantorRectangleWidth, RecursionDepth,
                new Point(fp.distanceFromCorner, fp.distanceFromCorner),
                fp.bitmapSize - 2 * fp.distanceFromCorner);
        }

    }
}
