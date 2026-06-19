using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Una empresa registra los nombres de sus 5 vendedores y el total de ventas
    //realizadas por cada uno en un mes.Cargar los nombres y ventas en dos
    //vectores paralelos, ordenar los datos de mayor a menor según las ventas,
    //imprimir la lista ordenada con nombre y monto de la venta, e informar quien fue
    //el que menos vendió de los 5 empleados.
    class Vendedores
    {
        private string[] nombres;
        private double[] ventas;

        public void Cargar()
        {
            nombres = new string[5];
            ventas = new double[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese venta: ");
                ventas[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < ventas.Length - 1; i++)
            {
                for (int k = i + 1; k < ventas.Length; k++)
                {
                    if (ventas[i] < ventas[k])
                    {
                        double auxVenta = ventas[i];
                        ventas[i] = ventas[k];
                        ventas[k] = auxVenta;

                        string auxNom = nombres[i];
                        nombres[i] = nombres[k];
                        nombres[k] = auxNom;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Lista ordenada:");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " = " + ventas[i]);
            }

            Console.WriteLine("Menor vendedor: " + nombres[nombres.Length - 1]);
        }

        static void Main(string[] args)
        {
            Vendedores vd = new Vendedores();
            vd.Cargar();
            vd.Ordenar();
            vd.Imprimir();
            Console.ReadKey();
        }
    }
}
