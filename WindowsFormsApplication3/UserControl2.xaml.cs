using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using System.Reflection;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    /// <summary>
    /// Berisi perintah-perintah
    /// untuk mengendalikan model3D
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        private float x_axis = 0;
        private float y_axis = 0;
        private float z_axis = 0;
        private float rotate = 50;
        private ModelVisual3D device3D;

        public UserControl2()
        {
            InitializeComponent();
            this.device3D = new ModelVisual3D();
            //string model_path = @"C:\Users\Dispsiau 2013\Documents\Visual Studio 2015\Projects\WindowsFormsApplication10\WindowsFormsApplication10\Poly.obj";
          
            string appFolderPath = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string model_path = appFolderPath + @"/Resources/Poly.obj";
            this.device3D.Content = Display3d(model_path);
            viewPort3d.Children.Add(this.device3D);
        }

        /// <summary>
        /// Method untuk menghentikan 
        /// pergerakan dari model3D
        /// </summary>
        public void stop()
        {
            this.rotate = 0;
        }

        /// <summary>
        /// Method untuk menggerakkan model3D
        /// sesuai dengan data attitude roket
        /// </summary>
        /// <param name="pitch">data pitch roket</param>
        /// <param name="yaw">data yaw roket</param>
        /// <param name="roll">data roll roket</param>
        public void move(float pitch, float yaw, float roll)
        {
            updateAxis(pitch, yaw, roll);
            rotateModel();
        }

        /// <summary>
        /// Method untuk merotasi roket
        /// </summary>
        private void rotateModel()
        {
            RotateTransform3D rt = new RotateTransform3D();
            AxisAngleRotation3D ar = new AxisAngleRotation3D();
            ar.Axis = new Vector3D(this.x_axis, this.y_axis, this.z_axis);
            ar.Angle = this.rotate;
            rt.Rotation = ar;

            Transform3DGroup tg = new Transform3DGroup();
            tg.Children.Add(rt);

            this.device3D.Transform = tg;
        }

        /// <summary>
        /// Method untuk mengubah nilai dari
        /// pitch, yaw, roll
        /// </summary>
        /// <param name="pitch">Data pitch roket</param>
        /// <param name="yaw">Data yaw roket</param>
        /// <param name="roll">Data roll roket</param>
        private void updateAxis(float pitch, float yaw, float roll)
        {
            this.x_axis = pitch * -1;
            this.y_axis = roll * -1;
            this.z_axis = yaw * -1;
        }

        /// <summary>
        /// Method untuk menggenerate
        /// model3D
        /// </summary>
        /// <param name="model">objek model3D yg diinginkan</param>
        /// <returns>hasil model3D yang udah di generate</returns>
        private Model3D Display3d(string model)
        {
            Model3D device = null;
            try
            {
                //Adding a gesture here
                viewPort3d.RotateGesture = new MouseGesture(MouseAction.LeftClick);

                //Import 3D model file
                ModelImporter import = new ModelImporter();

                //Load the 3D model file
                device = import.Load(model);
            }
            catch (Exception e)
            {
                // Handle exception in case can not file 3D model
                MessageBox.Show("Exception Error : " + e.StackTrace);
            }
            return device;
        }

        ///To Do:
        ///Membuat method untuk meng-set nilai rotasi sesuai yg diinginkan
        ///atau gk mengubah dari 0 (stlh di stop) kembali ke nilai awal
    }
}
