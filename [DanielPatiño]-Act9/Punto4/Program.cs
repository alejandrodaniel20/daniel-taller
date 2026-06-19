using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Se realiza una evaluación a 6 docentes por parte de sus alumnos.Se registran
    //sus nombres y puntajes promedio obtenidos (de 1 a 10).
    //Cargar sus datos en vectores paralelos, mostrar docente con calificación más
    //alta y más baja, ordenar los vectores de mayor a menor de acuerdo con la
    //calificación y mostrar en pantalla la cantidad de docentes que aprobaron y
    //desaprobaron(tomando como base que se aprueba con una nota mayor o igual
    //a 6)
    class Docentes
    {
        private string[] nombres;
        private int[] notas;

        public void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese docente: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese calificación: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            int mayor = 0;
            int menor = 0;

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > notas[mayor])
                    mayor = i;

                if (notas[i] < notas[menor])
                    menor = i;
            }

            Console.WriteLine("\nOrdenados:");
            Console.WriteLine("Mayor calificación: " + nombres[mayor] + " = " + notas[mayor]);
            Console.WriteLine("Menor calificación: " + nombres[menor] + " = " + notas[menor]);

            for (int i = 0; i < notas.Length - 1; i++)
            {
                for (int k = i + 1; k < notas.Length; k++)
                {
                    if (notas[i] < notas[k])
                    {
                        int auxNota = notas[i];
                        notas[i] = notas[k];
                        notas[k] = auxNota;

                        string auxNom = nombres[i];
                        nombres[i] = nombres[k];
                        nombres[k] = auxNom;
                    }
                }
            }

            Console.WriteLine("\nOrdenados:");

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i] + " = " + notas[i]);
            }

            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] >= 6)
                    aprobados++;
                else
                    desaprobados++;
            }

            Console.WriteLine("Aprobados: " + aprobados);
            Console.WriteLine("Desaprobados: " + desaprobados);
        }

        static void Main(string[] args)
        {
            Docentes dt = new Docentes();
            dt.Cargar();
            dt.Procesar();
            Console.ReadKey();
        }
    }
}
