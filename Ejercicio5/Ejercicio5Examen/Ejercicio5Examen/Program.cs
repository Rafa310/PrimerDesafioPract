using System;

namespace Ejercicio5Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Programa para calcular salarios.";
            Double i, horas, cuenta=0;
            string nombre, apellido, cargo, cargo1=null, cargo2=null, cargo3=null ;
            string nom1 = null, nom2 = null, nom3 = null;

            for (i = 1; i <= 3; i = i + 1)
            {

                Console.WriteLine("Por favor empleado número " + i + " inserte su nombre: ");
                nombre = Console.ReadLine();
                if (i == 1)
                {
                    nom1 = nombre;

                }
                if (i == 2)
                {
                    nom2 = nombre;
                }
                if (i == 3)
                {
                    nom3 = nombre;
                }
                Console.WriteLine("Muchas gracias " + nombre + " por favor escriba su apellido ahora.");
                apellido = Console.ReadLine();
                Console.WriteLine("Por favor sr/sra " + apellido + " diganos, cual es su cargo en la empresa?");
                Console.WriteLine("El cargo debe iniciar con mayúscula.");
                cargo = Console.ReadLine();
                if (i == 1)
                {
                    cargo1 = cargo;

                }
                if (i == 2)
                {
                    cargo2 = cargo;
                }
                if (i == 3)
                {
                    cargo3 = cargo;
                }
                Console.WriteLine("Muchsimas gracias sr/sra " + apellido);
                Console.WriteLine("como ultima solicitud, podría decirnos cuantas horas trabaja mensualmente ? ");
                horas = Double.Parse(Console.ReadLine());
                Double pago = 9.75, bon, pagonodesc, ISSS, AFP, Renta, pagoreal = 0, sal1 = 0, sal2 = 0, sal3 = 0;


                if (horas == 0 || horas < 0)
                {
                    Console.WriteLine("Horas introducidas inválidas.");
                    Console.ReadKey();
                    Console.WriteLine("Introduzca nuevamente los datos.");
                    Console.ReadKey();
                    i = i - 1;
                }
                if (cargo == "Gerente")
                {
                    Console.WriteLine("Muchisimas gracias por la información sr/sr " + apellido);
                    Console.WriteLine("El cálculo de su salario se hará de la siguiente manera: ");
                    Console.ReadKey();
                    Console.WriteLine("Al ser usted " + cargo + " tendrá un bono del 10%");
                    Console.WriteLine("y se le pagará $9.75 la hora por las primeras 160 horas y $11.50 cada hora extra.");
                    Console.WriteLine("Luego de esto se le harán los descuentos por Ley");
                    if (horas <= 160)
                    {
                        pago = 9.75 * horas;
                    }
                    if (horas > 160)
                    {
                        pago = 160 * 9.75 + (horas - 160) * 11.50;
                    }

                    Console.WriteLine("El salario a pagarle a usted es de " + pago + " dolares, sin bono.");
                    Console.ReadKey();
                    bon = pago * 0.1;
                    pagonodesc = bon + pago;
                    Console.WriteLine("La cantidad a pagarle con bono es de un total de " + pagonodesc + " dolares sin descuentos.");
                    ISSS = pago * 0.0525;
                    AFP = pago * 0.0688;
                    Renta = pago * 0.1;
                    pagoreal = pago - ISSS - AFP - Renta + bon;
                    Console.WriteLine("Estimado Sr/Sra " + apellido + " los descuentos a aplicarsele son: ");
                    Console.WriteLine("Del ISSS son: $" + ISSS);
                    Console.WriteLine("De la AFP son: $" + AFP);
                    Console.WriteLine("De la Renta son: $" + Renta);
                    Console.WriteLine("Por ende su pago final es de: $" + pagoreal);
                    Console.WriteLine("Muchisimas gracias por usar nuestra calculadora.");
                }
                if (cargo == "Asistente")
                {
                    Console.WriteLine("Muchisimas gracias por la información sr/sr " + apellido);
                    Console.WriteLine("El cálculo de su salario se hará de la siguiente manera: ");
                    Console.ReadKey();
                    Console.WriteLine("Al ser usted " + cargo + " tendrá un bono del 5%");
                    Console.WriteLine("y se le pagará $9.75 la hora por las primeras 160 horas y $11.50 cada hora extra.");
                    Console.WriteLine("Luego de esto se le harán los descuentos por Ley");
                    if (horas <= 160)
                    {
                        pago = 9.75 * horas;
                    }
                    if (horas > 160)
                    {
                        pago = 160 * 9.75 + (horas - 160) * 11.50;
                    }
                    Console.WriteLine("El salario a pagarle a usted es de " + pago + " dolares, sin bono.");
                    Console.ReadKey();
                    bon = pago * 0.05;
                    pagonodesc = bon + pago;
                    Console.WriteLine("La cantidad a pagarle con bono es de un total de " + pagonodesc + " dolares sin descuentos.");
                    ISSS = pago * 0.0525;
                    AFP = pago * 0.0688;
                    Renta = pago * 0.1;
                    pagoreal = pago - ISSS - AFP - Renta + bon;
                    Console.WriteLine("Estimado Sr/Sra " + apellido + " los descuentos a aplicarsele son: ");
                    Console.WriteLine("Del ISSS son: $" + ISSS);
                    Console.WriteLine("De la AFP son: $" + AFP);
                    Console.WriteLine("De la Renta son: $" + Renta);
                    Console.WriteLine("Por ende su pago final es de: $" + pagoreal);
                    Console.WriteLine("Muchisimas gracias por usar nuestra calculadora.");
                }
                if (cargo == "Secretaria")
                {
                    Console.WriteLine("Muchisimas gracias por la información sr/sr " + apellido);
                    Console.WriteLine("El cálculo de su salario se hará de la siguiente manera: ");
                    Console.ReadKey();
                    Console.WriteLine("Al ser usted " + cargo + " tendrá un bono del 3%");
                    Console.WriteLine("y se le pagará $9.75 la hora por las primeras 160 horas y $11.50 cada hora extra.");
                    Console.WriteLine("Luego de esto se le harán los descuentos por Ley");
                    if (horas <= 160)
                    {
                        pago = 9.75 * horas;
                    }
                    if (horas > 160)
                    {
                        pago = 160 * 9.75 + (horas - 160) * 11.50;
                    }
                    Console.WriteLine("El salario a pagarle a usted es de " + pago + " dolares, sin bono.");
                    Console.ReadKey();
                    bon = pago * 0.03;
                    pagonodesc = bon + pago;
                    Console.WriteLine("La cantidad a pagarle con bono es de un total de " + pagonodesc + " dolares sin descuentos.");
                    ISSS = pago * 0.0525;
                    AFP = pago * 0.0688;
                    Renta = pago * 0.1;
                    pagoreal = pago - ISSS - AFP - Renta + bon;
                    Console.WriteLine("Estimado Sr/Sra " + apellido + " los descuentos a aplicarsele son: ");
                    Console.WriteLine("Del ISSS son: $" + ISSS);
                    Console.WriteLine("De la AFP son: $" + AFP);
                    Console.WriteLine("De la Renta son: $" + Renta);
                    Console.WriteLine("Por ende su pago final es de: $" + pagoreal);
                    Console.WriteLine("Muchisimas gracias por usar nuestra calculadora.");
                }
                if (cargo != "Secretaria" && cargo != "Gerente" && cargo != "Asistente")
                {
                    Console.WriteLine("Muchisimas gracias por la información sr/sr " + apellido);
                    Console.WriteLine("El cálculo de su salario se hará de la siguiente manera: ");
                    Console.ReadKey();
                    Console.WriteLine("Al ser usted " + cargo + " tendrá un bono del 2%");
                    Console.WriteLine("y se le pagará $9.75 la hora por las primeras 160 horas y $11.50 cada hora extra.");
                    Console.WriteLine("Luego de esto se le harán los descuentos por Ley");
                    if (horas <= 160)
                    {
                        pago = 9.75 * horas;
                    }
                    if (horas > 160)
                    {
                        pago = 160 * 9.75 + (horas - 160) * 11.50;
                    }
                    Console.WriteLine("El salario a pagarle a usted es de " + pago + " dolares, sin bono.");
                    Console.ReadKey();
                    bon = pago * 0.02;
                    pagonodesc = bon + pago;
                    Console.WriteLine("La cantidad a pagarle con bono es de un total de " + pagonodesc + " dolares sin descuentos.");
                    ISSS = pago * 0.0525;
                    AFP = pago * 0.0688;
                    Renta = pago * 0.1;
                    pagoreal = pago - ISSS - AFP - Renta + bon;
                    Console.WriteLine("Estimado Sr/Sra " + apellido + " los descuentos a aplicarsele son: ");
                    Console.WriteLine("Del ISSS son: $" + ISSS);
                    Console.WriteLine("De la AFP son: $" + AFP);
                    Console.WriteLine("De la Renta son: $" + Renta);
                    Console.WriteLine("Por ende su pago final es de: $" + pagoreal);
                    Console.WriteLine("Muchisimas gracias por usar nuestra calculadora.");
                }
                if (i == 1)
                {
                    sal1 = pagoreal;

                }
                if (i == 2)
                {
                    sal2 = pagoreal;
                }
                if (i == 3)
                {
                    sal3 = pagoreal;
                }

                if ((cargo1 == "Gerente") && (cargo2 == "Asistente") && (cargo3 == "Secretaria"))
                {
                    Console.Clear();
                    Console.WriteLine("NO HAY BONO");
                    break;
                }
                


                Console.ReadKey();
                Console.Clear();
                if (i == 3)
                {
                    if (sal1 > sal2 && sal1 > sal3)
                    {
                        Console.WriteLine("El trabajador que más gana es " + nom1);
                    }
                    if (sal2 > sal1 && sal2 > sal3)
                    {
                        Console.WriteLine("El trabajador que más gana es " + nom2);
                    }
                    if (sal3 > sal1 && sal3 > sal2)
                    {
                        Console.WriteLine("El trabajador que más gana es " + nom3);
                    }
                }
                Console.WriteLine("\n");
                if (i == 3)
                {
                    if (sal1 > 300)
                    {
                        cuenta = cuenta + 1;

                    }
                    if (sal2 > 300)
                    {
                        cuenta = cuenta + 1;
                    }
                    if (sal3 > 300)
                    {
                        cuenta = cuenta + 1;
                    }
                    Console.WriteLine(cuenta + " de los 3 trabajadores ganan más de $300.");
                }
            }
            
           

            Console.ReadKey();



        }
    }
}
