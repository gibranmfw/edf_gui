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
using GMap.NET.MapProviders;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form3 : Form
    {
        GMapOverlay setofMarkers = new GMapOverlay("Markers");

        public Form3()
        {
            InitializeComponent();
            gMap.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerOnly;
            gMap.DragButton = MouseButtons.Left;
            gMap.SetPositionByKeywords("Jakarta");
            gMap.ShowCenter = false;
        }

        private void addMarker(PointLatLng position)
        {
            GMapMarker marker = new GMarkerGoogle(position, GMarkerGoogleType.blue_pushpin);
            setofMarkers.Markers.Add(marker);
            gMap.Overlays.Add(setofMarkers);
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

        public void lineReceived(double latitude, double longitude)
        {
            PointLatLng newPosition = new GMap.NET.PointLatLng(latitude, longitude);
            gMap.Position = newPosition;
            addMarker(gMap.Position);
        }
    }
}
