using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



//Komurindo UI
//AURORA TEAM UNIVERSITY of INDONESIA
namespace WindowsFormsApplication3
{
    /// <summary>  
    ///  Module ini mendefinisikan form
    ///  mengenai data sensor dari roket
    ///  dan bagaimana mengvisualisasikannya
    ///  sehingga dapat dengan mudah dibaca user
    /// </summary>  
    public partial class DataForm : Form

    {
        public DataForm()
        {
            InitializeComponent();
            rocketobj.InitializeComponent();
        }

        /// <summary>  
        ///  Method ini bertugas untuk
        ///  Menerima data IMU dari MainForm (form utama)
        /// </summary>  
        /// <param name="ax">data percepatan pada sumbu x</param>
        /// <param name="ay">data percepatan pada sumbu y</param>
        /// <param name="az">data percepatan pada sumbu z</param>
        public void lineReceived(double ax, double ay, double az)
        {
            float roll = (float) Formula.calculateRoll(ax, ay, az);
            float pitch = (float) Formula.calculatePitch(ax, ay, az);
            float yaw = (float) Formula.calculateYaw(ax, ay, az);

            rocketobj.move(roll, pitch, yaw);
            showResult(roll, pitch, yaw);
        }

        /// <summary>  
        ///  Method ini bertugas untuk
        ///  menerima data GPS dari MainForm (form utama)
        /// </summary>  
        /// <param name="altitude">data ketinggian dari GPS</param>
        /// <param name="distance">data jarak tempuh dari GPS</param>
        public void lineReceived(double altitude, double distance)
        {
            trajectoryChart.Series["Trajectory"].Points.AddXY(distance, altitude);
        }

        /// <summary>  
        ///  Method ini akan menghentikan
        ///  pergerakkan dari model3D
        /// </summary>  
        public void stop3D()
        {
            rocketobj.stop();
        }


        /// <summary>  
        ///  Method ini bertugas untuk
        ///  menampilkan data roll, pitch, dan yaw
        ///  pada gauge, textbox, dan chart
        /// </summary>  
        ///  <param name="pitch">data pitch roket</param>
        ///  <param name="roll">data roll roket</param>
        ///  <param name="yaw">data yaw roket</param>
        private void showResult(float roll, float pitch, float yaw)
        {
            rollBox.Text = roll + "";
            rollGauge.Value = roll;
            artificialHorizon.roll_angle = roll;
            attitudeChart.Series["Roll"].Points.AddY(roll);

            yawBox.Text = yaw + "";
            yawGauge.Value = yaw;
            attitudeChart.Series["Yaw"].Points.AddY(yaw);

            pitchBox.Text = pitch + "";
            pitchGauge.Value = pitch;
            artificialHorizon.pitch_angle = pitch;
            attitudeChart.Series["Pitch"].Points.AddY(pitch);
        }
    }
    
    ///perbaiki trajectory chart
}




