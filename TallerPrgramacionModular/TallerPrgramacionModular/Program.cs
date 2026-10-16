using System;


namespace Taller5Modular1
{
    internal class Program
    {
        /*Desarrolla un programa que permita: 
         Ingresar una palabra 
         LLevar la palabra ingresada a un vector de caracteres 
         Contar la cantidad de vocales y consonantes en la palabra proporcionada por el 
         usuario. */

        static void Main(string[] args)
        {
            char[] vector = Vector(IngresarPalabra());
            Contar(vector);
        }
        static string IngresarPalabra()
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();
            return palabra;
        }

        static char[] Vector(string palabra)
        {
            char[] vector = palabra.ToCharArray();
            return vector;
        }

        static void Contar(char[] vector)
        {
            int vocales = 0;
            int consonantes = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == 'a' || vector[i] == 'e' || vector[i] == 'i' || vector[i] == 'o' || vector[i] == 'u')
                {
                    vocales++;
                }
                else
                {
                    consonantes++;
                }
            }
            Console.WriteLine($"La cantidad de vocales es: {vocales}");
            Console.WriteLine($"La cantidad de consonantes es: {consonantes}");
        }

    }
}
