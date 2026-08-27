using System;

namespace _9_CiclosWhile2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            byte CantNum = 0;
            int num = 0;
            int contador = 0;
            byte ContNeg = 0;
            byte ContPos = 0;
            byte Cont0 = 0;

            Console.WriteLine("Ingrese la cantidad de los números que va a introducir");
            CantNum = byte.Parse(Console.ReadLine());

            while (CantNum > contador)
            {
                contador++;
                Console.WriteLine("ingrese el numero a evaluar");
                num = int.Parse(Console.ReadLine());

                if (num < 0)
                {
                    ContNeg++;
                }

                else
                {
                    if (num > 0)
                    {
                        ContPos++;
                    }

                    else
                    {
                        Cont0++;
                    }
                }
            }
            Console.WriteLine($"la cantidad de numeros positivos es {ContPos}");
            Console.WriteLine($"la cantidad de numeros neutros es {Cont0}");
            Console.WriteLine($"la cantidad de numeros negativos es {ContNeg}");

        }
    }
}
