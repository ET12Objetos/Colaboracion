using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_Solucion1
{
    public class Juan
    {
        public string nombre { get; set; }

        public Computadora computadora { get; set; }

        public Juan(string unNombre)
        {
            this.nombre = unNombre;

            computadora = new Computadora("COMPU-07");
        }

        public void ImprimirInforme(string nombreArchivo)
        {
            computadora.ImprimirArchivo(nombreArchivo);
        }
    }
}
