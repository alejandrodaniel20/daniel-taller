using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    class Vendedores
    {
        private string[] nombres;
        private double[] ventas;

        public void Cargar()
        {
            nombres = new string[5];
            ventas = new double[5];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[f] = Console.ReadLine();

                Console.Write("Ingrese venta: ");
                ventas[f] = double.Parse(Console.ReadLine());
            }
        }

        public void Ordenar()
        {
            for (int f = 0; f < ventas.Length - 1; f++)
            {
                for (int k = f + 1; k < ventas.Length; k++)
                {
                    if (ventas[f] < ventas[k])
                    {
                        double auxVenta = ventas[f];
                        ventas[f] = ventas[k];
                        ventas[k] = auxVenta;

                        string auxNom = nombres[f];
                        nombres[f] = nombres[k];
                        nombres[k] = auxNom;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Lista ordenada:");

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.WriteLine(nombres[f] + " - " + ventas[f]);
            }

            Console.WriteLine("Menor vendedor: " +
                              nombres[nombres.Length - 1]);
        }

        static void Main(string[] args)
        {
            Vendedores v = new Vendedores();
            v.Cargar();
            v.Ordenar();
            v.Imprimir();
        }
    }
}
