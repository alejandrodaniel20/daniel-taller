using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{/*2. Catálogo de Películas (Encapsulación, Validación y Composición)
Plantear una clase llamada Pelicula y otra clase llamada Catalogo.
La clase Pelicula debe tener como atributos privados: Titulo, DuracionMinutos y Calificacion
(un puntaje del 1 al 5). Definir las propiedades necesarias para acceder a estos atributos,
asegurando mediante validaciones lógicas que:
 La duración en minutos sea estrictamente mayor a cero (0).
 La calificación se encuentre únicamente en el rango de 1 a 5 (de lo contrario, asignar
un valor por defecto de 1).
La clase Catalogo debe contener internamente un vector capaz de almacenar 3 objetos de
la clase Pelicula. Definir un método dentro de Catalogo para mostrar por pantalla todas las
películas ordenadas de mayor a menor en base a su duración. Además, el método debe
informar el título de la película con mejor calificación y cuál es la película más corta del
catálogo.*/

    class Pelicula
    {
        private string titulo;
        private int duracionMinutos;
        private int calificacion;

        public string Titulo
        {
            set { titulo = value; }
            get { return titulo; }
        }
        public int DuracionMinutos
        {
            set
            {
                duracionMinutos = value;
            }
            get { return duracionMinutos; }
        }
        public int Calificacion
        {
            set
            {
                calificacion = value;
            }
            get { return calificacion; }
        }
        public Pelicula()
        {
            string linea;
            Console.WriteLine("ingresa el titulo de la pelicula");
            titulo = Console.ReadLine();
            Console.WriteLine("ingresa la duracion en minutos de la pelicula (estrictamente mayor a 0)");
            for (int i = 0; i < 1; i++)
            {
                linea = Console.ReadLine();
                duracionMinutos = int.Parse(linea);
                if (duracionMinutos <= 0)
                {
                    Console.WriteLine("duracion no permitida, ingresa de nuevo");
                    i--;
                }
            }
            Console.WriteLine("ahora escribi la calificacion de la pelicula");

            linea = Console.ReadLine();
            calificacion = int.Parse(linea);

            if (calificacion <= 0 || calificacion > 5)
            {
                Console.WriteLine("no pueden haber calificaciones menores o iguales a 0 o mayores a 5. Se asignará 1 a la calificacion por defecto");
                calificacion = 1;
            }
        }


    }
    internal class Catalogo
    {
        private Pelicula[] peliculas;
        public Catalogo()
        {
            peliculas = new Pelicula[3];
            for (int i = 0; i < peliculas.Length; i++)
            {
                peliculas[i] = new Pelicula();
            }
        }

        public void ordenar()
        {
            Pelicula temporal = peliculas[0];
            for (int i = 0; i < peliculas.Length; i++)
            {
                for (int y = 0; y < peliculas.Length - i - 1; y++)
                {
                    if (peliculas[y].DuracionMinutos < peliculas[y + 1].DuracionMinutos)
                    {
                        temporal = peliculas[y + 1];
                        peliculas[y + 1] = peliculas[y];
                        peliculas[y] = temporal;
                    }
                }
            }
        }
        public void mostrar()
        {
            int menorDuracion;
            for (int i = 0; i < peliculas.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Pelicula: " + peliculas[i].Titulo + ". Duracion: " + peliculas[i].DuracionMinutos + ". Calificacion: " + peliculas[i].Calificacion);
                Console.WriteLine();

            }
            menorDuracion = peliculas[peliculas.Length - 1].DuracionMinutos;
            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].DuracionMinutos == menorDuracion)
                {
                    Console.WriteLine("la pelicula " + peliculas[i].Titulo + " tiene la menor duracion con " + menorDuracion + " minutos");
                }
            }

        }
        public void mejorCalificacion()
        {
            int mejorCalificacion = peliculas[0].Calificacion;
            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].Calificacion > mejorCalificacion)
                {
                    mejorCalificacion = peliculas[i].Calificacion;
                }
            }
            for (int i = 0; i < peliculas.Length; i++)
            {
                if (peliculas[i].Calificacion == mejorCalificacion)
                {
                    Console.WriteLine("la pelicula " + peliculas[i].Titulo + " tiene la mejor calificacion con " + mejorCalificacion);
                }
            }
        }

        static void Main(string[] args)
        {
            Catalogo catalogo = new Catalogo();
            catalogo.ordenar();
            catalogo.mostrar();
            catalogo.mejorCalificacion();
            Console.ReadKey();
        }
    }
}