using System;

namespace CAI_Ejercicio_07
{
    class Program
    {

        // Crear una aplicación que, cuando el usuario ingrese cinco números, 
        // indique cuál es mayor, cuál es valor intermedio y cuál el menor.
        static void Main(string[] args)
        {
            int numero1 = pedirNumero("Numero 1: ");
            int numero2 = pedirNumero("Numero 2: ");
            int numero3 = pedirNumero("Numero 3: ");
            int numero4 = pedirNumero("Numero 4: ");
            int numero5 = pedirNumero("Numero 5: ");

            int[] numeros = { numero1, numero2, numero3, numero4, numero5 };
            Array.Sort(numeros);

            Console.WriteLine("Menor: " + numeros[0]);
            Console.WriteLine("Intermedio: " + numeros[numeros.Length / 2]);
            Console.WriteLine("Mayor: " + numeros[numeros.Length - 1]);
        }

        static int pedirNumero(string msg) {
            Console.Write(msg);
            return Int32.Parse(Console.ReadLine());
        }
    }
}
