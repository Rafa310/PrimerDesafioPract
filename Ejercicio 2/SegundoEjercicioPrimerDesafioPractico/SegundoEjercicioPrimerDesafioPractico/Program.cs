using System;

namespace SegundoEjercicioPrimerDesafioPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Programa para sumar 2 numeros y multiplicar 2 numeros";
            Console.WriteLine("A continuación se le pediran 4 valores, el primero y el segundo serán sumados, el tercero y cuarto, multiplicados.");
            Double dato1, dato2, dato3, dato4, suma, multi;
            Console.WriteLine("Ingrese su primer valor numerico: ");
            dato1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor númerico: ");
            dato2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor númerico: ");
            dato3 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el cuarto valor númerico: ");
            dato4 = Double.Parse(Console.ReadLine());
            suma = dato1 + dato2;
            multi = dato3 * dato4;
            Console.WriteLine("La suma de los dos primeros valores es de: " + suma);
            Console.WriteLine("La multiplicación del tercer y cuarto valor es de: " + multi);
            Console.WriteLine("\n");
            Console.WriteLine("\n--->Fin del programa...");
            Console.ReadKey();
        }
    }
}
