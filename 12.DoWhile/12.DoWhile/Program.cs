using System;

namespace _12.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = " ";
            string Cuenta = " ";
            int saldo = 0;
            int contador = 0;
            int acumulador = 0;
            bool respuesta = false;

            do
            {
                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();
                Console.WriteLine("ingrese el numero de cuenta");
                Cuenta = Console.ReadLine();
                Console.WriteLine("ingrese el saldo");
                saldo = int.Parse(Console.ReadLine());

                contador++;
                acumulador += saldo;

                if (saldo >= 3000000)
                {
                    Console.WriteLine($"{nombre}, identificado con el numero {Cuenta}, con saldo {saldo}, es apto para el credito");
                }
                else
                {
                    Console.WriteLine($"{nombre}, identificado con el numero {Cuenta}, con saldo {saldo},  no es apto para el credito");
                }

                Console.WriteLine("¿Desea seguir ingresando usuarios?");
                Console.WriteLine("No: false");
                Console.WriteLine("Si: true");
                respuesta=bool.Parse(Console.ReadLine());

            } while (respuesta == true);

            
            Console.WriteLine($"El número de usuarios que ingresaste fueron: {contador}");
            Console.WriteLine($"El promedio de saldos ingresados fue: {acumulador/contador}");

        }
    }
}
