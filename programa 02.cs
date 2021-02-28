using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluacion_1
{
    class Program
    {
        static void Main(string[] args)
        {// programa para controlar la entradas de un parque de diversiones
           
                string cadena = "";
                Double altura = 0.0;
                int edad = 0;

            // pedir edad
            Console.WriteLine("ingrese su edad:");
            cadena = Console.ReadLine();
            edad = Convert.ToInt32(cadena);

            if (edad >= 18);
            {
                Console.WriteLine("usted ha superado el limite de esas, lo sentimos");

            }
            else
            {
                //pedir altura

                Console.WriteLine("Cuanto mide usted?");
                cadena = Console.ReadLine();
                altura = Convert.ToDouble(cadena);

                if (altura < 1.5) ;
                {
                    Console.WriteLine("puede acceder a todas las atracciones hubicadas en el ala este del parque");

                }
                else
                {

                    Console.WriteLine("usted tiene acceso a todo el parque");
                }
                //
            }


            Console.ReadKey();

        }
    }
}

