using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System.Text.RegularExpressions;
using GMap.NET.MapProviders;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace WindowsFormsApplication3
{

    public partial class Form3 : Form
    {
        public Form2 parentForm { get; set; }
        GMapOverlay markerOverlay = new GMapOverlay("markers");
        private int num = 1;
        GMapRoute lineLayer = new GMapRoute("single_line");
        public readonly Action<string> _sendData;
        public double curr_lat = 0;
        public double curr_long = 0;
        public bool is_connected = false;

        public Form3(Action<string> sendData)
        {
            try
            {
                System.Net.IPHostEntry e =
                     System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
                      "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }
            this._sendData = sendData;
            InitializeComponent();
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.DragButton = MouseButtons.Left;
            gMap.SetPositionByKeywords("jakarta");
            
            gMap.ShowCenter = false;
            lineLayer.Stroke = new Pen(Brushes.Black, 2);
            markerOverlay.Routes.Add(lineLayer);
            gMap.Overlays.Add(markerOverlay);
            latitudebox.Text = curr_lat + "";
            longitudebox.Text = curr_long + "";
            //gMap.Overlays.Add(markerOverlay);
        }

        private int addMarker(PointLatLng position, GMarkerGoogleType type)
        {
            GMapMarker marker = new GMarkerGoogle(position, type);
            marker.ToolTipText = num + "";
            //markerOverlay.Markers.Add(marker);
            markerOverlay.Markers.Add(marker);
            gMap.Overlays.Add(markerOverlay);
            return markerOverlay.Markers.Count - 1;

        }

        private void addRoute()
        {
            int markersSize = markerOverlay.Markers.Count();
            lineLayer.Points.Add(markerOverlay.Markers[markersSize - 1].Position);
            gMap.UpdateRouteLocalPosition(lineLayer);
        }

        public void toggle_connect()
        {
            is_connected = !(is_connected || false);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(gMap.Zoom < gMap.MaxZoom)
            {
                gMap.Zoom++;
                if (gMap.Zoom == gMap.MaxZoom)
                {
                    button1.Enabled = false;
                }
                else
                {
                    button2.Enabled = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(gMap.Zoom > gMap.MinZoom)
            {
                gMap.Zoom--;
                if (gMap.Zoom == gMap.MinZoom)
                {
                    button2.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                }
            }
        }
        

        public void gMap_MouseDown(object sender, MouseEventArgs e)
        {
            if(is_connected)
            {
                switch (e.Button)
                {
                    case MouseButtons.Right:
                        {
                            double lat = gMap.FromLocalToLatLng(e.X, e.Y).Lat;
                            double lng = gMap.FromLocalToLatLng(e.X, e.Y).Lng;
                            int idxmarker = addMarker(new PointLatLng(lat, lng), GMarkerGoogleType.red_pushpin);
                            addRoute();
                            updateDistance();
                            dataGridView2.Rows.Add(num, 0, lat, lng, "Delete");
                            num++;
                            Form6 form6 = new Form6(this.set_altitude);
                            form6.ShowDialog();
                        }
                        break;
                }
            }
        }

        public void updateDistance()
        {
            distanceBox.Text = lineLayer.Distance + " km";
        }

        public void lineReceived(double latitude, double longitude, double altitude, double distance)
        {
            //if(markerOverlay.Markers.Count() > 0 && markerOverlay.Markers[markerOverlay.Markers.Count() - 1].ToolTipText == "rocket")
            //{
            //    markerOverlay.Markers.RemoveAt(markerOverlay.Markers.Count() - 1);
            //}
            PointLatLng newPosition = new GMap.NET.PointLatLng(latitude, longitude);
            gMap.Position = newPosition;
            int index = containRocket();
            if (index != -1)
            {
                markerOverlay.Markers[index].Position = newPosition;
            }
            else
            {
                addMarker(gMap.Position, GMarkerGoogleType.arrow);
                markerOverlay.Markers[markerOverlay.Markers.Count() - 1].ToolTipText = "rocket";
            }

            rocketbox.Text = distance + " M";
            textBox5.Text = altitude + " M";
            curr_lat = latitude;
            curr_long = longitude;
        }

        public int containRocket()
        {
            for(int ii = 0; ii < markerOverlay.Markers.Count(); ii++)
            {
                if(markerOverlay.Markers[ii].ToolTipText == "rocket")
                {
                    return ii;
                }
            }

            return -1;
        }

        public void updateData()
        {
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].Cells[0].Value = i + 1;
            }
            for(int i = 1; i < markerOverlay.Markers.Count; i++)
            {
                markerOverlay.Markers[i].ToolTipText = i + "";
            }
        }

        public void updateWaypointwithGrid(DataGridViewRow currrow)
        {
            
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void markerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public void set_altitude(double alt)
        {
            int endrowindex = dataGridView2.Rows.Count - 2;
            dataGridView2.Rows[endrowindex].Cells[1].Value = alt;
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (is_connected && e.ColumnIndex == 4)
            {
                try
                {
                    dataGridView2.Rows.RemoveAt(e.RowIndex);
                    markerOverlay.Markers.RemoveAt(e.RowIndex + 1);
                    lineLayer.Points.RemoveAt(e.RowIndex);
                    gMap.UpdateRouteLocalPosition(lineLayer);
                    updateDistance();
                    updateData();
                    num--;
                }
                catch (InvalidOperationException)
                {

                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dataGridView2.Rows.Count > 1)
            {
                string data = "";
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    string end = " "; 
                    for (int j = 1; j < 4; j++)
                    {
                        string temp = "@";
                        if (j == 3)
                        {
                            temp = "";
                        }

                        data += dataGridView2.Rows[i].Cells[j].Value + temp;
                    }
                    if (i == dataGridView2.Rows.Count - 1)
                    {
                        end = "";
                    }
                    data += end;
                }
                this._sendData(data);
                Form4 messageform = new WindowsFormsApplication3.Form4();
                messageform.ShowDialog();
            }
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            if(is_connected)
            {
                this._sendData("3");
                textBox5.Text = curr_lat + "";
                longitudebox.Text = curr_long + "";
            }
        }

        private void altitudebox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
