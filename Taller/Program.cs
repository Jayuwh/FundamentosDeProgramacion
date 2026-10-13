using System;

namespace Taller
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Console.WriteLine("numero1");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("numero2");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("numero3");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 != numero2 && numero1 != numero3 && numero2 != numero3)
            {
                Console.WriteLine("se deben ingresar numero diferemtes");
            }

            
                else
            {
                int mayor = 1;
                if (numero2 > mayor) mayor = numero2;
                if (numero3 > mayor) mayor = numero3;

                int menor = numero1;
                if (numero2 < menor) menor = numero2;
                if (numero3 < menor) menor = numero3;

                int medio = (numero1 + numero2 + numero3) - mayor - menor;

                Console.WriteLine($"el numero mayor es: {mayor}");
                Console.WriteLine($"el numero del miedo es: {medio}");
                Console.WriteLine($"el numero menor es: {menor}");
            }







                                                                          
                  
        }


    }

}

           
                            

                        








