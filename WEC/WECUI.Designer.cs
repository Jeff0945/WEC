namespace WEC {
    partial class WECUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20000D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20000D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20000D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(20000D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WECUI));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.title = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizeButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.prLabel = new System.Windows.Forms.Label();
            this.cLabel = new System.Windows.Forms.Label();
            this.trLabel = new System.Windows.Forms.Label();
            this.originalLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.calibrationData = new System.Windows.Forms.DataGridView();
            this.frequencies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.frPanel = new System.Windows.Forms.Panel();
            this.shResponse = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trPanel = new System.Windows.Forms.Panel();
            this.offset = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tResponse = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.calibrateButton = new System.Windows.Forms.Label();
            this.calibPanel = new System.Windows.Forms.Panel();
            this.saveEQ = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.savePath = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.calibrationData)).BeginInit();
            this.frPanel.SuspendLayout();
            this.trPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.calibPanel.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AxisX.IsLogarithmic = true;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            chartArea1.AxisX.LabelStyle.Interval = 1D;
            chartArea1.AxisX.LabelStyle.IntervalOffset = 1D;
            chartArea1.AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.AxisX.MajorTickMark.Enabled = false;
            chartArea1.AxisX.Maximum = 20000D;
            chartArea1.AxisX.Minimum = 10D;
            chartArea1.AxisX.MinorGrid.Enabled = true;
            chartArea1.AxisX.MinorGrid.Interval = 1D;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.AxisY.Interval = 10D;
            chartArea1.AxisY.IntervalOffset = 5D;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            chartArea1.AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.AxisY.MajorTickMark.Enabled = false;
            chartArea1.AxisY.Maximum = 30D;
            chartArea1.AxisY.Minimum = -30D;
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.Interval = 5D;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            chartArea1.InnerPlotPosition.Auto = false;
            chartArea1.InnerPlotPosition.Height = 96F;
            chartArea1.InnerPlotPosition.Width = 96F;
            chartArea1.InnerPlotPosition.X = 4F;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            chartArea1.Position.Auto = false;
            chartArea1.Position.Height = 100F;
            chartArea1.Position.Width = 100F;
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(215, 89);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            series1.Name = "freqResponse";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(65)))));
            series2.IsVisibleInLegend = false;
            series2.LabelForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(211)))));
            series2.LegendText = "Target Response";
            series2.Name = "targetCurve";
            dataPoint3.BorderColor = System.Drawing.Color.Empty;
            dataPoint3.LegendText = "Target Response";
            dataPoint3.MarkerColor = System.Drawing.Color.Empty;
            dataPoint4.BorderColor = System.Drawing.Color.Empty;
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Color = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(113)))));
            series3.Name = "calibrationCurve";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(14)))), ((int)(((byte)(225)))));
            series4.Name = "predictedResponse";
            series4.Points.Add(dataPoint7);
            series4.Points.Add(dataPoint8);
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(776, 359);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(50, 25);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(214, 21);
            this.title.TabIndex = 1;
            this.title.Text = "Wavelet Equalizer Calculator";
            this.title.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(51)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.minimizeButton);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.title);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 61);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // minimizeButton
            // 
            this.minimizeButton.FlatAppearance.BorderSize = 0;
            this.minimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.minimizeButton.Location = new System.Drawing.Point(911, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(40, 25);
            this.minimizeButton.TabIndex = 6;
            this.minimizeButton.Text = " —";
            this.minimizeButton.UseVisualStyleBackColor = true;
            this.minimizeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.exitButton.Location = new System.Drawing.Point(957, 0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(40, 25);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = " ✕";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(12, 18);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(35, 35);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 2;
            this.logo.TabStop = false;
            this.logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(41)))), ((int)(((byte)(49)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.prLabel);
            this.panel2.Controls.Add(this.cLabel);
            this.panel2.Controls.Add(this.trLabel);
            this.panel2.Controls.Add(this.originalLabel);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(-1, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 31);
            this.panel2.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.label6.Location = new System.Drawing.Point(227, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Frequency response curves";
            // 
            // prLabel
            // 
            this.prLabel.AutoSize = true;
            this.prLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(14)))), ((int)(((byte)(225)))));
            this.prLabel.Image = global::WEC.Properties.Resources.purplec;
            this.prLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.prLabel.Location = new System.Drawing.Point(812, 4);
            this.prLabel.Name = "prLabel";
            this.prLabel.Size = new System.Drawing.Size(165, 19);
            this.prLabel.TabIndex = 8;
            this.prLabel.Text = "      Predicted Response";
            this.prLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.prLabel_MouseUp);
            // 
            // cLabel
            // 
            this.cLabel.AutoSize = true;
            this.cLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(113)))));
            this.cLabel.Image = global::WEC.Properties.Resources.greenc;
            this.cLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cLabel.Location = new System.Drawing.Point(683, 4);
            this.cLabel.Name = "cLabel";
            this.cLabel.Size = new System.Drawing.Size(107, 19);
            this.cLabel.TabIndex = 7;
            this.cLabel.Text = "      Calibration";
            this.cLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cLabel_MouseUp);
            // 
            // trLabel
            // 
            this.trLabel.AutoSize = true;
            this.trLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(65)))));
            this.trLabel.Image = global::WEC.Properties.Resources.orangec;
            this.trLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.trLabel.Location = new System.Drawing.Point(519, 4);
            this.trLabel.Name = "trLabel";
            this.trLabel.Size = new System.Drawing.Size(143, 19);
            this.trLabel.TabIndex = 6;
            this.trLabel.Text = "      Target Response";
            this.trLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trLabel_MouseUp);
            // 
            // originalLabel
            // 
            this.originalLabel.AutoSize = true;
            this.originalLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.originalLabel.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.originalLabel.Image = global::WEC.Properties.Resources.bluec;
            this.originalLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.originalLabel.Location = new System.Drawing.Point(415, 4);
            this.originalLabel.Name = "originalLabel";
            this.originalLabel.Size = new System.Drawing.Size(87, 19);
            this.originalLabel.TabIndex = 5;
            this.originalLabel.Text = "      Original";
            this.originalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.originalLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.originalLabel_MouseUp);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(222, 31);
            this.panel3.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.label7.Location = new System.Drawing.Point(8, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(158, 19);
            this.label7.TabIndex = 5;
            this.label7.Text = "Equalizer (Calibration)";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.vScrollBar1);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.calibrationData);
            this.panel4.Location = new System.Drawing.Point(-1, 89);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(222, 512);
            this.panel4.TabIndex = 4;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(203, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(18, 510);
            this.vScrollBar1.TabIndex = 3;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(100, -1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(103, 31);
            this.panel8.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(-2, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gain";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.label2);
            this.panel7.Location = new System.Drawing.Point(-1, -1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(102, 31);
            this.panel7.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Frequencies";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calibrationData
            // 
            this.calibrationData.AllowUserToAddRows = false;
            this.calibrationData.AllowUserToDeleteRows = false;
            this.calibrationData.AllowUserToResizeColumns = false;
            this.calibrationData.AllowUserToResizeRows = false;
            this.calibrationData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.calibrationData.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.calibrationData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calibrationData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.calibrationData.ColumnHeadersHeight = 26;
            this.calibrationData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.calibrationData.ColumnHeadersVisible = false;
            this.calibrationData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.frequencies,
            this.gain});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.calibrationData.DefaultCellStyle = dataGridViewCellStyle4;
            this.calibrationData.EnableHeadersVisualStyles = false;
            this.calibrationData.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(89)))), ((int)(((byte)(93)))));
            this.calibrationData.Location = new System.Drawing.Point(-2, 28);
            this.calibrationData.MultiSelect = false;
            this.calibrationData.Name = "calibrationData";
            this.calibrationData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.calibrationData.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.calibrationData.RowHeadersVisible = false;
            this.calibrationData.RowHeadersWidth = 5;
            this.calibrationData.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.calibrationData.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrationData.RowTemplate.Height = 31;
            this.calibrationData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.calibrationData.Size = new System.Drawing.Size(206, 483);
            this.calibrationData.TabIndex = 0;
            this.calibrationData.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.calibrationData_CellValueChanged);
            this.calibrationData.Scroll += new System.Windows.Forms.ScrollEventHandler(this.calibrationData_Scroll);
            // 
            // frequencies
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.frequencies.DefaultCellStyle = dataGridViewCellStyle2;
            this.frequencies.FillWeight = 101F;
            this.frequencies.HeaderText = "Frequencies";
            this.frequencies.MinimumWidth = 50;
            this.frequencies.Name = "frequencies";
            this.frequencies.ReadOnly = true;
            this.frequencies.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.frequencies.Width = 101;
            // 
            // gain
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.gain.DefaultCellStyle = dataGridViewCellStyle3;
            this.gain.FillWeight = 102F;
            this.gain.HeaderText = "Gain";
            this.gain.MinimumWidth = 50;
            this.gain.Name = "gain";
            this.gain.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gain.Width = 102;
            // 
            // frPanel
            // 
            this.frPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.frPanel.Controls.Add(this.shResponse);
            this.frPanel.Controls.Add(this.label1);
            this.frPanel.Location = new System.Drawing.Point(-1, -1);
            this.frPanel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.frPanel.Name = "frPanel";
            this.frPanel.Size = new System.Drawing.Size(291, 147);
            this.frPanel.TabIndex = 5;
            // 
            // shResponse
            // 
            this.shResponse.AutoSize = true;
            this.shResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.shResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.shResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(137)))), ((int)(((byte)(239)))));
            this.shResponse.Location = new System.Drawing.Point(9, 42);
            this.shResponse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 18);
            this.shResponse.MaximumSize = new System.Drawing.Size(274, 85);
            this.shResponse.Name = "shResponse";
            this.shResponse.Size = new System.Drawing.Size(58, 19);
            this.shResponse.TabIndex = 1;
            this.shResponse.Text = "Browse";
            this.shResponse.Click += new System.EventHandler(this.shResponse_Click);
            this.shResponse.MouseEnter += new System.EventHandler(this.shResponse_MouseEnter);
            this.shResponse.MouseLeave += new System.EventHandler(this.shResponse_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 18, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speaker/Headphone Response";
            // 
            // trPanel
            // 
            this.trPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.trPanel.Controls.Add(this.offset);
            this.trPanel.Controls.Add(this.label5);
            this.trPanel.Controls.Add(this.tResponse);
            this.trPanel.Controls.Add(this.label4);
            this.trPanel.Location = new System.Drawing.Point(289, -1);
            this.trPanel.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.trPanel.Name = "trPanel";
            this.trPanel.Size = new System.Drawing.Size(291, 147);
            this.trPanel.TabIndex = 6;
            // 
            // offset
            // 
            this.offset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.offset.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.offset.DecimalPlaces = 1;
            this.offset.Enabled = false;
            this.offset.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.offset.ForeColor = System.Drawing.Color.White;
            this.offset.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.offset.Location = new System.Drawing.Point(55, 121);
            this.offset.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.offset.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            -2147483648});
            this.offset.Name = "offset";
            this.offset.Size = new System.Drawing.Size(45, 21);
            this.offset.TabIndex = 10;
            this.offset.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.offset.ValueChanged += new System.EventHandler(this.offset_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(202)))), ((int)(((byte)(201)))));
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "Offset:";
            // 
            // tResponse
            // 
            this.tResponse.AutoSize = true;
            this.tResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tResponse.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.tResponse.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(83)))), ((int)(((byte)(65)))));
            this.tResponse.Location = new System.Drawing.Point(9, 42);
            this.tResponse.Margin = new System.Windows.Forms.Padding(6, 0, 6, 18);
            this.tResponse.MaximumSize = new System.Drawing.Size(274, 76);
            this.tResponse.Name = "tResponse";
            this.tResponse.Size = new System.Drawing.Size(58, 19);
            this.tResponse.TabIndex = 3;
            this.tResponse.Text = "Browse";
            this.tResponse.Click += new System.EventHandler(this.tResponse_Click);
            this.tResponse.MouseEnter += new System.EventHandler(this.tResponse_MouseEnter);
            this.tResponse.MouseLeave += new System.EventHandler(this.tResponse_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 18, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Target Response";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Supported Files (*.csv/*.txt)|*.csv;*.txt";
            // 
            // mainPanel
            // 
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.calibrateButton);
            this.mainPanel.Controls.Add(this.frPanel);
            this.mainPanel.Controls.Add(this.trPanel);
            this.mainPanel.Location = new System.Drawing.Point(220, 454);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(781, 147);
            this.mainPanel.TabIndex = 8;
            // 
            // calibrateButton
            // 
            this.calibrateButton.BackColor = System.Drawing.Color.Transparent;
            this.calibrateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calibrateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calibrateButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calibrateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(113)))));
            this.calibrateButton.Location = new System.Drawing.Point(586, 6);
            this.calibrateButton.Margin = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.calibrateButton.Name = "calibrateButton";
            this.calibrateButton.Size = new System.Drawing.Size(187, 133);
            this.calibrateButton.TabIndex = 7;
            this.calibrateButton.Text = "Calibrate >>";
            this.calibrateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.calibrateButton.Click += new System.EventHandler(this.calibrateButton_Click);
            this.calibrateButton.MouseEnter += new System.EventHandler(this.calibrateButton_MouseEnter);
            this.calibrateButton.MouseLeave += new System.EventHandler(this.calibrateButton_MouseLeave);
            // 
            // calibPanel
            // 
            this.calibPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calibPanel.Controls.Add(this.saveEQ);
            this.calibPanel.Controls.Add(this.backButton);
            this.calibPanel.Controls.Add(this.panel6);
            this.calibPanel.Controls.Add(this.panel9);
            this.calibPanel.Location = new System.Drawing.Point(231, 224);
            this.calibPanel.Name = "calibPanel";
            this.calibPanel.Size = new System.Drawing.Size(781, 147);
            this.calibPanel.TabIndex = 9;
            // 
            // saveEQ
            // 
            this.saveEQ.BackColor = System.Drawing.Color.Transparent;
            this.saveEQ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveEQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEQ.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEQ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(170)))), ((int)(((byte)(113)))));
            this.saveEQ.Location = new System.Drawing.Point(296, 6);
            this.saveEQ.Margin = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.saveEQ.Name = "saveEQ";
            this.saveEQ.Size = new System.Drawing.Size(277, 133);
            this.saveEQ.TabIndex = 8;
            this.saveEQ.Text = "Save Equalizer Data";
            this.saveEQ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveEQ.MouseClick += new System.Windows.Forms.MouseEventHandler(this.saveEQ_MouseClick);
            this.saveEQ.MouseEnter += new System.EventHandler(this.saveEQ_MouseEnter);
            this.saveEQ.MouseLeave += new System.EventHandler(this.saveEQ_MouseLeave);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(120)))), ((int)(((byte)(209)))));
            this.backButton.Location = new System.Drawing.Point(586, 6);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 6, 6, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(187, 133);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<< Back";
            this.backButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            this.backButton.MouseEnter += new System.EventHandler(this.backButton_MouseEnter);
            this.backButton.MouseLeave += new System.EventHandler(this.backButton_MouseLeave);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.savePath);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Location = new System.Drawing.Point(-1, -1);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(291, 147);
            this.panel6.TabIndex = 5;
            // 
            // savePath
            // 
            this.savePath.AutoSize = true;
            this.savePath.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savePath.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.savePath.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.savePath.Location = new System.Drawing.Point(9, 42);
            this.savePath.Margin = new System.Windows.Forms.Padding(6, 0, 6, 18);
            this.savePath.MaximumSize = new System.Drawing.Size(274, 85);
            this.savePath.Name = "savePath";
            this.savePath.Size = new System.Drawing.Size(58, 19);
            this.savePath.TabIndex = 1;
            this.savePath.Text = "Browse";
            this.savePath.Click += new System.EventHandler(this.savePath_Click);
            this.savePath.MouseEnter += new System.EventHandler(this.savePath_MouseEnter);
            this.savePath.MouseLeave += new System.EventHandler(this.savePath_MouseLeave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(9, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 18, 3, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Save Path";
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(289, -1);
            this.panel9.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(291, 147);
            this.panel9.TabIndex = 6;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Text File (*.txt)|*.txt";
            // 
            // WECUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(52)))), ((int)(((byte)(56)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.calibPanel);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WECUI";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.calibrationData)).EndInit();
            this.frPanel.ResumeLayout(false);
            this.frPanel.PerformLayout();
            this.trPanel.ResumeLayout(false);
            this.trPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.offset)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.calibPanel.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label prLabel;
        private System.Windows.Forms.Label cLabel;
        private System.Windows.Forms.Label trLabel;
        private System.Windows.Forms.Label originalLabel;
        private System.Windows.Forms.Button minimizeButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label shResponse;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        public System.Windows.Forms.Panel frPanel;
        public System.Windows.Forms.Panel trPanel;
        private System.Windows.Forms.Label tResponse;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label calibrateButton;
        public System.Windows.Forms.Panel mainPanel;
        public System.Windows.Forms.Panel calibPanel;
        private System.Windows.Forms.Label backButton;
        public System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label savePath;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.NumericUpDown offset;
        public System.Windows.Forms.DataGridView calibrationData;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequencies;
        private System.Windows.Forms.DataGridViewTextBoxColumn gain;
        private System.Windows.Forms.Label saveEQ;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}