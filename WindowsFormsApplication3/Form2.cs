using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        private Form1 dataForm = new Form1();
        private Form3 mapForm;
        private bool isConnected = false;
        private const int gpsConst = 10000000;
        private const string low = "750";
        private const string high = "2000";
        public int test = 12;


        public Form2()
        {
            mapForm = new Form3(this.sendData);
            InitializeComponent();
            connect_button.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.disconnectIcon;
            getAvailablePorts();
            motor_button.Enabled = false;
            parachute_button.Enabled = false;
            connect_button.Enabled = true;
            status_bar.Enabled = true;
            dataForm.TopLevel = false;
            mapForm.TopLevel = false;
            dataForm.FormBorderStyle = FormBorderStyle.None;
            mapForm.FormBorderStyle = FormBorderStyle.None;
            panelData.Controls.Clear();
            panelData.Controls.Add(dataForm);
            panelMap.Controls.Clear();
            panelMap.Controls.Add(mapForm);
            dataForm.Visible = true;
            mapForm.Visible = true;
            mapForm.Dock = DockStyle.Fill;
            dataForm.Dock = DockStyle.Fill;
            

        }

        public delegate void LineReceivedEvent(double ax, double ay, double az);
        public delegate void LineReceivedEvent2(double latitude, double longitude, double altitude, double distance);
        public delegate void LineReceivedEvent3(double altitude, double distance);

        public void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            port_combo.Items.AddRange(ports);
        }

        private void connect()
        {
            try
            {
                if (port_combo.Text.Equals("Port Available") || port_combo.Text.Equals(""))
                {
                    status_bar.Text = "Please, choose port value";

                }
                else if (baud_combo.Text.Equals("Baud Rate") || port_combo.Text.Equals(""))
                {
                    status_bar.Text = "Please, choose baud rate value";
                }
                else
                {
                    //pilih port 
                    serialPort1.PortName = port_combo.Text;
                    //pilih baudrate
                    serialPort1.BaudRate = Convert.ToInt32(baud_combo.Text);

                    isConnected = true;
                    status_bar.Text = "Connected";
                    serialPort1.Open();
                    serialPort1.DataReceived += serialPort1_DataReceived;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Encoding = System.Text.Encoding.Default;



                    progress_bar.Value = 100;                    //supaya button lain aktif
                    motor_button.Enabled = true;
                    parachute_button.Enabled = true;
                    port_combo.Enabled = false;
                    baud_combo.Enabled = false;
                    mapForm.toggle_connect();
                }
            }
            catch (UnauthorizedAccessException)
            {
                status_bar.Text = "Port is busy, please select other port";
                //Seandainya port arduino udah diconnect via lain, maka muncul pesan itu
            }
        }

        private void disconnect()
        {
            serialPort1.DataReceived -= serialPort1_DataReceived;
            serialPort1.Close();
            progress_bar.Value = 0;
            motor_button.Enabled = false;
            port_combo.Enabled = true;
            baud_combo.Enabled = true;
            status_bar.Text = "Disconnected";
            isConnected = false;
            mapForm.toggle_connect();
        }

        private void connectButton_Click(object sender, EventArgs e)
        {

        }

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                connect_button.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.disconnectIcon;
                disconnect();
            }
            else
            {
                connect_button.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.connectIcon;
                connect();
            }

        }

        //        public void read()
        //        {
        //            while(_continue)
        //            {
        //                try
        //                {

        //               }
        //                catch
        //                {

        //                }
        //            }
        //        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string[] input = serialPort1.ReadLine().Split(' ');

                if (input.Length == 3)
                {
                    double ax;
                    double ay;
                    double az;
                    //if (Double.TryParse(input[0], out lat) && Double.TryParse(input[1], out lon) && Double.TryParse(input[2], out alt) && Double.TryParse(input[3], out dis) && Double.TryParse(input[4], out ax) && Double.TryParse(input[5], out ay) && Double.TryParse(input[6], out az))
                    if(Double.TryParse(input[0].Replace(".",","), out ax) && Double.TryParse(input[1].Replace(".", ","), out ay) && Double.TryParse(input[2].Replace(".", ","), out az))
                    {
                        //double latitude = Double.Parse(input[3]) / gpsConst;
                        //double longitude = Double.Parse(input[4]) / gpsConst;

                        //if (lat == 0 && lon == 0)
                        //{
                        //    getSignal = false;
                        //}

                        Debug.Print(ax + "");
                        Debug.Print(ay + "");
                        Debug.Print(az + "");

                        if (isConnected)
                        {
                            this.BeginInvoke(new LineReceivedEvent(dataForm.LineReceived), ax, ay, az);
                           // if (getSignal)
                           // {
                           //     this.BeginInvoke(new LineReceivedEvent2(mapForm.lineReceived), lat, lon);
                           // }
                        }
                        else
                        {
                            dataForm.stop3D();
                        }
                    }
                }
                else if(input.Length == 4)
                {
                    double lat;
                    double lon;
                    double alt;
                    double dis;

                    if (!string.IsNullOrEmpty(input[0]) && !string.IsNullOrEmpty(input[1]) && !string.IsNullOrEmpty(input[2]) && !string.IsNullOrEmpty(input[3]) && Double.TryParse(input[0].Replace(".", ","), out lat) && Double.TryParse(input[1].Replace(".", ","), out lon) && Double.TryParse(input[2].Replace(".", ","), out dis) && Double.TryParse(input[3].Replace(".", ","), out alt))
                    {
                        bool getSignal = true;

                        if (lat == 0 && lon == 0)
                        {
                            getSignal = false;
                        }

                        if (isConnected && getSignal)
                        {
                            this.BeginInvoke(new LineReceivedEvent2(mapForm.lineReceived), lat, lon, alt, dis);
                            this.BeginInvoke(new LineReceivedEvent3(dataForm.LineReceived2), alt, dis);
                        }
                    }
                }
            }
            catch(Exception)
            {
                serialPort1.Close();
            }
        }

        //Buat kontrol sekian derajat servo ke arduino//
        private void motorButton_Click(object sender, EventArgs e)
        {
        }

        private void motor_button_Click(object sender, EventArgs e)
        {
            status_bar.Text = "Toggle motor";
            this.sendData("2");
        }

        public void sendData(string data)
        {
            serialPort1.WriteLine(data);
        }

        private void parachuteButton_Click(object sender, EventArgs e)
        {
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            status_bar.Text = "parachute on";
            this.sendData("1");
        }

        private void status_bar_Click(object sender, EventArgs e)
        {

        }
    }
}
