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

namespace WindowsFormsApplication3
{
    /// <summary>
    /// Form utama pada program ini
    /// berfungsi sebagai container untuk 
    /// menampung form lainnya, serta untuk
    /// berkomunikasi dengan hardware luar
    /// </summary>
    public partial class MainForm : Form
    {
        private DataForm dataForm = new DataForm();
        private MapForm mapForm;
        private bool isConnected = false;
        private delegate void LineReceivedEvent(double ax, double ay, double az);
        private delegate void LineReceivedEvent2(double latitude, double longitude, double altitude, double distance);
        private delegate void LineReceivedEvent3(double altitude, double distance);

        public MainForm()
        {
            mapForm = new MapForm(this.sendData);
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

        /// <summary>
        /// Method untuk menampilkan semua opsi
        /// ports yang tersedia
        /// </summary>
        private void getAvailablePorts()
        {
            String[] ports = SerialPort.GetPortNames();
            port_combo.Items.AddRange(ports);
        }

        /// <summary>
        /// Method untuk menghandle
        /// ketika GUI mulai berkomunikasi
        /// dengan roket
        /// </summary>
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
                    //choose port
                    serialPort1.PortName = port_combo.Text;
                    //choose baudrate
                    serialPort1.BaudRate = Convert.ToInt32(baud_combo.Text);

                    isConnected = true;
                    status_bar.Text = "Connected";

                    //basic serialport connection setting
                    serialPort1.Open();
                    serialPort1.DataReceived += serialPort1_DataReceived;
                    serialPort1.DataBits = 8;
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.Encoding = System.Text.Encoding.Default;

                    //setting when connected
                    progress_bar.Value = 100;
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
            }
        }

        /// <summary>
        /// Method untuk mengatur ketika 
        /// komuniasi antara roket dan GUI
        /// diputus oleh user
        /// </summary>
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

        /// <summary>
        /// Method yang mengatur toggle
        /// dari connectButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Method untuk mengatur ketika
        /// program menerima data dari serialPort (roket)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                string[] input = serialPort1.ReadLine().Split(' ');

                ///program dibawah berfungsi ketika menerima data IMU
                if (input.Length == 3)
                {
                    double ax;
                    double ay;
                    double az;

                    if(Double.TryParse(input[0].Replace(".",","), out ax) && Double.TryParse(input[1].Replace(".", ","), out ay) && Double.TryParse(input[2].Replace(".", ","), out az))
                    {
                        if (isConnected)
                        {
                            this.BeginInvoke(new LineReceivedEvent(dataForm.lineReceived), ax, ay, az);
                        }
                        else
                        {
                            dataForm.stop3D();
                        }
                    }
                }

                ///program dibawah berfungsi ketika menerima data GPS
                else if (input.Length == 4)
                {
                    double lat;
                    double lon;
                    double alt;
                    double dis;

                    if (!string.IsNullOrEmpty(input[0]) && !string.IsNullOrEmpty(input[1]) && !string.IsNullOrEmpty(input[2]) && !string.IsNullOrEmpty(input[3]) && Double.TryParse(input[0].Replace(".", ","), out lat) && Double.TryParse(input[1].Replace(".", ","), out lon) && Double.TryParse(input[2].Replace(".", ","), out dis) && Double.TryParse(input[3].Replace(".", ","), out alt))
                    {
                        if (isConnected && lat != 0 && lon != 0)
                        {
                            this.BeginInvoke(new LineReceivedEvent2(mapForm.lineReceived), lat, lon, alt, dis);
                            this.BeginInvoke(new LineReceivedEvent3(dataForm.lineReceived), alt, dis);
                        }
                    }
                }
            }
            catch(Exception)
            {
                serialPort1.Close();
            }
        }

        /// <summary>
        /// Method yang mengatur ketika user
        /// mengklik motorButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void motor_button_Click(object sender, EventArgs e)
        {
            status_bar.Text = "Toggle motor";
            this.sendData("2");
        }

        /// <summary>
        /// Method untuk mengirimkan data
        /// ke roket melalui serialPort
        /// </summary>
        /// <param name="data">Data yang ingin dikirimkan</param>
        public void sendData(string data)
        {
            serialPort1.WriteLine(data);
        }

        /// <summary>
        /// Method untuk menghandle ketika
        /// user ingin mengeluarkan parasut roket
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            status_bar.Text = "parachute on";
            this.sendData("1");
        }
    }
    /// To - do:
    /// atur sistem local sehingga program bisa
    /// digunakan dengan menggunakan laptop
    /// mana saja
}
