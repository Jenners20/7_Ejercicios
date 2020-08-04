using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Ejercicio5
    {
        /*Realice un programa que almacene en una tabla
         el número de días que tiene cada mes (de un año bisiesto),
         pida al usuario que le indique un mes (ej. 2 para febrero) 
         y un día (ej. el día 15) y diga qué número de día es dentro 
         del año (por ejemplo, el 15 de febrero sería el día 
         número 46, el 31 de diciembre sería el día 365). */
        static void DiasDelMes()
        {
            int[] Dias = new int[12];
            int mes = 0;
            int dia = 0;
            int TotalDias = 0;
            string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };


            Console.Write("Ingrese el mes:");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Ingrese el día: ");
            dia = int.Parse(Console.ReadLine());

            for (int i = 1; i < mes; i++)
            {
                Dias[i] = DateTime.DaysInMonth(2015, i);
                TotalDias = TotalDias + Dias[i];
            }

            TotalDias = TotalDias + dia;
            Console.WriteLine();
            Console.WriteLine("El {0} de {1} sería el día numero {2} del año",dia,Meses[mes-1],TotalDias);
        }
        static void Main(string[] args)
        {
            DiasDelMes();
            Console.ReadKey();
        }
    }
}
