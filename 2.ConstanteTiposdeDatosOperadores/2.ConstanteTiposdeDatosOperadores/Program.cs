using System;

namespace _2.ConstanteTiposdeDatosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Constantes
            const string iva="19%";
            string nombre = "Sofia";
            nombre = "Trujillo";
            //iva = "20%"; a una constante no le puedes cambiar el valor
            //Tipos de datos
            //numericos
            byte dato1 = 255;
            int dato2 = -12365;
            long dato3 = 123456789;
            //Decimales
            float dato4 = 5.3f;
            double dato5 = 12.36d;
            decimal dato6 = 12394843247.879873987398m;
            //no numericos
            char dato7 = '?';//un solo caracter
            string dato8 = "yo me llamo cumbia yo soy la reina por donde voy";
            bool dato9 = false; //true o false
            object dato10 = new object();

            //OPERADORES
            //operadores numericos
            //cambio de signo
            int dato11 = 5;
            int dato12 = -dato11;
            Console.WriteLine("dato11: {0}, dato12:{1}", dato11, dato12);
            //operadores aritmeticos
            int dato13 = 3 + 5;
            Console.WriteLine("la suma es:{0}", dato13);
            int dato14 = dato13 - 2;
            Console.WriteLine("la resta es:{0}", dato14);
            int dato15 = 3 * 5;
            Console.WriteLine("la multiplicacion es:{0}", dato15);
            // float dato16 =(float) 5 / 3;
            float dato16 = 5f / 3f;
            Console.WriteLine("la division es:{0}", dato16);
        }
    }
}
