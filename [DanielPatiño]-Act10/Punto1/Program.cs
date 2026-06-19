using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    //Crear una matriz de 2 filas y 5 columnas.Realizar la carga de
    //componentes por columna(es decir primero ingresar toda la primer
    //columna, luego la segunda columna y así sucesivamente)
    //Imprimir luego la matriz.
    class Matriz
    {
        private int[,] matriz;

        public void Cargar()
        {
            matriz = new int[2, 5];

            for (int i = 0; i < 5; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write("Ingrese componente: ");
                    matriz[k, i] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine();
            for (int k = 0; k < 2; k++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write(matriz[k, i] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Matriz mt = new Matriz();
            mt.Cargar();
            mt.Imprimir();
            Console.ReadKey();
        }
    }
}
