using System;

namespace TallerCondicinales_PruebaEscritorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,numero2, numero3 respectivamente. El algoritmo debe comprobar si los números son diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en pantalla los números de menor a mayor. Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben ingresar números diferentes.

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("ingrese el número 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número 3");
            num3 = int.Parse(Console.ReadLine());

            if (num1 == num2)
            {
                Console.WriteLine("Debe ingresar numeros diferentes");
            }
            else
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        if (num2 > num3)
                        {
                            Console.WriteLine($"{num3}, {num2}, {num1}");
                        }

                        else
                        {
                            Console.WriteLine($"{num2}, {num3}, {num1}");
                        }
                    }

                    else
                    {
                        if (num1 > num2)
                        {
                            Console.WriteLine($"{num2}, {num1}, {num3}");
                        }
                        else
                        {
                            if (num2 > num3)
                            {
                                Console.WriteLine($"{num1}, {num3}, {num2}");
                            }
                            else
                            {
                                Console.WriteLine($"{num1}, {num2}, {num3}");
                            }
                        }
                    }
                }
                else
                {
                    if (num3 > num2)
                    {
                        Console.WriteLine($"{num1}, {num2}, {num3}");
                    }
                    else
                    {
                        if (num1 > num3)
                        {
                            Console.WriteLine($"{num3}, {num1}, {num2}");
                        }
                        else
                        {
                            Console.WriteLine($"{num1}, {num3}, {num2}");
                        }
                    }
                }
                if (num1 == num3)
                {
                    Console.WriteLine("Debe ingresar numeros diferentes");
                }
                if (num3 == num2)
                {
                    Console.WriteLine("Debe ingresar numeros diferentes");
                }

            }
        }
    }
}
