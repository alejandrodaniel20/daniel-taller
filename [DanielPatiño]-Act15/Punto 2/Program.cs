using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    //2. Logística de Puerto Espacial
    //Una estación de acoplamiento registra el peso de los contenedores transportados en las
    //bodegas de carga de las naves espaciales que llegan al puerto.
    //● Crear la clase NaveEspacial que contenga únicamente el atributo privado
    //NombreNave y su constructor para cargarlo.
    //● Crear la clase colaboradora PuertoControl que contenga:
    //○ Un vector de 3 objetos de la clase NaveEspacial.
    //○ Una matriz irregular de tipo double llamado pesoContenedores, donde
    //cada fila representa a una nave, el tamaño de la fila es la cantidad de
    //bodegas que posee esa nave, y los valores almacenados son los pesos (en
    //toneladas) de los contenedores que transporta cada bodega.
    //En PuertoControl, definir los siguientes métodos:
    //1. Un constructor que cargue los nombres de las 3 naves, pregunte para cada una
    //cuántas bodegas activas posee (para definir el tamaño de su fila en la matriz
    //irregular) y cargue el peso del contenedor asignado a cada bodega.
    //2. Un método que muestre en pantalla el detalle de los pesos cargados por cada nave
    //espacial.
    //3. Un método que identifique e informe qué nave transporta el contenedor individual
    //más pesado de todo el puerto espacial (el valor máximo absoluto de la matriz
    //irregular).
    //4. Un método que indique el nombre de la nave que transporta menor peso acumulado
    //total(la suma de todos sus contenedores).
    class NaveEspacial
    {
        private string nombreNave;
        public NaveEspacial()
        {
            Console.WriteLine("escribe el nombre de la nave");
            nombreNave = Console.ReadLine();
        }
        public string devolverNombre()
        {
            return nombreNave;
        }
    }

    class PuertoControl
    {
        NaveEspacial[] naves;
        float[][] matrizPesos;
        public PuertoControl()
        {
            string linea;
            matrizPesos = new float[3][];
            naves = new NaveEspacial[3];
            for (int i = 0; i < naves.Length; i++)
            {
                naves[i] = new NaveEspacial();
            }
            for (int i = 0; i < naves.Length; i++)
            {
                Console.WriteLine("escribe ahora la cantidad de bodegas que tendrá la nave " + naves[i].devolverNombre());
                linea = Console.ReadLine();
                matrizPesos[i] = new float[int.Parse(linea)];
            }
            for (int i = 0; i < matrizPesos.GetLength(0); i++)
            {
                for (int f = 0; f < matrizPesos[i].Length; f++)
                {
                    Console.WriteLine("escribe ahora el peso (en toneladas) que tendrá la nave " + naves[i].devolverNombre() + " en la bodega numero " + f);
                    linea = Console.ReadLine();
                    matrizPesos[i][f] = float.Parse(linea);
                }
            }
        }

        public void mostrarDetalles()
        {

            for (int i = 0; i < matrizPesos.GetLength(0); i++)
            {

                Console.WriteLine("los pesos de cada bodega de la nave " + naves[i].devolverNombre() + " son...");
                for (int f = 0; f < matrizPesos[i].Length; f++)
                {
                    Console.WriteLine("bodega numero " + f + ": " + matrizPesos[i][f] + " Toneladas");
                }
                Console.WriteLine();
            }

        }

        public void pesoMasGrande()
        {
            float mayorValor = matrizPesos[0][0];
            for (int i = 0; i < matrizPesos.GetLength(0); i++)
            {
                for (int f = 0; f < matrizPesos[i].Length; f++)
                {
                    if (matrizPesos[i][f] > mayorValor)
                    {
                        mayorValor = matrizPesos[i][f];
                    }
                }
            }
            for (int i = 0; i < matrizPesos.GetLength(0); i++)
            {
                for (int f = 0; f < matrizPesos[i].Length; f++)
                {
                    if (matrizPesos[i][f] == mayorValor)
                    {
                        Console.WriteLine("la nave " + naves[i].devolverNombre() + "tiene el peso mas grande en todo el puerto espacial con " + matrizPesos[i][f] + " toneladas");
                    }
                }
            }

        }

        public void menorPesoAcumulado()
        {
            float sumaValores;
            float sumaValoresAuxiliar = 0;
            float menorValor = 0;
            string nombre = "";
            for (int i = 0; i < matrizPesos.GetLength(0); i++)
            {
                sumaValores = 0;
                for (int f = 0; f < matrizPesos[i].Length; f++)
                {
                    sumaValores += matrizPesos[i][f];
                }

                if (sumaValores < sumaValoresAuxiliar || i == 0)
                {
                    menorValor = sumaValores;
                    nombre = naves[i].devolverNombre();
                }

                sumaValoresAuxiliar = sumaValores;
            }

            Console.WriteLine("la nave con el peso acumulado mas pequeño es: " + nombre + " con " + menorValor + " toneladas");
        }
        static void Main(string[] args)
        {
            PuertoControl pc = new PuertoControl();
            pc.mostrarDetalles();
            pc.pesoMasGrande();
            pc.menorPesoAcumulado();
            Console.ReadKey();
        }
    }
}