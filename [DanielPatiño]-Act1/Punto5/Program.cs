using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5. Realizar la carga del radio de un círculo, mostrar por pantalla la circunferencia y el área del mismo (La circunferencia se calcula multiplicando el doble del radio por π (pi), y el área se calcula multiplicando π por el cuadrado del radio).
            double radio, circunferencia, area;
            string linea;
            Console.Write("pon el radio: ");
            linea = Console.ReadLine();
            radio = double.Parse(linea);

            circunferencia = 3.1416 * (radio * 2);
            area = 3.1416 * (radio * radio);
            Console.Write("La circunferencia es de: ");
            Console.WriteLine(circunferencia);
            Console.Write("El area es de: ");
            Console.WriteLine(area);
            Console.ReadKey();
        }
    }
}
