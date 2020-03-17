using System;

namespace CAI_Ejercicio_10
{
    class Program
    {
        // Crear una aplicación que, cuando el usuario ingrese un nombre, un apellido 
        // y la edad en un mismo input(en cualquier orden), indique cuál es cada uno.
        // Por ejemplo, el usuario ingresa “26 Suyai Pecoraro”, el programa mostrará 
        // por pantalla “Nombre: Suyai, Apellido: Pecoraro, Edad: 26”.

        static void Main(string[] args) {
            Console.Write("Ingresa nombre, apellido y edad (en cualquier orden): ");
            string entrada = Console.ReadLine();

            string[] entradaArray = entrada.Split(" ");

            string nombre = null;
            string apellido = null;
            string edad = null;
            for (int i = 0; i < entradaArray.Length; i++) {
                if (esNumero(entradaArray[i])) {
                    edad = entradaArray[i];
                } else {
                    if (nombre == null) {
                        nombre = entradaArray[i];
                    } else {
                        apellido = entradaArray[i];
                    }
                }
            }
            Console.WriteLine("Nombre: " + nombre + ", Apellido: " + apellido + ", Edad: " + edad);
        }

        static bool esNumero(string str) {
            int numero;
            return int.TryParse(str, out numero);
        }
    }
}
