using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_17
{
    class Program
    {
        // Crear una aplicación que tome los nombres y sueldos de cinco empleados, 
        // para mostrar por pantalla el sueldo mayor y el nombre del empleado.
        static void Main(string[] args)
        {
            String empleadoSueldoMayor = null;
            int sueldoMayor = 0;

            int entradas = 0;
            while (entradas < 5)
            {
                Console.Write("Nombre empleado: ");
                String empleado = Console.ReadLine();
                Console.Write("Sueldo: ");
                int sueldo = Int32.Parse(Console.ReadLine());
                if (sueldo > sueldoMayor)
                {
                    sueldoMayor = sueldo;
                    empleadoSueldoMayor = empleado;
                }
                entradas++;
            }
            Console.WriteLine(empleadoSueldoMayor + " tiene el sueldo mas alto: " + sueldoMayor);

            Console.ReadLine(); // mantiene la consola abierta
        }
    }
}
