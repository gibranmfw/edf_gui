namespace WindowsFormsApplication3
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.altitudebox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.rocketbox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.latitudebox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.longitudebox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gMap
            // 
            this.gMap.Bearing = 0F;
            this.gMap.CanDragMap = true;
            this.gMap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMap.GrayScaleMode = false;
            this.gMap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMap.LevelsKeepInMemmory = 5;
            this.gMap.Location = new System.Drawing.Point(121, 61);
            this.gMap.MarkersEnabled = true;
            this.gMap.MaxZoom = 18;
            this.gMap.MinZoom = 2;
            this.gMap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMap.Name = "gMap";
            this.gMap.NegativeMode = false;
            this.gMap.PolygonsEnabled = true;
            this.gMap.RetryLoadTile = 0;
            this.gMap.RoutesEnabled = true;
            this.gMap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMap.ShowTileGridLines = false;
            this.gMap.Size = new System.Drawing.Size(1132, 366);
            this.gMap.TabIndex = 0;
            this.gMap.Zoom = 14D;
            this.gMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMap_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Stencil", 24.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(357, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(647, 40);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Map";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Image = global::WindowsFormsApplication3.Properties.Resources.zoom_out;
            this.button2.Location = new System.Drawing.Point(61, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(54, 47);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(61, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 47);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(148)))));
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Header,
            this.altitude,
            this.latitude,
            this.longitude,
            this.Command});
            this.dataGridView2.Location = new System.Drawing.Point(121, 449);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(542, 116);
            this.dataGridView2.TabIndex = 7;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // Header
            // 
            this.Header.HeaderText = "No";
            this.Header.Name = "Header";
            this.Header.ReadOnly = true;
            // 
            // altitude
            // 
            this.altitude.HeaderText = "Altitude";
            this.altitude.Name = "altitude";
            this.altitude.ReadOnly = true;
            // 
            // latitude
            // 
            this.latitude.HeaderText = "Latitude";
            this.latitude.Name = "latitude";
            this.latitude.ReadOnly = true;
            // 
            // longitude
            // 
            this.longitude.HeaderText = "Longitude";
            this.longitude.Name = "longitude";
            this.longitude.ReadOnly = true;
            // 
            // Command
            // 
            this.Command.HeaderText = "Command";
            this.Command.Name = "Command";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(94, 16);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(114, 21);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "mission distance :";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // distanceBox
            // 
            this.distanceBox.BackColor = System.Drawing.Color.White;
            this.distanceBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.distanceBox.Location = new System.Drawing.Point(94, 53);
            this.distanceBox.Name = "distanceBox";
            this.distanceBox.ReadOnly = true;
            this.distanceBox.Size = new System.Drawing.Size(131, 21);
            this.distanceBox.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(148)))));
            this.panel1.Controls.Add(this.textBox5);
            this.panel1.Controls.Add(this.altitudebox);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.rocketbox);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.distanceBox);
            this.panel1.Location = new System.Drawing.Point(699, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 168);
            this.panel1.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(382, 53);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(131, 21);
            this.textBox5.TabIndex = 15;
            // 
            // altitudebox
            // 
            this.altitudebox.Location = new System.Drawing.Point(382, 16);
            this.altitudebox.Name = "altitudebox";
            this.altitudebox.ReadOnly = true;
            this.altitudebox.Size = new System.Drawing.Size(114, 21);
            this.altitudebox.TabIndex = 14;
            this.altitudebox.Text = "ALTITUDE :";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(3, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 67);
            this.button3.TabIndex = 10;
            this.button3.Text = "write waypoint";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rocketbox
            // 
            this.rocketbox.BackColor = System.Drawing.Color.White;
            this.rocketbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rocketbox.Location = new System.Drawing.Point(238, 53);
            this.rocketbox.Name = "rocketbox";
            this.rocketbox.ReadOnly = true;
            this.rocketbox.Size = new System.Drawing.Size(133, 21);
            this.rocketbox.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.White;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(238, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(109, 21);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "Rocket Position:";
            // 
            // homebutton
            // 
            this.homebutton.BackColor = System.Drawing.Color.White;
            this.homebutton.Location = new System.Drawing.Point(1270, 380);
            this.homebutton.Name = "homebutton";
            this.homebutton.Size = new System.Drawing.Size(62, 38);
            this.homebutton.TabIndex = 16;
            this.homebutton.Text = "set home";
            this.homebutton.UseVisualStyleBackColor = false;
            this.homebutton.Click += new System.EventHandler(this.homebutton_Click);
            // 
            // latitudebox
            // 
            this.latitudebox.Location = new System.Drawing.Point(1262, 273);
            this.latitudebox.Name = "latitudebox";
            this.latitudebox.ReadOnly = true;
            this.latitudebox.Size = new System.Drawing.Size(80, 21);
            this.latitudebox.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1262, 314);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(80, 21);
            this.textBox6.TabIndex = 18;
            this.textBox6.Text = "Longitude";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // longitudebox
            // 
            this.longitudebox.Location = new System.Drawing.Point(1262, 341);
            this.longitudebox.Name = "longitudebox";
            this.longitudebox.ReadOnly = true;
            this.longitudebox.Size = new System.Drawing.Size(80, 21);
            this.longitudebox.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(1262, 246);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(80, 21);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "Latitude";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(1259, 202);
            this.textBox9.Name = "textBox9";
            this.textBox9.ReadOnly = true;
            this.textBox9.Size = new System.Drawing.Size(88, 21);
            this.textBox9.TabIndex = 21;
            this.textBox9.Text = "Home Position";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(63)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(1354, 642);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.longitudebox);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.latitudebox);
            this.Controls.Add(this.homebutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gMap);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox rocketbox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox altitudebox;
        private System.Windows.Forms.Button homebutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Header;
        private System.Windows.Forms.DataGridViewTextBoxColumn altitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn latitude;
        private System.Windows.Forms.DataGridViewTextBoxColumn longitude;
        private System.Windows.Forms.DataGridViewButtonColumn Command;
        private System.Windows.Forms.TextBox latitudebox;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox longitudebox;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
    }
}