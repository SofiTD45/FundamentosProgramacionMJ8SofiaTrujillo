using System;

namespace _11.CicloDoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ciclo Do..While

            /*int acumulador = 0;
            int contador = 1;

            do
            {
                acumulador += contador;
                contador++;

            } while (contador <= 5);

            Console.WriteLine($"la suma de los primeros 5 números enteros es: {acumulador}");*/

            int Num = 0;
            int contador = 0;
            bool Respuesta = false;


            do
            {
                Console.WriteLine("Escribe el numero que desea expresar su tabla");
                Num = int.Parse(Console.ReadLine());

                do
                {
                    contador ++;
                    Console.WriteLine($" {Num} X {contador} = {Num*contador} ");

                } while( contador < 10 );

                contador = 0;
                Console.WriteLine("¿Quiere ver la tabla de otro numero?");
                Console.WriteLine("No: false");
                Console.WriteLine("Si: true");
                Respuesta = bool.Parse(Console.ReadLine());

            } while (Respuesta == true);





        }   
    }
}
