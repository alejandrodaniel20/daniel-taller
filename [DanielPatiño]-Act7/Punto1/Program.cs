using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
    //El valor acumulado de todos los elementos del vector.
    //El valor acumulado de los elementos del vector que sean mayores a 36.
    //Cantidad de valores mayores a 50.

    internal class Vectores
    {
        private int[] vector;

        public void cargar()
        {
            vector = new int[8];
                string linea;
            for (int i = 0; i < 8; i++)
            {
                
                Console.Write("Ingrese el valor del vector: ");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);

            }
       
        }

        public void Condicion()
        {
            int sumaTotal = 0;
            int sumaMayores36 = 0;
            int cantidadMayores50 = 0;

            for (int i = 0; i < 8; i++)
            {
                sumaTotal += vector[i];

                if (vector[i] > 36)
                {
                    sumaMayores36 += vector[i];
                }

                if (vector[i] > 50)
                {
                    cantidadMayores50++;
                }
            }

            Console.WriteLine("Suma total: " + sumaTotal);
            Console.WriteLine("Suma mayores a 36: " + sumaMayores36);
            Console.WriteLine("Cantidad mayores a 50: " + cantidadMayores50);
        }

        static void Main(string[] args)
        {
            Vectores vt = new Vectores();
            vt.cargar();
            vt.Condicion();
            Console.ReadKey();
        }
    }
}
