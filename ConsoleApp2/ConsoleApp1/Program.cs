using System;

int menu = 0;
bool Val = false;

while (true)
{
    while (true)
    {
        Console.WriteLine("\n|---------| MENU |---------|\n1. Suma\n2. Resta\n3. Multiplicacion\n4. Division\n5. Salir");
        Console.Write("Seleccione una opción: ");
        string Input = Console.ReadLine();

        Val = int.TryParse(Input, out menu);
        if (Val && menu >= 1 && menu <= 5)
        {
            break;
        }
        Console.WriteLine("ERROR, VALOR INVALIDO. Intente de nuevo.");
    }
    if (menu == 5)
    {
        Console.WriteLine("Saliendo del programa...");
        break;
    }
    double num1 = 0, num2 = 0;
    Console.Write("Ingrese el primer número: ");
    double.TryParse(Console.ReadLine(), out num1);
    Console.Write("Ingrese el segundo número: ");
    double.TryParse(Console.ReadLine(), out num2);
    switch (menu)
    {
        case 1:
            Console.WriteLine($"Resultado de la Suma: {num1 + num2}");
            break;

        case 2:
            Console.WriteLine($"Resultado de la Resta: {num1 - num2}");
            break;

        case 3:
            Console.WriteLine($"Resultado de la Multiplicación: {num1 * num2}");
            break;
        case 4:
            if (num2 != 0)
            {
                Console.WriteLine($"Resultado de la División: {num1 / num2}");
            }
            else
            {
                Console.WriteLine("ERROR: No se puede dividir entre cero.");
            }
            break;
    }
}
