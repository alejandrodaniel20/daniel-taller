using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
            //a) La cantidad de valores ingresados negativos.
            //b) La cantidad de valores ingresados positivos.
            //c) La cantidad de múltiplos de 15.
            //d) El valor acumulado de los números ingresados que son pares.

            int num, suma = 0, nega = 0, posi = 0, m15 = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Ingrese valor: ");
                num = int.Parse(Console.ReadLine());
                if (num >= 0)
                {
                    posi++;
                }
                else
                {
                    nega++;
                }
                if (num % 15 == 0)
                {
                    m15++;
                }
                if (num % 2 == 0)
                {
                    suma = suma + num;
                }
            }
            Console.Write("Los valores negativos son: " + nega + "\n");
            Console.Write("Los valores positivos son: " + posi + "\n");
            Console.Write("La cantidad multiplo de 15 es: " + m15 + "\n");
            Console.Write("La suma de todos los numeros pares es: " + suma);
            Console.ReadKey();


        }
    }
}
