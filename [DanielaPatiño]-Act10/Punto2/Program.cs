using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Matriz2
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

        public void Intercambiar()
        {
            for (int c = 0; c < columnas; c++)
            {
                int aux = mat[0, c];
                mat[0, c] = mat[1, c];
                mat[1, c] = aux;
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < filas; f++)
            {
                for (int c = 0; c < columnas; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Matriz2 ma = new Matriz2();
            ma.Cargar();
            ma.Intercambiar();
            ma.Imprimir();
        }
    }
}
