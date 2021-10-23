using System;
using System.Collections.Generic;
using System.Text;

namespace ProgTarea2
{
    class HelloEscenario
    {
        private List<Objeto3D> listaDeObjetos3D;

        public HelloEscenario(List<Objeto3D> listaDeObjetos3D)
        {
            this.listaDeObjetos3D = listaDeObjetos3D;
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
