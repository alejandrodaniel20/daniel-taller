using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    class Docentes
    {
        private string[] nombres;
        private int[] notas;

        public void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese docente: ");
                nombres[f] = Console.ReadLine();

                Console.Write("Ingrese calificación: ");
                notas[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            int mayor = 0;
            int menor = 0;

            for (int f = 1; f < notas.Length; f++)
            {
                if (notas[f] > notas[mayor])
                    mayor = f;

                if (notas[f] < notas[menor])
                    menor = f;
            }

            Console.WriteLine("Mayor calificación: " +
                              nombres[mayor] + " - " + notas[mayor]);

            Console.WriteLine("Menor calificación: " +
                              nombres[menor] + " - " + notas[menor]);

            for (int f = 0; f < notas.Length - 1; f++)
            {
                for (int k = f + 1; k < notas.Length; k++)
                {
                    if (notas[f] < notas[k])
                    {
                        int auxNota = notas[f];
                        notas[f] = notas[k];
                        notas[k] = auxNota;

                        string auxNom = nombres[f];
                        nombres[f] = nombres[k];
                        nombres[k] = auxNom;
                    }
                }
            }

            Console.WriteLine("\nOrdenados:");

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.WriteLine(nombres[f] + " - " + notas[f]);
            }

            int aprobados = 0;
            int desaprobados = 0;

            for (int f = 0; f < notas.Length; f++)
            {
                if (notas[f] >= 6)
                    aprobados++;
                else
                    desaprobados++;
            }

            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
        }

        static void Main(string[] args)
        {
            Docentes d = new Docentes();
            d.Cargar();
            d.Procesar();
        }
    }
}
