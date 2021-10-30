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
        private HashSet<Objeto3D> objetos = new HashSet<Objeto3D>();
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title) { }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.White);
            GL.MatrixMode(MatrixMode.Projection);
            //GL.LoadIdentity();
            GL.Ortho(-500, 500, -500, 500, -500, 500);
            Objeto3D prueba = CargadorJson.Cargar("../../Objetos/prueba.json");
            Objeto3D prueba1 = CargadorJson.Cargar("../../Objetos/prueba1.json");
            objetos.Add(prueba);
            objetos.Add(prueba1);

        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            GL.Rotate(0.5, 0, 1.0, 0.2);
            base.OnUpdateFrame(e);
        }
        
        protected override void OnRenderFrame(FrameEventArgs e)
        {

            GL.Enable(EnableCap.DepthTest);
            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
            GL.MatrixMode(MatrixMode.Modelview);
            //GL.LoadIdentity();

            //GL.Rotate(20, 1, 1, 0);
            HelloEscenario escenario = new HelloEscenario(objetos, new Vector(0,70,0));
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
