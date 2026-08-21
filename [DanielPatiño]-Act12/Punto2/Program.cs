using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    internal class Cine
    {
        /*2. Gestión de Complejo de Cine
Un cine tiene 4 salas con diferentes capacidades de espectadores (la Sala 1 tiene 10
asientos, la Sala 2 tiene 15, la Sala 3 tiene 8 y la Sala 4 tiene 12).
● Definir una matriz irregular de 4 filas para representar los asientos.
● Métodos:
1. Inicializar la matriz con los tamaños de las salas mencionadas (sin
intervención del operador).
2. Crear un método de &quot;Venta de Entradas&quot; que permita cargar la edad del
espectador en un asiento específico (fila y columna).
3. Imprimir el mapa de ocupación de las salas indicando la edad del espectador
en cada asiento.
4. Calcular cuántos menores de edad (menos de 18 años) hay en cada sala.
5. Informar cuál es el promedio de edad de los espectadores de todo el
complejo.*/

        private int[][] asientos;

        string linea;
        int edad;
        int menores;

        public void inicializar()
        {
            asientos = new int[4][];
            asientos[0] = new int[10];
            asientos[1] = new int[15];
            asientos[2] = new int[8];
            asientos[3] = new int[12];
        }

        public void ventaEntradas()
        {
            do
            {
                string linea2, linea3;
                Console.WriteLine("ingrese el numero de sala (0-3). si escribe -1 se termina el programa");

                linea = Console.ReadLine();
                if (int.Parse(linea) != -1)
                {

                    if (int.Parse(linea) < -1 || int.Parse(linea) > 3)
                    {
                        Console.WriteLine("numero de sala invalido, pruebe de nuevo");
                    }
                    else
                    {

                        Console.WriteLine("ahora ingrese el numero de asiento de la sala " + int.Parse(linea) + " que tiene " + (asientos[int.Parse(linea)].Length - 1) + " asientos (empezando desde el 0)");
                        linea2 = Console.ReadLine();
                        if (int.Parse(linea2) >= asientos[int.Parse(linea)].Length || int.Parse(linea2) <= -1)
                        {
                            Console.WriteLine("fuera del rango de asientos");
                        }
                        else
                        {
                            Console.WriteLine("ahora ingresa la edad del espectador que pondrás en ese asiento.");
                            linea3 = Console.ReadLine();
                            if (int.Parse(linea3) <= 0)
                            {
                                Console.WriteLine("no podes escribir edades menores o iguales a 0");
                            }
                            else
                            {
                                asientos[int.Parse(linea)][int.Parse(linea2)] = int.Parse(linea3);
                            }
                        }

                    }

                }
                else
                {
                    Console.WriteLine("programa terminado");
                }
            }
            while (int.Parse(linea) != -1);


        }


        public void imprimir()
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                Console.WriteLine("sala " + i + ":");
                for (int f = 0; f < asientos[i].Length; f++)
                {
                    Console.Write(asientos[i][f] + "  ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        public void calcularMenores()
        {
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                menores = 0;
                for (int f = 0; f < asientos[i].Length; f++)
                {
                    if (asientos[i][f] < 18)
                    {

                        if (asientos[i][f] != 0)
                        {
                            menores += 1;


                        }


                    }
                }
                if (menores > 0)
                {
                    Console.WriteLine("la sala " + i + " tiene " + menores + " menores de edad");
                }
            }
        }

        public void Promedio()
        {
            float suma = 0;
            float divisor = 0;
            float promedio = 0;
            for (int i = 0; i < asientos.GetLength(0); i++)
            {
                for (int f = 0; f < asientos[i].Length; f++)
                {
                    if (asientos[i][f] != 0)
                    {
                        suma += asientos[i][f];

                    }
                }
                divisor += asientos[i].Length;
            }
            promedio = suma / divisor;
            Console.WriteLine("el promedio de edades es: " + promedio);
        }
        static void Main(string[] args)
        {
            Cine cine = new Cine();
            cine.inicializar();
            cine.ventaEntradas();
            cine.imprimir();
            cine.calcularMenores();
            cine.Promedio();
            Console.ReadKey();
        }
    }
}