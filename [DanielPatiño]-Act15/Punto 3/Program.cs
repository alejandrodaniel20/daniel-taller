using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace punto_3
{   
    //3. Geolocalización de Reservas Naturales
    //Un centro de ecología realiza mapeos de biodiversidad para contabilizar el avistamiento de
    //especies protegidas en cuadrículas de territorio.
    //● Confeccionar la clase ReservaNatural que tenga como atributos privados el
    //NombreReserva y una matriz llamada avistamientos de 3x3(que representa un
    //mapa de coordenadas o sectores de 3 filas y 3 columnas, donde se almacena la
    //cantidad de animales avistados en cada sector). El constructor de la clase debe
    //cargar por teclado el nombre y rellenar el mapa de avistamientos.
    //● Confeccionar la clase colaboradora CentroEcologico que contenga un vector de 3
    //objetos de la clase ReservaNatural.
    //La clase CentroEcologico debe implementar los siguientes métodos:
    //1. Un constructor que solicite la carga secuencial de las 3 reservas.
    //2. Un método que enliste cada reserva junto a la cantidad total de avistamientos que
    //registró en toda su superficie(la suma de toda su matriz rectangular).
    //3. Un método que determine e informe cuál fue la coordenada o sector específico([fila,
    //columna]) que registró la mayor concentración de avistamientos de toda la red de
    //reservas, indicando a qué reserva pertenece.
    class ReservaNatural
    {
        private string nombreReserva;
        private int[,] avistamientos;

        public ReservaNatural()
        {
            string linea;
            avistamientos = new int[3, 3];
            Console.WriteLine("escribe el nombre de la reserva: ");
            nombreReserva = Console.ReadLine();
            for (int i = 0; i < avistamientos.GetLength(0); i++)
            {
                for (int f = 0; f < avistamientos.GetLength(1); f++)
                {
                    Console.WriteLine("escribe por favor el numero de avistamientos que se hicieron en el sector de la fila numero " + i + " con la columna numero " + f);
                    linea = Console.ReadLine();
                    avistamientos[i, f] = int.Parse(linea);
                }
            }
        }

        public string devolverNombre()
        {
            return nombreReserva;
        }
        public int[,] devolverAvistamientos()
        {
            return avistamientos;
        }
    }

    class CentroEcologico
    {
        ReservaNatural[] reservas;

        public CentroEcologico()
        {
            reservas = new ReservaNatural[3];
            for (int i = 0; i < reservas.Length; i++)
            {
                reservas[i] = new ReservaNatural();
            }
        }

        public void mostrarAvistamientos()
        {
            int sumaTotal = 0;
            for (int i = 0; i < reservas.Length; i++)
            {
                sumaTotal = 0;
                int[,] avistamientos = new int[3, 3];
                avistamientos = reservas[i].devolverAvistamientos();
                for (int f = 0; f < avistamientos.GetLength(0); f++)
                {
                    for (int y = 0; y < avistamientos.GetLength(1); y++)
                    {
                        sumaTotal += avistamientos[f, y];
                    }
                }
                Console.WriteLine("la reserva " + reservas[i].devolverNombre() + " tuvo " + sumaTotal + " avistamientos totales");
            }
        }

        public void masAvistamientos()
        {
            int mayor = -1;
            int filaMayor = -1;
            int columnaMayor = -1;
            string nombreReserva = "";
            for (int i = 0; i < reservas.Length; i++)
            {
                int[,] avistamientos = new int[3, 3];
                avistamientos = reservas[i].devolverAvistamientos();

                for (int f = 0; f < avistamientos.GetLength(0); f++)
                {
                    for (int y = 0; y < avistamientos.GetLength(1); y++)
                    {
                        if (avistamientos[f, y] > mayor)
                        {
                            mayor = avistamientos[f, y];
                            filaMayor = f;
                            columnaMayor = y;
                            nombreReserva = reservas[i].devolverNombre();
                        }
                    }
                }
            }

            Console.WriteLine("la reserva " + nombreReserva + " tuvo la cantidad mas grande de todas las reservas con " + mayor + " y fue en la fila " + filaMayor + " y columna " + columnaMayor);
        }

        static void Main(string[] args)
        {
            CentroEcologico centro = new CentroEcologico();
            centro.mostrarAvistamientos();
            centro.masAvistamientos();
            Console.ReadKey();
        }
    }
}