using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    /// <summary>
    /// Module ini akan berisi semua definisi
    /// rumus-rumus yang digunakan pada
    /// software ini
    /// </summary>
    class Formula
    {
        /// <summary>
        /// Mengubah vairable dari derajat
        /// ke bentuk radian
        /// </summary>
        /// <param name="degrees">variable derajat</param>
        /// <returns>hasil konversi dalam radian</returns>
        public static double degreesToRad(double degrees)
        {
            return degrees * Math.PI / 180;
        }
        
        /// <summary>
        /// Menghitung jarak dari 2 coordinate
        /// </summary>
        /// <param name="lat1">latitude awal</param>
        /// <param name="long1">longitude awal</param>
        /// <param name="lat2">latitude akhir</param>
        /// <param name="long2">longitude akhir</param>
        /// <returns>jarak antar 2 koordinate dalam km (kilometer)</returns>
        public static double distanceTwoCoor(double lat1, double long1, double lat2, double long2)
        {
            double rEarth = 6371; //Radius of earth in km
            double dlat = degreesToRad(lat2 - lat1);
            double dlong = degreesToRad(long2 - long1);

            double lat1d = degreesToRad(lat1);
            double lat2d = degreesToRad(lat2);

            double a = Math.Sin(dlat / 2) * Math.Sin(dlat / 2) + Math.Sin(dlong / 2) * Math.Sin(dlong / 2) * Math.Cos(lat1d) * Math.Cos(lat2d);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return rEarth * c;
        }

        /// <summary>
        /// Mengubah nilai kilometer menjadi meter
        /// </summary>
        /// <param name="distance">nilai yang ingin dikonversi</param>
        /// <returns>hasil konversi dalam meter (m)</returns>
        public static double kmToM(double distance)
        {
            return distance * 1000;
        }

        /// <summary>
        /// Menghitung nilai pitch
        /// </summary>
        /// <param name="ax">percepatan dalam sumbu x</param>
        /// <param name="ay">percepatan dalam sumbu y</param>
        /// <param name="az">percepatan dalam sumbu z</param>
        /// <returns>nilai pitch</returns>
        public static double calculatePitch(double ax, double ay, double az)
        {
            return 180.0 * Math.Atan(ax / Math.Sqrt(Math.Pow(ay, 2) + Math.Pow(az, 2))) / Math.PI;
        }

        /// <summary>
        /// Menghitung nilai yaw
        /// </summary>
        /// <param name="ax">percepatan dalam sumbu x</param>
        /// <param name="ay">percepatan dalam sumbu y</param>
        /// <param name="az">percepatan dalam sumbu z</param>
        /// <returns></returns>
        public static double calculateYaw(double ax, double ay, double az)
        {
            return 180.0 * Math.Atan(az / Math.Sqrt(Math.Pow(ax, 2) + Math.Pow(az, 2))) / Math.PI;
        }

        /// <summary>
        /// Menghitung nilai roll
        /// </summary>
        /// <param name="ax">percepatan dalam sumbu x</param>
        /// <param name="ay">percepatan dalam sumbu y</param>
        /// <param name="az">percepatan dalam sumbu z</param>
        /// <returns></returns>
        public static double calculateRoll(double ax, double ay, double az)
        {
            return 180.0 * Math.Atan(ay / Math.Sqrt(Math.Pow(ax, 2) + Math.Pow(az, 2))) / Math.PI;
        }
    }
}
