using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
        //Plantear una clase llamada Atleta que tenga como atributos privados el Nombre y el TiempoSegundos (tiempo que tardó en completar una carrera). Definir un constructor para ingresar ambos datos.
        //Luego, crear una clase llamada Carrera que administre 3 objetos de la clase Atleta como atributos de la clase.
        //Definir los siguientes métodos en la clase Carrera:
        //Un constructor que cargue los datos de los 3 atletas de la carrera.
        //Un método que imprima los nombres de los atletas junto con sus marcas de tiempo.
        //Un método que calcule e imprima el tiempo promedio de la carrera.
        //Un método que informe el nombre del atleta ganador de la carrera (aquel que completó la prueba en el menor tiempo).
        //Un método que muestre a los atletas que superaron el promedio.
    internal class atleta
    {
        private string nombre;
        private double tiemposegundos;
        public atleta()
        {
            Console.WriteLine("ingrese el nombre del atleta: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese su tiempo en la carrera: ");
            tiemposegundos = double.Parse(Console.ReadLine());
        }
        public string nombreatl()
        {
            return nombre;
        }
        public double tiempo()
        {
            return tiemposegundos;
        }
    }
    class carrera
    {
        private atleta corredor1, corredor2, corredor3;
        public carrera()
        {
            corredor1 = new atleta();
            corredor2 = new atleta();
            corredor3 = new atleta();
        }
        public void carrerafinal()
        {
            Console.WriteLine("el atleta " + corredor1.nombreatl() + " tienen un tiempo de " + corredor1.tiempo());
            Console.WriteLine("el atleta " + corredor2.nombreatl() + " tienen un tiempo de " + corredor2.tiempo());
            Console.WriteLine("el atleta " + corredor3.nombreatl() + " tienen un tiempo de " + corredor3.tiempo());
        }
        public void promedio()
        {
            double suma = 0, promedio = 0;
            suma = corredor1.tiempo();
            suma = suma + corredor2.tiempo();
            suma = suma + corredor3.tiempo();
            promedio = suma / 3;
            Console.WriteLine("el tiempo promedio de la carrera es de " + promedio);
        }
        public void ganador()
        {
            if (corredor1.tiempo() < corredor2.tiempo() && corredor1.tiempo() < corredor3.tiempo())
            {
                Console.WriteLine("el atleta " + corredor1.nombreatl() + " es el ganador con un tiempo de " + corredor1.tiempo());
            }
            if (corredor2.tiempo() < corredor1.tiempo() && corredor2.tiempo() < corredor3.tiempo())
            {
                Console.WriteLine("el atleta " + corredor2.nombreatl() + " es el ganador con un tiempo de " + corredor2.tiempo());
            }
            else
            {
                Console.WriteLine("el atleta " + corredor3.nombreatl() + " es el ganador con un tiempo de " + corredor3.tiempo());
            }
        }
        public void promediosuperado()
        {
            double suma = 0, promedio = 0;
            suma = corredor1.tiempo();
            suma = suma + corredor2.tiempo();
            suma = suma + corredor3.tiempo();
            promedio = suma / 3;
            if (promedio > corredor1.tiempo())
            {
                Console.WriteLine("el atleta " + corredor1.nombreatl() + " supero el promedio " + corredor1.tiempo());
            }
            if (promedio > corredor2.tiempo())
            {
                Console.WriteLine("el atleta " + corredor2.nombreatl() + " supero el promedio " + corredor2.tiempo());
            }
            if (promedio > corredor3.tiempo())
            {
                Console.WriteLine("el atleta " + corredor3.nombreatl() + " supero el promedio " + corredor3.tiempo());
            }
        }
        static void Main(string[] args)
        {
        
            carrera c = new carrera();
            c.carrerafinal();
            c.promedio();
            c.ganador();
            c.promediosuperado();
            Console.ReadKey();
        }
    }
}