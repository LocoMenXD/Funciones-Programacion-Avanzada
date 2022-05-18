using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


// Crea una función que sume dos números pasados por parámetros, devolverá el resultado.

namespace Funciones2Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = suma(10, 5); //Llamada de la función, lo guardo en una variable
            Console.WriteLine(resultado);
            Console.ReadLine();
        }

        //Función que nos devuelve la suma de dos números
        public static int suma(int num1, int num2)
        {

            int resultado = num1 + num2;
            return resultado;
        }

    }
}