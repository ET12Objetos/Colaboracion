using System;

namespace Ejercicio4_Solucion1
{
    public class Indice
    {
        public string nombre { get; set; }

        public Indice(string unNombre)
        {
            nombre = unNombre;
        }

        public int Buscar(string titulo)
        {
            Console.WriteLine($"3 - Devuelve el código del libro {titulo}");

            //Aqui correspondereria buscar el CODIGO del libro en función a su TITULO
            //Para simplificar se genera un número aleatorio que representa al código del libro
            return new Random().Next(1000);
        }
    }
}