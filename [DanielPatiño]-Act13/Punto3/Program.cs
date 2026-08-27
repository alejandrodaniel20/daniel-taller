using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{

    class Socio
    {
        /*3. Plantear una clase Club y otra clase Socio.
La clase Socio debe tener los siguientes atributos privados: nombre y la
antigüedad en el club (en años). En el constructor pedir la carga del nombre y
su antigüedad. La clase Club debe tener como atributos 3 objetos de la clase
Socio. Definir una responsabilidad para imprimir el nombre del socio con mayor
antigüedad en el club.*/

        private string nombre;
        private int antigüedad;
        public Socio()
        {

            string linea;
            Console.WriteLine("ingresa el nombre del socio");
            nombre = Console.ReadLine();
            Console.WriteLine("ahora ingresa su antigüedad en el club en años");
            linea = Console.ReadLine();
            antigüedad = int.Parse(linea);
        }
        public int retornarAntigüedad()
        {
            return antigüedad;
        }
        public string retornarNombre()
        {
            return nombre;
        }
    }
    class Club
    {
        private Socio socio1, socio2, socio3;
        private int mayor;
        private string nombreMayor;
        public Club()
        {
            socio1 = new Socio();
            socio2 = new Socio();
            socio3 = new Socio();
        }
        public void sacarMayor()
        {
            mayor = socio1.retornarAntigüedad();
            nombreMayor = socio1.retornarNombre();

            if (socio2.retornarAntigüedad() > mayor)
            {
                mayor = socio2.retornarAntigüedad();
                nombreMayor = socio2.retornarNombre();
            }
            if (socio3.retornarAntigüedad() > mayor)
            {
                mayor = socio3.retornarAntigüedad();
                nombreMayor = socio3.retornarNombre();
            }

        }
        public void mostrarMayor()
        {
            Console.WriteLine("el nombre del socio con mayor Antigüedad en el club es: " + nombreMayor);
        }
        static void Main(string[] args)
        {
            Club club = new Club();
            club.sacarMayor();
            club.mostrarMayor();
            Console.ReadKey();

        }
    }
}