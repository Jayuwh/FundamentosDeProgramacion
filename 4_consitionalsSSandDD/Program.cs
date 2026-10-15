using System;

namespace 4_consitionalsSSandDD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTRUCTURAS DE CONTROL CONDICIONAL
            //Condicional simple
            //1.  Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: "Bienvenido a mi sitio web"
            /* byte edad = 0;
             Console.WriteLine("Ingrese su edad:");
             edad = Convert.ToByte(Console.ReadLine());

             if(edad >= 18)
             {
                 //Si la condicion es verdadera
                 Console.WriteLine("Bienvenido a mi sitio web");
             }*/

            //Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando que debe abonar impuestos.
            /*  byte sueldo = 0;
              Console.WriteLine("Ingrese su nombre: ");
              Console.WriteLine("Ingrese su sueldo: ");
              sueldo = Convert.ToByte(Console.ReadLine());

              if (sueldo >= 3000)
              {
                  //Si la condicion es verdadera
                  Console.WriteLine("nombre: abonar impuestos");
              }
  */
            byte edad = 0;
            Console.WriteLine("Ingrese su edad:");
            edad = Convert.ToByte(Console.ReadLine());

            if (edad >= 18)
            {
                //Si la condicion es verdadera
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                //Si la condicion NO se cumple 
                Console.WriteLine("No es apto para el contenido del sitio wed");
            }

        }
    }
}