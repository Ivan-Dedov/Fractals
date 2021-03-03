using System;
using System.Drawing;

namespace Peer5
{
    public static class Constants
    {

        public static readonly int MAX_RECURSION_SIERPINSKI_TRIANGLE = 10;
        public static readonly int MAX_RECURSION_SIERPINSKI_CARPET = 7;
        public static readonly int MAX_RECURSION_CANTOR_SET = 7;
        public static readonly int MAX_RECURSION_PYTHAGOREAN_TREE = 12;
        public static readonly int MAX_RECURSION_KOCH_CURVE = 6;
        public static readonly int BITMAP_SIZE = 925;
        public static readonly int DISTANCE_FROM_CORNER = 9;
        public static readonly int CANTOR_RECTANGLE_WIDTH = 9;
        public static readonly int MINIMUM_DISTANCE_BETWEEN_LINES = 25;

        /// <summary>
        /// Gets the average colour of the two (linear gradient).
        /// </summary>
        /// <param name="first">Starting colour.</param>
        /// <param name="second">Ending colour.</param>
        /// <param name="iterationsLeft">The number of iterations left.</param>
        /// <param name="recursionDepth">The depth of the recusion.</param>
        /// <returns></returns>
        public static Color GetAverageColour(Color first, Color second, int iterationsLeft, int recursionDepth)
        {
            int avgRed = second.R + (first.R - second.R) * iterationsLeft / recursionDepth;
            int avgGreen = second.G + (first.G - second.G) * iterationsLeft / recursionDepth;
            int avgBlue = second.B + (first.B - second.B) * iterationsLeft / recursionDepth;
            return Color.FromArgb(avgRed, avgGreen, avgBlue);
        }

    }
}
