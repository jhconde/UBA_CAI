using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_15
{
    class Program
    {
        // Crear una aplicación que verifique, en tres oportunidades, si la clave ingresada por el usuario es correcta. 
        // La clave será el nombre del usuario, si acierta mostrará por pantalla “Bienvenido, *usuario*”, si no acierta mostrará “Acceso denegado. 
        // La contraseña no es correcta”, y cuando se cumplan los tres intentos mostrará “Clave bloqueada”.
        static void Main(string[] args)
        {
            int intentosMaximo = 3;
            int intentos = 0;
            String usuarioCorrecto = "Jose";
            bool autenticado = false;
            String usuario = null;
            do
            {
                Console.Write("Usuario: ");
                usuario = Console.ReadLine();
                if (usuario == usuarioCorrecto)
                {
                    autenticado = true;
                } else
                {
                    Console.WriteLine("Acceso denegado. La contraseña no es correcta");
                }
                intentos++;
            } while (intentos < intentosMaximo && !autenticado);

            if (intentos >= intentosMaximo)
            {
                Console.WriteLine("Clave bloqueada");
            } else if (autenticado)
            {
                Console.WriteLine("Bienvenido, " + usuario);
            }
            Console.ReadLine(); // mantiene la consola abierta
        }
    }
}
