using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Ejercicio2
    {
        /*Realice un programa que pida al usuario 5 números reales 
         * (pista: necesitarás un array de "float" ) y luego los muestre 
         en el orden contrario al que se introdujeron */
        static void Main(string[] args)
        {

            float[] numeros = new float[5];
            int c = 5;

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Ingrese un numero real: ");
                numeros[i] = float.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            Console.WriteLine("El orden contrario a los numeros ingresados es:");
            while (c > 0)
            {
                c--;
                Console.Write(numeros[c]);
                Console.Write("  ");
            }
            Console.ReadKey();
        }
    }
}
