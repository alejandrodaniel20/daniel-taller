using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //3. Cargar un vector de n elementos de tipo entero.Ordenar posteriormente el vector
    //(el orden lo pueden elegir ustedes).
    class VectorOrdenado
    {
        private int[] vector;

        public void Cargar()
        {
            Console.Write("Ingrese cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            vector = new int[n];

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write("Ingrese elemento: ");
                vector[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int k = i + 1; k < vector.Length; k++)
                {
                    if (vector[i] > vector[k])
                    {
                        int aux = vector[i];
                        vector[i] = vector[k];
                        vector[k] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Vector ordenado:");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.WriteLine(vector[i]);
            }
        }

        static void Main(string[] args)
        {
            VectorOrdenado vo = new VectorOrdenado();
            vo.Cargar();
            vo.Ordenar();
            vo.Imprimir();
            Console.ReadKey();
        }
    }
}
