using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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


            int numeros, Cont_numeros;
            String Linea;
            Cont_numeros = 0;

            do
            {

                Console.Write("ingrese datos: ");
                Linea = Console.ReadLine();
                numeros = int.Parse(Linea);

                if (numeros == 9999)
                {

                }
                else { Cont_numeros++; }


            } while (numeros != 9999);

            Console.WriteLine("Se ingresaron la cantidad de: " + Cont_numeros + " numeros");

            Console.ReadKey();

        }
    }
}