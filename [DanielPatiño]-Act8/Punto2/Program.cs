using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{
    //2. Definir un vector donde almacenar los nombres de 5 países.Confeccionar el
    //algoritmo de ordenamiento alfabético.
    class PaisesOrdenados
    {
        private string[] paises;

        public void Cargar()
        {
            paises = new string[5];

            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese país: ");
                paises[i] = Console.ReadLine();
            }
        }

        public void Ordenar()
        {
            for (int i = 0; i < paises.Length - 1; i++)
            {
                for (int k = i + 1; k < paises.Length; k++)
                {
                    if (paises[i]. CompareTo (paises[k]) > 0)
                    {
                        string aux = paises[i];
                        paises[i] = paises[k];
                        paises[k] = aux;
                    }
                }
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("Países ordenados:");

            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine(paises[i]);
            }
        }

        static void Main(string[] args)
        {
            PaisesOrdenados po = new PaisesOrdenados();
            po.Cargar();
            po.Ordenar();
            po.Imprimir();
            Console.ReadKey();
        }
    }
}
