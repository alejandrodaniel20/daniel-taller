using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    class Estudiantes
    {
        private string[] nombres;
        private int[] notas;

        public void Cargar()
        {
            nombres = new string[6];
            notas = new int[6];

            for (int f = 0; f < nombres.Length; f++)
            {
                Console.Write("Ingrese nombre: ");
                nombres[f] = Console.ReadLine();

                Console.Write("Ingrese nota: ");
                notas[f] = int.Parse(Console.ReadLine());
            }
        }

        public void Procesar()
        {
            int posMayor = 0;
            int posMenor = 0;

            for (int f = 1; f < notas.Length; f++)
            {
                if (notas[f] > notas[posMayor])
                    posMayor = f;

                if (notas[f] < notas[posMenor])
                    posMenor = f;
            }

            Console.WriteLine("Mayor nota: " + nombres[posMayor] +
                              " - " + notas[posMayor]);

            Console.WriteLine("Menor nota: " + nombres[posMenor] +
                              " - " + notas[posMenor]);

            int repMayor = 0;
            int repMenor = 0;

            for (int f = 0; f < notas.Length; f++)
            {
                if (notas[f] == notas[posMayor])
                    repMayor++;

                if (notas[f] == notas[posMenor])
                    repMenor++;
            }

            if (repMayor > 1)
                Console.WriteLine("La nota máxima se repite.");

            if (repMenor > 1)
                Console.WriteLine("La nota mínima se repite.");
        }

        static void Main(string[] args)
        {
            Estudiantes e = new Estudiantes();
            e.Cargar();
            e.Procesar();
        }
    }
}
