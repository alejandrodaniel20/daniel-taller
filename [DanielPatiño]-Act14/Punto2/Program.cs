using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
        //Plantear una clase llamada Pasajero que tenga los atributos privados: Nombre, DNI y EquipajeKilos (peso del equipaje en kg). En su constructor, solicitar la carga de estos tres datos.
        //Luego, confeccionar una clase llamada Vuelo que administre un vector de 4 objetos de la clase Pasajero. Su constructor debe inicializar el vector y solicitar la carga por teclado de cada uno de los 4 pasajeros.
        //Agregar los siguientes métodos en la clase Vuelo:
        //Un método que muestre un listado completo con los datos de todos los pasajeros del vuelo.
        //Un método que calcule y muestre el peso total de equipaje que transporta el avión (la suma de todos los pesos).
        //Un método que informe si algún pasajero excede el límite permitido de equipaje (mayor a 23 kg), imprimiendo su nombre y su DNI.
    internal class pasajero
    {
        private string nombre;
        private int DNI;
        private double equipajekilos;
        public pasajero()
        {
            string linea;
            Console.Write("ingrese el nombre del pasajero: ");
            nombre = Console.ReadLine();
            Console.Write("ingrese el DNI del pasajero: ");
            linea = Console.ReadLine();
            DNI = int.Parse(linea);
            Console.Write("ingrese el peso del equipaje del pasajero: ");
            linea = Console.ReadLine();
            equipajekilos = double.Parse(linea);
        }
        public string nombrepasajero()
        {
            return nombre;
        }
        public int DNIpasajero()
        {
            return DNI;
        }
        public double peso()
        {
            return equipajekilos;
        }
        public bool pesomayor()
        {
            if (equipajekilos > 23)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class vuelo
    {
        private pasajero[] pasa;
        public vuelo()
        {
            pasa = new pasajero[4];
            for (int i = 0; i < 4; i++)
            {
                pasa[i] = new pasajero();
            }
        }
        public void imprimir()
        {
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("nombre pasajero:" + pasa[i].nombrepasajero() + ". DNI pasajero:" + pasa[i].DNIpasajero() + ". Peso del equipaje del pasajero:" + pasa[i].peso());
            }
        }
        public void pesototal()
        {
            double suma = 0;
            for (int i = 0; i < 4; i++)
            {
                suma = suma + pasa[i].peso();
                Console.WriteLine("el peso total es de: " + suma);
            }
        }
        public void excede()
        {
            for (int i = 0; i < 4; i++)
            {
                if (pasa[i].pesomayor() == true)
                {
                    Console.WriteLine("el pasajero que excede es " + pasa[i].nombrepasajero() + " y su DNI es " + pasa[i].DNIpasajero());
                }
            }
        }
        static void Main(string[] args)
        {
        
            vuelo vuelo = new vuelo();
            vuelo.imprimir();
            vuelo.pesototal();
            vuelo.excede();
            Console.ReadKey();
        }
    }
}
