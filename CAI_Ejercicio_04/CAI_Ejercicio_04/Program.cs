using System;

namespace CAI_Ejercicio_04
{
    class Program
    {
        // Crear una aplicación que indique, cuando el usuario ingresa dos palabras, si éstas son un anagrama.
        // Nota: Anagrama son palabras que reordenando sus letras forman una nueva, como "roma" y "amor".

        static void Main(string[] args) {
            Console.Write("Ingrese palabra 1: ");
            String palabra1 = Console.ReadLine();
            Console.Write("Ingrese palabra 2: ");
            String palabra2 = Console.ReadLine();

            bool valido = false;
            for (int i = 0; i < palabra1.Length; i++) {
                valido = false;
                for (int j = 0; j < palabra2.Length; j++) {
                    if (palabra1[i] == palabra2[j]) {
                        valido = true;
                        break;
                    }
                }
                if (!valido) {
                    break;
                }
            }

            Console.Write(valido ? "es anagrama" : "no es anagrama");
        }

    }
}
