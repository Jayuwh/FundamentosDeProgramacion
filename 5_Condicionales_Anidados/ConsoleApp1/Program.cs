using System;


namespace 5_Condicionales_Anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Condicionales Anidados
            //

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            Console.WriteLine("se deben ingresar tres valores diferentes");
            Console.WriteLine("ingrese el valor del numero 1");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 2");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el valor del numero 3");
            num3 = int.Parse(Console.ReadLine());

            if (num2 > num3)
            {
                Console.WriteLine("el numero 2 es el mayor");
            }
            else
            {
                Console.WriteLine("el numero 3 es el mayor");
            }

            if (num1 > num3)
            {
                Console.WriteLine("el numero 2 es el mayor");
            }
            else
            {
                Console.WriteLine("el numero 3 es el mayor");
            }

        }
    }
}
