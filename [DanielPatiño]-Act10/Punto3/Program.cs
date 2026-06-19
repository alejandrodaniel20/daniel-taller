using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Crear una matriz de n * m filas(cargar n y m por teclado) Imprimir los
    //cuatro valores que se encuentran en los vértices de la misma(mat[0][0]
    //etc.)
    class MatrizNfilas
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

            for (int i = 0; i < filas; i++)
            {
                for (int k = 0; k < columnas; k++)
                {
                    Console.Write("Ingrese componente: ");
                    mat[i, k] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Vertices()
        {
            Console.WriteLine();
            Console.WriteLine("Vértice superior izquierdo: " + mat[0, 0]);
            Console.WriteLine("Vértice superior derecho: " + mat[0, columnas - 1]);
            Console.WriteLine("Vértice inferior izquierdo: " + mat[filas - 1, 0]);
            Console.WriteLine("Vértice inferior derecho: " + mat[filas - 1, columnas - 1]);
        }

        static void Main(string[] args)
        {
            MatrizNfilas ma = new MatrizNfilas();
            ma.Cargar();
            ma.Vertices();
            Console.ReadKey();
        }
    }
}