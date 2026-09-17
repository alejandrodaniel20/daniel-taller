using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{/*3. Fábrica de Computadoras (Herencia y Constructores con base)
Crear una clase base llamada Computadora que contenga los atributos Marca y
MemoriaRAM (en GB). Definir un constructor que reciba estos dos valores obligatoriamente.
Luego, definir dos clases derivadas de la clase base:
 Notebook: que añade el atributo propio TamanoPantalla (en pulgadas).
 Escritorio: que añade el atributo propio PotenciaFuente (en Watts).
Cada una de estas clases derivadas debe poseer su propio constructor, el cual debe recibir
tanto los atributos específicos como los de la clase base, transfiriendo estos últimos a la
clase Computadora mediante el uso explícito de la palabra clave base. Instanciar un objeto
de cada clase derivada en el Main y mostrar la totalidad de sus datos por consola.*/
    class Computadora
    {
        private string marca;
        private int memoria;
        public string Marca
        {
            set { marca = value; }
            get { return marca; }
        }
        public int Memoria
        {
            set { memoria = value; }
            get { return memoria; }
        }
        public Computadora(string marcaPuesta, int memoriaPuesta)
        {
            marca = marcaPuesta;
            memoria = memoriaPuesta;
        }

    }
    class Notebook : Computadora
    {
        private float tamanoPantalla;
        public float TamanoPantalla
        {
            set { tamanoPantalla = value; }
            get { return tamanoPantalla; }
        }
        public Notebook(string marca, int memoria, float tamanoPantalla) : base(marca, memoria)
        {
            this.tamanoPantalla = tamanoPantalla;
        }

        public void imprimir()
        {
            Console.WriteLine("la marca de la notebook es " + base.Marca);
            Console.WriteLine("la memoria de la notebook es " + base.Memoria + " gigas");
            Console.WriteLine("el tamaño de la pantalla es " + this.TamanoPantalla + " pugladas");
        }
    }
    class Escritorio : Computadora
    {
        private int potenciaFuente;
        public int PotenciaFuente
        {
            set { potenciaFuente = value; }
            get { return potenciaFuente; }
        }
        public Escritorio(string marca, int memoria, int potenciaFuente) : base(marca, memoria)
        {
            this.potenciaFuente = potenciaFuente;
        }

        public void imprimir()
        {
            Console.WriteLine("la marca del escritorio es " + base.Marca);
            Console.WriteLine("la memoria del escritorio es " + base.Memoria + " gigas");
            Console.WriteLine("la potencia de su fuente es " + this.PotenciaFuente + " Watts");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Escritorio esc = new Escritorio("apple", 15, 600);
            esc.imprimir();
            Notebook note = new Notebook("apple", 10, 10.5f);
            note.imprimir();
            Console.ReadKey();
        }
    }
}
