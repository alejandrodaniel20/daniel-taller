using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto3
{
    //Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
    // un videojuego.El programa debe:
    // Mostrar la puntuación más alta y la más baja.
    // Calcular el promedio de puntuación.
    // Contar cuántas veces superó los 500 puntos.


    internal class Usuario
    {
        private int[] puntos;

        public void Cargar()
        {
            puntos = new int[6];
            string linea;

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Ingrese puntuación: ");
                linea = Console.ReadLine();
                puntos[i] = int.Parse(linea);
            }
        }

        public void puntAltayBaja()
        {
            int mayor = puntos[0];
            int menor = puntos[0];
            int suma = 0;
            int mayores500 = 0;

            for (int i = 0; i < 6; i++)
            {
                suma += puntos[i];

                if (puntos[i] > mayor)
                {
                    mayor = puntos[i];
                }

                if (puntos[i] < menor)
                {
                    menor = puntos[i];
                }

                if (puntos[i] > 500)
                {
                    mayores500++;
                }
            }
            
            double promedio = suma / 6.0;

            Console.WriteLine("Puntuación más alta: " + mayor);
            Console.WriteLine("Puntuación más baja: " + menor);
            Console.WriteLine("Promedio: " + promedio);
            Console.WriteLine("Veces que superó 500 puntos: " + mayores500);
        }

        static void Main(string[] args)
        {
            Usuario us = new Usuario();
            us.Cargar();
            us.puntAltayBaja();
            Console.ReadKey();
        }
    }
}
