using System;

namespace _18.ProgramacionModular
{
    internal class Program
    {
        static int añoActual = 2026;
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al curso de Fundamentos en Programación");
            MostrarMensaje("Sofia");
            Console.WriteLine($"Sofia tiene: {Calcularedad()} años");
            MostrarMensaje("Sofia", "Trujillo");
            MostrarMensaje("Martin");
            int añoNacimiento = 2000;
            Console.WriteLine($"Camilo tiene, {CalcularEdad(añoNacimiento,añoActual)} años");
            Console.ReadKey();
            BorrarPantalla();
        }

        //Funciones con parámetros
        static int CalcularEdad(int añoNacimiento, int añoActual)
        {
            return añoActual - añoNacimiento;
        }

        //Funciones sin parámetros
        static int Calcularedad()
        {
            int añoNacimiento = 2006;
            int añoActual = 2026;
            int edad = añoActual - añoNacimiento;
            return edad;
        }

        //Procedimiento sin parámetros
        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MostrarMensaje(string nombre)
        {
            Console.WriteLine($"Bienvenido, {nombre} al curso de fundamentos de programación!");
        }

        static void MostrarMensaje(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido, {nombre} {apellidos} al curso de fundamentos de programación!");
        }
    }
}
