using System;
using System.Diagnostics.Eventing.Reader;


namespace Examen3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int VentasPorMes;
            int TotalVentas = 0;
            int mesMayor = 0;
            int VentaMayor = 0;
            int MesMenor = 0;
            int VentaMenor = 0;
            double promedio;

            for (int mes = 1; mes <= 12; mes++)
            {
                Console.WriteLine("Ingrese las ventas del mes" + mes + " : ");
                VentasPorMes = int.Parse(Console.ReadLine());


                TotalVentas = TotalVentas + VentasPorMes;

                if (mes == 1)

                {
                    mesMayor = mes;
                    VentaMayor = VentasPorMes;
                    MesMenor = mes;
                    VentaMenor = VentasPorMes;
                }

                else
                {
                    if (VentasPorMes > VentaMayor)
                    {

                        VentaMayor = VentasPorMes;
                        mesMayor = mes;

                    }

                    if (VentasPorMes < VentaMenor)
                    {
                        VentaMenor = VentasPorMes;
                        MesMenor = mes;

                    }

                }

            }
                    promedio = TotalVentas / 12.0;

                    string mensaje;
                    if (promedio > 500)

                    {
                        mensaje = "se aprobo la meta";
                    }
                    
                    else
                    {

                        mensaje = "la meta de ventas no se cumplio";

                    }

                    Console.WriteLine("rporte final");
                    Console.WriteLine("promedio anual: " + promedio);
                    Console.WriteLine("Mes con mayor venta" + mesMayor + "con " + VentaMayor+ "ventas");
                    Console.WriteLine("mes con menor venta" + MesMenor + "con" + VentaMenor + "ventas");
                    Console.WriteLine(mensaje);
                    Console.ReadLine();

                }
            }
        }
    
