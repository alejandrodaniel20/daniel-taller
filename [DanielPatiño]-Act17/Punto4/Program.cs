using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_4
{/*4. Cadena de Herramientas (Herencia Multinivel y Orden de Constructores)
Armar una estructura jerárquica compuesta por tres clases consecutivas en una línea de
herencia: Material, Herramienta y Martillo.
 La clase Material (base) debe tener un atributo TipoMaterial (ej: Madera, Acero,
Plástico).
 La clase Herramienta (que hereda de Material) debe añadir el atributo
FuncionPrincipal.
 La clase Martillo (que hereda de Herramienta) debe añadir el atributo PesoGramos.
Cada una de las tres clases debe contar con un constructor encargado de recibir sus datos
correspondientes. Al momento de ejecutarse, cada constructor debe realizar la asignación y,
acto seguido, imprimir un mensaje en consola indicando a qué clase pertenece
(ejemplo: &quot;Constructor de la clase Material ejecutado&quot;).
En el método Main, crear únicamente un objeto de la clase final Martillo pasándole todos los
parámetros requeridos. Observar y verificar en la consola el orden secuencial de ejecución
en cadena de los constructores (desde la raíz hasta la clase derivada).*/

    class Material
    {
        private string tipoMaterial;
        public Material(string tipoMaterialPuesto)
        {
            tipoMaterial = tipoMaterialPuesto;
            Console.WriteLine("hola broder soy la clase Material, y el material es " + tipoMaterial);
        }
    }


    class Herramienta : Material
    {
        private string funcionPrincipal;
        public Herramienta(string funcionPrincipalPuesta, string tipoMaterial) : base(tipoMaterial)
        {
            funcionPrincipal = funcionPrincipalPuesta;
            Console.WriteLine("la funcion principal es " + funcionPrincipal + " y esto sale de herramienta");
        }
    }
    internal class Martillo : Herramienta
    {
        float pesoGramos;
        public Martillo(float pesoGramosPuesto, string funcionPrincipal, string tipoMaterial) : base(funcionPrincipal, tipoMaterial)
        {
            pesoGramos = pesoGramosPuesto;
            Console.WriteLine("el peso en gramos es de " + pesoGramos + "kilos, y esto sale de martillo");
        }
        static void Main(string[] args)
        {
            Martillo martillo = new Martillo(2.5f, "martillar", "hierro");
            Console.ReadKey();
        }
    }
}