using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace punto_3
{
    /*3.
    Crear una clase base llamada SondaExploradora que contenga los atributos Modelo (string) y
    AutonomiaMinutos (int). Definir un constructor que reciba estos dos valores como parámetros y
    realice su asignación.
    Luego, definir dos clases derivadas de la clase base:
    ● SondaSubmarina: que añade el atributo propio PresionMaximaAtm (int, presión máxima
    soportada en atmósferas).
    ● RoverTerrestre: que añade el atributo propio CantidadRuedas (int).
    Cada una de estas clases derivadas debe poseer su propio constructor. El mismo debe recibir
    tanto el atributo específico como los heredados de la clase base, transfiriendo estos últimos a la
    clase SondaExploradora mediante el uso explícito de la palabra clave base.
    En el método Main, instanciar un objeto de cada clase derivada y mostrar la totalidad de sus
    parámetros unificados por consola.*/
    class SondaExploradora
    {
        private string modelo;
        private int autonomiaMinutos;
        public string Modelo
        {
            set { modelo = value; }
            get { return modelo; }
        }
        public int AutonomiaMinutos
        {
            set { autonomiaMinutos = value; }
            get { return autonomiaMinutos; }
        }
        public SondaExploradora(int autonomiaRecibida, string modeloRecibido)
        {
            modelo = modeloRecibido;
            autonomiaMinutos = autonomiaRecibida;
        }

    }
    class SondaSubmarina : SondaExploradora
    {
        private int presionMaximaAtm;
        public int PresionMaximaAtm
        {
            set { presionMaximaAtm = value; }
            get { return presionMaximaAtm; }
        }
        public SondaSubmarina(int presionRecibida, int autonomiaRecibida, string modeloRecibido) : base(autonomiaRecibida, modeloRecibido)
        {
            presionMaximaAtm = presionRecibida;
        }

    }
    class RoverTerreste : SondaExploradora
    {
        private int cantidadRuedas;
        public int CantidadRuedas
        {
            set { cantidadRuedas = value; }
            get { return cantidadRuedas; }
        }
        public RoverTerreste(int cantidadRuedasRecibida, int autonomiaRecibida, string modeloRecibido) : base(autonomiaRecibida, modeloRecibido)
        {
            cantidadRuedas = cantidadRuedasRecibida;
        }

        static void Main(string[] args)
        {
            SondaSubmarina sonda = new SondaSubmarina(20, 20, "xd");
            RoverTerreste rover = new RoverTerreste(4, 20, "xd2");
            Console.WriteLine("la sonda es: " + sonda.Modelo + " que aguanta una presion de " + sonda.PresionMaximaAtm + " y tiene unos minutos de autonomia de " + sonda.AutonomiaMinutos);
            Console.WriteLine("el rover es: " + rover.Modelo + " que tiene " + rover.CantidadRuedas + " ruedas y tiene unos minutos de autonomia de " + rover.AutonomiaMinutos);
            Console.ReadKey();
        }
    }
}
