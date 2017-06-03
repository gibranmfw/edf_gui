using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3
{
    class Formula
    {
        public static double calculatePitch(double ax, double ay, double az)
        {
            return (Math.Atan(ax / Math.Sqrt(ay * ay + az * az)) * 180.0) / Math.PI;
        }

        public static double calculateYaw(double ax, double ay, double az)
        {
            return 180.0 * (Math.Atan(az / Math.Sqrt(ax * ax + az * az))) / Math.PI;
        }

        public static double calculateRoll(double ax, double ay, double az)
        {
            return Math.Atan(-ay / az) * 180.0 / Math.PI;
        }
    }
}
