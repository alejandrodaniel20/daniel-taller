using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Matriz3
    {
        private int[,] mat;
        private int filas;
        private int columnas;

        public void Cargar()
        {
            Console.Write("Ingrese cantidad de filas: ");
            filas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cantidad de columnas: ");
            columnas = int.Parse(Console.ReadLine());

            mat = new int[filas, columnas];

            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write("Ingrese componente: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Vertices()
        {
            Console.WriteLine("Vértice superior izquierdo: " + mat[0, 0]);
            Console.WriteLine("Vértice superior derecho: " + mat[0, columnas - 1]);
            Console.WriteLine("Vértice inferior izquierdo: " + mat[filas - 1, 0]);
            Console.WriteLine("Vértice inferior derecho: " + mat[filas - 1, columnas - 1]);
        }

        static void Main(string[] args)
        {
            Matriz3 ma = new Matriz3();
            ma.Cargar();
            ma.Vertices();
        }
    }
}
