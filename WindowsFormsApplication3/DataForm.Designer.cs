using System;

namespace WindowsFormsApplication3
{
    partial class DataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.rollBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.yawBox = new System.Windows.Forms.TextBox();
            this.pitchBox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.yawGauge = new System.Windows.Forms.AGauge();
            this.rollGauge = new System.Windows.Forms.AGauge();
            this.pitchGauge = new System.Windows.Forms.AGauge();
            this.attitudeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rocketHost = new System.Windows.Forms.Integration.ElementHost();
            this.rocketobj = new WindowsFormsApplication3.UserControl2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.artificialHorizon = new ArtificialHorizon.ArtificialHorizon();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.trajectoryChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel5 = new System.Windows.Forms.Panel();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.attitudeChart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trajectoryChart)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Makara_UI_Render.png");
            // 
            // rollBox
            // 
            this.rollBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rollBox.Location = new System.Drawing.Point(0, 208);
            this.rollBox.Multiline = true;
            this.rollBox.Name = "rollBox";
            this.rollBox.Size = new System.Drawing.Size(215, 31);
            this.rollBox.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox3.Location = new System.Drawing.Point(0, 0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(215, 20);
            this.textBox3.TabIndex = 11;
            this.textBox3.Text = "Roll";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yawBox
            // 
            this.yawBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.yawBox.Location = new System.Drawing.Point(0, 208);
            this.yawBox.Multiline = true;
            this.yawBox.Name = "yawBox";
            this.yawBox.Size = new System.Drawing.Size(214, 31);
            this.yawBox.TabIndex = 12;
            // 
            // pitchBox
            // 
            this.pitchBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pitchBox.Location = new System.Drawing.Point(0, 212);
            this.pitchBox.Multiline = true;
            this.pitchBox.Name = "pitchBox";
            this.pitchBox.Size = new System.Drawing.Size(216, 30);
            this.pitchBox.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.White;
            this.textBox6.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox6.Location = new System.Drawing.Point(0, 0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(214, 20);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "Yaw";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.White;
            this.textBox7.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox7.Location = new System.Drawing.Point(0, 0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(216, 20);
            this.textBox7.TabIndex = 17;
            this.textBox7.Text = "Pitch";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yawGauge
            // 
            this.yawGauge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.yawGauge.BackColor = System.Drawing.Color.Gainsboro;
            this.yawGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.yawGauge.BaseArcRadius = 80;
            this.yawGauge.BaseArcStart = 135;
            this.yawGauge.BaseArcSweep = 270;
            this.yawGauge.BaseArcWidth = 2;
            this.yawGauge.Center = new System.Drawing.Point(100, 100);
            this.yawGauge.Location = new System.Drawing.Point(3, 26);
            this.yawGauge.MaxValue = 360F;
            this.yawGauge.MinValue = -360F;
            this.yawGauge.Name = "yawGauge";
            this.yawGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.yawGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.yawGauge.NeedleRadius = 80;
            this.yawGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.yawGauge.NeedleWidth = 2;
            this.yawGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.yawGauge.ScaleLinesInterInnerRadius = 73;
            this.yawGauge.ScaleLinesInterOuterRadius = 80;
            this.yawGauge.ScaleLinesInterWidth = 1;
            this.yawGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.yawGauge.ScaleLinesMajorInnerRadius = 70;
            this.yawGauge.ScaleLinesMajorOuterRadius = 80;
            this.yawGauge.ScaleLinesMajorStepValue = 90F;
            this.yawGauge.ScaleLinesMajorWidth = 2;
            this.yawGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.yawGauge.ScaleLinesMinorInnerRadius = 75;
            this.yawGauge.ScaleLinesMinorOuterRadius = 80;
            this.yawGauge.ScaleLinesMinorTicks = 9;
            this.yawGauge.ScaleLinesMinorWidth = 1;
            this.yawGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.yawGauge.ScaleNumbersFormat = null;
            this.yawGauge.ScaleNumbersRadius = 95;
            this.yawGauge.ScaleNumbersRotation = 0;
            this.yawGauge.ScaleNumbersStartScaleLine = 0;
            this.yawGauge.ScaleNumbersStepScaleLines = 1;
            this.yawGauge.Size = new System.Drawing.Size(210, 187);
            this.yawGauge.TabIndex = 13;
            this.yawGauge.Text = "aGauge2";
            this.yawGauge.Value = 0F;
            // 
            // rollGauge
            // 
            this.rollGauge.BackColor = System.Drawing.Color.Gainsboro;
            this.rollGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.rollGauge.BaseArcRadius = 80;
            this.rollGauge.BaseArcStart = 135;
            this.rollGauge.BaseArcSweep = 270;
            this.rollGauge.BaseArcWidth = 2;
            this.rollGauge.Center = new System.Drawing.Point(100, 100);
            this.rollGauge.Location = new System.Drawing.Point(3, 26);
            this.rollGauge.MaxValue = 360F;
            this.rollGauge.MinValue = -360F;
            this.rollGauge.Name = "rollGauge";
            this.rollGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.rollGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.rollGauge.NeedleRadius = 80;
            this.rollGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.rollGauge.NeedleWidth = 2;
            this.rollGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.rollGauge.ScaleLinesInterInnerRadius = 73;
            this.rollGauge.ScaleLinesInterOuterRadius = 80;
            this.rollGauge.ScaleLinesInterWidth = 1;
            this.rollGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.rollGauge.ScaleLinesMajorInnerRadius = 70;
            this.rollGauge.ScaleLinesMajorOuterRadius = 80;
            this.rollGauge.ScaleLinesMajorStepValue = 90F;
            this.rollGauge.ScaleLinesMajorWidth = 2;
            this.rollGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.rollGauge.ScaleLinesMinorInnerRadius = 75;
            this.rollGauge.ScaleLinesMinorOuterRadius = 80;
            this.rollGauge.ScaleLinesMinorTicks = 9;
            this.rollGauge.ScaleLinesMinorWidth = 1;
            this.rollGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.rollGauge.ScaleNumbersFormat = null;
            this.rollGauge.ScaleNumbersRadius = 95;
            this.rollGauge.ScaleNumbersRotation = 0;
            this.rollGauge.ScaleNumbersStartScaleLine = 0;
            this.rollGauge.ScaleNumbersStepScaleLines = 1;
            this.rollGauge.Size = new System.Drawing.Size(206, 174);
            this.rollGauge.TabIndex = 21;
            this.rollGauge.Text = "aGauge1";
            this.rollGauge.Value = 0F;
            // 
            // pitchGauge
            // 
            this.pitchGauge.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pitchGauge.BackColor = System.Drawing.Color.Gainsboro;
            this.pitchGauge.BaseArcColor = System.Drawing.Color.Gray;
            this.pitchGauge.BaseArcRadius = 80;
            this.pitchGauge.BaseArcStart = 135;
            this.pitchGauge.BaseArcSweep = 270;
            this.pitchGauge.BaseArcWidth = 2;
            this.pitchGauge.Center = new System.Drawing.Point(100, 100);
            this.pitchGauge.Location = new System.Drawing.Point(4, 26);
            this.pitchGauge.MaxValue = 360F;
            this.pitchGauge.MinValue = -360F;
            this.pitchGauge.Name = "pitchGauge";
            this.pitchGauge.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.pitchGauge.NeedleColor2 = System.Drawing.Color.DimGray;
            this.pitchGauge.NeedleRadius = 80;
            this.pitchGauge.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.pitchGauge.NeedleWidth = 2;
            this.pitchGauge.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.pitchGauge.ScaleLinesInterInnerRadius = 73;
            this.pitchGauge.ScaleLinesInterOuterRadius = 80;
            this.pitchGauge.ScaleLinesInterWidth = 1;
            this.pitchGauge.ScaleLinesMajorColor = System.Drawing.Color.Black;
            this.pitchGauge.ScaleLinesMajorInnerRadius = 70;
            this.pitchGauge.ScaleLinesMajorOuterRadius = 80;
            this.pitchGauge.ScaleLinesMajorStepValue = 90F;
            this.pitchGauge.ScaleLinesMajorWidth = 2;
            this.pitchGauge.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.pitchGauge.ScaleLinesMinorInnerRadius = 75;
            this.pitchGauge.ScaleLinesMinorOuterRadius = 80;
            this.pitchGauge.ScaleLinesMinorTicks = 9;
            this.pitchGauge.ScaleLinesMinorWidth = 1;
            this.pitchGauge.ScaleNumbersColor = System.Drawing.Color.Black;
            this.pitchGauge.ScaleNumbersFormat = null;
            this.pitchGauge.ScaleNumbersRadius = 95;
            this.pitchGauge.ScaleNumbersRotation = 0;
            this.pitchGauge.ScaleNumbersStartScaleLine = 0;
            this.pitchGauge.ScaleNumbersStepScaleLines = 1;
            this.pitchGauge.Size = new System.Drawing.Size(206, 182);
            this.pitchGauge.TabIndex = 22;
            this.pitchGauge.Text = "aGauge3";
            this.pitchGauge.Value = 0F;
            // 
            // attitudeChart
            // 
            this.attitudeChart.BackColor = System.Drawing.Color.Black;
            this.attitudeChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.attitudeChart.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea1.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.MediumBlue;
            chartArea1.AxisX.Title = "Time";
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.MediumBlue;
            chartArea1.AxisY.Title = "Attitude";
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.attitudeChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.attitudeChart.Legends.Add(legend1);
            this.attitudeChart.Location = new System.Drawing.Point(4, 3);
            this.attitudeChart.Name = "attitudeChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "Roll";
            series1.Points.Add(dataPoint1);
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "Pitch";
            series2.Points.Add(dataPoint2);
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Yaw";
            series3.Points.Add(dataPoint3);
            this.attitudeChart.Series.Add(series1);
            this.attitudeChart.Series.Add(series2);
            this.attitudeChart.Series.Add(series3);
            this.attitudeChart.Size = new System.Drawing.Size(544, 224);
            this.attitudeChart.TabIndex = 23;
            this.attitudeChart.Text = "Rocket Attitude";
            title1.ForeColor = System.Drawing.Color.White;
            title1.Name = "Rocket Attitude";
            title1.Text = "Rocket Attitude";
            this.attitudeChart.Titles.Add(title1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.rocketHost, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(445, 495);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // rocketHost
            // 
            this.rocketHost.BackColor = System.Drawing.Color.DimGray;
            this.rocketHost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rocketHost.Location = new System.Drawing.Point(225, 250);
            this.rocketHost.Name = "rocketHost";
            this.rocketHost.Size = new System.Drawing.Size(217, 242);
            this.rocketHost.TabIndex = 30;
            this.rocketHost.Text = "elementHost2";
            this.rocketHost.Child = this.rocketobj;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.rollBox);
            this.panel2.Controls.Add(this.rollGauge);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(225, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(217, 241);
            this.panel2.TabIndex = 27;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.yawBox);
            this.panel3.Controls.Add(this.yawGauge);
            this.panel3.Controls.Add(this.textBox6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(216, 241);
            this.panel3.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gainsboro;
            this.panel4.Controls.Add(this.textBox7);
            this.panel4.Controls.Add(this.pitchBox);
            this.panel4.Controls.Add(this.pitchGauge);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(216, 242);
            this.panel4.TabIndex = 29;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(0, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(447, 497);
            this.panel1.TabIndex = 27;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1294, 513);
            this.splitContainer1.SplitterDistance = 443;
            this.splitContainer1.TabIndex = 28;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(443, 20);
            this.textBox1.TabIndex = 28;
            this.textBox1.Text = "Gauge Data\r\n";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel1.Controls.Add(this.artificialHorizon);
            this.splitContainer2.Panel1.Controls.Add(this.textBox8);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.Color.Black;
            this.splitContainer2.Panel2.Controls.Add(this.panel6);
            this.splitContainer2.Panel2.Controls.Add(this.panel5);
            this.splitContainer2.Panel2.Controls.Add(this.textBox9);
            this.splitContainer2.Size = new System.Drawing.Size(847, 513);
            this.splitContainer2.SplitterDistance = 280;
            this.splitContainer2.TabIndex = 24;
            // 
            // artificialHorizon
            // 
            this.artificialHorizon.AutoScroll = true;
            this.artificialHorizon.Location = new System.Drawing.Point(22, 51);
            this.artificialHorizon.Name = "artificialHorizon";
            this.artificialHorizon.pitch_angle = 0D;
            this.artificialHorizon.roll_angle = 0D;
            this.artificialHorizon.Size = new System.Drawing.Size(232, 432);
            this.artificialHorizon.TabIndex = 30;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.White;
            this.textBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox8.Location = new System.Drawing.Point(0, 0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(280, 20);
            this.textBox8.TabIndex = 29;
            this.textBox8.Text = "Censor Data\r\n";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.trajectoryChart);
            this.panel6.Location = new System.Drawing.Point(3, 265);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(560, 245);
            this.panel6.TabIndex = 27;
            // 
            // trajectoryChart
            // 
            this.trajectoryChart.BackColor = System.Drawing.Color.Black;
            this.trajectoryChart.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.trajectoryChart.BorderlineColor = System.Drawing.Color.LightGray;
            chartArea2.AxisX.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisX.LineColor = System.Drawing.Color.MediumBlue;
            chartArea2.AxisX.Title = "Distance";
            chartArea2.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.InterlacedColor = System.Drawing.Color.White;
            chartArea2.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea2.AxisY.LineColor = System.Drawing.Color.MediumBlue;
            chartArea2.AxisY.Title = "Altitude";
            chartArea2.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea2.Name = "ChartArea1";
            this.trajectoryChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.trajectoryChart.Legends.Add(legend2);
            this.trajectoryChart.Location = new System.Drawing.Point(4, 6);
            this.trajectoryChart.Name = "trajectoryChart";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Trajectory";
            series4.Points.Add(dataPoint4);
            this.trajectoryChart.Series.Add(series4);
            this.trajectoryChart.Size = new System.Drawing.Size(544, 224);
            this.trajectoryChart.TabIndex = 24;
            this.trajectoryChart.Text = "Rocket Attitude";
            title2.ForeColor = System.Drawing.Color.White;
            title2.Name = "Trajectory";
            title2.Text = "Trajectory";
            this.trajectoryChart.Titles.Add(title2);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Controls.Add(this.attitudeChart);
            this.panel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.panel5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(3, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(557, 240);
            this.panel5.TabIndex = 26;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.White;
            this.textBox9.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox9.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox9.Location = new System.Drawing.Point(0, 0);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(563, 20);
            this.textBox9.TabIndex = 24;
            this.textBox9.Text = "Graph";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1294, 642);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataForm";
            this.Text = "ATRAMAKARA UI";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attitudeChart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trajectoryChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #endregion
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox rollBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox yawBox;
        private System.Windows.Forms.AGauge yawGauge;
        private System.Windows.Forms.TextBox pitchBox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.AGauge rollGauge;
        private System.Windows.Forms.AGauge pitchGauge;
        private System.Windows.Forms.DataVisualization.Charting.Chart attitudeChart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Integration.ElementHost rocketHost;
        private UserControl2 rocketobj;
        private ArtificialHorizon.ArtificialHorizon artificialHorizon;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataVisualization.Charting.Chart trajectoryChart;
    }
}

