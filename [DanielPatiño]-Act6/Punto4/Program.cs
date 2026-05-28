using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Implementar la clase operaciones.Se deben cargar dos valores enteros,
    //calcular su suma, resta, multiplicación y división, cada una en un método,
    //imprimir dichos resultados.
    internal class Operaciones
    {
        private int valor1, valor2;

        public void cargar()
        {
            string linea;
            Console.Write("Ingrese valor1: ");
            linea = Console.ReadLine();
            valor1 = int.Parse(linea);

            Console.Write("Ingrese valor2: ");
            linea = Console.ReadLine();
            valor2 = int.Parse(linea);

        }
        
        public void suma()
        {
            int suma = valor1 + valor2;
            Console.WriteLine("La suma es: " + suma);

        }
        
        public void resta()
        {
            int resta = valor1 - valor2;
            Console.WriteLine("La resta es:" + resta);

        }

        public void multiplicacion()
        {
            int multiplicacion;
            multiplicacion = valor1 * valor2;
            Console.WriteLine("La multiplicacion es: " + multiplicacion);
        }

        public void division()
        {
            double division = valor1 / valor2;
            Console.WriteLine("La division es: " + division);
        }

        
        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.cargar();
            op.suma();
            op.resta();
            op.division();
            op.multiplicacion();
            Console.ReadKey();
        }
    }
}
