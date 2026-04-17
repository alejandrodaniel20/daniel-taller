using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6. Escribir un programa que lea el peso (en kilogramos) y la altura (en metros) de una persona, y mostrar por pantalla su índice de masa corporal (IMC) (El IMC se calcula dividiendo el peso entre el cuadrado de la altura).
            double peso, altura, IMC;
            string linea;
            Console.Write("Escriba su peso: ");
            linea = Console.ReadLine();
            peso = double.Parse(linea);
            Console.Write("Escriba su altura: ");
            linea = Console.ReadLine();
            altura = double.Parse(linea);

            IMC = peso / (altura * altura);
            Console.Write("El IMC es de: ");
            Console.WriteLine(IMC);
            Console.ReadKey();
        }
    }
}
