using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion2
{
    class Ejercicio1
    {
        /* Crear un programa que pida al usuario la fecha, detallando el día (1 al 31) y 
         el mes (1 = enero, 12 = diciembre), luego muestre en pantalla el número 
         de días que quedan hasta final de año. */
        static void Dias()
        {
            int[] DiasMes = new int[12];
            int dia = 0;
            int mes = 0;
            string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre"
            ,"Diciembre"};
            int Dias = 0;
            int DiasRestantes = 0;

            Console.Write("Ingrese el mes: ");
            mes = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Ingrese el dia: ");
            dia = int.Parse(Console.ReadLine());

            if (mes<=12 && mes>0)
            {
                if (dia <= 31 && dia > 0) 
                {
                    for (int i = 1; i < mes; i++)
                    {
                        DiasMes[i] = DateTime.DaysInMonth(2015, i);
                        Dias = Dias + DiasMes[i];
                    }
                    Dias = Dias + dia;
                    Console.WriteLine("El total de dias transcurridos hasta el dia {0} del mes de {1} son:{2}", dia, Meses[mes - 1], Dias);
                    Console.WriteLine();
                    DiasRestantes = 365-Dias ;
                    Console.WriteLine("Por lo que la cantidad de días restante es: " + DiasRestantes);
                }

            }
           
        }
        static void Main(string[] args)
        {
            Dias();
            Console.ReadKey();

        }
    }
}
