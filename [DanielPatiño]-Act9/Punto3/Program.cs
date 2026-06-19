using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    class Atletas
    {
        private string[] nombres;
        private double[] tiempos;

        public void Cargar()
        {
            nombres = new string[5];
            tiempos = new double[5];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese atleta: ");
                nombres[f] = Console.ReadLine();

                Console.Write("Ingrese tiempo: ");
                tiempos[f] = double.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            double suma = 0;

            for (int f = 0; f < tiempos.Length; f++)
            {
                suma += tiempos[f];
            }

            double promedio = suma / tiempos.Length;

            int mejor = 0;
            int peor = 0;

            for (int f = 1; f < tiempos.Length; f++)
            {
                if (tiempos[f] < tiempos[mejor])
                    mejor = f;

                if (tiempos[f] > tiempos[peor])
                    peor = f;
            }

            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Mejor tiempo: " + nombres[mejor]);
            Console.WriteLine("Peor tiempo: " + nombres[peor]);

            Console.WriteLine("Superaron el promedio:");

            for (int f = 0; f < tiempos.Length; f++)
            {
                if (tiempos[f] < promedio)
                {
                    Console.WriteLine(nombres[f]);
                }
            }
        }

        static void Main(string[] args)
        {
            Atletas a = new Atletas();
            a.Cargar();
            a.Procesar();
        }
    }
}
