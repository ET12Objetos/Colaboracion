namespace Ejercicio1_Solucion1
{
    public class Computadora
    {
        public string nombre { get; set; }

        public Impresora impresora { get; set; }

        public Computadora(string unNombre)
        {
            nombre = unNombre;

            impresora = new Impresora("IMP-05");
        }

        public void ImprimirArchivo(string nombre)
        {
            impresora.Imprimir(nombre);
        }
    }
}