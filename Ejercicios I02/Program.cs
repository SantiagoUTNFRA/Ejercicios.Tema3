/*
 Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

Deberá tener los atributos:

nombre
fechaDeNacimiento
dni
Deberá tener un constructor que inicialice todos los atributos.

Construir los siguientes métodos para la clase:

Setter y getter para cada uno de los atributos.
CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
Instanciar 3 objetos de tipo Persona en el método Main.
Mostrar quiénes son mayores de edad y quiénes no.

    Nombre: Santiago Felipe Cantos
    Dni: 42587701
    Division: 2E

 */
using Contenedor2;

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Juan", new DateTime(2016, 1, 29), 42587701);
            Persona personaDos = new Persona("Pedro", new DateTime(1990, 1, 29), 24922833);
            Persona personaTres = new Persona("Maria", new DateTime(2020, 5, 26), 46322121);

            personaUno.Mostrar();
            personaDos.Mostrar();
            personaTres.Mostrar();

            Console.WriteLine($"{personaUno.GetNombre()} {personaUno.EsMayorDeEdad(personaUno.GetFechaNacimiento())}");

            Console.WriteLine($"{personaDos.GetNombre()} {personaDos.EsMayorDeEdad(personaDos.GetFechaNacimiento())}");

            Console.WriteLine($"{personaTres.GetNombre()} {personaTres.EsMayorDeEdad(personaTres.GetFechaNacimiento())}");
        }
    }
}