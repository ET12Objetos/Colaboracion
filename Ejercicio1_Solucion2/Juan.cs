using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio1_Solucion2
{
    public class Juan
    {
        public string nombre { get; set; }

        public Computadora computadora { get; set; }

        public Impresora impresora { get; set; }

        public Juan(string unNombre)
        {
            this.nombre = unNombre;

            computadora = new Computadora("COMPU-07");

            impresora = new Impresora("IMP-05");
        }

        public void ImprimirInforme(string nombreArchivo)
        {
            computadora.ImprimirArchivo(impresora, nombreArchivo);
        }
    }
}
