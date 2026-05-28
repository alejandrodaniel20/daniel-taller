using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Confeccionar una clase que represente un empleado.Definir como atributos su
    //nombre y su sueldo.Confeccionar los métodos para la carga, otro para imprimir
    //sus datos y por último uno que imprima un mensaje si debe pagar impuestos
    //(si el sueldo supera a 3000).
    internal class Empleado
    {
        private string nombre;
        private float sueldo;
        
        public void cargar()
        {
            string linea;
            Console.Write("Ingrese nombre del empleado: ");
            nombre = Console.ReadLine();

            Console.Write("ingrese sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
        }
            
            public void impuesto()
            {

            if (sueldo > 3000)
            {
                Console.WriteLine("Debe pagar impuestos");
            }
           
        }
                
            
        public void imprimir()
        {

            Console.WriteLine("nombre " + nombre );
            Console.WriteLine("sueldo " + sueldo );

        }
        static void Main(string[] args)
        {
            Empleado empleado1 = new Empleado();

            empleado1.cargar();
            empleado1.impuesto();
            empleado1.imprimir();

            Console.ReadKey();
        }
    }
}
