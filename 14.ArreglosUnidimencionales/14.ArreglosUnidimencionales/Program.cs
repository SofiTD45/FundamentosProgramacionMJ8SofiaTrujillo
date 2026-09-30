using System;

namespace _14.ArreglosUnidimencionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglos unidimencioneles o vector
            /* int[] numeros = new int[5];
             numeros[0] = 15;
             numeros[1] = 56;
             numeros[2] = 20;
             numeros[3] = 47;
             numeros[4] = 27;
             Console.WriteLine($"El dato almacenado en la posición 4 con índice3 es: {numeros[3]}");*/

            /*float[]  notas = new float[3];
            notas[0] = 3.7f;
            notas[1] = 4.1f;
            notas[2] = 5f;*/

            //Recorrer un vector para llenar los datos

            /*string[] nombre = new string[7];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la P {i + 1}:I{i}");
                nombre[i] = Console.ReadLine();
            }

            // Recorrer el vector para recuperar los datos almacenados en el vector

            for (int i = 0;i < nombre.Length;i++)
            {
                Console.Write($"{nombre[i]}|");
            }*/

            int [] enteros = new int [100];

            for (int i = 0; i < enteros.Length; i++)
            { 
               enteros [i] = 10;
                Console.WriteLine(enteros[i]);
            }
        }
    } 
}

