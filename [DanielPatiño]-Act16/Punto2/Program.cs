using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{   
    //2. Plantear una clase Producto y otra clase Inventario.
    //La clase Producto debe tener como atributos privados el nombre, precio y
    //stock.Definir propiedades para acceder a estos atributos, asegurando que el
    //stock no pueda ser negativo y el precio sea mayor a cero.
    //La clase Inventario debe contener 3 objetos de la clase Producto.Definir un
    //método para mostrar todos los productos ordenados de menor a mayor en
    //base al precio, además, mostrar el producto más caro y más barato del
    //inventario.
    class Producto
    {
        protected string nombre;
        protected int stock;
        protected float precio;
        public Producto()
        {
            string linea;
            Console.WriteLine("ingresa el nombre del producto:");
            nombre = Console.ReadLine();
            Console.WriteLine("escribe ahora su cantidad de stock");
            for (int i = 0; i < 1; i++)
            {
                linea = Console.ReadLine();
                stock = int.Parse(linea);
                if (stock < 0)
                {
                    Console.WriteLine("no están permitidos los valores negativos");
                    i--;
                }
            }
            for (int i = 0; i < 1; i++)
            {
                Console.WriteLine("escribe su precio");
                linea = Console.ReadLine();
                precio = int.Parse(linea);
                if (precio <= 0)
                {
                    Console.WriteLine("no están permitidos los valores negativos ni 0");
                    i--;
                }
            }
        }
        public string Nombre
        {
            set
            {
                nombre = value;
            }
            get
            {
                return nombre;
            }
        }
        public int Stock
        {
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    Console.WriteLine("no se puede tener Stock negativo");

                }
            }
            get
            {
                return stock;
            }
        }
        public float Precio
        {
            set
            {
                if (value > 0)
                {
                    precio = value;
                }
                else
                {
                    Console.WriteLine("no se pueden tener precios iguales o menores a 0");
                }
            }
            get
            {
                return precio;
            }
        }
    }
    class Inventario
    {
        Producto[] productos;
        private float masChico;
        private float masGrande;
        public Inventario()
        {
            productos = new Producto[3];
            for (int i = 0; i < productos.Length; i++)
            {
                productos[i] = new Producto();
            }
        }
        public void mostrarPorOrden()
        {
            for (int i = 0; i < productos.Length; i++)
            {
                for (int f = 0; f < productos.Length - i - 1; f++)
                {
                    if (productos[f].Precio > productos[f + 1].Precio)
                    {
                        Producto temporal = productos[f + 1];
                        productos[f + 1] = productos[f];
                        productos[f] = temporal;
                    }

                }
            }

            for (int i = 0; i < productos.Length; i++)
            {
                Console.WriteLine("producto: " + productos[i].Nombre + ". Precio: " + productos[i].Precio + " con un stock de: " + productos[i].Stock);
            }
        }
        public void masBarato()
        {
            masChico = productos[0].Precio;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Precio < masChico)
                {
                    masChico = productos[i].Precio;
                }
            }
        }
        public void masCaro()
        {
            masGrande = productos[0].Precio;
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Precio > masGrande)
                {
                    masGrande = productos[i].Precio;
                }
            }
        }
        public void mostrar()
        {
            for (int i = 0; i < productos.Length; i++)
            {
                if (productos[i].Precio == masChico)
                {
                    Console.WriteLine("el producto con el precio mas chico es: " + productos[i].Nombre);
                }
                if (productos[i].Precio == masGrande)
                {
                    Console.WriteLine("el producto con el precio mas grande es: " + productos[i].Nombre);
                }
            }

        }
        static void Main(string[] args)
        {
            Inventario inv = new Inventario();
            inv.mostrarPorOrden();
            inv.masBarato();
            inv.masCaro();
            inv.mostrar();
            Console.ReadKey();
        }
    }
}
