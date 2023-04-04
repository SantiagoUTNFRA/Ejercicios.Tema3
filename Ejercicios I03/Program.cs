using Logica_I03;

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //test
            Estudiante unEstudiante = new Estudiante("pepe", "perez", "123");

            unEstudiante.SetNotaPrimerParcial(6);
            unEstudiante.SetNotaSegundoParcial(7);

            Console.WriteLine(unEstudiante.Mostrar());
        }
    }
}