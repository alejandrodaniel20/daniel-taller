﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    /*
    2. Confeccionar una clase para administrar una matriz irregular de 5 filas y 1 columna la
    primer fila, 2 columnas la segunda fila y así sucesivamente hasta 5 columnas la última fila
    (crearla sin la intervención del operador)
    Realizar la carga por teclado e imprimir posteriormente.
    */

    internal class MatIrregular
    {
        private int[][] irregular;

        public void MatrizIrregular()
        {
            irregular = new int[6][];

            for(int f = 0; f < irregular.Length; f++)
            {
                irregular[f] = new int[f];
            }
        }

        public void Cargar()
        {
            for(int f = 0; f < irregular.Length; f++)
            {
                for (int c = 0; c < irregular[f].Length; c++)
                {
                    Console.Write("Ingresa los componentes de la matriz: ");
                    irregular[f][c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for(int f = 0; f < irregular.Length; f++)
            {
                for(int c = 0; c < irregular[f].Length; c++)
                {
                    Console.Write(irregular[f][c] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            MatIrregular mi2 = new MatIrregular();
            mi2.MatrizIrregular();
            mi2.Cargar();
            mi2.Imprimir();
            Console.ReadKey();
        }
    }
}