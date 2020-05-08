using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_13
{
    class Program
    {
        // Crear una aplicación que, cuando el usuario ingrese un número, 
        // calcule el factorial del mismo y lo muestre por pantalla.
        // Nota: El factorial de un número es el producto de todos los números 
        // enteros positivos desde 1 hasta n. Por ejemplo: 5! = 1 x 2 x 3 x 4 x 5 = 120.
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            int factorial = numero;
            while(numero > 1)
            {
                factorial = factorial * (numero - 1);
                numero--;
            }
            Console.WriteLine("Factorial: " + factorial);
            Console.ReadLine(); // mantiene abierta la consola
        }
    }
}
