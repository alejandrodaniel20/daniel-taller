using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    //3. Crear una clase base Vehículo que contenga atributos marca y
    //velocidadMaxima.
    //Definir dos clases derivadas: Auto y Moto, que hereden de Vehículo.Cada
    //una debe tener un constructor que reciba los valores de los atributos base
    //mediante la palabra clave base, y un atributo propio (cantidadPuertas en
    //Auto, cilindrada en Moto).
    //Crear un objeto de cada clase y mostrar todos sus datos por consola.
    class Vehiculo
    {
        private string marca;
        private float velocidadMaxima;
        private string linea;
        public Vehiculo(string marcaPuesta, float velocidadPuesta)
        {
            marca = marcaPuesta;

            velocidadMaxima = velocidadPuesta;
        }
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public float VelocidadMaxima
        {
            set { velocidadMaxima = value; }
            get { return velocidadMaxima; }
        }


    }

    class Moto : Vehiculo
    {

        private int cilindrada;
        private string linea;
        public Moto(string marca, float velocidadMaxima, int cilindrada) : base(marca, velocidadMaxima)
        {
            this.cilindrada = cilindrada;
        }
        public int Cilindrada
        {
            set { cilindrada = value; }
            get { return cilindrada; }
        }
        public void imprimir()
        {
            Console.WriteLine(base.Marca);
            Console.WriteLine(base.VelocidadMaxima);
            Console.WriteLine(this.Cilindrada);
        }
    }

    class Auto : Vehiculo
    {
        private string linea;
        private int numeroPuertas;
        public Auto(string marca, float velocidadMaxima, int numeroPuertas) : base(marca, velocidadMaxima)
        {
            this.numeroPuertas = numeroPuertas;

        }
        public int NumeroPuertas
        {
            set { numeroPuertas = value; }
            get { return numeroPuertas; }
        }
        public void imprimir()
        {
            Console.WriteLine(base.Marca);
            Console.WriteLine(base.VelocidadMaxima);
            Console.WriteLine(this.NumeroPuertas);
        }
        static void Main(string[] args)
        {

            Moto moto = new Moto("BMW", 120, 12);
            Auto auto = new Auto("Tesla", 200, 12);
            moto.imprimir();
            auto.imprimir();
            Console.ReadKey();
        }
    }
}