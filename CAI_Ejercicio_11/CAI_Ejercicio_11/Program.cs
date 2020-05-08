using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_11
{
    class Program
    {
        // Crear una aplicación que lea un carácter tecleado por el usuario e indique si se trata de una vocal, 
        // una cifra numérica o una consonante.
        // Nota: Incluir todas las validaciones que considere necesarias (los caracteres especiales 
        // no deben tenerse en cuenta).
        static void Main(string[] args)
        {
            Console.Write("Caracter: ");
            String caracter = Console.ReadLine();

            if (caracter.Length != 1)
            {
                Console.WriteLine("Entrada invalida, debe ingresar un caracter.");
                Console.ReadLine(); // mantiene la consola abierta
            }
            else if (esVocal(caracter))
            {
                Console.WriteLine("Es vocal");
            }
            else if (esConsonante(caracter))
            {
                Console.WriteLine("Es consonante");
            }
            else if (esNumero(caracter))
            {
                Console.WriteLine("Es numero");
            }
            else
            {
                Console.WriteLine("Es un caracter especial");
            }
            Console.ReadLine(); // mantiene la consola abierta
        }

        public static bool esVocal(String caracter)
        {
            String[] vocales = { "a", "e", "i", "o", "u" };
            bool esVocal = false;
            for (int i = 0; i < vocales.Length; i++)
            {
                if (vocales[i] == caracter.ToLower())
                {
                    esVocal = true;
                    break;
                }
            }
            return esVocal;
        }

        public static bool esConsonante(String caracter)
        {
            String[] consonantes = { "b", "c", "d", "f", "g", "h", "j", "k", "l",
                "m", "n", "ñ", "p", "q", "r", "s", "t", "v", "w", "x", "y", "z" };
            bool esConsonante = false;
            for (int i = 0; i < consonantes.Length; i++)
            {
                if (consonantes[i] == caracter.ToLower())
                {
                    esConsonante = true;
                    break;
                }
            }
            return esConsonante;
        }

        public static bool esNumero(String caracter)
        {
            String[] numeros = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            bool esNumero = false;
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == caracter)
                {
                    esNumero = true;
                    break;
                }
            }
            return esNumero;
        }
    }
}
