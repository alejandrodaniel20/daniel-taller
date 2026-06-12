using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{
        //Plantear una clase llamada Articulo que tenga como atributos privados el NombreArticulo, el Precio y el StockActual. El constructor de la clase debe cargar estos atributos por teclado.
        //Confeccionar otra clase llamada Sucursal que contenga un vector de 3 objetos de la clase Articulo. El constructor de Sucursal debe pedir el nombre o número de la sucursal y realizar la carga de los 3 artículos.
        //Implementar en la clase Sucursal los siguientes métodos:
        //Un método que imprima la lista de los artículos junto con su valor total en inventario (Precio * Stock).
        //Un método que busque y muestre el nombre del artículo más caro del local.
        //Un método que verifique e indique qué artículos de la sucursal requieren reposición urgente (aquellos cuyo stock sea menor o igual a 5 unidades).
        
    internal class articulo
    {
        private string nombre;
        private int precio, stockactual;
        public articulo()
        {
            Console.WriteLine("ingrese el nombre del articulo: ");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el precio del articulo: ");
            precio = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de articulos que hay: ");
            stockactual = int.Parse(Console.ReadLine());
        }
        public string nombreart()
        {
            return nombre;
        }
        public int prec()
        {
            return precio;
        }
        public int inventario()
        {
            int inventario = 0;
            inventario = precio * stockactual;
            return inventario;
        }
        public bool repo()
        {
            if (stockactual <= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class sucursal
    {
        private articulo[] producto;
        private string nombre;
        public sucursal()
        {
            producto = new articulo[3];
            for (int i = 0; i < 3; i++)
            {
                producto[i] = new articulo();
            }
            Console.WriteLine("ingrese el nombre de la sucursal: ");
            nombre = Console.ReadLine();
        }
        public void inventario()
        {
            Console.WriteLine("en la sucursal " + nombre);
            for (int i = 0; i < producto.Length; i++)
            {
                Console.WriteLine("el ariculo " + producto[i].nombreart() + " su inventario cuesta " + producto[i].inventario());
            }
        }
        public void articulocaro()
        {
            int mayor = producto[0].prec();
            string nombre = producto[0].nombreart();
            for (int i = 1; i < producto.Length; i++)
            {
                if (mayor < producto[i].prec())
                {
                    mayor = producto[i].prec();
                    nombre = producto[i].nombreart();
                }
            }
            Console.WriteLine("el articulo mas caro es " + nombre + " con un precio de " + mayor);
        }
        public void reposicion()
        {
            for (int i = 0; i < producto.Length; i++)
            {
                if (producto[i].repo())
                {
                    Console.WriteLine("el articulo " + producto[i].nombreart() + " necesita reposicion");
                }
            }
        }
        static void Main(string[] args)
        {
            sucursal s = new sucursal();
            s.inventario();
            s.articulocaro();
            s.reposicion();
            Console.ReadKey();
        }
    }
}
