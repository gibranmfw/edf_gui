using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using SharpGL;
using SharpGL.SceneGraph;

namespace WindowsFormsApplication3
{
    /// <summary>
    /// Interaction logic for UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        private float x_axis = 0;
        private float y_axis = 0;
        private float z_axis = 0;
        private float rotate = 50;

        public UserControl1()
        {
            Width = 214;
            Height = 242;
            InitializeComponent();
        }

        public void updateAxis(float pitch, float yaw, float roll)
        {
            this.x_axis = pitch * -1;
            this.y_axis = yaw;
            this.z_axis = roll * -1;
        }

        public void stop()
        {
            this.rotate = 0;
        }

        public void start()
        {
            this.rotate = 50;
        }
        
        private void OpenGLControl_OpenGLDraw(object sender, OpenGLEventArgs args)
        {
            OpenGL gl = args.OpenGL;

            //  Hilangkan warna
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            //  Reset modelview.
            gl.LoadIdentity();

            //  Pindah model 3D ke tengah
            gl.Translate(0.0f, 0.0f, -7.0f);
           
            // x muter keatas
            // y belok ke kanan
            // z muter clockwise
            gl.Rotate(rotate, this.x_axis, this.y_axis, this.z_axis);

            gl.Begin(OpenGL.GL_QUADS);

            gl.Color(0.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);

            gl.Color(1.0f, 0.5f, 0.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.Color(1.0f, 0.0f, 0.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);

            gl.Color(1.0f, 1.0f, 0.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);

            gl.Color(0.0f, 0.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, 1.0f);
            gl.Vertex(-1.0f, 1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, -1.0f);
            gl.Vertex(-1.0f, -1.0f, 1.0f);

            gl.Color(1.0f, 0.0f, 1.0f);
            gl.Vertex(1.0f, 1.0f, -1.0f);
            gl.Vertex(1.0f, 1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, 1.0f);
            gl.Vertex(1.0f, -1.0f, -1.0f);

            gl.End();
            
            //  Flush OpenGL.
            gl.Flush();
        }
    }
}
