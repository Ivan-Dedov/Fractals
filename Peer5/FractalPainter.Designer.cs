
namespace Peer5
{
    partial class FFractalPainter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLPTitle = new System.Windows.Forms.TableLayoutPanel();
            this.TLPFractal = new System.Windows.Forms.TableLayoutPanel();
            this.TLPSettings = new System.Windows.Forms.TableLayoutPanel();
            this.TLPAdditionalSettings = new System.Windows.Forms.TableLayoutPanel();
            this.LLineCoefficient = new System.Windows.Forms.Label();
            this.LDistanceBetweenLines = new System.Windows.Forms.Label();
            this.LFirstAngle = new System.Windows.Forms.Label();
            this.LSecondAngle = new System.Windows.Forms.Label();
            this.TBLineCoefficient = new System.Windows.Forms.TrackBar();
            this.TBSecondAngle = new System.Windows.Forms.TrackBar();
            this.TBFirstAngle = new System.Windows.Forms.TrackBar();
            this.TBDistanceBetweenLines = new System.Windows.Forms.TrackBar();
            this.LCustomizeFractal = new System.Windows.Forms.Label();
            this.TLPRecursionDepth = new System.Windows.Forms.TableLayoutPanel();
            this.LRecursionDepth = new System.Windows.Forms.Label();
            this.TBRecursionDepth = new System.Windows.Forms.TrackBar();
            this.TLPColours = new System.Windows.Forms.TableLayoutPanel();
            this.BFirstColour = new System.Windows.Forms.Button();
            this.BSecondColour = new System.Windows.Forms.Button();
            this.BDrawFractal = new System.Windows.Forms.Button();
            this.CBFractalSelector = new System.Windows.Forms.ComboBox();
            this.TLPPictureDrawer = new System.Windows.Forms.TableLayoutPanel();
            this.TLPPictureButtons = new System.Windows.Forms.TableLayoutPanel();
            this.BZoomIn = new System.Windows.Forms.Button();
            this.BZoomOut = new System.Windows.Forms.Button();
            this.BSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PBFractalCanvas = new System.Windows.Forms.PictureBox();
            this.CDColourPicker = new System.Windows.Forms.ColorDialog();
            this.TLPTitle.SuspendLayout();
            this.TLPFractal.SuspendLayout();
            this.TLPSettings.SuspendLayout();
            this.TLPAdditionalSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBLineCoefficient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSecondAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFirstAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBDistanceBetweenLines)).BeginInit();
            this.TLPRecursionDepth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBRecursionDepth)).BeginInit();
            this.TLPColours.SuspendLayout();
            this.TLPPictureDrawer.SuspendLayout();
            this.TLPPictureButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFractalCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // TLPTitle
            // 
            this.TLPTitle.AutoScroll = true;
            this.TLPTitle.BackColor = System.Drawing.Color.Transparent;
            this.TLPTitle.ColumnCount = 1;
            this.TLPTitle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPTitle.Controls.Add(this.TLPFractal, 0, 0);
            this.TLPTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPTitle.Location = new System.Drawing.Point(0, 0);
            this.TLPTitle.Name = "TLPTitle";
            this.TLPTitle.RowCount = 1;
            this.TLPTitle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPTitle.Size = new System.Drawing.Size(1123, 632);
            this.TLPTitle.TabIndex = 0;
            // 
            // TLPFractal
            // 
            this.TLPFractal.AutoScroll = true;
            this.TLPFractal.BackColor = System.Drawing.Color.Transparent;
            this.TLPFractal.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TLPFractal.ColumnCount = 2;
            this.TLPFractal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPFractal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPFractal.Controls.Add(this.TLPSettings, 0, 0);
            this.TLPFractal.Controls.Add(this.TLPPictureDrawer, 1, 0);
            this.TLPFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPFractal.Location = new System.Drawing.Point(3, 3);
            this.TLPFractal.Name = "TLPFractal";
            this.TLPFractal.RowCount = 1;
            this.TLPFractal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPFractal.Size = new System.Drawing.Size(1117, 626);
            this.TLPFractal.TabIndex = 1;
            // 
            // TLPSettings
            // 
            this.TLPSettings.AutoScroll = true;
            this.TLPSettings.ColumnCount = 1;
            this.TLPSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPSettings.Controls.Add(this.TLPAdditionalSettings, 0, 3);
            this.TLPSettings.Controls.Add(this.LCustomizeFractal, 0, 0);
            this.TLPSettings.Controls.Add(this.TLPRecursionDepth, 0, 2);
            this.TLPSettings.Controls.Add(this.TLPColours, 0, 4);
            this.TLPSettings.Controls.Add(this.BDrawFractal, 0, 5);
            this.TLPSettings.Controls.Add(this.CBFractalSelector, 0, 1);
            this.TLPSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPSettings.Location = new System.Drawing.Point(4, 4);
            this.TLPSettings.Name = "TLPSettings";
            this.TLPSettings.RowCount = 6;
            this.TLPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPSettings.Size = new System.Drawing.Size(551, 618);
            this.TLPSettings.TabIndex = 0;
            // 
            // TLPAdditionalSettings
            // 
            this.TLPAdditionalSettings.AutoScroll = true;
            this.TLPAdditionalSettings.BackColor = System.Drawing.Color.Transparent;
            this.TLPAdditionalSettings.ColumnCount = 2;
            this.TLPAdditionalSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPAdditionalSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPAdditionalSettings.Controls.Add(this.LLineCoefficient, 0, 0);
            this.TLPAdditionalSettings.Controls.Add(this.LDistanceBetweenLines, 1, 0);
            this.TLPAdditionalSettings.Controls.Add(this.LFirstAngle, 0, 2);
            this.TLPAdditionalSettings.Controls.Add(this.LSecondAngle, 1, 2);
            this.TLPAdditionalSettings.Controls.Add(this.TBLineCoefficient, 0, 1);
            this.TLPAdditionalSettings.Controls.Add(this.TBSecondAngle, 1, 3);
            this.TLPAdditionalSettings.Controls.Add(this.TBFirstAngle, 0, 3);
            this.TLPAdditionalSettings.Controls.Add(this.TBDistanceBetweenLines, 1, 1);
            this.TLPAdditionalSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPAdditionalSettings.Location = new System.Drawing.Point(3, 248);
            this.TLPAdditionalSettings.Name = "TLPAdditionalSettings";
            this.TLPAdditionalSettings.RowCount = 4;
            this.TLPAdditionalSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPAdditionalSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPAdditionalSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPAdditionalSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLPAdditionalSettings.Size = new System.Drawing.Size(545, 179);
            this.TLPAdditionalSettings.TabIndex = 0;
            // 
            // LLineCoefficient
            // 
            this.LLineCoefficient.AutoSize = true;
            this.LLineCoefficient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LLineCoefficient.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LLineCoefficient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LLineCoefficient.Location = new System.Drawing.Point(3, 0);
            this.LLineCoefficient.Name = "LLineCoefficient";
            this.LLineCoefficient.Size = new System.Drawing.Size(266, 35);
            this.LLineCoefficient.TabIndex = 0;
            this.LLineCoefficient.Text = "Length Coefficient";
            this.LLineCoefficient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LLineCoefficient.Visible = false;
            // 
            // LDistanceBetweenLines
            // 
            this.LDistanceBetweenLines.AutoSize = true;
            this.LDistanceBetweenLines.BackColor = System.Drawing.Color.Transparent;
            this.LDistanceBetweenLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LDistanceBetweenLines.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LDistanceBetweenLines.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LDistanceBetweenLines.Location = new System.Drawing.Point(275, 0);
            this.LDistanceBetweenLines.Name = "LDistanceBetweenLines";
            this.LDistanceBetweenLines.Size = new System.Drawing.Size(267, 35);
            this.LDistanceBetweenLines.TabIndex = 1;
            this.LDistanceBetweenLines.Text = "Distance Between Lines";
            this.LDistanceBetweenLines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LDistanceBetweenLines.Visible = false;
            // 
            // LFirstAngle
            // 
            this.LFirstAngle.AutoSize = true;
            this.LFirstAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LFirstAngle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LFirstAngle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LFirstAngle.Location = new System.Drawing.Point(3, 88);
            this.LFirstAngle.Name = "LFirstAngle";
            this.LFirstAngle.Size = new System.Drawing.Size(266, 35);
            this.LFirstAngle.TabIndex = 5;
            this.LFirstAngle.Text = "Left Branch Angle";
            this.LFirstAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LFirstAngle.Visible = false;
            // 
            // LSecondAngle
            // 
            this.LSecondAngle.AutoSize = true;
            this.LSecondAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LSecondAngle.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LSecondAngle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LSecondAngle.Location = new System.Drawing.Point(275, 88);
            this.LSecondAngle.Name = "LSecondAngle";
            this.LSecondAngle.Size = new System.Drawing.Size(267, 35);
            this.LSecondAngle.TabIndex = 6;
            this.LSecondAngle.Text = "Right Branch Angle";
            this.LSecondAngle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LSecondAngle.Visible = false;
            // 
            // TBLineCoefficient
            // 
            this.TBLineCoefficient.BackColor = System.Drawing.Color.Black;
            this.TBLineCoefficient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBLineCoefficient.LargeChange = 1;
            this.TBLineCoefficient.Location = new System.Drawing.Point(3, 38);
            this.TBLineCoefficient.Maximum = 70;
            this.TBLineCoefficient.Name = "TBLineCoefficient";
            this.TBLineCoefficient.Size = new System.Drawing.Size(266, 47);
            this.TBLineCoefficient.TabIndex = 7;
            this.TBLineCoefficient.Value = 50;
            this.TBLineCoefficient.Scroll += new System.EventHandler(this.TBLineCoefficient_Scroll);
            // 
            // TBSecondAngle
            // 
            this.TBSecondAngle.BackColor = System.Drawing.Color.Black;
            this.TBSecondAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBSecondAngle.LargeChange = 10;
            this.TBSecondAngle.Location = new System.Drawing.Point(275, 126);
            this.TBSecondAngle.Maximum = 180;
            this.TBSecondAngle.Minimum = -180;
            this.TBSecondAngle.Name = "TBSecondAngle";
            this.TBSecondAngle.Size = new System.Drawing.Size(267, 50);
            this.TBSecondAngle.TabIndex = 9;
            this.TBSecondAngle.Value = 45;
            this.TBSecondAngle.Scroll += new System.EventHandler(this.TBSecondAngle_Scroll);
            // 
            // TBFirstAngle
            // 
            this.TBFirstAngle.BackColor = System.Drawing.Color.Black;
            this.TBFirstAngle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBFirstAngle.LargeChange = 10;
            this.TBFirstAngle.Location = new System.Drawing.Point(3, 126);
            this.TBFirstAngle.Maximum = 180;
            this.TBFirstAngle.Minimum = -180;
            this.TBFirstAngle.Name = "TBFirstAngle";
            this.TBFirstAngle.Size = new System.Drawing.Size(266, 50);
            this.TBFirstAngle.TabIndex = 10;
            this.TBFirstAngle.Value = -45;
            this.TBFirstAngle.Scroll += new System.EventHandler(this.TBFirstAngle_Scroll);
            // 
            // TBDistanceBetweenLines
            // 
            this.TBDistanceBetweenLines.BackColor = System.Drawing.Color.Black;
            this.TBDistanceBetweenLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBDistanceBetweenLines.LargeChange = 1;
            this.TBDistanceBetweenLines.Location = new System.Drawing.Point(275, 38);
            this.TBDistanceBetweenLines.Maximum = 100;
            this.TBDistanceBetweenLines.Minimum = 25;
            this.TBDistanceBetweenLines.Name = "TBDistanceBetweenLines";
            this.TBDistanceBetweenLines.Size = new System.Drawing.Size(267, 47);
            this.TBDistanceBetweenLines.TabIndex = 11;
            this.TBDistanceBetweenLines.Value = 25;
            this.TBDistanceBetweenLines.Scroll += new System.EventHandler(this.TBDistanceBetweenLines_Scroll);
            // 
            // LCustomizeFractal
            // 
            this.LCustomizeFractal.AutoSize = true;
            this.LCustomizeFractal.BackColor = System.Drawing.Color.Transparent;
            this.LCustomizeFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LCustomizeFractal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LCustomizeFractal.ForeColor = System.Drawing.Color.White;
            this.LCustomizeFractal.Location = new System.Drawing.Point(3, 0);
            this.LCustomizeFractal.Name = "LCustomizeFractal";
            this.LCustomizeFractal.Size = new System.Drawing.Size(545, 61);
            this.LCustomizeFractal.TabIndex = 1;
            this.LCustomizeFractal.Text = "Customize your fractal:";
            this.LCustomizeFractal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TLPRecursionDepth
            // 
            this.TLPRecursionDepth.AutoScroll = true;
            this.TLPRecursionDepth.ColumnCount = 1;
            this.TLPRecursionDepth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPRecursionDepth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPRecursionDepth.Controls.Add(this.LRecursionDepth, 0, 0);
            this.TLPRecursionDepth.Controls.Add(this.TBRecursionDepth, 0, 1);
            this.TLPRecursionDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPRecursionDepth.Location = new System.Drawing.Point(3, 125);
            this.TLPRecursionDepth.Name = "TLPRecursionDepth";
            this.TLPRecursionDepth.RowCount = 2;
            this.TLPRecursionDepth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPRecursionDepth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPRecursionDepth.Size = new System.Drawing.Size(545, 117);
            this.TLPRecursionDepth.TabIndex = 3;
            // 
            // LRecursionDepth
            // 
            this.LRecursionDepth.AutoSize = true;
            this.LRecursionDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LRecursionDepth.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LRecursionDepth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LRecursionDepth.Location = new System.Drawing.Point(3, 0);
            this.LRecursionDepth.Name = "LRecursionDepth";
            this.LRecursionDepth.Size = new System.Drawing.Size(539, 58);
            this.LRecursionDepth.TabIndex = 0;
            this.LRecursionDepth.Text = "Recursion Depth";
            this.LRecursionDepth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LRecursionDepth.Visible = false;
            // 
            // TBRecursionDepth
            // 
            this.TBRecursionDepth.BackColor = System.Drawing.Color.Black;
            this.TBRecursionDepth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBRecursionDepth.LargeChange = 1;
            this.TBRecursionDepth.Location = new System.Drawing.Point(3, 61);
            this.TBRecursionDepth.Maximum = 25;
            this.TBRecursionDepth.Minimum = 1;
            this.TBRecursionDepth.Name = "TBRecursionDepth";
            this.TBRecursionDepth.Size = new System.Drawing.Size(539, 53);
            this.TBRecursionDepth.TabIndex = 1;
            this.TBRecursionDepth.Value = 1;
            this.TBRecursionDepth.Visible = false;
            this.TBRecursionDepth.Scroll += new System.EventHandler(this.TBRecursionDepth_Scroll);
            // 
            // TLPColours
            // 
            this.TLPColours.AutoScroll = true;
            this.TLPColours.BackColor = System.Drawing.Color.Transparent;
            this.TLPColours.ColumnCount = 2;
            this.TLPColours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPColours.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPColours.Controls.Add(this.BFirstColour, 0, 0);
            this.TLPColours.Controls.Add(this.BSecondColour, 1, 0);
            this.TLPColours.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPColours.Location = new System.Drawing.Point(3, 433);
            this.TLPColours.Name = "TLPColours";
            this.TLPColours.RowCount = 1;
            this.TLPColours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPColours.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.TLPColours.Size = new System.Drawing.Size(545, 117);
            this.TLPColours.TabIndex = 4;
            // 
            // BFirstColour
            // 
            this.BFirstColour.BackColor = System.Drawing.Color.White;
            this.BFirstColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BFirstColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BFirstColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BFirstColour.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BFirstColour.Location = new System.Drawing.Point(3, 3);
            this.BFirstColour.Name = "BFirstColour";
            this.BFirstColour.Size = new System.Drawing.Size(266, 111);
            this.BFirstColour.TabIndex = 0;
            this.BFirstColour.Text = "Starting Colour";
            this.BFirstColour.UseVisualStyleBackColor = false;
            this.BFirstColour.Visible = false;
            this.BFirstColour.Click += new System.EventHandler(this.BFirstColour_Click);
            // 
            // BSecondColour
            // 
            this.BSecondColour.BackColor = System.Drawing.Color.White;
            this.BSecondColour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSecondColour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BSecondColour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSecondColour.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BSecondColour.Location = new System.Drawing.Point(275, 3);
            this.BSecondColour.Name = "BSecondColour";
            this.BSecondColour.Size = new System.Drawing.Size(267, 111);
            this.BSecondColour.TabIndex = 1;
            this.BSecondColour.Text = "Ending Colour";
            this.BSecondColour.UseVisualStyleBackColor = false;
            this.BSecondColour.Visible = false;
            this.BSecondColour.Click += new System.EventHandler(this.BSecondColour_Click);
            // 
            // BDrawFractal
            // 
            this.BDrawFractal.BackColor = System.Drawing.Color.Silver;
            this.BDrawFractal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BDrawFractal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BDrawFractal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BDrawFractal.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BDrawFractal.Location = new System.Drawing.Point(3, 556);
            this.BDrawFractal.Name = "BDrawFractal";
            this.BDrawFractal.Size = new System.Drawing.Size(545, 59);
            this.BDrawFractal.TabIndex = 5;
            this.BDrawFractal.Text = "Draw the Fractal";
            this.BDrawFractal.UseVisualStyleBackColor = false;
            this.BDrawFractal.Click += new System.EventHandler(this.BDrawFractal_Click);
            // 
            // CBFractalSelector
            // 
            this.CBFractalSelector.BackColor = System.Drawing.Color.Black;
            this.CBFractalSelector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBFractalSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CBFractalSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBFractalSelector.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.CBFractalSelector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.CBFractalSelector.FormattingEnabled = true;
            this.CBFractalSelector.Items.AddRange(new object[] {
            "Pythagorean Tree",
            "Koch Curve",
            "Sierpinski Carpet",
            "Sierpinski Triangle",
            "Cantor Set"});
            this.CBFractalSelector.Location = new System.Drawing.Point(3, 64);
            this.CBFractalSelector.Name = "CBFractalSelector";
            this.CBFractalSelector.Size = new System.Drawing.Size(545, 32);
            this.CBFractalSelector.TabIndex = 6;
            this.CBFractalSelector.SelectedIndexChanged += new System.EventHandler(this.CBFractalSelector_SelectedIndexChanged);
            // 
            // TLPPictureDrawer
            // 
            this.TLPPictureDrawer.AutoScroll = true;
            this.TLPPictureDrawer.ColumnCount = 1;
            this.TLPPictureDrawer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPPictureDrawer.Controls.Add(this.TLPPictureButtons, 0, 1);
            this.TLPPictureDrawer.Controls.Add(this.panel1, 0, 0);
            this.TLPPictureDrawer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPictureDrawer.Location = new System.Drawing.Point(562, 4);
            this.TLPPictureDrawer.Name = "TLPPictureDrawer";
            this.TLPPictureDrawer.RowCount = 2;
            this.TLPPictureDrawer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.TLPPictureDrawer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.TLPPictureDrawer.Size = new System.Drawing.Size(551, 618);
            this.TLPPictureDrawer.TabIndex = 1;
            // 
            // TLPPictureButtons
            // 
            this.TLPPictureButtons.AutoScroll = true;
            this.TLPPictureButtons.ColumnCount = 3;
            this.TLPPictureButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPPictureButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPPictureButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.TLPPictureButtons.Controls.Add(this.BZoomIn, 0, 0);
            this.TLPPictureButtons.Controls.Add(this.BZoomOut, 1, 0);
            this.TLPPictureButtons.Controls.Add(this.BSave, 2, 0);
            this.TLPPictureButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPictureButtons.Location = new System.Drawing.Point(3, 590);
            this.TLPPictureButtons.Name = "TLPPictureButtons";
            this.TLPPictureButtons.RowCount = 1;
            this.TLPPictureButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPPictureButtons.Size = new System.Drawing.Size(545, 25);
            this.TLPPictureButtons.TabIndex = 2;
            // 
            // BZoomIn
            // 
            this.BZoomIn.BackColor = System.Drawing.Color.White;
            this.BZoomIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BZoomIn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BZoomIn.FlatAppearance.BorderSize = 0;
            this.BZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BZoomIn.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BZoomIn.Location = new System.Drawing.Point(3, 3);
            this.BZoomIn.Name = "BZoomIn";
            this.BZoomIn.Size = new System.Drawing.Size(103, 19);
            this.BZoomIn.TabIndex = 0;
            this.BZoomIn.Text = "Zoom In";
            this.BZoomIn.UseVisualStyleBackColor = false;
            this.BZoomIn.Click += new System.EventHandler(this.BZoomIn_Click);
            // 
            // BZoomOut
            // 
            this.BZoomOut.BackColor = System.Drawing.Color.White;
            this.BZoomOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BZoomOut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BZoomOut.FlatAppearance.BorderSize = 0;
            this.BZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BZoomOut.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BZoomOut.Location = new System.Drawing.Point(112, 3);
            this.BZoomOut.Name = "BZoomOut";
            this.BZoomOut.Size = new System.Drawing.Size(103, 19);
            this.BZoomOut.TabIndex = 1;
            this.BZoomOut.Text = "Zoom Out";
            this.BZoomOut.UseVisualStyleBackColor = false;
            this.BZoomOut.Click += new System.EventHandler(this.BZoomOut_Click);
            // 
            // BSave
            // 
            this.BSave.BackColor = System.Drawing.Color.White;
            this.BSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BSave.FlatAppearance.BorderSize = 0;
            this.BSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BSave.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BSave.Location = new System.Drawing.Point(221, 3);
            this.BSave.Name = "BSave";
            this.BSave.Size = new System.Drawing.Size(321, 19);
            this.BSave.TabIndex = 2;
            this.BSave.Text = "Save As Picture";
            this.BSave.UseVisualStyleBackColor = false;
            this.BSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.PBFractalCanvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(545, 581);
            this.panel1.TabIndex = 3;
            // 
            // PBFractalCanvas
            // 
            this.PBFractalCanvas.BackColor = System.Drawing.Color.Black;
            this.PBFractalCanvas.Location = new System.Drawing.Point(0, 0);
            this.PBFractalCanvas.Name = "PBFractalCanvas";
            this.PBFractalCanvas.Size = new System.Drawing.Size(250, 250);
            this.PBFractalCanvas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.PBFractalCanvas.TabIndex = 1;
            this.PBFractalCanvas.TabStop = false;
            // 
            // FFractalPainter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1123, 632);
            this.Controls.Add(this.TLPTitle);
            this.Name = "FFractalPainter";
            this.Text = "Fractal Painter";
            this.TLPTitle.ResumeLayout(false);
            this.TLPFractal.ResumeLayout(false);
            this.TLPSettings.ResumeLayout(false);
            this.TLPSettings.PerformLayout();
            this.TLPAdditionalSettings.ResumeLayout(false);
            this.TLPAdditionalSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBLineCoefficient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBSecondAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBFirstAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBDistanceBetweenLines)).EndInit();
            this.TLPRecursionDepth.ResumeLayout(false);
            this.TLPRecursionDepth.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TBRecursionDepth)).EndInit();
            this.TLPColours.ResumeLayout(false);
            this.TLPPictureDrawer.ResumeLayout(false);
            this.TLPPictureButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBFractalCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPTitle;
        private System.Windows.Forms.TableLayoutPanel TLPFractal;
        private System.Windows.Forms.TableLayoutPanel TLPSettings;
        private System.Windows.Forms.TableLayoutPanel TLPAdditionalSettings;
        private System.Windows.Forms.Label LCustomizeFractal;
        private System.Windows.Forms.TableLayoutPanel TLPRecursionDepth;
        private System.Windows.Forms.TableLayoutPanel TLPColours;
        private System.Windows.Forms.Button BDrawFractal;
        private System.Windows.Forms.Label LLineCoefficient;
        private System.Windows.Forms.Label LDistanceBetweenLines;
        private System.Windows.Forms.Label LFirstAngle;
        private System.Windows.Forms.Label LSecondAngle;
        private System.Windows.Forms.Button BFirstColour;
        private System.Windows.Forms.Button BSecondColour;
        private System.Windows.Forms.ColorDialog CDColourPicker;
        private System.Windows.Forms.TrackBar TBLineCoefficient;
        private System.Windows.Forms.TrackBar TBSecondAngle;
        private System.Windows.Forms.TrackBar TBFirstAngle;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TrackBar TBDistanceBetweenLines;
        private System.Windows.Forms.Label LRecursionDepth;
        private System.Windows.Forms.TrackBar TBRecursionDepth;
        private System.Windows.Forms.ComboBox CBFractalSelector;
        private System.Windows.Forms.PictureBox PBFractalCanvas;
        private System.Windows.Forms.TableLayoutPanel TLPPictureDrawer;
        private System.Windows.Forms.TableLayoutPanel TLPPictureButtons;
        private System.Windows.Forms.Button BZoomIn;
        private System.Windows.Forms.Button BZoomOut;
        private System.Windows.Forms.Button BSave;
        private System.Windows.Forms.Panel PanelFractal;
        private System.Windows.Forms.Panel panel1;
    }
}

