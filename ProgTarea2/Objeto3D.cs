using OpenTK;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTarea2
{
    class Objeto3D
    {
        private List<Face> listaDeCaras;
        public Vector3 centro;
        public Objeto3D(List<Face> listaDeCaras, Vector3 centro)
        {
            this.listaDeCaras = listaDeCaras;
            this.centro = centro;

            foreach (var cara in this.listaDeCaras)
            {
                cara.centro = centro;
            }
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
