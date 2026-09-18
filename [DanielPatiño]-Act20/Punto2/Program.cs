using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{   
    //Actividad 2: Administración de entregas logísticas
    //Problema:
    //Una empresa de envíos desea registrar sus entregas mediante colaboración de
    //clases.
    //Crear una clase Paquete con propiedades: código, peso y destino.Crear una clase
    //Despachador que contenga una lista de paquetes y un método para registrar nuevos
    //paquetes.
    //Desde el método Main, instanciar un Despachador, cargar 5 paquetes y mostrar:
    // Todos los paquetes registrados.
    // Cuántos superan los 10 kg de peso.
    // Cuántos tienen destino nacional (por ejemplo, “Argentina”).
    class Paquete
    {
        private int codigo;
        private float peso;
        private string destino;
        public int Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }
        public float Peso
        {
            set { peso = value; }
            get { return peso; }
        }
        public string Destino
        {
            set { destino = value; }
            get { return destino; }
        }

        public Paquete()
        {
            string linea;
            Console.WriteLine("ingrese el codigo del paquete");
            linea = Console.ReadLine();
            codigo = int.Parse(linea);
            Console.WriteLine("ingrese el peso del paquete en kilos");
            linea = Console.ReadLine();
            peso = float.Parse(linea);
            Console.WriteLine("ingrese el destino");
            destino = Console.ReadLine();
        }
    }
    class Despachador
    {
        List<Paquete> paquetes = new List<Paquete>();

        public List<Paquete> Paquetes
        {
            set { paquetes = value; }
            get { return paquetes; }
        }

        public void cargarPaquete()
        {
            Paquete p = new Paquete();
            paquetes.Add(p);
        }
        static void Main(string[] args)
        {
            Despachador despachador = new Despachador();
            despachador.cargarPaquete();
            despachador.cargarPaquete();
            despachador.cargarPaquete();
            despachador.cargarPaquete();
            despachador.cargarPaquete();
            int cantidad = 0;
            int cantidadNacional = 0;
            foreach (Paquete paquete in despachador.Paquetes)
            {
                Console.WriteLine("el codigo del paquete es: " + paquete.Codigo + " y su peso es de " + paquete.Peso + " kilos. con destino a " + paquete.Destino);
                if (paquete.Peso > 10)
                {
                    cantidad++;
                }
                if (paquete.Destino == "Argentina")
                {
                    cantidadNacional++;
                }
            }
            Console.WriteLine("la cantidad de paquetes que superan los 10 kilos son " + cantidad);
            Console.WriteLine("la cantidad de paquetes que son de destino nacional son " + cantidadNacional);
            Console.ReadKey();
        }
    }
}
