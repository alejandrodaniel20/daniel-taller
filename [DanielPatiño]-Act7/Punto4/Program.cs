using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    //Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
    //ordenado de menor a mayor y de mayor a menor.

    internal class elementos
    {
        private int[] vector;

        public void cargar()
        {
            vector = new int[10];
            string linea;
            for (int i = 0; i < 10; i++) {
                Console.Write("ingrese un numero");
                linea = Console.ReadLine();
                vector[i] = int.Parse(linea);
            }
        }

        public void Mayoramenor()
        {
            bool mayoramenor = true;
            int auxiliar = vector [0];

            for (int i = 1; i < 10; i++)
            {

                if (vector[i] <= auxiliar)
                {
                    auxiliar = vector[i];
                }
                else
                {
                    mayoramenor = false;

                }
            }
                if (mayoramenor == false)
                {

                    Console.WriteLine("no esta ordenado de mayor a menor");

                }
                else {

                    Console.WriteLine("esta ordenado de mayor a menor");

                    }

            }
        
        

        public void MenoraMayor (){
            
             bool menoramayor = true;
             int auxiliar = vector[0];

            for (int i = 1; i < 10; i++)

            {
                if (vector[i] >= auxiliar)
                {
                    auxiliar = vector[i];
                }

                else
                {
                    menoramayor = false;
                }
            }
                if (menoramayor == false)
                {
                    Console.WriteLine("No esta ordenado de menor a mayor");
                }

                else
                {
                    Console.WriteLine("Esta ordenado de menor a mayor ");
                }




            }



        


        static void Main(string[] args)
        {
            elementos el = new elementos();
            el.cargar();
            el.MenoraMayor();
            el.Mayoramenor();
        }
    }
}
