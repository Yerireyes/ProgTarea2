using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics;
using OpenTK.Graphics.OpenGL;

namespace ProgTarea2
{
    class Game : GameWindow
    {
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.White);
            GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();
            GL.Ortho(-300, 300, -300, 300, -300, 300);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Rotate(0.5, 0, 1.0, 0.3);
            base.OnUpdateFrame(e);
        }
        private Color color = Color.Black;
        public List<Vector3> lista1 = new List<Vector3>() { new Vector3(0, 50, 0), new Vector3(50, 50, 0), new Vector3(50, 0, 0), new Vector3(0, 0, 0) };
        public List<Vector3> lista2 = new List<Vector3>() { new Vector3(0, 50, 0), new Vector3(0, 50, 50), new Vector3(0, 0, 50), new Vector3(0, 0, 0) };
        public List<Vector3> lista3 = new List<Vector3>() { new Vector3(0, 50, 50), new Vector3(50, 50, 50), new Vector3(50, 0, 50), new Vector3(0, 0, 50) };
        public List<Vector3> lista4 = new List<Vector3>() { new Vector3(50, 50, 50), new Vector3(50, 50, 0), new Vector3(50, 0, 0), new Vector3(50, 0, 50) };
        public List<Vector3> listaCuboArriba = new List<Vector3>() { new Vector3(0, 50, 50), new Vector3(50, 50, 50), new Vector3(50, 50, 0), new Vector3(0, 50, 0) };
        public List<Vector3> listaCuboAbajo = new List<Vector3>() { new Vector3(0, 0, 50), new Vector3(50, 0, 50), new Vector3(50, 0, 0), new Vector3(0, 0, 00) };

        public List<Vector3> lista5 = new List<Vector3>() { new Vector3(0, 100, 0), new Vector3(50, 0, 50), new Vector3(50, 0, -50)};
        public List<Vector3> lista6 = new List<Vector3>() { new Vector3(0, 100, 0), new Vector3(50, 0, -50), new Vector3(-50, 0, -50)};
        public List<Vector3> lista7 = new List<Vector3>() { new Vector3(0, 100, 0), new Vector3(-50, 0, -50), new Vector3(-50, 0, 50) };
        public List<Vector3> lista8 = new List<Vector3>() { new Vector3(0, 100, 0), new Vector3(50, 0, 50), new Vector3(-50, 0, 50)};
        protected override void OnRenderFrame(FrameEventArgs e)
        {

            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();

            //GL.Rotate(20, 1, 1, 0);
            Face cara1 = new Face(lista1, Color.Green);
            Face cara2 = new Face(lista2, Color.Red);
            Face cara3 = new Face(lista3, Color.Blue);
            Face cara4 = new Face(lista4, color);
            Face caraCuboArriba = new Face(listaCuboArriba, Color.Yellow);
            Face caraCuboAbajo = new Face(listaCuboAbajo, Color.GreenYellow);
            Face cara5 = new Face(lista5, Color.LightGray);
            Face cara6 = new Face(lista6, Color.Aqua);
            Face cara7 = new Face(lista7, Color.Gold);
            Face cara8 = new Face(lista8, color);
            Objeto3D prueba = new Objeto3D(new List<Face>() { cara1,  cara2, cara3, cara4, caraCuboArriba, caraCuboAbajo} , new Vector3(-150, -120, 0));
            Objeto3D prueba1 = new Objeto3D(new List<Face>() { cara5, cara6, cara7, cara8 }, new Vector3(70, 70, 70));
            HelloEscenario escenario = new HelloEscenario(new List<Objeto3D>() { prueba, prueba1});
            escenario.Dibujar();
            
            SwapBuffers();
            base.OnRenderFrame(e);
        }
        protected override void OnResize(EventArgs e)
        {
            GL.Viewport(0, 0, Width, Height);
            base.OnResize(e);
        }
    }
}
