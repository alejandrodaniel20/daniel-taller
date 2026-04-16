using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Se cuenta con la siguiente información:
            //● Las edades de 20 estudiantes del turno mañana.
            //● Las edades de 30 estudiantes del turno tarde.
            //● Las edades de 15 estudiantes del turno noche.
            //Las edades de cada estudiante deben ingresarse por teclado.
            //a) Obtener el promedio de las edades de cada turno(tres promedios)
            //b) Imprimir dichos promedios(promedio de cada turno)
            //c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
            //promedio de edades menor.

            int edad;
            float promedioM = 0, promedioT = 0, promedioN = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                promedioM = promedioM + edad;
            }
            promedioM = promedioM / 20;
            Console.Write("\n" + promedioM + "\n");
            for (int i = 0; i < 30; i++)
            {
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                promedioT = promedioT + edad;
            }
            promedioT = promedioT / 30;
            Console.Write("\n" + promedioT + "\n");
            for (int i = 0; i < 15; i++)
            {
                Console.Write("Ingrese la edad: ");
                edad = int.Parse(Console.ReadLine());
                promedioN = promedioN + edad;
            }
            promedioN = promedioN / 15;
            Console.Write("\n" + promedioN);
            Console.ReadKey();
        }
    }
}
