using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Crear una matriz de n * m filas(cargar n y m por teclado) Intercambiar la
    //primer fila con la segunda.Imprimir luego la matriz.
    class MatrideNfilas
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

        public void Intercambiarfilas()
        {
            for (int k = 0; k < columnas; k++)
            {
                int aux = mat[0, k];
                mat[0, k] = mat[1, k];
                mat[1, k] = aux;
            }
        }

        public void Imprimir()
        {
            Console.ReadLine();
            for (int i = 0; i < filas; i++)
            {
                for (int k = 0; k < columnas; k++)
                {
                    Console.Write(mat[i, k] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MatrideNfilas mn = new MatrideNfilas();
            mn.Cargar();
            mn.Intercambiarfilas();
            mn.Imprimir();
            Console.ReadKey();
        }
    }
}
