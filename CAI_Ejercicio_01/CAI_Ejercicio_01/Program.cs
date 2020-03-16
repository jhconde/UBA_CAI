using System;

namespace CAI_Ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese texto: ");
            char[] param = Console.ReadLine().ToCharArray();
            int inicioIdx = 0, finIdx = param.Length - 1;
            bool ok = true;
            while (inicioIdx < finIdx)
            {
                if (param[inicioIdx] != param[finIdx])
                {
                    ok = false;
                    break;
                }
                inicioIdx++;
                finIdx--;
            }
            Console.WriteLine(ok ? "es palindromo" : "no es palindormo");
        }
    }
}
