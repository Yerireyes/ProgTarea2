using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTarea2
{
    class Objeto3D
    {
        public HashSet<Face> listaDeCaras;
        public Vector centro { get; set; }
        public Objeto3D(HashSet<Face> listaDeCaras, Vector centro)
        {
            this.listaDeCaras = listaDeCaras;
            this.centro = centro;

            foreach (var cara in this.listaDeCaras)
            {
                cara.centro = centro;
            }
        }

        public void Insertar(Face nuevaCara)
        {
            listaDeCaras.Add(nuevaCara);
        }

        public void Eliminar(Face caraAEliminar)
        {
            listaDeCaras.Remove(caraAEliminar);
        }

        public void Dibujar()
        {
            foreach (var face in this.listaDeCaras)
            {
                face.Dibujar();
            }
        }

    }
}
