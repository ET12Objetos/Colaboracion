using System;

namespace Ejercicio4_Solucion1
{
    public class Bibliotecario
    {
        public string nombre { get; set; }

        public Indice indice { get; set; }

        public Asistente asistente { get; set; }

        public Bibliotecario(string unNombre, Asistente unAsistente)
        {
            nombre = unNombre;

            asistente = unAsistente;

            indice = new Indice("Inventario");
        }

        public Libro BuscarLibro(string titulo)
        {
            Console.WriteLine($"2 - Busco en libro {titulo} en el Indice");

            //busco el libro en el indice y me retorna el código del mismo
            int codigoLibro = indice.Buscar(titulo);

            Console.WriteLine($"4 - Le solicito al asistente {asistente.nombre} que traiga el libro con código {codigoLibro}");

            //Le indico al asistente que traiga el libro con el código determinado
            Libro libro = asistente.SolicitarLibro(codigoLibro);

            Console.WriteLine($"6 - Le entrego el libro con código {libro.nombre} al lector");

            //Devuelve el libro solicitado al bibliotecario
            return libro;
        }
    }
}