using System;

namespace CAI_Ejercicio_05
{
    class Program
    {

        // Crear una aplicación que, cuando el usuario ingresa un número de 5 cifras, lo invierta y muestre por pantalla 
        // “El número invertido es: *nnnnn*”. Por ejemplo, si el usuario ingresa “12345”, mostrará por pantalla “54321”.
        static void Main(string[] args) {
            string entrada = "";
            do {
                Console.Write("Ingrese un numero de 5 cifras: ");
                entrada = Console.ReadLine();
            } while (entrada.Length < 5);
            
            for (int i = entrada.Length - 1; i > -1; i--) {
                Console.Write(entrada[i]);
            }
        }
    }
}
