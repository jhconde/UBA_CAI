using System;

namespace CAI_Ejercicio_09
{
    class Program
    {

        // Crear una aplicación que pida al usuario su nombre e indique por pantalla “¡Hola, *usuario*!” si ingresa su nombre, en caso contrario dirá “No te conozco”.
        // Por ejemplo, si el usuario es Suyai, e ingresa el nombre “Suyai” dirá “¡Hola, Suyai!”, si no, “No te conozco”
        static void Main(string[] args) {
            const string USUARIO_VALIDO = "Suyai";

            Console.Write("Ingrese usuario: ");
            string usuarioEntrada = Console.ReadLine();

            if (USUARIO_VALIDO.Equals(usuarioEntrada)) {
                Console.WriteLine("¡Hola, " + USUARIO_VALIDO + "!");
            } else {
                Console.WriteLine("No te conozco.");
            }
        }
    }
}
