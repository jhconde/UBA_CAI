using System;

namespace CAI_Ejercicio_08
{
    class Program
    {
        // Crear una aplicación que, cuando el usuario ingrese una fecha, calcule la diferencia 
        // entre ésta y el día de hoy, mostrando por pantalla "La diferencia de fechas es de *nnnnn* días."
        static void Main(string[] args)
        {
            Console.Write("Ingrese una fecha (dd/MM/yyyy): ");
            string fechaIngresadaStr = Console.ReadLine();
            DateTime fechaIngresada = DateTime.ParseExact(fechaIngresadaStr, "dd/MM/yyyy", null);
            DateTime hoy = DateTime.Now;

            int resultado = Math.Abs((int) (fechaIngresada - hoy).TotalDays);
            Console.WriteLine("La diferencia de fechas es de " + resultado + " días." );
        }
    }
}
