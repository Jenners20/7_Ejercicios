using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seccion_1
{
    class Ejercicio1
    {
        /*Realice un programa que pida al usuario 4 números, los memorice 
         (utilizando una tabla), calcule su media aritméticay después 
         muestre en pantalla la medida y los datos tecleados. */
        static void Main(string[] args)
        {
            int[] numeros = new int[4];
            double media = 0;

            for (int i = 0; i <= 3; i++)
            {
                Console.Write("Ingrese un numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            for (int i = 0; i <= 3; i++)
            {
                media = media + numeros[i];
            }
            media = media / 4;

            Console.WriteLine("La media aritmetica es: " + media);
            Console.WriteLine();
            Console.WriteLine("Los datos ingresados son: ");
            Console.WriteLine();
            for (int i = 0; i <= 3; i++)
            {
                Console.Write(numeros[i]);
                Console.Write("  ");
            }

            Console.ReadKey();
        }
    }
}
