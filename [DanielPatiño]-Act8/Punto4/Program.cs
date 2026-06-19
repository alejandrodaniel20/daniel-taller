using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //4. Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
    //habitantes de este.Ordenar alfabéticamente e imprimir los resultados.Por último
    //ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
    //nuevamente.
    class PaisesHabitantes
    {
        private string[] paises;
        private int[] habitantes;

        public void Cargar()
        {
            paises = new string[5];
            habitantes = new int[5];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese país: ");
                paises[i] = Console.ReadLine();

                Console.Write("Ingrese habitantes: ");
                habitantes[i] = int.Parse(Console.ReadLine());
            }
        }

        public void OrdenarAlfabetico()
        {
            for (int i = 0; i < paises.Length - 1; i++)
            {
                for (int k = i + 1; k < paises.Length; k++)
                {
                    if (string.Compare(paises[i], paises[k]) > 0)
                    {
                        string auxPais = paises[i];
                        paises[i] = paises[k];
                        paises[k] = auxPais;

                        int auxHab = habitantes[i];
                        habitantes[i] = habitantes[k];
                        habitantes[k] = auxHab;
                    }
                }
            }
        }

        public void OrdenarHabitantes()
        {
            for (int i = 0; i < habitantes.Length - 1; i++)
            {
                for (int k = i + 1; k < habitantes.Length; k++)
                {
                    if (habitantes[i] < habitantes[k])
                    {
                        int auxHab = habitantes[i];
                        habitantes[i] = habitantes[k];
                        habitantes[k] = auxHab;

                        string auxPais = paises[i];
                        paises[i] = paises[k];
                        paises[k] = auxPais;
                    }
                }
            }
        }

        public void Imprimir()
        {
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i] + " - " + habitantes[i]);
            }
        }

        static void Main(string[] args)
        {
            PaisesHabitantes ph = new PaisesHabitantes();

            ph.Cargar();

            Console.WriteLine("\nOrden alfabético:");
            ph.OrdenarAlfabetico();
            ph.Imprimir();

            Console.WriteLine("\nOrden por habitantes:");
            ph.OrdenarHabitantes();
            ph.Imprimir();
        }
    }
}
