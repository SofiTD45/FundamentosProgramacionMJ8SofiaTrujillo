using System;
namespace _20.ProgramacionModular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una matriz de n filas por m columnas, que permita ingresar solamente múltiplos de 5 hasta que se llene la matriz.

            int filas = CapturaFilas();
            int columnas = CapturaColumnas();
            int[,] matriz = new int[filas, columnas];
            LlenarMatriz(matriz, filas, columnas);
            MostrarMatriz(matriz, filas, columnas);
            BorrarPantalla();
        }

        static int CapturaFilas()
        {
            Console.WriteLine("Ingrese el número de filas de la matriz:");
            return int.Parse(Console.ReadLine());
        }

        static int CapturaColumnas()
        {
            Console.WriteLine("Ingrese el número de columnas de la matriz:");
            return int.Parse(Console.ReadLine());
        }

        static void LlenarMatriz(int[,] matriz, int filas, int columnas)
        {
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    int valor;
                    do
                    {
                        Console.WriteLine($"Ingrese un múltiplo de 5 para la posición [{i},{j}]:");
                        valor = int.Parse(Console.ReadLine());

                    } while (valor % 5 != 0);

                    matriz[i, j] = valor;
                }
            }
        }

        static void MostrarMatriz(int[,] matriz, int filas, int columnas)
        {
            Console.WriteLine("La matriz ingresada es:");
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($" {matriz[i, j]} |");
                }
                Console.WriteLine();
            }
        }

        static void BorrarPantalla()
        {
            Console.ReadKey();
            Console.Clear();
        }

    }
}




