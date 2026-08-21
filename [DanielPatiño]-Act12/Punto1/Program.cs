using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{
    internal class correo
    {

        /*1. Sistema de Logística: Envíos por Sucursal
Una empresa de correo tiene 3 sucursales principales. Cada sucursal procesa una
cantidad diferente de paquetes por día dependiendo de su demanda.
● Definir un vector de tipo string para los nombres de las 3 sucursales.
● Definir una matriz irregular donde cada fila sea una sucursal y cada columna
represente el peso (en kg) de cada paquete enviado.
● Métodos:
1. Cargar los nombres de las sucursales y, para cada una, preguntar cuántos
paquetes se enviaron hoy para definir el tamaño de su fila.
2. Cargar el peso de cada paquete.
3. Imprimir el peso de todos los paquetes organizados por sucursal.
4. Calcular e informar el peso total despachado por cada sucursal.
5. Informar cuál es el paquete más pesado de toda la empresa y a qué sucursal
pertenece.*/

        private string[] sucursales;
        private float[][] paquetes;
        private float suma;
        private float pesoMayor;

        public void cargar()
        {
            sucursales = new string[3];
            paquetes = new float[3][];
            string linea;
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.WriteLine("escribe el nombre de la sucursal:");
                sucursales[i] = Console.ReadLine();
                Console.WriteLine("ahora escribi la cantidad de paquetes que se envió hoy en la sucursal que escribiste:");
                linea = Console.ReadLine();
                paquetes[i] = new float[int.Parse(linea)];
            }

        }
        public void cargarPesos()
        {
            string linea;
            for (int i = 0; i < paquetes.GetLength(0); i++)
            {
                for (int f = 0; f < paquetes[i].Length; f++)
                {
                    Console.WriteLine("Escribe el peso (en Kilogramos) del paquete numero " + (f + 1) + " de la sucursal " + sucursales[i]);
                    linea = Console.ReadLine();
                    if (float.Parse(linea) <= 0)
                    {
                        Console.WriteLine("no podes escribir pesos negativos");
                        f = f - 1;
                    }
                    else
                    {
                        paquetes[i][f] = float.Parse(linea);
                    }
                }
            }

        }

        public void imprimirPesos()
        {
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < paquetes.GetLength(0); i++)
            {
                Console.WriteLine("Los pesos de los paquetes de la sucursal " + sucursales[i] + " son");
                for (int f = 0; f < paquetes[i].Length; f++)
                {
                    Console.Write(paquetes[i][f] + "kg  ");
                }
                Console.WriteLine();
            }
        }

        public void calcularPesos()
        {
            Console.WriteLine("-----------------------------");
            for (int i = 0; i < paquetes.GetLength(0); i++)
            {
                suma = 0;
                for (int f = 0; f < paquetes[i].Length; f++)
                {
                    suma += paquetes[i][f];

                }
                Console.WriteLine("la cantidad total de peso que se envio en paquetes para la sucursal " + sucursales[i] + " es de " + suma);
            }
            Console.WriteLine("-----------------------------");
        }

        public void calcularMasPesado()
        {
            pesoMayor = paquetes[0][0];

            for (int i = 0; i < paquetes.GetLength(0); i++)
            {
                for (int f = 0; f < paquetes[i].Length; f++)
                {
                    if (paquetes[i][f] > pesoMayor)
                    {
                        pesoMayor = paquetes[i][f];
                    }
                }
            }
        }
        public void informarMayor()
        {
            for (int i = 0; i < paquetes.GetLength(0); i++)
            {
                for (int f = 0; f < paquetes[i].Length; f++)
                {
                    if (paquetes[i][f] == pesoMayor)
                    {
                        Console.WriteLine("la sucursal " + sucursales[i] + " tiene un paquete con el peso mas grande, con " + pesoMayor);
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            correo Correo = new correo();
            Correo.cargar();
            Correo.cargarPesos();
            Correo.imprimirPesos();
            Correo.calcularPesos();
            Correo.calcularMasPesado();
            Correo.informarMayor();
            Console.ReadKey();
        }
    }
}