using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente. Mostrar lo que debe abonar el comprador.
            double precio, cantidad, resultado;
            string linea;
            Console.Write("Ingrese el precio: ");
            linea = Console.ReadLine();
            precio = double.Parse(linea);
            Console.Write("Ingrese la cantidad: ");
            linea = Console.ReadLine();
            cantidad = double.Parse(linea);

            resultado = precio * cantidad;
            Console.Write("tenes que pagar: ");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
    }
}
