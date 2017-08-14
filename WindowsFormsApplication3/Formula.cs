using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Formula
    {
        public static double degreesToRad(double degrees)
        {
            return degrees * Math.PI / 180;
        }

        // Distance between 2 coordinate (latitude, longitude) in km
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

        public static double kmToM(double distance)
        {
            return distance * 1000;
        }

        public static double calculatePitch(double ax, double ay, double az)
        {
            return 180.0 * Math.Atan(ax / Math.Sqrt(Math.Pow(ay, 2) + Math.Pow(az, 2))) / Math.PI;
        }

        public static double calculateYaw(double ax, double ay, double az)
        {
            return 180.0 * Math.Atan(az / Math.Sqrt(Math.Pow(ax, 2) + Math.Pow(az, 2))) / Math.PI;
        }

        public static double calculateRoll(double ax, double ay, double az)
        {
            return 180.0 * Math.Atan(ay / Math.Sqrt(Math.Pow(ax, 2) + Math.Pow(az, 2))) / Math.PI;
        }
    }
}
