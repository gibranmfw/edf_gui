namespace WindowsFormsApplication3
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.tabData = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip8 = new System.Windows.Forms.ToolStrip();
            this.status_bar = new System.Windows.Forms.ToolStripTextBox();
            this.panelData = new System.Windows.Forms.Panel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panelMap = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolStrip7 = new System.Windows.Forms.ToolStrip();
            this.port_combo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip6 = new System.Windows.Forms.ToolStrip();
            this.baud_combo = new System.Windows.Forms.ToolStripComboBox();
            this.toolStrip5 = new System.Windows.Forms.ToolStrip();
            this.parachute_button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip4 = new System.Windows.Forms.ToolStrip();
            this.motor_button = new System.Windows.Forms.ToolStripButton();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.progress_bar = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.connect_button = new System.Windows.Forms.ToolStripButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabData.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip8.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.toolStrip7.SuspendLayout();
            this.toolStrip6.SuspendLayout();
            this.toolStrip5.SuspendLayout();
            this.toolStrip4.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabData
            // 
            this.tabData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabData.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabData.Controls.Add(this.tabPage1);
            this.tabData.Controls.Add(this.tabPage2);
            this.tabData.Location = new System.Drawing.Point(0, 128);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Drawing.Point(9, 3);
            this.tabData.SelectedIndex = 0;
            this.tabData.Size = new System.Drawing.Size(1350, 576);
            this.tabData.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.tabPage1.Controls.Add(this.toolStrip8);
            this.tabPage1.Controls.Add(this.panelData);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1342, 547);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            // 
            // toolStrip8
            // 
            this.toolStrip8.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip8.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status_bar});
            this.toolStrip8.Location = new System.Drawing.Point(1131, 522);
            this.toolStrip8.Name = "toolStrip8";
            this.toolStrip8.Size = new System.Drawing.Size(214, 25);
            this.toolStrip8.TabIndex = 9;
            this.toolStrip8.Text = "toolStrip8";
            // 
            // status_bar
            // 
            this.status_bar.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.status_bar.Name = "status_bar";
            this.status_bar.ReadOnly = true;
            this.status_bar.Size = new System.Drawing.Size(200, 25);
            this.status_bar.Text = "Disconnected";
            this.status_bar.Click += new System.EventHandler(this.status_bar_Click);
            // 
            // panelData
            // 
            this.panelData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.panelData.Location = new System.Drawing.Point(-4, 0);
            this.panelData.Name = "panelData";
            this.panelData.Size = new System.Drawing.Size(1343, 519);
            this.panelData.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.tabPage2.Controls.Add(this.panelMap);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1342, 547);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Map";
            // 
            // panelMap
            // 
            this.panelMap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(3, 3);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(1336, 541);
            this.panelMap.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.toolStrip7);
            this.panel1.Controls.Add(this.toolStrip6);
            this.panel1.Controls.Add(this.toolStrip5);
            this.panel1.Controls.Add(this.toolStrip4);
            this.panel1.Controls.Add(this.toolStrip3);
            this.panel1.Controls.Add(this.toolStrip2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1485, 177);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.GROUND_CONTROL_STATION;
            this.pictureBox1.Location = new System.Drawing.Point(410, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 91);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // toolStrip7
            // 
            this.toolStrip7.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip7.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.port_combo});
            this.toolStrip7.Location = new System.Drawing.Point(1053, 87);
            this.toolStrip7.Name = "toolStrip7";
            this.toolStrip7.Size = new System.Drawing.Size(126, 25);
            this.toolStrip7.TabIndex = 8;
            this.toolStrip7.Text = "toolStrip7";
            // 
            // port_combo
            // 
            this.port_combo.Name = "port_combo";
            this.port_combo.Size = new System.Drawing.Size(121, 25);
            this.port_combo.Text = "Port Available";
            // 
            // toolStrip6
            // 
            this.toolStrip6.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip6.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baud_combo});
            this.toolStrip6.Location = new System.Drawing.Point(1200, 87);
            this.toolStrip6.Name = "toolStrip6";
            this.toolStrip6.Size = new System.Drawing.Size(166, 25);
            this.toolStrip6.TabIndex = 7;
            this.toolStrip6.Text = "toolStrip6";
            // 
            // baud_combo
            // 
            this.baud_combo.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.baud_combo.Margin = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.baud_combo.Name = "baud_combo";
            this.baud_combo.Size = new System.Drawing.Size(121, 25);
            this.baud_combo.Text = "Baud Rate";
            // 
            // toolStrip5
            // 
            this.toolStrip5.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip5.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip5.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parachute_button});
            this.toolStrip5.Location = new System.Drawing.Point(219, 87);
            this.toolStrip5.Name = "toolStrip5";
            this.toolStrip5.Size = new System.Drawing.Size(26, 25);
            this.toolStrip5.TabIndex = 6;
            this.toolStrip5.Text = "toolStrip5";
            // 
            // parachute_button
            // 
            this.parachute_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.parachute_button.Image = global::WindowsFormsApplication3.Properties.Resources.parachute;
            this.parachute_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.parachute_button.Name = "parachute_button";
            this.parachute_button.Size = new System.Drawing.Size(23, 22);
            this.parachute_button.Text = "toolStripButton3";
            this.parachute_button.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStrip4
            // 
            this.toolStrip4.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motor_button});
            this.toolStrip4.Location = new System.Drawing.Point(255, 87);
            this.toolStrip4.Name = "toolStrip4";
            this.toolStrip4.Size = new System.Drawing.Size(26, 25);
            this.toolStrip4.TabIndex = 5;
            this.toolStrip4.Text = "toolStrip4";
            // 
            // motor_button
            // 
            this.motor_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.motor_button.Image = global::WindowsFormsApplication3.Properties.Resources.power_logo;
            this.motor_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.motor_button.Name = "motor_button";
            this.motor_button.Size = new System.Drawing.Size(23, 22);
            this.motor_button.Text = "toolStripButton2";
            this.motor_button.Click += new System.EventHandler(this.motor_button_Click);
            // 
            // toolStrip3
            // 
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progress_bar});
            this.toolStrip3.Location = new System.Drawing.Point(54, 87);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.Size = new System.Drawing.Size(155, 25);
            this.toolStrip3.TabIndex = 4;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // progress_bar
            // 
            this.progress_bar.Name = "progress_bar";
            this.progress_bar.Size = new System.Drawing.Size(150, 22);
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connect_button});
            this.toolStrip2.Location = new System.Drawing.Point(22, 87);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(26, 25);
            this.toolStrip2.TabIndex = 3;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // connect_button
            // 
            this.connect_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.connect_button.Image = global::WindowsFormsApplication3.Properties.Resources.disconnect;
            this.connect_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(23, 22);
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1350, 706);
            this.Controls.Add(this.tabData);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1300, 681);
            this.Name = "Form2";
            this.Text = "GCSAstramakara UI";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabData.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip8.ResumeLayout(false);
            this.toolStrip8.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.toolStrip7.ResumeLayout(false);
            this.toolStrip7.PerformLayout();
            this.toolStrip6.ResumeLayout(false);
            this.toolStrip6.PerformLayout();
            this.toolStrip5.ResumeLayout(false);
            this.toolStrip5.PerformLayout();
            this.toolStrip4.ResumeLayout(false);
            this.toolStrip4.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TabControl tabData;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panelMap;
        private System.Windows.Forms.ToolStrip toolStrip8;
        private System.Windows.Forms.ToolStripTextBox status_bar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip toolStrip7;
        private System.Windows.Forms.ToolStripComboBox port_combo;
        private System.Windows.Forms.ToolStrip toolStrip6;
        private System.Windows.Forms.ToolStripComboBox baud_combo;
        private System.Windows.Forms.ToolStrip toolStrip5;
        private System.Windows.Forms.ToolStrip toolStrip4;
        private System.Windows.Forms.ToolStripButton motor_button;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripProgressBar progress_bar;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton connect_button;
        private System.Windows.Forms.ToolStripButton parachute_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelData;
    }
}