using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Punto1
                //Desarrollar una clase que represente un punto en el plano y tenga los
                //siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
                //encuentra dicho punto(concepto matemático, primer cuadrante si x e y son
                //positivas, si x&lt; 0 e y&gt; 0 segundo cuadrante, etc.)
{
    internal class Punto
    {
        
        private int x, y;
        
        public void cargar()
        {
            string linea;
            Console.Write("Ingrese valor de x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.Write("Ingrese valor de y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

        }
        
        public void imprimir()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Estas en el primer cuadrante");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Estas en el segundo cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Estas en el tercer cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("Estas en el cuarto cuadrante");
            }
            else
            {
                Console.WriteLine("El punto se encuentra sobre un eje");
            }

        }
        
        
        static void Main(string[] args)
        {
            Punto punto1 = new Punto();
            punto1.cargar();
            punto1.imprimir();
            Console.ReadKey();
        }
    }
}