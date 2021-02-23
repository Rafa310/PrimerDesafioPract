using System;

namespace Ejercicio1PrimerDesafíoPractico
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            string nombre;
            Console.Title = "Programa para calcular la cantidad a pagar";
            Console.WriteLine("Inserte su nombre por favor.");
            nombre=Console.ReadLine();
            Console.WriteLine("Bienvenid@ " + nombre + " a la aplicación para saber el costo total de su compra.");
            Console.WriteLine("\n");
            Console.WriteLine("A continuación le pediremos que nos indique los precios de un máximo de 100 articulos diferentes.");
            Console.WriteLine("igualmente le pediremos que ingrese la cantidad del articulo en especifico que lleva.");
            Console.WriteLine("Si usted posee menos de 100 articulos por favor digite 0 al llegar al ultimo articulo, ingrese todos los valores en enteros, por favor");
            Console.WriteLine("\n");
            Double i, art, cant, total, decisión, totalabs=0;
            for (i=1;i<=100;i=i+1)
            {
                Console.WriteLine("Por favor ingrese el costo del articulo número " + i);
                art=Double.Parse(Console.ReadLine());
                Console.WriteLine("Muchas gracias, ahora diganos cuantos de esos articulos lleva por favor.");
                cant = Double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                total = art * cant;
                Console.WriteLine("Por el articulo número " + i + " usted deberá pagar " + total +" dolares");
                totalabs = totalabs + total;
                Console.WriteLine("El total en este momento es de: "+ totalabs);
                Console.WriteLine("Quisiera agregar otro articulo? (Sí=Digite 1//No=Cualquier numero)");
                decisión = Double.Parse(Console.ReadLine());
                if (decisión!=1)
                {
                    Console.WriteLine("Muchisimas gracias por utilizar la aplicación, feliz día.");
                    break;
                }
            }
            Console.WriteLine("--->Fin del programa...");
            Console.ReadKey();
          
        }
    }
}
