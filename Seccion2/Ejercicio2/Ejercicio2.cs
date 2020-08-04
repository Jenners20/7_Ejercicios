using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        /*Realice un programa que pida al usuario 10 números,
         calcule su media y luego muestre los que están por encima 
         de la media. */
         static void media()
        {
            int[] numeros = new int[10];
            double media = 0.0;
            int Total = 0;
            int c = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write(i+1+". Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
                Total = Total + numeros[i];
            }

            media = Total / 10;
            Console.WriteLine("La media es: "+media);
            Console.WriteLine();
            Console.WriteLine("Los numeros mayores a la media son: ");
            for (int i = 0; i < 10; i++)
            {
                if (numeros[i]>media)
                {
                    c++;
                    Console.WriteLine(c+". "+numeros[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            media();
            Console.ReadKey();
        }
    }
}
