using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class Empleado
    {
        /*1. Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. En el constructor cargar los atributos y luego en otro
método imprimir sus datos y por último uno que imprima un mensaje si debe
pagar impuestos (si el sueldo supera a 3000)*/
        private string nombre;
        private float sueldo;

        public Empleado()
        {
            string linea;
            Console.WriteLine("escribe el nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe ahora su sueldo");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }

        public void imprimirDatos()
        {
            Console.WriteLine("el nombre del empleado es: " + nombre + " y su sueldo es de " + sueldo + " dolares");
        }
        public void pagaImpuestos()
        {
            if (sueldo > 3000)
            {
                Console.WriteLine("el empleado debe pagar impuestos");
            }
        }
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();
            empleado.imprimirDatos();
            empleado.pagaImpuestos();
            Console.ReadKey();
        }
    }
}
