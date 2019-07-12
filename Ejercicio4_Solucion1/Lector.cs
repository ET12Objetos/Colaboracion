using System;

namespace Ejercicio4_Solucion1
{
    public class Lector
    {
        public string nombre { get; set; }

        public Lector(string unNombre)
        {
            this.nombre = unNombre;
        }

        public void SolicitarLibro(Bibliotecario bibliotecario, string titulo)
        {
            Console.WriteLine($"1 - Solicito el libro: {titulo} a {bibliotecario.nombre}");

            //Le indico al objeto "bibliotecario" que deseo buscar un libro con un titulo determinado
            Libro libro = bibliotecario.BuscarLibro(titulo);

            Console.WriteLine($"El lector {nombre} ya posee el libro {libro.nombre}");
        }
    }
}