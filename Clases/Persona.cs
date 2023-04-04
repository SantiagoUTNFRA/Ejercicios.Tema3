namespace Contenedor2
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaNacimiento;
        public int dni;

        public Persona(string nombre, DateTime fechaNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
            this.dni = dni;
        }

        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaNacimiento()
        {
            return this.fechaNacimiento;
        }

        public string GetDni()
        {
            return this.dni.ToString();
        }

        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaNacimiento(DateTime fechaNacimiento)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }

        public int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }


        public string Mostrar()
        {
            return $"Nombre: {nombre} - Fecha de Nacimiento: {fechaNacimiento} - DNI: {dni}";
        }

        public string EsMayorDeEdad(DateTime fechaNacimiento)
        {
            return (CalcularEdad(fechaNacimiento) >= 18 ? "Es mayor de edad" : "Es menor de edad");
        }
    }
}