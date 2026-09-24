using System;

namespace _16.ArreglosBidimencinal_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arreglos bidimencionales -  Matrices

            /*int[,] numeros = new int[2,3];

            //numeros[2,1] = 45; Nose se puede almacenar porque el indice de la fila no existe
            //numeros[1,4] = 45; Nose se puede almacenar porque el indice de la columba no existe

            numeros [0,0] = 12;
            numeros [0,1] = 89;
            numeros [0,2] = 46;
            numeros [1,0] = 2;
            numeros [1,1] = 54;
            numeros [1,2] = 25;*/

            //Recuperar el dato de la posición

            // Console.WriteLine($"El numero almacenado en numeros[0,1] es: {numeros[0, 1]}");

            //Recorrer matriz para llenar
            /*char[,] simbolos = new char[3, 2];

            for (int i = 0; i < 3; i++)//Recorrer las filas
            {
                for (int j = 0; j < 2; j++)// recorrer las columnas
                {
                    Console.WriteLine($"Escriba el caracter para los simbolos [{i},{j}]");
                    simbolos[i, j] = char.Parse(Console.ReadLine());
                }
            }

            // Recorrer para recuperar los datos
            Console.Clear();

            for (int i = 0; i < simbolos.GetLength(0); i++)
            {
                for (int j = 0;j < simbolos.GetLength(1); j++)
                {
                    Console.Write($"{simbolos[i, j]} |");
                }
                Console.WriteLine();
            }*/

            /*int[,] 100 = new int[10, 20];

            for (int i = 0; i < 10; i++)//Recorrer las filas
            {
                for (int j = 0; j < 20; j++)// recorrer las columnas
                {
                    100[i, j] = 100;
                }
            }

            // Recorrer para recuperar los datos
            Console.Clear();

            for (int i = 0; i < 100.GetLength(0); i++)
            {
                for (int j = 0; j < 100.GetLength(1); j++)
                {
                    Console.Write($"{100[i, j]} |");
                }
                Console.WriteLine();
            }*/

            int[,] M1 = new int[2,3];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Esciba el numeros de la primera matriz [{i},{j}]");
                    M1[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int[,] M2 = new int[2, 3];

            for (int l = 0; l < 2; l++)
            {
                for (int k = 0; k < 3; k++)
                {
                    Console.WriteLine($"Escriba el numero de la segunda matriz [{l},{k}]");
                    M2[l, k] = int.Parse(Console.ReadLine());
                }
            }

            int[,] Mtotal = new int[2, 3];

            for (int m = 0; m < 2; m++)
            {
                for (int n = 0; n < 3; n++)
                {
                    Mtotal[m, n] = M1[m,n] + M2[m,n];
                    Console.Write($" {Mtotal[m, n]} |");
                }
                Console.WriteLine();
            }

        }
    }
}
