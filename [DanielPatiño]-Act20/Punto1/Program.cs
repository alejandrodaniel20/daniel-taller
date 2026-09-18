using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{   
    //Actividad 1: Sistema de control de vuelos
    //Problema:
    //Una aerolínea administra los vuelos programados mediante un sistema orientado a
    //objetos.
    //Plantear una clase base Vuelo que contenga como propiedades: número de vuelo,
    //destino y duración en horas.Luego definir una clase derivada VueloInternacional que
    //herede de Vuelo e incluya una propiedad adicional llamada paisDestino.
    //Crear una lista de objetos de tipo VueloInternacional, cargar 5 vuelos con sus datos
    //desde consola y luego:
    // Mostrar los vuelos registrados y el país de destino.
    // Informar cuál es el vuelo con mayor duración.
    // Mostrar el orden de ejecución de los constructores.
    class Vuelo
    {
        private int numeroVuelo, duracion;
        private string destino;

        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }
        public int NumeroVuelo
        {
            set { numeroVuelo = value; }
            get { return numeroVuelo; }
        }
        public int Duracion
        {
            set { duracion = value; }
            get { return duracion; }
        }
        public Vuelo()
        {
            string linea;
            Console.WriteLine("--------------------------");
            Console.WriteLine("clase actual: Vuelo");
            Console.WriteLine("--------------------------");
            Console.WriteLine("ingresa el numero de vuelo");
            linea = Console.ReadLine();
            numeroVuelo = int.Parse(linea);
            Console.WriteLine("ingresa la duracion en horas");
            linea = Console.ReadLine();
            duracion = int.Parse(linea);
            Console.WriteLine("ingresa el destino");
            destino = Console.ReadLine();
        }
    }
    class VueloInternacional : Vuelo
    {
        private string paisDestino;
        private int mayor;
        public string PaisDestino
        {
            set { paisDestino = value; }
            get { return paisDestino; }
        }
        public VueloInternacional()
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine("clase actual: VueloInternacional");
            Console.WriteLine("--------------------------");
            Console.WriteLine("escribe el pais del destino");
            paisDestino = Console.ReadLine();

        }
        static void Main(string[] args)
        {
            List<VueloInternacional> vuelosInternacionales = new List<VueloInternacional>();

            for (int i = 0; i < 5; i++)
            {
                VueloInternacional v = new VueloInternacional();
                vuelosInternacionales.Add(v);
            }
            int mayor = vuelosInternacionales[0].Duracion;
            Console.WriteLine("===  REGISTRO DE VUELOS  ===");
            Console.WriteLine("_________________________________________________________");
            foreach (Vuelo vuelo in vuelosInternacionales)
            {
                if (vuelo.Duracion > mayor)
                {
                    mayor = vuelo.Duracion;
                }
            }
            foreach (VueloInternacional vuelo in vuelosInternacionales)
            {
                Console.WriteLine("Numero de vuelo: " + vuelo.NumeroVuelo);
                Console.WriteLine("Duracion del vuelo: " + vuelo.Duracion);
                Console.WriteLine("destino del vuelo: " + vuelo.Destino);
                Console.WriteLine("pais del destino: " + vuelo.PaisDestino);
                if (vuelo.Duracion == mayor)
                {
                    Console.WriteLine("el vuelo de numero " + vuelo.NumeroVuelo + " fue uno de los que mas duró con " + mayor + " horas");
                }
                Console.WriteLine("__________________________________________________________");
            }
            Console.ReadKey();
        }
    }
}