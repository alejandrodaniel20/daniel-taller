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
            //Realizar un programa que acumule(sume) valores ingresados por teclado hasta
            //ingresar el 9999(no sumar dicho valor, indica que ha finalizado la carga).Imprimir el
            //valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.

            int suma = 0;
            int numero;
           
            do
            {
                Console.Write("Ingrese un valor: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero != 9999)
                    {
                        suma += numero;
                    }
                }

            } while (numero != 9999);

            Console.WriteLine("El valor acumulado total es: " + suma);

            
            if (suma == 0)
            {
                Console.WriteLine("El valor acumulado es cero.");
            }
            else if (suma > 0)
            {
                Console.WriteLine("El valor acumulado es mayor a cero.");
            }
            else
            {
                Console.WriteLine("El valor acumulado es menor a cero.");
            }

            Console.ReadKey();

        }
    }
}
