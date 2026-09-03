using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace punto_1
{   
    //1. Monitoreo Clínico de Pacientes
    //En una sala de cuidados intensivos, se requiere realizar un seguimiento constante del ritmo
    //cardíaco de los pacientes.
    //● Plantear una clase llamada Paciente que tenga como atributos privados:
    //1. Nombre(de tipo string).
    //2. Una matriz llamada ritmoCardiaco de tamaño 3x4(representando los
    //registros de pulsaciones tomados durante 3 días diferentes, en 4 momentos
    //clave de cada día: mañana, mediodía, tarde y noche).
    //3. El constructor de Paciente debe pedir su nombre y solicitar la carga por
    //teclado de las 12 lecturas cardíacas.
    //● Confeccionar la clase colaboradora SalaMonitoreo que administre un vector de 3
    //objetos de la clase Paciente.Su constructor debe inicializar el vector y solicitar la
    //carga de los 3 pacientes.Implementar los siguientes métodos dentro de
    //SalaMonitoreo:
    //1. Un método que imprima la grilla de lecturas cardíacas completa de cada
    //paciente organizada por día y momento.
    //2. Un método que calcule e imprima el promedio de pulsaciones de cada
    //paciente a lo largo de todo su monitoreo.
    //3. Un método que verifique si algún paciente registró un evento de taquicardia
    //severa (cualquier lectura individual que sea estrictamente mayor a 120
    //pulsaciones), mostrando por consola su nombre y la lectura detectada.
    class Paciente
    {

        int[,] ritmosCardiacos;
        string nombre;

        public Paciente()
        {
            ritmosCardiacos = new int[3, 4];

            string momento = "mañana";
            Console.WriteLine("Por favor escribe el nombre del paciente");
            nombre = Console.ReadLine();
            for (int i = 0; i < ritmosCardiacos.GetLength(0); i++)
            {
                for (int f = 0; f < ritmosCardiacos.GetLength(1); f++)
                {
                    if (f == 0) { momento = "la mañana"; }
                    if (f == 1) { momento = "el mediodia"; }
                    if (f == 2) { momento = "la tarde"; }
                    if (f == 3) { momento = "la noche"; }
                    Console.WriteLine("escribe el ritmo cardiaco que tuvo el paciente " + nombre + " en " + momento + " en el dia " + i);
                    string linea = Console.ReadLine();
                    ritmosCardiacos[i, f] = int.Parse(linea);
                }
            }
        }
        public string devolverNombre()
        {
            return nombre;
        }
        public int[,] devolverRitmos()
        {
            return ritmosCardiacos;
        }
    }


    class SalaMonitoreo
    {
        Paciente[] Pacientes;
        public SalaMonitoreo()
        {
            Pacientes = new Paciente[3];
            for (int i = 0; i < Pacientes.Length; i++)
            {
                Pacientes[i] = new Paciente();
            }
        }

        public void imprimirGrilla()
        {
            for (int i = 0; i < Pacientes.Length; i++)
            {
                string nombre = Pacientes[i].devolverNombre();
                int[,] matriz = Pacientes[i].devolverRitmos();
                Console.WriteLine("resultados del paciente " + nombre);
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    Console.WriteLine("dia " + f);
                    for (int y = 0; y < matriz.GetLength(1); y++)
                    {
                        string momento = "";
                        if (y == 0) { momento = " mañana"; }
                        if (y == 1) { momento = " mediodia"; }
                        if (y == 2) { momento = " tarde"; }
                        if (y == 3) { momento = " noche"; }
                        Console.WriteLine("  " + momento + ": " + matriz[f, y]);
                    }
                }
            }
        }

        public void promedioPulsaciones()
        {

            for (int i = 0; i < Pacientes.Length; i++)
            {
                float promedio = 0;
                int sumaEspacios = 0;
                int[,] matriz = Pacientes[i].devolverRitmos();
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    for (int y = 0; y < matriz.GetLength(1); y++)
                    {
                        promedio += matriz[f, y];
                        sumaEspacios++;
                    }
                }
                promedio = promedio / sumaEspacios;
                Console.WriteLine("el promedio de pulsaciones del paciente " + Pacientes[i].devolverNombre() + " es de " + promedio);
                Console.WriteLine();
            }
        }

        public void taquicardia()
        {
            for (int i = 0; i < Pacientes.Length; i++)
            {
                bool tuvoTaquicardia = false;
                int[,] matriz = Pacientes[i].devolverRitmos();
                Console.WriteLine("el paciente " + Pacientes[i].devolverNombre() + "... ");
                for (int f = 0; f < matriz.GetLength(0); f++)
                {
                    for (int y = 0; y < matriz.GetLength(1); y++)
                    {
                        if (matriz[f, y] >= 120)
                        {
                            tuvoTaquicardia = true;
                            string momento = "";
                            if (y == 0) { momento = "la mañana"; }
                            if (y == 1) { momento = "el mediodia"; }
                            if (y == 2) { momento = "la tarde"; }
                            if (y == 3) { momento = "la noche"; }
                            Console.WriteLine("...tuvo una taquicardia en el dia " + f + " y en " + momento);
                            Console.WriteLine();
                            Console.WriteLine();
                        }
                    }
                }
                if (tuvoTaquicardia == false)
                {
                    Console.WriteLine("...no tuvo taquicardias");
                    Console.WriteLine();
                    Console.WriteLine();
                }

            }
        }


        static void Main(string[] args)
        {
            SalaMonitoreo sala = new SalaMonitoreo();
            sala.imprimirGrilla();
            sala.promedioPulsaciones();
            sala.taquicardia();
            Console.ReadKey();
        }
    }
}
