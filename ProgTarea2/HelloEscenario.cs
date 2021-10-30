using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTarea2
{
    class HelloEscenario
    {
        public HashSet<Objeto3D> listaDeObjetos3D;
        public Vector centro;

        public HelloEscenario(HashSet<Objeto3D> listaDeObjetos3D, Vector centro)
        {
            this.listaDeObjetos3D = listaDeObjetos3D;
            this.centro = centro;
        }

        public void Dibujar()
        {
            foreach (var objeto3D in listaDeObjetos3D)
            {
                objeto3D.Dibujar();
            }
        }
    }
}
