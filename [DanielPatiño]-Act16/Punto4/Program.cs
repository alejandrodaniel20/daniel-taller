using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{   
    //4. Armar tres clases: Animal, Mamífero y Perro.
    //La clase Animal debe tener un atributo especie.
    //La clase Mamífero, que hereda de Animal, debe tener un atributo
    //tipoAlimentacion.
    //La clase Perro, que hereda de Mamífero, debe tener un atributo nombre.
    //Cada clase debe tener un constructor que reciba los datos correspondientes
    //y los imprima indicando a qué clase pertenecen.Los datos deben ser
    //asignados previamente
    //Crear un objeto de la clase Perro y verificar la ejecución en cadena de los
    //constructores.
    class Animal
    {
        private string especie;
        public Animal(string especieRecibida)
        {
            especie = especieRecibida;
            Console.WriteLine("la especie es " + especie + ". esta informacion viene de Animal");
        }
        public string Especie
        {
            set { especie = value; }
            get { return especie; }
        }
    }
    class Mamifero : Animal
    {
        private string tipoAlimentacion;

        public Mamifero(string comidaRecibida, string especieRecibida) : base(especieRecibida)
        {
            tipoAlimentacion = comidaRecibida;
            Console.WriteLine("el tipo de alimentacion es " + tipoAlimentacion + ". esta informacion viene de Mamifero");
        }

        public string TipoAlimentacion
        {
            set { tipoAlimentacion = value; }
            get { return tipoAlimentacion; }
        }
    }

    internal class Perro : Mamifero
    {
        private string nombre;
        public Perro(string nombreRecibido, string comidaRecibida, string especieRecibida) : base(comidaRecibida, especieRecibida)
        {

            nombre = nombreRecibido;
            Console.WriteLine("el nombre es " + nombre + ". esta informacion viene de Perro");
        }
        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        static void Main(string[] args)
        {
            Animal perro = new Perro("chufo", "personas", "mamifero");
            Console.ReadKey();
        }
    }
}