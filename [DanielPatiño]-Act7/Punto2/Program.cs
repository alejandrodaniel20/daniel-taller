using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
    //elementos.Obtener la suma de los dos vectores, dicho resultado guardarlo en un
    //tercer vector del mismo tamaño.Sumar componente a componente.
    internal class VectoresNumericos
    {
        private int[] vector1, vector2, suma ;
       
        public void cargar()
        {
            vector1 = new int[4];
            vector2 = new int[4];
            suma = new int[4];

            Console.WriteLine("Carga del primer vector");

                string linea;
           
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese valor: ");
                linea = Console.ReadLine();
                vector1[i] = int.Parse(linea);
            }

            Console.WriteLine("Carga del segundo vector");

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Ingrese valor: ");
                linea = Console.ReadLine();
                vector2[i] = int.Parse(linea);
            }

        }

        public void sumar()
        {
            for (int i = 0; i < 4; i++)
            {
                suma[i] = vector1[i] + vector2[i];
            }
        }

        public void imprimir()
        {
            Console.WriteLine("suma del vector: ");

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(suma[i]);
            }
        }


        static void Main(string[] args)
        {
            VectoresNumericos vn = new VectoresNumericos();
            vn.cargar();
            vn.sumar();
            vn.imprimir();
            Console.ReadKey();
        }
    }
}
