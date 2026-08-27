using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    /*2. Implementar la clase operaciones.Se deben cargar dos valores enteros en el
constructor, calcular su suma, resta, multiplicación y división, cada una en un
método, imprimir dichos resultados*/
    internal class Operaciones
    {
        private int entero1, entero2;
        private float resultado;
        public Operaciones()
        {
            string linea;
            Console.WriteLine("escribe el primer entero");
            linea = Console.ReadLine();
            entero1 = int.Parse(linea);
            Console.WriteLine("escribe ahora el segundo entero");
            linea = Console.ReadLine();
            entero2 = int.Parse(linea);
        }

        public void suma()
        {
            resultado = entero1 + entero2;
            Console.WriteLine("su suma es: " + resultado);
        }
        public void multiplicar()
        {
            resultado = entero1 * entero2;
            Console.WriteLine("su producto es: " + resultado);
        }
        public void resta()
        {
            resultado = entero1 - entero2;
            Console.WriteLine("la diferencia entre el primer numero y el segundo es: " + resultado);
        }
        public void dividir()
        {
            resultado = (float)entero1 / (float)entero2;
            Console.WriteLine("el cociente entre el primer numero y el segundo es de: " + resultado);
        }

        static void Main(string[] args)
        {
            Operaciones op = new Operaciones();
            op.suma();
            op.multiplicar();
            op.resta();
            op.dividir();
            Console.ReadKey();
        }
    }
}
