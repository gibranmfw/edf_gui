using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Media3D;



//Komurindo UI
//AURORA TEAM UNIVERSITY of INDONESIA

//Program masih perkembangan
namespace WindowsFormsApplication3
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();

        }

        //Mengolah data yang di dapat dari IMU
        public void LineReceived(double ax, double ay, double az)
        {
            float roll = (float) Formula.calculateRoll(ax, ay, az);
            float pitch = (float) Formula.calculatePitch(ax, ay, az);
            float yaw = (float) Formula.calculateYaw(ax, ay, az);

            userControl11.updateAxis(pitch, yaw, roll);
            userControl11.start();
            showResult(roll, pitch, yaw);
        }

        //Menghentikan Model 3D
        public void stop3D()
        {
            userControl11.stop();
        }

        //buat menampilkan data sensor
        private void showResult(float roll, float pitch, float yaw)
        {
            textBox2.Text = roll + "";
            aGauge1.Value = roll;
            artificialHorizon1.roll_angle = roll;
            chart1.Series["Roll"].Points.AddY(roll);

            textBox4.Text = yaw + "";
            aGauge2.Value = yaw;
            chart1.Series["Yaw"].Points.AddY(yaw);

            textBox5.Text = pitch + "";
            aGauge3.Value = pitch;
            artificialHorizon1.pitch_angle = pitch;
            chart1.Series["Pitch"].Points.AddY(pitch);
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }
    }
}




