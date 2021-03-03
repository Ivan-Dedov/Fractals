using System;
using System.Drawing;
using System.Windows.Forms;

namespace Peer5
{
    public partial class FFractalPainter : Form
    {

        /// <summary>
        /// Creates a new Form.
        /// </summary>
        public FFractalPainter()
        {
            InitializeComponent();
            MaximumSize = SystemInformation.PrimaryMonitorSize;
            MinimumSize = SystemInformation.PrimaryMonitorSize / 2;
            ChangeVisivilityOfCantorSetOptions(false);
            ChangeVisibilityOfPythagoreanTreeOptions(false);
            LRecursionDepth.Text = "Recursion Depth: " + TBRecursionDepth.Value;
            LLineCoefficient.Text = "Line Length Coefficient: " + TBLineCoefficient.Value / 100.0;
            LFirstAngle.Text = "Left Branch Angle: " + TBFirstAngle.Value + "\u00B0";
            LSecondAngle.Text = "Left Branch Angle: " + TBSecondAngle.Value + "\u00B0";
            LDistanceBetweenLines.Text = "Distance Between Lines: " + TBDistanceBetweenLines.Value;
            BFirstColour.BackColor = firstColour;
            BSecondColour.BackColor = secondColour;
            BZoomOut.Hide();
        }

        /// <summary>
        /// The fractal to be drawn.
        /// </summary>
        private Fractal fractal;

        /// <summary>
        /// The zoom value for the image.
        /// </summary>
        private int zoom = 1;

        /// <summary>
        /// The size of the bitmap on which to draw (in pixels).
        /// </summary>
        public int bitmapSize { get; set; } = Constants.BITMAP_SIZE;

        /// <summary>
        /// The distance from the corner of the frame (in pixels).
        /// </summary>
        public int distanceFromCorner { get; set; } = Constants.DISTANCE_FROM_CORNER;

        /// <summary>
        /// The width of the rectangle in the Cantor Set (in pixels).
        /// </summary>
        public int cantorRectangleWidth { get; set; } = Constants.CANTOR_RECTANGLE_WIDTH;

        /// <summary>
        /// The distance between two adjacent lines in the Cantor Set (in pixels).
        /// </summary>
        public int distanceBetweenLines { get; set; } = Constants.MINIMUM_DISTANCE_BETWEEN_LINES;

        /// <summary>
        /// The starting colour of the Fractal.
        /// </summary>
        public Color firstColour { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// The ending colour of the Fractal.
        /// </summary>
        public Color secondColour { get; set; } = Color.FromArgb(255, 255, 255);

        /// <summary>
        /// Selects a Fractal type.
        /// </summary>
        /// <param name="fractalIndex">The index of the Fractal to be selected.</param>
        /// <returns>The Fractal of the appropriate type.</returns>
        private Fractal GetFractal(int fractalIndex)
        {
            switch (fractalIndex)
            {
                case 0:
                    TBRecursionDepth.Maximum = Constants.MAX_RECURSION_PYTHAGOREAN_TREE;
                    return new PythagoreanTree();
                case 1:
                    TBRecursionDepth.Maximum = Constants.MAX_RECURSION_KOCH_CURVE;
                    return new KochCurve();
                case 2:
                    TBRecursionDepth.Maximum = Constants.MAX_RECURSION_SIERPINSKI_CARPET;
                    return new SierpinskiCarpet();
                case 3:
                    TBRecursionDepth.Maximum = Constants.MAX_RECURSION_SIERPINSKI_TRIANGLE;
                    return new SierpinskiTriangle();
                case 4:
                    TBRecursionDepth.Maximum = Constants.MAX_RECURSION_CANTOR_SET;
                    return new CantorSet();
                default:
                    throw new ArgumentException("Incorrect fractal index.");
            }
        }

        // Displays the correct options for the corresponding fractals.
        private void CBFractalSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Changing the selected fractal.
            fractal = GetFractal(CBFractalSelector.SelectedIndex);

            // Changing the labels and toggling the visibility of the appropriate buttons and labels.
            LRecursionDepth.Text = "Recursion Depth: " + TBRecursionDepth.Value;
            fractal.RecursionDepth = TBRecursionDepth.Value;
            LRecursionDepth.Show();
            TBRecursionDepth.Show();
            BFirstColour.Show();
            BSecondColour.Show();
            if (CBFractalSelector.SelectedIndex == 0)
            {
                ChangeVisivilityOfCantorSetOptions(false);
                ChangeVisibilityOfPythagoreanTreeOptions(true);
            }
            else
            {
                if (CBFractalSelector.SelectedIndex == 4)
                {
                    ChangeVisivilityOfCantorSetOptions(true);
                    ChangeVisibilityOfPythagoreanTreeOptions(false);
                }
                else
                {
                    ChangeVisivilityOfCantorSetOptions(false);
                    ChangeVisibilityOfPythagoreanTreeOptions(false);
                }
            }
        }

        /// <summary>
        /// Changes the visibilty of the Pythagorean Tree options on the form.
        /// </summary>
        /// <param name="show">true, if they need to be shown; false, otherwise.</param>
        private void ChangeVisibilityOfPythagoreanTreeOptions(bool show)
        {
            if (show)
            {
                LLineCoefficient.Show();
                TBLineCoefficient.Show();
                LFirstAngle.Show();
                TBFirstAngle.Show();
                LSecondAngle.Show();
                TBSecondAngle.Show();
                return;
            }
            LLineCoefficient.Hide();
            TBLineCoefficient.Hide();
            LFirstAngle.Hide();
            TBFirstAngle.Hide();
            LSecondAngle.Hide();
            TBSecondAngle.Hide();
        }

        /// <summary>
        /// Changes the visibility of the Cantor Set options on the form.
        /// </summary>
        /// <param name="show">true, if they need to be shown; false, otherwise.</param>
        private void ChangeVisivilityOfCantorSetOptions(bool show)
        {
            if (show)
            {
                LDistanceBetweenLines.Show();
                TBDistanceBetweenLines.Show();
                return;
            }
            LDistanceBetweenLines.Hide();
            TBDistanceBetweenLines.Hide();
        }

        // Selects the starting colour for the fractal.
        private void BFirstColour_Click(object sender, EventArgs e)
        {
            if (CDColourPicker.ShowDialog() == DialogResult.OK)
            {
                BFirstColour.BackColor = CDColourPicker.Color;
                firstColour = CDColourPicker.Color;
                DrawFractal();
            }
        }

        // Selects the ending colour for the fractal.
        private void BSecondColour_Click(object sender, EventArgs e)
        {
            if (CDColourPicker.ShowDialog() == DialogResult.OK)
            {
                BSecondColour.BackColor = CDColourPicker.Color;
                secondColour = CDColourPicker.Color;
                DrawFractal();
            }
        }

        // Draws the fractal.
        private void BDrawFractal_Click(object sender, EventArgs e)
        {
            if (fractal == null)
            {
                MessageBox.Show("Please select a fractal to be drawn!", "No Fractal Selected");
                return;
            }
            zoom = 1;
            ChangeZoomSettings(1);
            BZoomOut.Hide();
            BZoomIn.Show();
            BZoomIn.Text = "Zoom In (to 2x)";
            DrawFractal();
        }

        /// <summary>
        /// Draws the Fractal.
        /// </summary>
        private void DrawFractal()
        {
            Bitmap bitmap = new Bitmap(bitmapSize, bitmapSize);
            using (Graphics gfx = Graphics.FromImage(bitmap))
            using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 0, 0)))
            {
                gfx.FillRectangle(brush, 0, 0, bitmapSize, bitmapSize);
            }
            PBFractalCanvas.Image = bitmap;
            fractal.Draw(Graphics.FromImage(PBFractalCanvas.Image), this);
        }

        // Selecting the recursion depth.
        private void TBRecursionDepth_Scroll(object sender, EventArgs e)
        {
            LRecursionDepth.Text = "Recursion Depth: " + TBRecursionDepth.Value;
            fractal.RecursionDepth = TBRecursionDepth.Value;
            DrawFractal();
        }

        // Selecting the coefficient by which do decrease the line length
        // of the next step in the Fractal.
        private void TBLineCoefficient_Scroll(object sender, EventArgs e)
        {
            LLineCoefficient.Text = "Line Length Coefficient: " + TBLineCoefficient.Value / 100.0;
            if (fractal is PythagoreanTree)
            {
                (fractal as PythagoreanTree).Coefficient = TBLineCoefficient.Value / 100.0;
                DrawFractal();
            }
            else
            {
                throw new ArgumentException("Incorrect fractal type: Pythagorean Tree required.");
            }
        }

        // Selecting the angle by which to rotate the left branch.
        private void TBFirstAngle_Scroll(object sender, EventArgs e)
        {
            LFirstAngle.Text = "Left Branch Angle: " + TBFirstAngle.Value + "\u00B0";
            if (fractal is PythagoreanTree)
            {
                (fractal as PythagoreanTree).FirstAngle = TBFirstAngle.Value;
                DrawFractal();
            }
            else
            {
                throw new ArgumentException("Incorrect fractal type: Pythagorean Tree required.");
            }
        }

        // Selecting the angle by which to rotate the right branch.
        private void TBSecondAngle_Scroll(object sender, EventArgs e)
        {
            LSecondAngle.Text = "Right Branch Angle: " + TBSecondAngle.Value + "\u00B0";
            if (fractal is PythagoreanTree)
            {
                (fractal as PythagoreanTree).SecondAngle = TBSecondAngle.Value;
                DrawFractal();
            }
            else
            {
                throw new ArgumentException("Incorrect fractal type: Pythagorean Tree required.");
            }
        }

        // Selecting the distance between lines drawn on consequent iterations.
        private void TBDistanceBetweenLines_Scroll(object sender, EventArgs e)
        {
            LDistanceBetweenLines.Text = "Distance Between Lines: " + TBDistanceBetweenLines.Value;
            if (fractal is CantorSet)
            {
                (fractal as CantorSet).DistanceBetweenIterations = TBDistanceBetweenLines.Value * zoom;
            }
            else
            {
                throw new ArgumentException("Incorrect fractal type: Cantor Set required.");
            }
        }

        // Zooms in.
        private void BZoomIn_Click(object sender, EventArgs e)
        {
            if (fractal == null)
            {
                return;
            }
            switch (zoom)
            {
                case 1:
                    ChangeZoomSettings(2);
                    BZoomOut.Text = "Zoom Out (to 1x)";
                    BZoomIn.Text = "Zoom In (to 3x)";
                    BZoomOut.Show();
                    break;
                case 2:
                    ChangeZoomSettings(3);
                    BZoomOut.Text = "Zoom Out (to 2x)";
                    BZoomIn.Text = "Zoom In (to 5x)";
                    BZoomOut.Show();
                    break;
                case 3:
                    ChangeZoomSettings(5);
                    BZoomOut.Text = "Zoom Out (to 3x)";
                    BZoomOut.Show();
                    BZoomIn.Hide();
                    break;
                default:
                    throw new ArgumentException("Incorrect zoom.");
            }
            DrawFractal();
        }

        // Zooms out.
        private void BZoomOut_Click(object sender, EventArgs e)
        {
            if (fractal == null)
            {
                return;
            }
            switch (zoom)
            {
                case 2:
                    ChangeZoomSettings(1);
                    BZoomIn.Text = "Zoom In (to 2x)";
                    BZoomOut.Hide();
                    BZoomIn.Show();
                    break;
                case 3:
                    ChangeZoomSettings(2);
                    BZoomOut.Text = "Zoom Out (to 1x)";
                    BZoomIn.Text = "Zoom In (to 3x)";
                    BZoomIn.Show();
                    break;
                case 5:
                    ChangeZoomSettings(3);
                    BZoomOut.Text = "Zoom Out (to 2x)";
                    BZoomIn.Text = "Zoom In (to 5x)";
                    BZoomIn.Show();
                    break;
                default:
                    throw new ArgumentException("Incorrect zoom.");
            }
            DrawFractal();
        }

        /// <summary>
        /// Changes the zoom value.
        /// </summary>
        /// <param name="zoom">The new value.</param>
        private void ChangeZoomSettings(int zoom)
        {
            this.zoom = zoom;
            bitmapSize = Constants.BITMAP_SIZE * zoom;
            cantorRectangleWidth = Constants.CANTOR_RECTANGLE_WIDTH * zoom;
            distanceFromCorner = Constants.DISTANCE_FROM_CORNER * zoom;
            distanceBetweenLines = TBDistanceBetweenLines.Value * zoom;

            if (fractal is CantorSet)
            {
                (fractal as CantorSet).DistanceBetweenIterations = distanceBetweenLines * zoom;
            }
        }

        // Saves the images as a .png file.
        private void BSave_Click(object sender, EventArgs e)
        {
            if (PBFractalCanvas.Image == null)
            {
                return;
            }
            PBFractalCanvas.Image.Save("myAwesomeFractal.png");
        }
    }
}
