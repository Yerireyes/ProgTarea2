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
        public HashSet<Vector> listaDeVertices;
        public Color color;
        public Vector centro;

        public Face(HashSet<Vector> listaDeVertices, Color color, Vector centro)
        {
            this.listaDeVertices = listaDeVertices;
            this.color = color;
            this.centro = centro;
        }
        
        public void Insertar(Vector nuevoVertice)
        {
            listaDeVertices.Add(nuevoVertice);
        }
        
        public void Eliminar(Vector verticeAEliminar)
        {
            listaDeVertices.Remove(verticeAEliminar);
        }


        public void Dibujar()
        {
            GL.Color4(color);
            GL.Begin(PrimitiveType.Polygon);
            foreach (var vertice in listaDeVertices)
            {
                GL.Vertex3(vertice.X + centro.X , vertice.Y + centro.Y, vertice.Z + centro.Z);
            }
            GL.End();
            
        }
    }
}
