using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace punto_2
{
    /*2.
    Plantear una clase llamada CriaturaMarina y otra clase llamada HabitatAcuatico.
    La clase CriaturaMarina debe tener como atributos privados: Especie (string),
    ProfundidadOptima (int, en metros) y NivelSalinidad (un valor de 1 a 100). Definir las
    propiedades necesarias para acceder a estos atributos asegurando mediante validaciones que:
    ● La profundidad óptima sea estrictamente mayor a cero (0).
    ● El nivel de salinidad se encuentre únicamente en el rango de 1 a 100 (de lo contrario,
    asignar un valor por defecto de 35, que representa la salinidad promedio del océano).
    La clase HabitatAcuatico debe contener como atributo un vector capaz de almacenar 3 objetos
    de la clase CriaturaMarina. Definir un método dentro de HabitatAcuatico para cargar las 3
    criaturas y otro método para mostrar todas las criaturas ordenadas de menor a mayor en base
    a su profundidad óptima. Además, el programa debe informar la especie que requiere el mayor
    nivel de salinidad para sobrevivir.*/
    class CriaturaMarina
    {
        private string especie;
        private int profundidadOptima, nivelSalinidad;
        public string Especie
        {
            set { especie = value; }
            get { return especie; }
        }
        public int ProfunidadOptima
        {
            set { profundidadOptima = value; }
            get { return profundidadOptima; }
        }
        public int NivelSalinidad
        {
            set { nivelSalinidad = value; }
            get { return nivelSalinidad; }
        }
        public CriaturaMarina()
        {
            string linea;
            Console.WriteLine("escribi su especie");
            especie = Console.ReadLine();
            Console.WriteLine("escribi su profundidad optima");
            for (int i = 0; i < 1; i++)
            {
                linea = Console.ReadLine();
                profundidadOptima = int.Parse(linea);
                if (profundidadOptima > 0)
                {

                }
                else
                {
                    Console.WriteLine("la profundidad debe ser estrictamente mayor a 0, intenta otra vez");
                    i--;
                }
            }

            Console.WriteLine("escribi su nivel de salinidad necesaria para sobrevivir, el numero debe estar entre 1 y 100, si no, automaticamente se colocará 35");

            linea = Console.ReadLine();
            nivelSalinidad = int.Parse(linea);
            if (nivelSalinidad < 1 || nivelSalinidad > 100)
            {
                nivelSalinidad = 35;
            }
        }

    }


    class HabitatAcuatico
    {
        private CriaturaMarina[] criaturas;

        public HabitatAcuatico()
        {

            criaturas = new CriaturaMarina[3];
            for (int i = 0; i < criaturas.Length; i++)
            {
                criaturas[i] = new CriaturaMarina();
            }
        }
        public void ordenar()
        {
            CriaturaMarina auxiliar = criaturas[0];
            for (int i = 0; i < criaturas.Length; i++)
            {
                for (int k = 0; k < criaturas.Length - i - 1; k++)
                {
                    if (criaturas[i].ProfunidadOptima > criaturas[i + 1].ProfunidadOptima)
                    {
                        auxiliar = criaturas[i + 1];
                        criaturas[i + 1] = criaturas[i];
                        criaturas[i] = auxiliar;
                    }
                }
            }

        }
        public void mostrarPorOrden()
        {
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < criaturas.Length; i++)
            {
                Console.WriteLine("criatura: " + criaturas[i].Especie);
                Console.WriteLine("profundidad optima: " + criaturas[i].ProfunidadOptima);
                Console.WriteLine("nivel de salinidad: " + criaturas[i].NivelSalinidad);
                Console.WriteLine();
            }
        }
        public void mostrarMayorSalinidad()
        {
            int mayor = criaturas[0].NivelSalinidad;
            for (int i = 0; i < criaturas.Length; i++)
            {
                if (criaturas[i].NivelSalinidad > mayor)
                {
                    mayor = criaturas[i].NivelSalinidad;
                }
            }

            for (int i = 0; i < criaturas.Length; i++)
            {
                if (criaturas[i].NivelSalinidad == mayor)
                {
                    Console.WriteLine("la criatura de la especie " + criaturas[i].Especie + " necesita el mayor nivel de salinidad para sobrevivir con: " + mayor);
                }
            }
        }

        static void Main(string[] args)
        {
            HabitatAcuatico habitat = new HabitatAcuatico();
            habitat.ordenar();
            habitat.mostrarPorOrden();
            habitat.mostrarMayorSalinidad();
            Console.ReadKey();
        }
    }
}