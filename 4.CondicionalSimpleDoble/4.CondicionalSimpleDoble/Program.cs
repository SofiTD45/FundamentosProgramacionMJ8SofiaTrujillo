using System;

namespace _4.CondicionalSimpleDoble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Estructura de control Condisional
            // Simple
            //1. crear un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenidos a mi sitio web"
             /*byte edad = 0;
             Console.WriteLine("Ingrese su edad");
             edad = Convert.ToByte(Console.ReadLine());
             if (edad >= 18)
             {
                 //Si la condicion es verdadera 
                 Console.WriteLine("Bienvenido a mi sitio web");
             }*/

            //2. Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos el mensaje en pantalla con el nombre de la persona, indica que debe abonar impuestos

            /*string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();
            float salario = 0;
            Console.WriteLine("ingrese su salario");
            salario = Convert.ToSingle(Console.ReadLine());

            if (salario >= 3000)
            {
                Console.WriteLine("Usted debe abonar impuestos");
            }*/

            //1. crear un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenidos a mi sitio web", de lo contrario mostrar el mensaje "usted no es apto para el contenido
            byte edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToByte(Console.ReadLine());
            if (edad >= 18)
            {
                //Si la condicion es verdadera 
                Console.WriteLine("Bienvenido a mi sitio web");
            }

            else
            {
                Console.WriteLine("Usted no es apto para este tipo de contenido");
            }
        }
    }
}
