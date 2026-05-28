using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //Desarrollar una clase que represente un Cuadrado y tenga los siguientes
    //métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.
    internal class Cuadrado
    {
        private float lado;
       public void cargar()
        {
            string linea;
            Console.Write("Ingrese el lado: ");
            linea= Console.ReadLine();
            lado = float.Parse(linea);

        }

        public void perimetro()
        {
            float perimetro = lado * 4;
            Console.WriteLine("El perímetro es: " + perimetro);

        }

        public void superficie()
        {
            float superficie = lado * lado;
            Console.WriteLine("La superficie es: " + superficie);
        }

        static void Main(string[] args)
        {
            Cuadrado cuadrado1 = new Cuadrado();
            cuadrado1.cargar();
            cuadrado1.perimetro();
            cuadrado1.superficie();
            Console.ReadKey();
        }
    }
}
