using System.Text;

namespace Logica_I03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random = new Random();

        static Estudiante()
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }

        private double CalcularPromedio(int notaPrimerParcial, int notaSegundoParcial)
        {
            return (double)(notaPrimerParcial + notaSegundoParcial) / 2;
        }

        public int CalcularNotaFinal()
        {
            int notaFinal = -1;

            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                notaFinal = random.Next(6, 11);
            }

            return notaFinal;
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("El nombre del alumno es: " + this.nombre);
            sb.AppendLine("La nota del primer parcial es: " + this.notaPrimerParcial);
            sb.AppendLine("La nota del segundo parcial es: " + this.notaSegundoParcial);
            sb.AppendLine("El promedio de notas es: " + CalcularPromedio(this.notaPrimerParcial, this.notaSegundoParcial));
            if (CalcularNotaFinal() != -1)
            {
                sb.AppendLine("La nota final es: " + CalcularNotaFinal());

            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            return sb.ToString();
        }
    }
}