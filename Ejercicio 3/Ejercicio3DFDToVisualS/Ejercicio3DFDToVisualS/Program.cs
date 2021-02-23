using System;

namespace Ejercicio3DFDToVisualS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Este es un programa basado en un diagrama de flujo, para obtener promedio de calificaciones.";
            Double i;
            Decimal nota, acumulado=0, promedio;
            string nombre;
            Console.WriteLine("Inserte su nombre, por favor: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvenid@ " + nombre + " en este programa sabra su media y si esta aprobado o no");
            Console.ReadKey();
            Console.WriteLine("A continuación se le pedira que ingrese tres diferentes notas y se le dara un resultado al final");
            for (i=1;i<=3;i=i+1)
            {
                Console.WriteLine("Por favor " + nombre + " inserte la nota numero " + i + " de su lista.");
                nota = Decimal.Parse(Console.ReadLine());
                acumulado = acumulado + nota;
            }
            promedio = acumulado / 3;
            Console.WriteLine("Su nota promedio es de: " + promedio);
            if (promedio == 10)
            {
                Console.WriteLine("Su nota es excelente, FELICIDADES! está más que aprobado!");
            }
            if (7 <= promedio && promedio < 10)
            {
                Console.WriteLine("Se encuentra aprobado. ");
            }
            if (4 <= promedio && promedio < 7)
            {
                Console.WriteLine("Su nota es regular, reprobado");
            }
            if (promedio<4)
            {
                Console.WriteLine("Reprobado.");
            }
                    
                
            
            Console.WriteLine("Muchisimas gracias " + nombre + " por usar nuestra herramienta, feliz día! :D");
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
