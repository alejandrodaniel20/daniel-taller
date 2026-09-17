using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    /*1. Personal de un Gimnasio (Herencia Simple y Propiedades)
Confeccionar una clase llamada PersonaGimnasio que tenga como atributos privados el
Nombre y el DNI (definir sus respectivas propiedades de lectura y escritura). Plantear un
método para imprimir estos datos básicos.
Luego, crear una segunda clase llamada Profesor que herede de PersonaGimnasio. Añadir
un atributo propio llamado Especialidad (con su propiedad correspondiente) y un método
para imprimir todos los datos del profesor (incluyendo los heredados).
En el programa principal (Main):
 Definir un objeto de la clase PersonaGimnasio, asignar valores a sus propiedades y
llamar a su método de impresión.
 Crear un objeto de la clase Profesor, interactuar con sus propiedades y comprobar
que puede acceder tanto a sus métodos propios como a los de la clase base.*/

    class PersonaGimnasio
    {
        private string nombre;
        private int dni;
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public int DNI
        {
            set { dni = value; }
            get { return dni; }
        }
        public void imprimirPersona()
        {
            Console.WriteLine("El nombre de la persona con el DNI " + DNI + " es " + nombre);
        }
    }



    internal class Profesor : PersonaGimnasio
    {
        private string especialidad;
        public string Especialidad
        {
            set { especialidad = value; }
            get { return especialidad; }
        }
        public void imprimirProfesor()
        {
            Console.WriteLine("su especialidad es: " + especialidad);
        }
        static void Main(string[] args)
        {
            PersonaGimnasio persona = new PersonaGimnasio();
            persona.Nombre = "Samuel";
            persona.DNI = 123456;
            persona.imprimirPersona();
            Profesor profe = new Profesor();
            profe.Nombre = "Maria Galeazzi";
            profe.DNI = 48856;
            profe.Especialidad = "Analisis de Sistemas";
            profe.imprimirPersona();
            profe.imprimirProfesor();
            Console.ReadKey();
        }
    }
}
