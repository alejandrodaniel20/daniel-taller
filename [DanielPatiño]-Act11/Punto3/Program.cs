using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Confeccionar una clase para administrar los días que han faltado los 3 empleados de una
    //empresa.
    //Definir un vector de 3 elementos de tipo string para cargar los nombres y una matriz
    //irregular para cargar los días que han faltado cada empleado (cargar el número de día que
    //faltó)
    //Cada fila de la matriz representa los días de cada empleado.
    //a.Mostrar los empleados con la cantidad de inasistencias.
    //b.Cuál empleado faltó menos días.
    internal class FaltasEmpleados
    {
        private string[] empleados;
        private int[][] inasistencias;
        private int longitud = 0;

        public void Cargar()
        {
            empleados = new string[3];
            inasistencias = new int[3][];
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.Write("Ingrese el nombre del " + (f + 1) + "° empleado: ");
                empleados[f] = Console.ReadLine();
                Console.Write("Cuantos dias falto " + empleados[f] + "?: ");
                longitud = int.Parse(Console.ReadLine());
                inasistencias[f] = new int[longitud];

                for (int c = 0; c < inasistencias[f].Length; c++)
                {
                    Console.Write("En que dia fue la " + (c + 1) + "° inasistencia que tuvo " + empleados[f] + ": ");
                    inasistencias[f][c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Imprimir()
        {
            for (int f = 0; f < empleados.Length; f++)
            {
                Console.WriteLine("Cantidad de Inasistencias de " + empleados[f] + ": " + inasistencias[f].Length);
            }
        }

        public void MenosFaltas()
        {
            int menor = inasistencias[0].Length;
            for (int f = 0; f < inasistencias.Length; f++)
            {
                for (int c = 0; c < inasistencias[f].Length; c++)
                {
                    if (menor > inasistencias[f].Length)
                    {
                        menor = inasistencias[f].Length;
                    }
                }
            }

            for (int i = 0; i < empleados.Length; i++)
            {
                if (inasistencias[i].Length == menor)
                {
                    Console.WriteLine("El empleado con menos faltas es " + empleados[i] + " el cual tiene " + menor + " faltas");
                }
            }
        }

        static void Main(string[] args)
        {
            FaltasEmpleados ft2 = new FaltasEmpleados();
            ft2.Cargar();
            ft2.Imprimir();
            ft2.MenosFaltas();
            Console.ReadKey();
        }
    }
}