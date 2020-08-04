using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Ejercicio3
    {
        /* Realice un programa que almacene los dias 
         de la semana en un array y luego mostrarlo */
        static void Main(string[] args)
        {
            string[] Dias = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

            Console.WriteLine("Los dias de la semana son: ");
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(i + 1 + ". " + Dias[i]);
            }
            Console.ReadKey();
        }
    }
}
