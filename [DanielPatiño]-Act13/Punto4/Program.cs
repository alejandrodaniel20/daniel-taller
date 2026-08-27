using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{
    /*Plantear una clase Alumno que tenga los atributos privados: nombre y un
vector de 4 notas.Definir un constructor que solicite el ingreso del nombre del
alumno y sus 4 calificaciones.
Luego, confeccionar una clase Curso que contenga un vector de 3 objetos
Alumno.
Agregar los siguientes métodos:
a) Un método que imprima el nombre de cada alumno y su promedio.
b) Un método que muestre el nombre del alumno con el promedio más
alto.
c) Un método que indique qué alumnos tienen al menos una nota
desaprobada(nota menor a 6)*/
    class Alumno
    {
        private string nombre;
        private float[] notas;
        public Alumno()
        {
            string linea;
            notas = new float[4];
            Console.WriteLine("cual es el nombre del alumno?");
            nombre = Console.ReadLine();

            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("por favor escribe la nota numero " + (i + 1) + " del alumno");

                linea = Console.ReadLine();

                notas[i] = float.Parse(linea);
            }
        }

        public string retornarNombre()
        {
            return nombre;
        }

        public float[] retornarNotas()
        {
            return notas;
        }
    }

    class Curso
    {
        private Alumno[] Alumnos;
        private float[] promedios = new float[4];
        public Curso()
        {
            Alumnos = new Alumno[4];
            for (int i = 0; i < Alumnos.Length; i++)
            {
                Alumnos[i] = new Alumno();
            }
        }
        public void nombreYPromedio()
        {
            float promedio;

            for (int i = 0; i < Alumnos.Length; i++)
            {
                float[] notas = Alumnos[i].retornarNotas();

                promedio = 0;

                for (int j = 0; j < notas.Length; j++)
                {
                    promedio += notas[j];
                }
                promedio = promedio / notas.Length;
                promedios[i] = promedio;
                Console.WriteLine(
                    "el nombre del alumno es: "
                    + Alumnos[i].retornarNombre()
                );
                Console.WriteLine(
                    "el promedio de sus notas es: "
                    + promedio
                );
            }
        }

        public void promedioMasAlto()
        {
            float notaMasGrande = promedios[0];
            for (int i = 0; i < promedios.Length; i++)
            {
                if (promedios[i] > notaMasGrande)
                {
                    notaMasGrande = promedios[i];
                }
            }

            for (int i = 0; i < promedios.Length; i++)
            {
                if (promedios[i] == notaMasGrande)
                {
                    Console.WriteLine(
                        "el alumno "
                        + Alumnos[i].retornarNombre()
                        + " tiene el promedio mas alto con "
                        + promedios[i]
                    );
                }
            }
        }
        public void alumnosDesaprobados()
        {
            for (int i = 0; i < Alumnos.Length; i++)
            {
                float[] notas = Alumnos[i].retornarNotas();
                int desaprobado = 0;
                for (int j = 0; j < notas.Length; j++)
                {
                    if (notas[j] < 6)
                    {
                        desaprobado += 1;
                    }
                }
                if (desaprobado > 1)
                {
                    Console.WriteLine(
                        "el alumno "
                        + Alumnos[i].retornarNombre()
                        + " tiene al menos una nota desaprobada"
                    );
                }
            }
        }
        static void Main(string[] args)
        {
            Curso curso = new Curso();
            Console.WriteLine("PROMEDIOS");
            curso.nombreYPromedio();
            Console.WriteLine();
            Console.WriteLine("pRomedios mas altos");
            curso.promedioMasAlto();
            Console.WriteLine();
            Console.WriteLine("desaprobados");
            curso.alumnosDesaprobados();
            Console.ReadKey();
        }
    }
}