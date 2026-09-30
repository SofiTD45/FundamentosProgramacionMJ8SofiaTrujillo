using System;
using System.Text.RegularExpressions;

namespace _17.Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Diseñe un algoritmo que permita transformar una matriz numérica reemplazando todos sus elementos que sean menores a un valor umbral N, por dicho valor.

            /* Solicitar al usuario las dimensiones de la matriz(número de filas y columnas).
              Capturar los valores numéricos para llenar la matriz.
              Solicitar el valor límite u objetivo(N).
              Recorrer la matriz y actualizar cualquier valor que cumpla la condición elemento<N.
              Mostrar la matriz resultante.*/

            Console.WriteLine("Ingrese el número de filas de la matriz: ");
            int filas = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el número de columnas de la matriz: ");
            int columnas = int.Parse(Console.ReadLine());

            int[,] matriz = new int[filas, columnas];

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Ingrese el valor para la posición [{i},{j}]:  "); 
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Ingrese el valor umbral N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    if (matriz[i, j] < N)
                    {
                        matriz[i, j] = N;
                    }
                }
            }

            Console.WriteLine("Matriz resultante:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"{matriz[i, j]} |");
                }
                Console.WriteLine();
            }

        }
    }
}
