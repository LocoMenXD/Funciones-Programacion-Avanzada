using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Crea un método que nos salude, pasándole un nombre por parámetro.

namespace Funciones1Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            saludar("ChicowowxD"); //Llamada del método
            Console.ReadLine();
        }

        //Método que saluda
        public static void saludar(string nombre)
        {

            Console.WriteLine("¡Hola " + nombre + " !");
            // Otra forma de hacerlo (Comenta lña anterior linea)
            //Console.WriteLine("¡Hola {0} !", nombre);

        }

    }

}