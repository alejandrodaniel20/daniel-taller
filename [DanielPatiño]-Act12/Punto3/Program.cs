using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    internal class Academia
    {
        /*3. Academia de Gastronomía: Recetario Dinámico
Un chef instructor evalúa a 3 alumnos en un examen final. Cada alumno debe presentar
una cantidad distinta de platos (uno presenta 2 platos, otro 4 y otro 3).
● Definir un vector para los nombres de los alumnos.
● Definir una matriz irregular para cargar el puntaje obtenido (0 a 100) en cada plato
presentado.
● Métodos:
1. Cargar nombres y definir el tamaño de las filas según la cantidad de platos
de cada alumno.
2. Cargar los puntajes de cada plato validando que estén entre 0 y 100.
3. Mostrar el listado de alumnos y el puntaje de cada uno de sus platos.
4. Calcular el puntaje promedio de cada alumno e informar si está &quot;Aprobado&quot;
(promedio &gt;= 70) o &quot;Reprobado&quot;.
5. Determinar quién obtuvo el puntaje individual más alto en un solo plato (el
valor máximo de la matriz).*/

        private float[][] platos;
        private string[] estudiantes;
        private float prom, suma;
        private float mayor;
        public void cargarPlatos()
        {
            string linea;
            platos = new float[3][];
            estudiantes = new string[3];

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine("Escribe el nombre de un estudiante");
                linea = Console.ReadLine();
                estudiantes[i] = linea;
            }

            platos[0] = new float[2];
            platos[1] = new float[4];
            platos[2] = new float[3];
        }

        public void cargarPuntajes()
        {
            string linea;
            for (int i = 0; i < platos.GetLength(0); i++)
            {
                for (int f = 0; f < platos[i].Length; f++)
                {
                    Console.WriteLine("escoge un puntaje para el alumno numero " + i + " y a su plato numero " + f);
                    linea = Console.ReadLine();
                    if (int.Parse(linea) < 0 || int.Parse(linea) > 100)
                    {
                        Console.WriteLine("puntaje no valido. intenta de nuevo");
                        f = f - 1;
                    }
                    else
                    {
                        platos[i][f] = int.Parse(linea);
                    }
                }
            }
        }

        public void mostrarListado()
        {

            for (int i = 0; i < platos.GetLength(0); i++)
            {
                Console.WriteLine("notas de los platos del alumno " + estudiantes[i]);
                for (int f = 0; f < platos[i].Length; f++)
                {
                    Console.WriteLine("plato " + f + ": " + platos[i][f]);
                }
            }

        }

        public void promedio()
        {
            prom = 0;
            suma = 0;
            for (int i = 0; i < platos.GetLength(0); i++)
            {
                for (int f = 0; f < platos[i].Length; f++)
                {
                    suma += platos[i][f];
                    prom = suma / platos[i].Length;

                }
                Console.WriteLine("El alumno " + estudiantes[i] + " tiene un promedio de " + prom);
                if (prom >= 70)
                {
                    Console.WriteLine("y está aprobado");
                }
                else
                {
                    Console.WriteLine("y está reprobado");
                }
                suma = 0;
            }
        }
        public void sacarMayor()
        {
            mayor = platos[0][0];
            for (int i = 0; i < platos.GetLength(0); i++)
            {
                for (int f = 0; f < platos[i].Length; f++)
                {
                    if (platos[i][f] > mayor)
                    {
                        mayor = platos[i][f];
                    }
                }
            }
        }
        public void mostrarMayor()
        {
            for (int i = 0; i < platos.GetLength(0); i++)
            {
                for (int f = 0; f < platos[i].Length; f++)
                {
                    if (platos[i][f] == mayor)
                    {
                        Console.WriteLine("el alumno numero " + i + " con su plato numero " + f + " tuvo el mejor plato con un puntaje de: " + platos[i][f]);
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Academia academia = new Academia();
            academia.cargarPlatos();
            academia.cargarPuntajes();
            academia.mostrarListado();
            academia.promedio();
            academia.sacarMayor();
            academia.mostrarMayor();

            Console.ReadKey();
        }
    }
}
