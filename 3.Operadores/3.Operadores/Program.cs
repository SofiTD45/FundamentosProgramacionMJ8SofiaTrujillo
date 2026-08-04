using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operadores númericos
            //Incremento decremento
            int dato1 = 0;
            dato1++;// dato1=dato1+1;Incremento
            dato1--;// dato1=dato1-1;Decremento
            dato1+=5;//dato1+5; Incremento 5 unidades
            dato1 *= 3;// dato1= dato1x3; incremento 3 veces
            dato1 /= 2;//dato1= dato1/2; se partio en 2
            dato1+=dato1; //dato1 sumado por si mismo

            //orden evaluacion de operadores númericos
            // primero lo va a ejecutar en orden algebraico
            float dato2 = 4 / 3 * 2; 
            float dato3 = 4 * (2 / 3); 
            float dato4 = 4 + 6 * 2; 
            float dato5 = 4 + 6 * (2 - 1);
            float dato6 = dato2 * dato3 - dato4 / dato5;

            //Operadores lógicos
            //Conjuncion - AND - Y -- &&
            Console.WriteLine("----------TABLA DE LA CONJUNCIÓN----------");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (true && false));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("-------------------------------------------");

            //Disyunción - OR - O - ||
            Console.WriteLine("----------TABLA DE LA CONJUNCIÓN----------");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (true || false));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("-------------------------------------------");

            bool dato7 = true;
            bool dato8 = !dato7;
            //OPERADORES DE ASIGNACION
            bool dato9 = 5 > 4;
            bool dato10 = 100 <= 99;
            bool dato11 = 25 == 25;
            bool dato12 = 4 != 4;
            bool dato13 = 5 < 4 && dato7;
            bool dato14 = 0 == 1 || 12 > 3 && dato9;

        }
    }
}
