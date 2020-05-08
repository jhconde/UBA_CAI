using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_16
{
    class Program
    {
        // Crear una aplicación que, cuando el usuario ingrese un número, lo muestre por pantalla e indique cuántos dígitos tiene.
        // Si el usuario ingresa 5629, mostrará “Número ingresado: 5629 – Tiene 4 dígitos”.
        static void Main(string[] args)
        {
            Console.Write("Ingrese un numero: ");
            String numero = Console.ReadLine();
            Console.WriteLine("Número ingresado: " + numero + " - Tiene " + numero.Length + " dígitos");

            Console.ReadLine(); // mantiene la consola abierta
        }
    }
}
