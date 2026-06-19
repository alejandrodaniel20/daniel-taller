using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //1. Cargar un vector de n elementos.imprimir el menor y un mensaje si se repite dentro
    //del vector.
    class VectorMenor
    {
        private int[] vector;

        public void Cargar()
        {
            Console.Write("Ingrese cantidad de elementos: ");
            int n = int.Parse(Console.ReadLine());

            vector = new int[n];

            for (int f = 0; f < vector.Length; f++)
            {
                Console.Write("Ingrese elemento: ");
                vector[f] = int.Parse(Console.ReadLine());
            }
        }

        public void MenorYRepetido()
        {
            int menor = vector[0];

            for (int f = 1; f < vector.Length; f++)
            {
                if (vector[f] < menor)
                    menor = vector[f];
            }

            Console.WriteLine("Menor elemento: " + menor);

            int cantidad = 0;

            for (int f = 0; f < vector.Length; f++)
            {
                if (vector[f] == menor)
                    cantidad++;
            }

            if (cantidad > 1)
                Console.WriteLine("El menor se repite.");
            else
                Console.WriteLine("El menor no se repite.");
        }

        static void Main(string[] args)
        {
            VectorMenor vm = new VectorMenor();
            vm.Cargar();
            vm.MenorYRepetido();
            Console.ReadKey();
        }
    }
}
