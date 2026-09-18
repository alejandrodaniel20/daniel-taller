using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_1
{

    class DispositivoEnergia
    {
        /*1.
        Confeccionar una clase llamada DispositivoEnergia que tenga como atributos privados el
        CodigoIdentificador (string) y la GeneracionKwh (double, que representa los Kilowatts-hora
        generados). Definir sus respectivas propiedades de lectura y escritura, validando que la
        generación no sea un valor negativo (en caso de serlo, asignarle 0). Plantear un método para
        imprimir estos datos básicos.
        Luego, crear una segunda clase llamada PanelSolar que herede de DispositivoEnergia. Añadir
        un atributo propio privado llamado AreaMetros (double, que representa la superficie del panel
        en metros cuadrados) con su propiedad correspondiente (validando que sea mayor a cero).
        Implementar un método para imprimir todos los datos del panel, incluyendo los heredados.
        En el programa principal (Main):
        ● Crear un objeto de la clase DispositivoEnergia, ingresar valores y probar su impresión.
        ● Crear un objeto de la clase PanelSolar, cargar sus datos por consola y comprobar que
        puede acceder tanto a sus propiedades heredadas como a las propias para realizar la
        muestra de información.*/
        private string codigoIdentificador;
        private double generacionKwh;

        public string CodigoIdentificador
        {
            set { codigoIdentificador = value; }
            get { return codigoIdentificador; }
        }
        public double GeneracionKwh
        {
            set { generacionKwh = value; }
            get { return generacionKwh; }
        }
        public DispositivoEnergia()
        {

            string linea;
            Console.WriteLine("escribe  el codigo identificador");
            codigoIdentificador = Console.ReadLine();
            Console.WriteLine("escribe ahora la generacion de kilowatts en una hora (si se coloca un numero negativo se pondrá '0' por defecto)");
            linea = Console.ReadLine();
            generacionKwh = int.Parse(linea);
            if (generacionKwh < 0)
            {
                generacionKwh = 0;
            }
        }




        public void imprimir()
        {

            Console.WriteLine("su codigo identificador es: " + CodigoIdentificador);
            Console.WriteLine("su generacion de killowatts por hora es de " + GeneracionKwh);
        }
    }


    class PanelSolar : DispositivoEnergia
    {
        private double areaMetros;
        string linea;
        public PanelSolar()
        {

            Console.WriteLine("escribe ahora el area que tiene el panel solar en metros (tiene que ser mayor a 0)");
            for (int i = 0; i < 1; i++)
            {
                linea = Console.ReadLine();
                areaMetros = double.Parse(linea);
                if (areaMetros > 0)
                {
                    Console.WriteLine("Muy bien");
                }
                else
                {

                    Console.WriteLine("lo que pusiste es 0 o algo menor, intenta de nuevo");
                    i--;
                }
            }
        }



        public void imprimirArea()
        {
            Console.WriteLine("su Area en metros es de " + areaMetros);
        }

        static void Main(string[] args)
        {

            DispositivoEnergia dispositivo = new DispositivoEnergia();

            PanelSolar panelSolar = new PanelSolar();
            dispositivo.imprimir();
            panelSolar.imprimir();
            panelSolar.imprimirArea();
            Console.ReadKey();
        }
    }
}
