using System;

namespace Ejercicio4ElMayorde_3Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A continuación le pediremos ingresar 3 numeros diferentes y le señalaremos el mayor.");
            Double num1, num2, num3;
            Console.Write("Inserte el primer número: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.Write("Inserte el segundo número: ");
            num2 = Double.Parse(Console.ReadLine());
            Console.Write("Inserte el tercer número: ");
            num3 = Double.Parse(Console.ReadLine());
            Console.ReadKey();
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("El mayor número de los 3 es el " + num1);
            }    
                
            if (num2>num1 && num2>num3)
            {
                Console.WriteLine("El mayor número de los 3 es el " + num2);

            }
                
            if (num3>num1 && num3>num2)
            {
                Console.WriteLine("El mayor número de los 3 es el " + num3);
            }
            if (num1==num2 || num1==num3 || num2==num3)
            {
                Console.WriteLine("No se aceptan dos o más números iguales.");
            }

        }
    }
}
