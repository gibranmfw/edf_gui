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

namespace WindowsFormsApplication3
{
    /// <summary>
    /// Module ini berisi definisi - definisi
    /// fungsi yang ada pada MapForm untuk 
    /// menampilkan peta menggunakan gMap (google)
    /// 
    /// note:
    /// dalam menggunakan gMap harus terhubung
    /// dengan jaringan internet
    /// </summary>
    public partial class MapForm : Form
    {
        public MainForm parentForm { get; set; }
        GMapOverlay markerOverlay = new GMapOverlay("markers");
        GMapRoute lineLayer = new GMapRoute("single_line");
        public readonly Action<string> _sendData;
        public double curr_lat = 0;
        public double curr_long = 0;
        private int num = 1;
        public bool is_connected = false;

        public MapForm(Action<string> sendData)
        {
            try
            {
                System.Net.IPHostEntry e =
                     System.Net.Dns.GetHostEntry("www.google.com");
            }
            catch
            {
                ///jika tidak terhubung dengan internet
                MessageBox.Show("No internet connection avaible, going to CacheOnly mode.",
                      "GMap.NET - Demo.WindowsForms", MessageBoxButtons.OK,
                      MessageBoxIcon.Warning);
            }

            this._sendData = sendData;
            InitializeComponent();
            initializeGmap();

            ///menampilkan koordinat sekarang 
            latitudebox.Text = curr_lat + "";
            longitudebox.Text = curr_long + "";
        }

        /// <summary>
        /// Method yang bertugas untuk
        /// setting awal dari komponen gMap
        /// </summary>
        private void initializeGmap()
        {
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.DragButton = MouseButtons.Left;
            gMap.SetPositionByKeywords("jakarta");
            gMap.ShowCenter = false;
            lineLayer.Stroke = new Pen(Brushes.Black, 2);
            markerOverlay.Routes.Add(lineLayer);
            gMap.Overlays.Add(markerOverlay);
            addMarker(new PointLatLng(0, 0), GMarkerGoogleType.blue_dot);
        }

        /// <summary>
        /// Method yang bertugas untuk menambah marker
        /// pada gMap (menambah point, atau penunjuk lokasi)
        /// </summary>
        /// <param name="position">posisi sesuai dengan koordinate</param>
        /// <param name="type">tipe marker yang ingin digunakan</param>
        /// <returns>indeks marker baru sesuai dengan yang ada di list markerOverlay.Markers</returns>
        private int addMarker(PointLatLng position, GMarkerGoogleType type)
        {
            GMapMarker marker = new GMarkerGoogle(position, type);
            marker.ToolTipText = num + "";
            markerOverlay.Markers.Add(marker);
            gMap.Overlays.Add(markerOverlay);
            return markerOverlay.Markers.Count - 1;

        }

        /// <summary>
        /// Method untuk menambahkan penghubung / rute
        /// dari satu marker ke marker lain
        /// 
        /// dalam konteks ini menambahkan penghubung dari marker
        /// paling terakhir dengan marker yang baru ditambah
        /// </summary>
        private void addRoute()
        {
            int markersSize = markerOverlay.Markers.Count();
            lineLayer.Points.Add(markerOverlay.Markers[markersSize - 1].Position);
            gMap.UpdateRouteLocalPosition(lineLayer);
        }

        /// <summary>
        /// toggle variable is_connected
        /// </summary>
        public void toggle_connect()
        {
            is_connected = !(is_connected || false);
        }

        /// <summary>
        /// Method untuk menghandle ketika
        /// user mengklik button zoomIn
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomInButton_Click(object sender, EventArgs e)
        {
            if(gMap.Zoom < gMap.MaxZoom)
            {
                gMap.Zoom++;
                if (gMap.Zoom == gMap.MaxZoom)
                {
                    zoomInButton.Enabled = false;
                }
                else
                {
                    zoomOutButtom.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Method untuk menghandle ketika user
        /// mengklik button zoomOut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void zoomOutButton_Click(object sender, EventArgs e)
        {
            if(gMap.Zoom > gMap.MinZoom)
            {
                gMap.Zoom--;
                if (gMap.Zoom == gMap.MinZoom)
                {
                    zoomOutButtom.Enabled = false;
                }
                else
                {
                    zoomInButton.Enabled = true;
                }
            }
        }
        
        /// <summary>
        /// Method untuk menghandle ketika user
        /// mengklik gMap dengan mouse
        ///
        /// Tombol kanan pada mouse berfungsi
        /// jika user ingin menambah waypoint baru
        /// 
        /// User mengklik kanan mouse, lalu method ini
        /// akan menyimpan koordinat titik yang di klik
        /// dan akan disimpan sebagai waypoint
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            waypointDataGrid.Rows.Add(num, 0, lat, lng, "Delete");
                            num++;

                            AltForm altForm = new AltForm(this.set_altitude);
                            altForm.ShowDialog();
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Method untuk mengupdate nilai yang ada
        /// pada distanceBox
        /// </summary>
        public void updateDistance()
        {
            distanceBox.Text = lineLayer.Distance + " km";
        }

        /// <summary>
        /// Method yang akan menghandle data
        /// yang dikirim dari MainForm (form utama)
        /// </summary>
        /// <param name="latitude">data latitude roket</param>
        /// <param name="longitude">data longitude roket</param>
        /// <param name="altitude">data altitude roket</param>
        /// <param name="distance">data jarak tempuh roket</param>
        public void lineReceived(double latitude, double longitude, double altitude, double distance)
        {
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

            ///update textbox dan variable yang diperlukan
            rocketbox.Text = distance + " M";
            altitudeBox.Text = altitude + " M";
            curr_lat = latitude;
            curr_long = longitude;
        }

        /// <summary>
        /// Method yang akan mengecek apakah
        /// pada list Markers ada penanda
        /// untuk roket atau tidak
        /// </summary>
        /// <returns>index selain -1 jika ada, -1 jika tidak ditemukan</returns>
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

        /// <summary>
        /// Method yang bertugas untuk mengupdate
        /// column Nums yang ada pada data grid
        /// </summary>
        public void updateData()
        {
            for (int i = 0; i < waypointDataGrid.Rows.Count; i++)
            {
                waypointDataGrid.Rows[i].Cells[0].Value = i + 1;
            }
            for(int i = 1; i < markerOverlay.Markers.Count; i++)
            {
                markerOverlay.Markers[i].ToolTipText = i + "";
            }
        }

        /// <summary>
        /// Method untuk mengubah nilai altitude
        /// </summary>
        /// <param name="alt">nilai altitude baru</param>
        public void set_altitude(double alt)
        {
            int endrowindex = waypointDataGrid.Rows.Count - 2;
            waypointDataGrid.Rows[endrowindex].Cells[1].Value = alt;
        }

        /// <summary>
        /// Method yang menghandle ketika
        /// user mengklik button delete yang ada di dataGrid
        /// 
        /// maka program akan menghapus row tersebut
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void waypointDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ///jika mengklik button delete
            if (is_connected && e.ColumnIndex == 4)
            {
                try
                {
                    waypointDataGrid.Rows.RemoveAt(e.RowIndex);
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

        /// <summary>
        /// Method untuk menghandle
        /// ketika user mengklik button write
        /// 
        /// program maka akan mengirimkan semua data
        /// yang ada di waypointDataGrid dan mengirimkan nya
        /// ke form utama untuk dikirim ke roket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void writeButton_Click(object sender, EventArgs e)
        {
            if(waypointDataGrid.Rows.Count > 1)
            {
                string data = "";
                for (int i = 0; i < waypointDataGrid.Rows.Count - 1; i++)
                {
                    string end = " "; 
                    for (int j = 1; j < 4; j++)
                    {
                        string temp = "@";
                        if (j == 3)
                        {
                            temp = "";
                        }

                        data += waypointDataGrid.Rows[i].Cells[j].Value + temp;
                    }
                    if (i == waypointDataGrid.Rows.Count - 1)
                    {
                        end = "";
                    }
                    data += end;
                }
                this._sendData(data);
            }
        }

        /// <summary>
        /// Method untuk mengupdate koordinat awal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void homebutton_Click(object sender, EventArgs e)
        {
            if(is_connected)
            {
                this._sendData("3");
                altitudeBox.Text = curr_lat + "";
                longitudebox.Text = curr_long + "";
            }
        }
    }
}
