using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace punto_4
{   
    //4. Línea de Ensamblaje Robótico
    //En una planta de fabricación automatizada, cada robot industrial realiza tareas de
    //ensamblaje complejas divididas en operaciones secundarias de duración variable.
    //● Diseñar la clase RobotEnsamblador que tenga como atributos privados:
    //1. ModeloRobot.
    //2. Una matriz irregular de tipo float (float[][] tiemposOperacion) donde cada
    //fila representa una de las 4 fases principales del proceso (Estructura,
    //Cableado, Pintura y Testeo), y cada columna los segundos que demoró en
    //completar las distintas subtareas de esa fase(por ejemplo, en la fase de
    //Estructura el robot puede tener 3 sub-tareas, pero en la de Testeo solo tiene
    //1).
    //3. El constructor de RobotEnsamblador debe pedir su modelo, preguntar para
    //cada una de las 4 fases de fabricación cuántas sub - tareas requirió realizar
    //(definiendo el tamaño de cada fila) y cargar la duración en segundos de cada
    //una de ellas.
    //● Diseñar la clase colaboradora PlantaIndustrial que gestione a 3 objetos de la clase
    //RobotEnsamblador.Implementar en PlantaIndustrial:
    //1. Un constructor que cargue la información de los 3 robots instalados en la
    //planta.
    //2. Un método que muestre un reporte detallado con los tiempos de operación
    //de cada robot fase por fase.
    //3. Un método que calcule el promedio general de tiempo por tarea de cada
    //robot y declare al &quot; Robot más Eficiente & quot; (aquel que registre el promedio de
    //tiempo por operación más bajo de la planta).
    class RobotEnsamblador
    {
        string modeloRobot;
        float[][] tiemposOperacion;

        public RobotEnsamblador()
        {
            string linea;
            string fase = "";
            tiemposOperacion = new float[4][];
            Console.WriteLine("escribe el nombre del modelo del robot");
            modeloRobot = Console.ReadLine();
            for (int i = 0; i < tiemposOperacion.GetLength(0); i++)
            {
                if (i == 0) { fase = " Estructura"; }
                if (i == 1) { fase = " Cableado"; }
                if (i == 2) { fase = " pintura"; }
                if (i == 3) { fase = " testeo"; }
                Console.WriteLine("escribe la cantidad de subtareas que este robot tuvo que realizar en la fase " + fase);
                linea = Console.ReadLine();
                tiemposOperacion[i] = new float[int.Parse(linea)];
                for (int f = 0; f < tiemposOperacion[i].Length; f++)
                {
                    Console.WriteLine("escribe cuando tiempo tardó en completar la subtarea numero " + f + " (en segundos)");
                    linea = Console.ReadLine();
                    tiemposOperacion[i][f] = float.Parse(linea);
                }
            }
        }
        public string devolverModelo()
        {
            return modeloRobot;
        }
        public float[][] devolverTiempos()
        {
            return tiemposOperacion;
        }


    }
    class PlantaIndustrial
    {
        RobotEnsamblador[] robots;
        float[][] matrizTiempos;
        public PlantaIndustrial()
        {
            robots = new RobotEnsamblador[3];
            for (int i = 0; i < robots.Length; i++)
            {
                robots[i] = new RobotEnsamblador();
            }
        }

        public void tiempos()
        {
            string fase = "";
            for (int i = 0; i < robots.Length; i++)
            {
                matrizTiempos = robots[i].devolverTiempos();
                Console.WriteLine("los tiempos de operacion del robot con nombre " + robots[i].devolverModelo() + " son");
                for (int f = 0; f < matrizTiempos.GetLength(0); f++)
                {
                    if (f == 0) { fase = " Estructura"; }
                    if (f == 1) { fase = " Cableado"; }
                    if (f == 2) { fase = " pintura"; }
                    if (f == 3) { fase = " testeo"; }
                    Console.WriteLine("los tiempos de la fase " + fase + " en sus respectivas subtareas son: ");
                    for (int y = 0; y < matrizTiempos[f].Length; y++)
                    {
                        Console.WriteLine("en la subtarea numero " + y + " tardó " + matrizTiempos[f][y] + " segundos");
                        Console.WriteLine();
                    }
                }
            }
        }

        public void promedioYEficiencia()
        {
            float promedio = 0;
            float promedioMasChico = 0;
            float[] promedios = new float[3];
            int suma = 0;
            for (int i = 0; i < robots.Length; i++)
            {
                promedio = 0;
                suma = 0;
                matrizTiempos = robots[i].devolverTiempos();
                for (int f = 0; f < matrizTiempos.GetLength(0); f++)
                {
                    for (int y = 0; y < matrizTiempos[f].Length; y++)
                    {
                        promedio += matrizTiempos[f][y];
                        suma++;
                    }
                }
                promedio = promedio / suma;
                promedios[i] = promedio;
            }

            promedioMasChico = promedios[0];

            for (int i = 0; i < promedios.Length; i++)
            {
                if (promedios[i] < promedioMasChico)
                {
                    promedioMasChico = promedios[i];
                }
            }

            for (int i = 0; i < promedios.Length; i++)
            {
                if (promedios[i] == promedioMasChico)
                {
                    Console.WriteLine("el robot mas eficiente con el mejor promedio de tiempo es el robot " + robots[i].devolverModelo());
                }
            }
        }
        static void Main(string[] args)
        {
            PlantaIndustrial pi = new PlantaIndustrial();
            pi.tiempos();
            pi.promedioYEficiencia();
            Console.ReadKey();
        }
    }
}