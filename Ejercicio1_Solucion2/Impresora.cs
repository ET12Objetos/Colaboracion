using System;

namespace Ejercicio1_Solucion2
{
    public class Impresora
    {
        public string nombre { get; set; }

        public Impresora(string unNombre)
        {
            this.nombre = unNombre;
        }

        internal void Imprimir(string nombre)
        {
            Console.WriteLine("La impresion de {0} fue exitosa", nombre);
        }
    }
}