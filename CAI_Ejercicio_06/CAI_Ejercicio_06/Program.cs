using System;

namespace CAI_Ejercicio_06
{
    class Program
    {
        // Crear una aplicación que, cuando el usuario ingrese dos números, 
        // realice la operación aritmética (a+b)*(a-b) e indique por pantalla el resultado.
        static void Main(string[] args) {
            Console.Write("Numero 1: ");
            string numero1str = Console.ReadLine();
            Console.Write("Numero 2: ");
            string numero2str = Console.ReadLine();

            int numero1 = Int32.Parse(numero1str);
            int numero2 = Int32.Parse(numero2str);

            Console.WriteLine("Resultado " + (numero1 + numero2) * (numero1 - numero2));
        }
    }
}
