using OpenTK;
using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace ProgTarea2
{
    class Face
    {
        private List<Vector3> listaDeVertices;
        public Color color;
        public Vector3 centro = new Vector3(0,0,0);

        public Face(List<Vector3> listaDeVertices, Color color)
        {
            this.listaDeVertices = listaDeVertices;
            this.color = color;
        }
        
        public void Dibujar()
        {
            GL.Color4(color);
            GL.Begin(PrimitiveType.Polygon);
            foreach (var vertice in listaDeVertices)
            {
                GL.Vertex3(vertice.X + centro.X, vertice.Y + centro.Y, vertice.Z + centro.Z);
            }
            GL.End();
            
        }
    }
}
