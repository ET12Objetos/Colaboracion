using System;

namespace Ejercicio4_Solucion1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instancio el objeto Lector y le asigno un nombre
            Lector lector = new Lector("Juan");

            //Instancio el objeto Asistente y le asigno un nombre
            Asistente asistente = new Asistente("Pedro");

            //Instancio un objeto bibliotecario le asigno un nombre y tambien le asigno un objeto Asistente (aquí el objeto "asistente" depende del objeto "bibliotecario")
            Bibliotecario bibliotecario = new Bibliotecario("Jose", asistente);

            //Se le indica al Lector que se desea Solicitar un libro
            lector.SolicitarLibro(bibliotecario, "Alicia en el país de las maravillas");
        }
    }
}
