using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Ciclos_While___Do_while___For
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sumaCalificaciones = 0;
            int contador = 0;
            int des;
            string continuar;

            List<float> calificaciones= new List<float>();

            while (true)
            {
                Console.WriteLine("ingrese calificacion");
                float calificacion = float.Parse(Console.ReadLine());
                calificaciones.Add(calificacion);
                contador++;

                Console.WriteLine("quiere ingresar otra nota?");
                Console.WriteLine("si");
                Console.WriteLine("no");

                int decision = int.Parse(Console.ReadLine());
                if (decision == 1)

                {
                    continue;
                }
                else if (decision == 2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("ERROR");
                }


            }




        }
    }
}
