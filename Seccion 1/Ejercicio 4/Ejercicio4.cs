using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_4
{
    class Ejercicio4
    {
        /*Realice un programa que almacene en una tabla el número 
         de días que tiene cada mes (supondremos que es un año no bisiesto),
         pida al usuario que le indique un mes (1=enero, 12= diciembre)
         y muestre en pantalla el número de días que tiene ese mes */

        static void DiasDelMes()
        {
            int mes = 0;
            string[] meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Octubre", "Noviembre", "Diciembre" };
            int Dias = 0;

            Console.Write("Ingrese el mes que desea validar los dias: ");
            mes = int.Parse(Console.ReadLine());

            if (mes >= 1 && mes <= 12)
            {
                Dias = DateTime.DaysInMonth(2015, mes);
                Console.WriteLine("En el mes de {0} hay {1} dias ", meses[mes - 1], Dias);
            }
            else
            {
                Console.WriteLine("Mes ingresado incorrectamente ");
                Console.WriteLine("Espere 2 segundos para volver a ingresar el mes ");
                TimeSpan dormida = new TimeSpan(0, 0, 2);
                Thread.Sleep(dormida);
                Console.Clear();
                DiasDelMes();

            }

        }
        static void Main(string[] args)
        {
            DiasDelMes();
            Console.ReadKey();
        }
    }
}
