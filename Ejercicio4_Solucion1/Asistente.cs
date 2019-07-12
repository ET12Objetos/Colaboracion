using System;

namespace Ejercicio4_Solucion1
{
    public class Asistente
    {
        public string nombre { get; set; }

        public Asistente(string unNombre)
        {
            nombre = unNombre;
        }

        public Libro SolicitarLibro(int codigoLibro)
        {
            Console.WriteLine($"5 - El libro con código {codigoLibro} es entregado");

            //Aqui el asistente deberia ir a buscar el objeto libro a partir de su código
            //Para simplificar la situación instancio un objeto Libro con el código "codigoLibro"
            return new Libro(codigoLibro);
        }
    }
}