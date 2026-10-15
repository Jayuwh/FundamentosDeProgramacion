using System;
using System.Data;

namespace 3_Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //orden de evaluacion operadores numericos
            float dato1 = 4 * 3 / 2;
            float dato2 = 4f / 3 * 2;
            float dato3 = 4f * (2f / 3);
            float dato4 = 4 + 6 * 3;
            float dato5 = 4 + 6 * (2 - 1);
            Console.WriteLine(dato3);

            //OPERADORES LOGICOS
            //conjugacion - AND - Y - &&
            Console.WriteLine("TABLA CONJUGACION");
            Console.WriteLine("V && V = " + (true && true));
            Console.WriteLine("V && F = " + (true && false));
            Console.WriteLine("F && V = " + (false && true));
            Console.WriteLine("F && F = " + (false && false));
            Console.WriteLine("--------------------");

            //Disyuncion - OR - 0 - ||
            Console.WriteLine("TABLA CONJUGACION");
            Console.WriteLine("V || V = " + (true || true));
            Console.WriteLine("V || F = " + (true || false));
            Console.WriteLine("F || V = " + (false || true));
            Console.WriteLine("F || F = " + (false || false));
            Console.WriteLine("--------------------");

            bool dato8 = true;
            bool dato9 = !dato8;

            //OPERADORES DE COMPARACION
            bool dato6 = 5 > 4;
            bool dato7 = 100 == 99;
            bool dato10 = 1002 != 102;
            bool dato11 = 10 > 10;
            bool dato12 = 12 < 11 && 0 == 1;
            bool dato13 = dato8 && 0 != 10 || dato9 && 0 != 1;

        }
    }
}