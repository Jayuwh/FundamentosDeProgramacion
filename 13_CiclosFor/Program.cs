using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CicloForLH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            for (int contador = 1; contador <= 5; contador++)
            {
                acumulador += contador;
            }
            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");
        }
    }
}
