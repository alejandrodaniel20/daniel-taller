using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //En un banco se procesan datos de las cuentas corrientes de sus clientes.De cada
            //cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
            //finalizar al ingresar un valor negativo en el número de cuenta.
            //Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
            //informe:
            //a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
            //que:
            //Estado de la cuenta:
            //○ “Acreedor” si el saldo es >; 0.
            //○ “Deudor” si el saldo es <; 0.
            //○ “Nulo” si el saldo es = 0.
            //b) La suma total de los saldos acreedores.

            int numeroCuenta;
            double saldo;
            double sumaAcreedores = 0;
            string linea;


            
            Console.Write("Ingrese número de cuenta: ");
            linea = Console.ReadLine();
            numeroCuenta = int.Parse(linea);

            while (numeroCuenta >= 0)
            {
                
                Console.Write("Ingrese el saldo actual: ");
                linea = Console.ReadLine();
                saldo = double.Parse(linea);

                
                Console.WriteLine("Cuenta: " + numeroCuenta);

                if (saldo > 0)
                {
                    Console.WriteLine("Estado: Acreedor");
                   
                    sumaAcreedores += saldo;
                }
                else if (saldo < 0)
                {
                    Console.WriteLine("Estado: Deudor");
                }
                else
                {
                    Console.WriteLine("Estado: Nulo");
                }

                
                Console.Write("Ingrese número de cuenta: ");
                linea = Console.ReadLine();
                numeroCuenta = int.Parse(linea);
            }

            
            Console.WriteLine("Suma total de saldos acreedores: " + sumaAcreedores);
            Console.ReadKey();
        }
    }
}
