using HelixToolkit.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;

namespace WindowsFormsApplication3
{
    /// <summary>
    /// Interaction logic for UserControl2.xaml
    /// </summary>
    public partial class UserControl2 : UserControl
    {
        private string MODEL_PATH = @"C:\Users\Dispsiau 2013\Documents\Visual Studio 2015\Projects\WindowsFormsApplication10\WindowsFormsApplication10\Poly.obj";
        private float x_axis = 0;
        private float y_axis = 0;
        private float z_axis = 0;
        private float rotate = 50;
        private ModelVisual3D device3D;


        public UserControl2()
        {
            InitializeComponent();
            this.device3D = new ModelVisual3D();
            this.device3D.Content = Display3d(MODEL_PATH);
            viewPort3d.Children.Add(this.device3D);

            //var axis = new Vector3D(20, 20, 1);
            //var angle = 180;

            //var matrix = this.device3D.Transform.Value;
            //matrix.Rotate(new Quaternion(axis, angle));

            //this.device3D.Transform = new MatrixTransform3D(matrix);
        }

        public void stop()
        {
            this.rotate = 0;
        }

        public void move(float pitch, float yaw, float roll)
        {
            updateAxis(pitch, yaw, roll);
            rotateModel();
        }

        public void rotateModel()
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

        public void updateAxis(float pitch, float yaw, float roll)
        {
            this.x_axis = pitch;
            this.y_axis = roll;
            this.z_axis = yaw;

            //var axis = new Vector3D(this.x_axis, this.y_axis, this.z_axis);

            //var matrix = this.device3D.Transform.Value;
            //matrix.Rotate(new Quaternion(axis, this.rotate));

            //this.device3D.Transform = new MatrixTransform3D(matrix);
        }

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
    }
}
