using Solucion.ExpendedoraNegocio.Entidades;
using Solucion.LibreriaConsola;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuarActivo = true;

            string menu = "0) Encender Expendedora \n1) Listar Latas \nC) Limpiar Consola \nX) Salir";

            // Creo el objeto con el que voy a trabajar en este programa
            Expendedora expendedora = new Expendedora("Proveedor Test");

            // pantalla de bienvenida
            Console.WriteLine("Usando la expendedora del proveedor: " + expendedora.Proveedor);

            do
            {
                Console.WriteLine(menu);

                try
                {
                    string opcionSeleccionada = Console.ReadLine();

                    switch (opcionSeleccionada)
                    {
                        case "0":
                            Program.EncenderExpendedora(expendedora);
                            break;
                        case "1":
                            Program.ListarLatasElegibles();
                            break;
                        case "C":
                            Console.Clear();
                            break;
                        case "X":
                            continuarActivo = false;
                            break;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error durante la ejecución del comando. Por favor intente nuevamente. Mensaje: " + ex.Message);
                }
                Console.WriteLine("Ingrese una tecla para continuar.");

                Console.ReadKey();
                Console.Clear();
            }
            while (continuarActivo);

            Console.WriteLine("Gracias por usar la app.");
            Console.ReadKey();
        }

        private static void EncenderExpendedora(Expendedora expendedora)
        {
            // validar si ya esta encendida
            expendedora.Encendida = true;
            Console.WriteLine("Maquina encendida\n");
        }

        private static void ListarLatasElegibles()
        {
            Console.WriteLine("CO1 - Coca Cola Regular\n"
                + "CO2 - Coca Cola Zero\n"
                + "SP1 - Sprite Regular\n"
                + "SP2 - Sprite Zero\n"
                + "FA1 - Fanta Regular\n"
                + "FA2 - Fanta Zero");
        }

        private static void IngresarLata(Expendedora expendedora)
        {
            // completar
        }

        private static void ExtraerLata(Expendedora expendedora)
        {
            // completar
        }

        private static void ObtenerBalance(Expendedora expendedora)
        {
            // completar
        }

        private static void MostrarStock(Expendedora expendedora)
        {
            // completar
        }

    }
}
