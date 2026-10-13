using System;
using System.Globalization;


namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.Write("nombre:");
            string nombre = Console.ReadLine();

            Console.Write("años trabajados:");
            int añosTrabajados = int.Parse(Console.ReadLine());

            Console.Write("sueldo base: ");
            double SueldoBase = double.Parse(Console.ReadLine());

            Console.Write("Ingrese calificacion del año actual:");
            double AñoActual = double.Parse(Console.ReadLine());

            Console.Write("Ingrese calificacion del año anterior:");
            double AñoAnterior = double.Parse(Console.ReadLine());


            bool esvalido(double c)
            {
                return c == 0.0 || c == 0.4 || c == 0.6 || c == 1.0;
            }

            if (!esvalido(AñoActual) || !esvalido(AñoAnterior))
            {
                Console.WriteLine("\n[ERROR]: Calificacion invalida. El programa terminara.");
                return;
            }


            double promedio = (AñoActual + AñoAnterior) / 2;
            double porcentaje;

            if (añosTrabajados == 0)
            {
                porcentaje = 0;
            }
            else if (añosTrabajados > 5)
            {
                porcentaje = 30;
            }
            else
            {
                if (promedio < 0.4)
                    porcentaje = 5;
                else if (promedio < 0.6)
                    porcentaje = 10;
                else
                    porcentaje = 20;
            }

            double ValorAumento = SueldoBase * (porcentaje / 100);
            double SueldoTotal = SueldoBase + ValorAumento;


            // 5. Impresión estética de los resultados
            Console.WriteLine("\n");
            Console.WriteLine($"Empleado: {nombre}");
            Console.WriteLine($"Promedio de calificacion: {promedio:F1}");
            Console.WriteLine($"Porcentaje de aumento: {porcentaje}%");
            Console.WriteLine($"Valor del aumento: ${ValorAumento:N0}");
            Console.WriteLine($"Sueldo Total: ${SueldoTotal:N0}");

        }
    }
}
