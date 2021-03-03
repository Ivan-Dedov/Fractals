using System;
using System.Drawing;

namespace Peer5
{
    public class SierpinskiCarpet : Fractal
    {

        /// <summary>
        /// Draws the Sierpinski Carpet.
        /// </summary>
        private void DrawSierpinskiCarpet(Graphics g, Color startingColour, Color endingColour,
            int iterationsLeft, RectangleF r)
        {
            Color newColour = Constants.GetAverageColour(startingColour, endingColour, iterationsLeft, RecursionDepth);

            // If reached the bottom, stop and fill the square.
            if (iterationsLeft == 0)
            {
                SolidBrush brush = new SolidBrush(newColour);
                g.FillRectangle(brush, r);
            }
            else
            {
                // Divide the rectangle into 9 pieces.
                float width = r.Width / 3f;
                float x0 = r.Left;
                float x1 = x0 + width;
                float x2 = x0 + width * 2f;

                float height = r.Height / 3f;
                float y0 = r.Top;
                float y1 = y0 + height;
                float y2 = y0 + height * 2f;

                // Recursively draw smaller carpets.
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x0, y0, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x1, y0, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x2, y0, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x0, y1, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x2, y1, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x0, y2, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x1, y2, width, height));
                DrawSierpinskiCarpet(g, startingColour, endingColour, iterationsLeft - 1,
                    new RectangleF(x2, y2, width, height));
            }
        }


        /// <summary>
        /// Draws the Sierpinski Carpet.
        /// </summary>
        /// <param name="g">The graphics surface.</param>
        /// <param name="fp">The form.</param>
        public override void Draw(Graphics g, FFractalPainter fp)
        {
            RectangleF rectangle = new RectangleF(fp.distanceFromCorner, fp.distanceFromCorner,
                fp.bitmapSize - 2 * fp.distanceFromCorner,
                fp.bitmapSize - 2 * fp.distanceFromCorner);
            DrawSierpinskiCarpet(g, fp.firstColour, fp.secondColour, RecursionDepth, rectangle);
        }

    }
}
