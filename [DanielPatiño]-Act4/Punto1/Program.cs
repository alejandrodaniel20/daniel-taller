using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
            //$500, realizar un programa que lea los sueldos que cobra cada empleado e
            //informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
            //de $300.Además el programa deberá informar el importe que gasta la empresa
            //en sueldos al personal.

            int Cant_Empleados, Sueldo, Cant_Linea, Cont_Mas, Cont_Menos, total_gastos;
            Cant_Linea = 1;
            Cont_Mas = 0;
            Cont_Menos = 0;
            total_gastos = 0;

            String Linea;

            Console.Write("Ingrese la Cantidad de Empleados: ");
            Linea = Console.ReadLine();
            Cant_Empleados = int.Parse(Linea);



            while (Cant_Linea <= Cant_Empleados)
            {

                Console.Write("Ingrese la cantidad de Sueldo: ");
                Linea = Console.ReadLine();
                Sueldo = int.Parse(Linea);
                Cant_Linea++;

                if (Sueldo >= 100 && Sueldo <= 300)
                {
                    Cont_Menos++;
                    total_gastos = total_gastos + Sueldo;

                }
                if (Sueldo > 300 && Sueldo <= 500)
                {

                    Cont_Mas++;
                    total_gastos = total_gastos + Sueldo;

                }
            }

            Console.WriteLine("Los empleados que cobran entre 100 y 300 son: " + Cont_Menos);
            Console.WriteLine("Los empleados que cobran Mas de 300 son: " + Cont_Mas);

            Console.WriteLine("La empresa gasta alrededor de " + total_gastos + " para pagar a sus empleados");
            Console.ReadKey();


        }
    }
}
