using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Matriz1
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[2, 5];

            for (int c = 0; c < 5; c++)
            {
                for (int f = 0; f < 2; f++)
                {
                    Console.Write("Ingrese componente: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Matriz1 ma = new Matriz1();
            ma.Cargar();
            ma.Imprimir();
        }
    }
}
