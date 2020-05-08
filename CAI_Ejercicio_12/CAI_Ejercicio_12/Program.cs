using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAI_Ejercicio_12
{
    class Program
    {

        // Crear una aplicación que, cuando el usuario ingrese dos fechas distintas, 
        // calcule la diferencia entre éstas y la muestre por pantalla, indicando años, 
        // meses y días por separado(en base 365).
        // Por ejemplo, si ingreso las fechas 23/09/1993 y 09/04/1997, la aplicación devolverá por 
        // pantalla “La diferencia es de 3 años, 6 meses y 19 días”.
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese fecha 1: ");
            DateTime fecha1 = obtenerFecha();
            Console.Write("Ingrese fecha 2: ");
            DateTime fecha2 = obtenerFecha();

            double totalDias = (fecha2 - fecha1).TotalDays;
            double años = totalDias / 365;
            double meses = (totalDias % 365) / 30;
            double dias = totalDias % 365 % 30;

            Console.WriteLine("La diferencia es de " + ((int) años) + " años, " + ((int) meses) + " meses y " + ((int) dias) + " días");

            Console.ReadLine(); // mantiene la consola abierta
        }

        public static DateTime obtenerFecha()
        {
            String formato = "dd/MM/yyyy";
            return DateTime.ParseExact(Console.ReadLine(), formato, null);
        }
    }
}
