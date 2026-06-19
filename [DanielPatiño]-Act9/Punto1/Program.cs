using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{   //Se desea desarrollar un programa que permita registrar los nombres y las
    //calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
    //nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
    //estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
    //máxima o mínima.
    class Estudiantes
    {
        private string[] nombres;
        private int[] notas;

        public void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[i] = Console.ReadLine();

                Console.Write("Ingrese nota: ");
                notas[i] = int.Parse(Console.ReadLine());
            }
        }

        public void MayoryMenorNota()
        {
            int Mayor = 0;
            int Menor = 0;

            for (int i = 1; i < notas.Length; i++)
            {
                if (notas[i] > notas[Mayor])
                    Mayor = i;

                if (notas[i] < notas[Menor])
                    Menor = i;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Mayor nota: " + nombres[Mayor] + " = " + notas[Mayor]);
            Console.WriteLine("Menor nota: " + nombres[Menor] + " = " + notas[Menor]);
            Console.WriteLine("\n");
            int mayor = 0;
            int menor = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                if (notas[i] == notas[mayor])
                    mayor++;

                if (notas[i] == notas[menor])
                    menor++;
            }

            if (mayor > 1)
                Console.WriteLine("La nota máxima se repite.");

            if (menor > 1)
                Console.WriteLine("La nota mínima se repite.");
        }

        static void Main(string[] args)
        {
            Estudiantes es = new Estudiantes();
            es.Cargar();
            es.MayoryMenorNota();
            Console.ReadKey();
        }
    }
}
