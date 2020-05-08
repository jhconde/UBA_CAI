using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_14
{
    class Program
    {
        // Crear una aplicación que, cuando el usuario ingrese un número, muestre su tabla de multiplicar por pantalla.
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            int numero = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int producto = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + producto);
            }
            Console.ReadLine(); // mantiene la consola abierta
        }
    }
}
