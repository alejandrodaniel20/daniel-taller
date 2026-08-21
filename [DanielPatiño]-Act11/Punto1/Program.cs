using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
 {  // 1. Se desea saber la temperatura media trimestral de cuatro paises.Para ello se tiene como
    //dato las temperaturas medias mensuales de dichos paises.
    //Se pide ingresar el nombre del país y seguidamente las tres temperaturas medias
    //mensuales.
    //Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en
    //memoria.
    //a.Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.
    //b.Imprimir los nombres de las paises y las temperaturas medias mensuales de las
    //mismas.
    //c.Calcular la temperatura media trimestral de cada país.
    //d.Imprimir los nombres de los paises y las temperaturas medias trimestrales.
    //e.Imprimir el nombre del país con la temperatura media trimestral mayor.
    internal class Program
    {
        private string[] paises;
        private int[,] temperatura;
        private float[] mediastrimetrales;

        public void cargar()
        {
            paises = new string[4];
            temperatura = new int[4,3];


            for (int f = 0; f < paises.Length; f++)
            {
                Console.WriteLine("----------------------------------------");
                Console.Write("Ingrese pais: ");
                string linea;
                linea = Console.ReadLine();
                paises[f] = linea;
            
                for (int i = 0; i < temperatura.GetLength(1); i++)
                {
                    Console.Write("Ingrese temperatura mensual" + (i+1) + ": ");
                    linea = Console.ReadLine();
                    temperatura[f, i] = int.Parse(linea);
                    
                }
            }
            
        }
       
        public void imprimirtemperatura()
        {
              Console.WriteLine("----------------------------------------");
            Console.WriteLine("Paises y sus temperaturas mensuales");
            for (int f = 0; f < temperatura.GetLength(0); f++)
            {
                Console.Write(paises[f] + " = ");
                for (int i = 0; i < temperatura.GetLength(1); i++)
                {
                    Console.Write(temperatura[f,i] + ": ");
                }

            }

            Console.WriteLine();


        }
        
        public void calcularmediatrimestral()
        {
            
            mediastrimetrales = new float[4];
            for (int f = 0; f < temperatura.GetLength(0); f++)
            {
                int suma = 0;
                for (int i = 0; i < temperatura.GetLength(1); i++)
                {
                    suma = suma + temperatura[f, i];
                }

                mediastrimetrales[f] = (float)suma / 3;
                
            }
           
        }
        
        public void imprimirmediastrimestrales()
        {
             Console.WriteLine();
            Console.WriteLine("paises y sus medias trimetrales: ");
            for (int f = 0; f < mediastrimetrales.Length; f++)
            {
                Console.WriteLine(paises[f] + ":" + mediastrimetrales[f]);
            }
            
            
        }
        
        public void paismayormedia()
        {
            Console.WriteLine();
            float mayor = mediastrimetrales[0];
            string paismayor = paises[0];

            for (int f = 1; f < mediastrimetrales.Length; f++)
            {
                if (mediastrimetrales[f] > mayor)
                {
                    mayor = mediastrimetrales[f];
                    paismayor = paises[f];
                }
            }
            Console.WriteLine("el pais con la mayor temperatura media trimestral es: " + paismayor);
        
            
        }
        
        
        static void Main(string[] args)
        {
            Program p = new Program();
            p.cargar();
            p.imprimirtemperatura();
            p.calcularmediatrimestral();
            p.imprimirmediastrimestrales();
            p.paismayormedia();
            Console.ReadKey();
        }
    }
}
