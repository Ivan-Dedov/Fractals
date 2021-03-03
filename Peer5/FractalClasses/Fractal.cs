using System;
using System.Drawing;

namespace Peer5
{
    public abstract class Fractal
    {

        /// <summary>
        /// The number of steps in recursion while drawing the Fractal.
        /// </summary>
        public int RecursionDepth { get; set; }

        /// <summary>
        /// Drawing the Fractal.
        /// </summary>
        public abstract void Draw(Graphics g, FFractalPainter fp);

    }
}
