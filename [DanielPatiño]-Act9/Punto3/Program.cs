using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Se registran los nombres de 5 atletas y sus tiempos(en segundos) en una
    //carrera de 100 metros.El programa debe cargar los datos en dos vectores
    //paralelos, calcular y mostrar el promedio de los tiempos, mostrar el nombre del
    //atleta con mejor y peor tiempo, y mostrar los nombres de quienes superaron el
    //promedio.
    class Atletas
    {
        private string[] nombres;
        private double[] tiempos;

        public void Cargar()
        {
            nombres = new string[5];
            tiempos = new double[5];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese atleta: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese tiempo: ");
                tiempos[i] = double.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            double suma = 0;

            for (int i = 0; i < tiempos.Length; i++)
            {
                suma += tiempos[i];
            }

            double promedio = suma / tiempos.Length;

            int mejor = 0;
            int peor = 0;

            for (int i = 1; i < tiempos.Length; i++)
            {
                if (tiempos[i] < tiempos[mejor])
                    mejor = i;

                if (tiempos[i] > tiempos[peor])
                    peor = i;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mejor tiempo: " + nombres[mejor]);
            Console.WriteLine("Peor tiempo: " + nombres[peor]);
            Console.WriteLine("Superaron el promedio:");

            for (int i = 0; i < tiempos.Length; i++)
            {
                if (tiempos[i] < promedio)
                {
                    Console.WriteLine(nombres[i]);
                }
            }
        }

        static void Main(string[] args)
        {
            Atletas at = new Atletas();
            at.Cargar();
            at.Procesar();
            Console.ReadKey();
        }
    }
}
