using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    class Persona
    { /*1. Confeccionar una clase Persona que tenga como atributos el nombre y la
edad (definir las propiedades para poder acceder a dichos atributos). Definir
un método para imprimirlos. Plantear una segunda clase Empleado que
herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) y el
método para imprimir su sueldo. Definir un objeto de la clase Persona y
llamar a sus métodos y propiedades. También crear un objeto de la clase
Empleado y llamar a sus métodos y propiedades.*/
        protected string nombre;
        protected int edad;

        public int Edad
        {
            set
            {
                edad = value;
            }
            get
            {
                return edad;
            }
        }
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }

        public void imprimir()
        {
            Console.WriteLine("El nombre de la Persona es: " + nombre + " y su edad es " + edad);
        }
    }


    class Empleado : Persona
    {
        private int sueldo;

        public int Sueldo
        {
            set
            {
                sueldo = value;
            }
            get
            {
                return sueldo;
            }
        }

        public void imprimirSueldo()
        {
            Console.WriteLine("y su sueldo es: " + sueldo);
        }
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Daniel";
            persona.Edad = 17;
            persona.imprimir();
            Empleado empleado = new Empleado();
            empleado.Nombre = "Martin";
            empleado.Edad = 18;
            empleado.Sueldo = 1;
            empleado.imprimir();
            empleado.imprimirSueldo();
            Console.ReadKey();
        }
    }
}