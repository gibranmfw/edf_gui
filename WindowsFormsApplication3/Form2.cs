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
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    public partial class Form2 : Form
    {
        private Form1 dataForm = new Form1();
        private Form3 mapForm = new Form3();
        private bool isConnected = false;
        private const int gpsConst = 10000000;
        private const string low = "750";
        private const string high = "2000";
        private bool _continue = false;
        private String prevESC = "0";
        private String prevPara = "0";


        public Form2()
        {
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
        public delegate void LineReceivedEvent2(double latitude, double longitude);

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
                    status_bar.Text = "Pilih port terlebih dahulu";

                }
                else if (baud_combo.Text.Equals("Baud Rate") || port_combo.Text.Equals(""))
                {
                    status_bar.Text = "Pilih baud rate terlebih dahulu";
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
                }
            }
            catch (UnauthorizedAccessException)
            {
                status_bar.Text = "Port sudah digunakan oleh perangkat lain";
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

                if (input.Length == 5)
                {
                    double ax;
                    double ay;
                    double az;
                    if (Double.TryParse(input[0], out ax) && Double.TryParse(input[1], out ay) && Double.TryParse(input[2], out az))
                    {
                        double latitude = Double.Parse(input[3]) / gpsConst;
                        double longitude = Double.Parse(input[4]) / gpsConst;
                        bool getSignal = true;
                        if (latitude == 0 && longitude == 0)
                        {
                            getSignal = false;
                        }

                        if (isConnected)
                        {
                            this.BeginInvoke(new LineReceivedEvent(dataForm.LineReceived), ax, ay, az);
                            if (getSignal)
                            {
                                this.BeginInvoke(new LineReceivedEvent2(mapForm.lineReceived), latitude, longitude);
                            }
                        }
                        else
                        {
                            dataForm.stop3D();
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
            Form4 form4 = new Form4();
            form4.parentForm = this;
            form4.ShowDialog();
        }

        public void sendtoSerial(String input)
        {
            serialPort1.Write(input + " " + prevPara);
            status_bar.Text = "Kecepatan motor : " + input;
            prevESC = input;
        }

        private void MotorDownButton_Click(object sender, EventArgs e)
        {
            sendtoSerial("700");
        }

        private void MotorUpButton_Click(object sender, EventArgs e)
        {
            sendtoSerial("2000");
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
            serialPort1.Write(prevESC + " " + 1);
            prevPara = "1";
        }

        private void status_bar_Click(object sender, EventArgs e)
        {

        }
    }
}
