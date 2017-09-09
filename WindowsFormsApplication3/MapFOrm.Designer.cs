namespace WindowsFormsApplication3
{
    partial class MapForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapForm));
            this.gMap = new GMap.NET.WindowsForms.GMapControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.zoomOutButtom = new System.Windows.Forms.Button();
            this.zoomInButton = new System.Windows.Forms.Button();
            this.waypointDataGrid = new System.Windows.Forms.DataGridView();
            this.Header = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.latitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.longitude = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Command = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.distanceBox = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.altitudeBox = new System.Windows.Forms.TextBox();
            this.altLabel = new System.Windows.Forms.TextBox();
            this.writeButton = new System.Windows.Forms.Button();
            this.rocketbox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.homebutton = new System.Windows.Forms.Button();
            this.latitudebox = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.longitudebox = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.waypointDataGrid)).BeginInit();
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
            // zoomOutButtom
            // 
            this.zoomOutButtom.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoomOutButtom.Image = global::WindowsFormsApplication3.Properties.Resources.zoom_out;
            this.zoomOutButtom.Location = new System.Drawing.Point(61, 380);
            this.zoomOutButtom.Name = "zoomOutButtom";
            this.zoomOutButtom.Size = new System.Drawing.Size(54, 47);
            this.zoomOutButtom.TabIndex = 2;
            this.zoomOutButtom.UseVisualStyleBackColor = true;
            this.zoomOutButtom.Click += new System.EventHandler(this.zoomOutButton_Click);
            // 
            // zoomInButton
            // 
            this.zoomInButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.zoomInButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.zoomInButton.ForeColor = System.Drawing.Color.White;
            this.zoomInButton.Image = ((System.Drawing.Image)(resources.GetObject("zoomInButton.Image")));
            this.zoomInButton.Location = new System.Drawing.Point(61, 327);
            this.zoomInButton.Name = "zoomInButton";
            this.zoomInButton.Size = new System.Drawing.Size(54, 47);
            this.zoomInButton.TabIndex = 1;
            this.zoomInButton.UseVisualStyleBackColor = true;
            this.zoomInButton.Click += new System.EventHandler(this.zoomInButton_Click);
            // 
            // waypointDataGrid
            // 
            this.waypointDataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(61)))), ((int)(((byte)(148)))));
            this.waypointDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.waypointDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waypointDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Header,
            this.altitude,
            this.latitude,
            this.longitude,
            this.Command});
            this.waypointDataGrid.Location = new System.Drawing.Point(121, 449);
            this.waypointDataGrid.Name = "waypointDataGrid";
            this.waypointDataGrid.Size = new System.Drawing.Size(542, 116);
            this.waypointDataGrid.TabIndex = 7;
            this.waypointDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waypointDataGrid_CellContentClick);
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
            this.panel1.Controls.Add(this.altitudeBox);
            this.panel1.Controls.Add(this.altLabel);
            this.panel1.Controls.Add(this.writeButton);
            this.panel1.Controls.Add(this.rocketbox);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.distanceBox);
            this.panel1.Location = new System.Drawing.Point(699, 433);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(542, 168);
            this.panel1.TabIndex = 11;
            // 
            // altitudeBox
            // 
            this.altitudeBox.Location = new System.Drawing.Point(382, 53);
            this.altitudeBox.Name = "altitudeBox";
            this.altitudeBox.ReadOnly = true;
            this.altitudeBox.Size = new System.Drawing.Size(131, 21);
            this.altitudeBox.TabIndex = 15;
            // 
            // altLabel
            // 
            this.altLabel.Location = new System.Drawing.Point(382, 16);
            this.altLabel.Name = "altLabel";
            this.altLabel.ReadOnly = true;
            this.altLabel.Size = new System.Drawing.Size(114, 21);
            this.altLabel.TabIndex = 14;
            this.altLabel.Text = "ALTITUDE :";
            // 
            // writeButton
            // 
            this.writeButton.BackColor = System.Drawing.Color.White;
            this.writeButton.Location = new System.Drawing.Point(3, 16);
            this.writeButton.Name = "writeButton";
            this.writeButton.Size = new System.Drawing.Size(85, 67);
            this.writeButton.TabIndex = 10;
            this.writeButton.Text = "write waypoint";
            this.writeButton.UseVisualStyleBackColor = false;
            this.writeButton.Click += new System.EventHandler(this.writeButton_Click);
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
            // MapForm
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
            this.Controls.Add(this.waypointDataGrid);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.zoomOutButtom);
            this.Controls.Add(this.zoomInButton);
            this.Controls.Add(this.gMap);
            this.Font = new System.Drawing.Font("Stencil", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MapForm";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.waypointDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMap;
        private System.Windows.Forms.Button zoomInButton;
        private System.Windows.Forms.Button zoomOutButtom;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView waypointDataGrid;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox distanceBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.TextBox rocketbox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox altitudeBox;
        private System.Windows.Forms.TextBox altLabel;
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