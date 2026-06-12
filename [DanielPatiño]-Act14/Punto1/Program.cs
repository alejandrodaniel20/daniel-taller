using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
{
        //    Plantear una clase llamada Vehiculo y otra clase llamada CabinaPeaje.
        //La clase Vehiculo debe tener los siguientes atributos privados:
        //Patente (de tipo string).
        //Tipo (puede ser "Auto", "Camion" o "Moto").
        //Tarifa (un valor decimal que representa el costo de su pase).
        //El constructor de Vehiculo debe solicitar y cargar estos tres datos por teclado.
        //La clase CabinaPeaje debe tener como atributos privados:
        //El número o identificador de la cabina.
        //Tres objetos de la clase Vehiculo (que representan los últimos 3 vehículos que pagaron en esa cabina).
        //Definir en la clase CabinaPeaje un constructor para inicializar su identificador y solicitar la carga de los 3 vehículos. Además, implementar los siguientes métodos dentro de CabinaPeaje:
        //Un método que imprima la patente y el tipo de los 3 vehículos registrados en la cabina.
        //Un método que calcule y muestre la recaudación total acumulada por esos 3 vehículos.
        //Un método que muestre la patente del vehículo que pagó la tarifa más cara.
    internal class vehiculo
    {
        private string patente, tipo;
        private double tarifa;
        public vehiculo()
        {
            string linea;
            bool valorcorrecto = true;
            Console.Write("inrese la patente del vehiculo: ");
            patente = Console.ReadLine();
            do
            {
                Console.Write("ingrese el tipo de vehiculo: ");
                linea = Console.ReadLine();
                if (linea == "auto" || linea == "camion" || linea == "moto")
                {
                    tipo = Console.ReadLine();
                    valorcorrecto = false;
                }
            }
            while (valorcorrecto);
            Console.Write("ingrese la tarifa: ");
            linea = Console.ReadLine();
            tarifa = double.Parse(linea);
        }
        public void Imprimir()
        {
            Console.WriteLine("Patente: " + patente);
            Console.WriteLine("Tipo: " + tipo);
        }
        public double tarifatotal()
        {
            return tarifa;
        }
    }
    class cabinapeaje
    {
        private int codigo;
        private vehiculo auto1, auto2, auto3;
        public cabinapeaje()
        {
            Console.Write("ingrese el codigo de cabina: ");
            codigo = int.Parse(Console.ReadLine());
            auto1 = new vehiculo();
            auto2 = new vehiculo();
            auto3 = new vehiculo();
        }
        public void imprimirtipo()
        {
            Console.WriteLine("en la cabina " + codigo);
            auto1.Imprimir();
            auto2.Imprimir();
            auto3.Imprimir();

        }
        public void recaudacion()
        {
            double suma = 0;
            suma = auto1.tarifatotal();
            suma = suma + auto2.tarifatotal();
            suma = suma + auto3.tarifatotal();
            Console.WriteLine("la recaudacion total es: " + suma);
        }
        public void TarifaCara()
        {
            if (auto1.tarifatotal() > auto2.tarifatotal() && auto1.tarifatotal() > auto3.tarifatotal())
            {
                Console.WriteLine("El que pagó mayor tarifa es: " + auto1.tarifatotal());

            }
            if (auto2.tarifatotal() > auto1.tarifatotal() & auto2.tarifatotal() > auto3.tarifatotal())
            {
                Console.WriteLine("El que pagó mayor tarifa es: " + auto2.tarifatotal());
            }
            else
            {
                Console.WriteLine("El que pagó mayor tarifa es: " + auto3.tarifatotal());
            }
        }
        static void Main(string[] args)
        {
        
            cabinapeaje p = new cabinapeaje();
            p.imprimirtipo();
            p.recaudacion();
            p.TarifaCara();
            Console.ReadKey();
        }
    }
}
