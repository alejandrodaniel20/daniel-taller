using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3. Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio.
            double num1, num2, num3, num4, suma, promedio;
            string linea;
            Console.Write("Ingrese el numero 1: ");
            linea = Console.ReadLine();
            num1 = double.Parse(linea);
            Console.Write("Ingrese el numero 2: ");
            linea = Console.ReadLine();
            num2 = double.Parse(linea);
            Console.Write("Ingrese el numero 3: ");
            linea = Console.ReadLine();
            num3 = double.Parse(linea);
            Console.Write("Ingrese el numero 4: ");
            linea = Console.ReadLine();
            num4 = double.Parse(linea);

            suma = num1 + num2 + num3 + num4;
            promedio = suma / 4;
            Console.Write("La suma es: ");
            Console.WriteLine(suma);
            Console.Write("El promedio es: ");
            Console.WriteLine(promedio);
            Console.ReadKey();
        }
    }
}
