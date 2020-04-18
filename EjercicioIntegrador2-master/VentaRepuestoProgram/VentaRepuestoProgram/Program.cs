using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoProgram
{
    class Program
    {
        static void Main(string[] args) {
            
            Console.WriteLine("1) Agregar repuesto");
            Console.WriteLine("2) Quitar repuesto");
            Console.WriteLine("3) Modificar precio");
            Console.WriteLine("4) Agregar stock");
            Console.WriteLine("5) Quitar stock");
            Console.WriteLine("6) Traer por categoria");

            Console.Write("Ingrese una opcion: ");
            VentaRepuestos ventaRepuestos = new VentaRepuestos("Local Ejemplo", "Direccion Ejemplo");
            string opcion = Console.ReadLine();
            switch(opcion)
            {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                case "6":
                    break;
            }

        }
    }
}
