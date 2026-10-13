using System;
using System.Collections.Generic;

float N1 = 0, N2 = 0, N3 = 0, Prom;
bool Val = false;
string input = "0";
int Opcion = 0;

List<float> Hist = new List<float>();

while (true)
{
    while (true)
    {
        Console.WriteLine("Ingrese la primera nota (0 a 10):");
        input = Console.ReadLine();
        Val = float.TryParse(input, out N1);
        if (Val && N1 >= 0 && N1 <= 10) { break; }
        Console.WriteLine("ERROR: Ingrese un número válido entre 0 y 10.\n");
    }
    while (true)
    {
        Console.WriteLine("Ingrese la segunda nota (0 a 10):");
        input = Console.ReadLine();
        Val = float.TryParse(input, out N2);
        if (Val && N2 >= 0 && N2 <= 10) { break; }
        Console.WriteLine("ERROR: Ingrese un número válido entre 0 y 10.\n");
    }
    while (true)
    {
        Console.WriteLine("Ingrese la tercera nota (0 a 10):");
        input = Console.ReadLine();
        Val = float.TryParse(input, out N3);
        if (Val && N3 >= 0 && N3 <= 10) { break; }
        Console.WriteLine("ERROR: Ingrese un número válido entre 0 y 10.\n");
    }
    Prom = (N1 + N2 + N3) / 3;
    Hist.Add(Prom);
    Console.WriteLine("\n-----------------------------------------");
    if (Prom <= 10 && Prom >= 9.5) { Console.WriteLine($"Valor del promedio {Prom:F2}, perfecto"); }
    else if (Prom >= 8.5 && Prom < 9.5) { Console.WriteLine($"Valor del promedio {Prom:F2}, muy bien"); }
    else if (Prom >= 7.5 && Prom < 8.5) { Console.WriteLine($"Valor del promedio {Prom:F2}, bien"); }
    else { Console.WriteLine($"Valor del promedio {Prom:F2}, reprobado"); }
    Console.WriteLine("-----------------------------------------\n");
    while (true)
    {
        Console.WriteLine("1. Ver historial de promedios \n2. Registrar otras notas \n3. Salir");
        input = Console.ReadLine();
        Val = int.TryParse(input, out Opcion);
        if (Val && Opcion >= 1 && Opcion <= 3) { break; }
        Console.WriteLine("ERROR: Opción inválida. Intente de nuevo.\n");
    }
    if (Opcion == 1)
    {
        Console.WriteLine("\n--- Historial de Promedios ---");
        foreach (float p in Hist)
        {
            Console.WriteLine($"Promedio registrado: {p:F2}");
        }
        Console.WriteLine("------------------------------\n");
    }
    else if (Opcion == 3)
    {
        break;
    }
}
