/*
 Consigna
Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

Deberá tener los atributos:

titular que contendrá la razón social del titular de la cuenta.
cantidad que será un número decimal que representa al monto actual de dinero en la cuenta.
Construir los siguientes métodos para la clase:

Un constructor que permita inicializar todos los atributos.
Un método getter para cada atributo.
mostrar retornará una cadena de texto con todos los datos de la cuenta.
ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando como va variando el saldo.

    Nombre: Santiago Felipe Cantos
    Dni: 42587701
    Division: 2E
 */

using ClassLibrary1;

namespace ProgramaciónOrientadaAObjetos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Cuenta unaCuenta = new Cuenta("Yo", 100);

            //funciona correctamente
            unaCuenta.Ingresar(150);
            unaCuenta.Retirar(300);

            Console.WriteLine(unaCuenta.GetData());
        }
    }
}