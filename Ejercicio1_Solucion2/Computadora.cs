namespace Ejercicio1_Solucion2
{
    public class Computadora
    {
        public string nombre { get; set; }

        public Computadora(string unNombre)
        {
            nombre = unNombre;
        }

        public void ImprimirArchivo(Impresora impresora, string nombre)
        {
            impresora.Imprimir(nombre);
        }
    }
}