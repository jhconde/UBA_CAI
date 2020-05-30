using Solucion.ExpendedoraNegocio.Entidades;
using Solucion.ExpendedoraNegocio.Helpers;
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

            string menu = "0) Encender Expendedora \n" +
                "1) Listar Latas \n" +
                "2) Insertar Lata \n" +
                "3) Extraer Lata \n" +
                "4) Balance \n" +
                "5) Stock \n" +
                "C) Limpiar Consola \n" +
                "X) Salir";

            // Creo el objeto con el que voy a trabajar en este programa
            Expendedora expendedora = new Expendedora("Proveedor Test");
            ExpendedoraHelper.InicializarLatas(expendedora);

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
                        case "2":
                            Program.IngresarLata(expendedora);
                            break;
                        case "3":
                            Program.ExtraerLata(expendedora);
                            break;
                        case "4":
                            Program.ObtenerBalance(expendedora);
                            break;
                        case "5":
                            Program.MostrarStock(expendedora);
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
            expendedora.EncenderMaquina();
            Console.WriteLine("Maquina encendida\n");
        }

        private static void ListarLatasElegibles()
        {
            string latasElegibles = "";
            List<string> catalogo = ExpendedoraHelper.ObtenerCatalogo();
            for (int i = 0; i < catalogo.Count; i++)
            {
                latasElegibles = latasElegibles + catalogo[i] + "\n";
            }
            Console.WriteLine(latasElegibles);
        }

        private static void ListarStockDetalle(Expendedora expendedora)
        {
            if (!expendedora.Encendida)
            {
                Console.WriteLine("Maquina apagada");
                return;
            }
            string stockDetalleString = "";
            List<string> stockDetalle = expendedora.GetStockDetalle();
            for (int i = 0; i < stockDetalle.Count; i++)
            {
                stockDetalleString = stockDetalleString + stockDetalle[i] + "\n";
            }
            Console.WriteLine(stockDetalleString);
        }

        private static void IngresarLata(Expendedora expendedora)
        {
            if (expendedora.Encendida)
            {
                if (expendedora.GetCapacidadRestante() == 0)
                {
                    Console.WriteLine("Maquina llena");
                    return;
                }
                ListarLatasElegibles();
                string codigo = ConsolaHelper.PedirString("Codigo: ");
                if (!ExpendedoraHelper.EsCodigoValido(codigo))
                {
                    Console.WriteLine("Codigo invalido");
                    return;
                }
                double precio = ConsolaHelper.PedirDouble("Precio: ");
                double volumen = ConsolaHelper.PedirDouble("Volumen: ");
                string marca = ExpendedoraHelper.ObtenerMarca(codigo);
                string sabor = ExpendedoraHelper.ObtenerSabor(codigo);
                Lata lata = new Lata(codigo, marca, sabor, precio, volumen);
                expendedora.AgregarLata(lata);
            }
            else
            {
                Console.WriteLine("Maquina apagada");
            }
        }

        private static void ExtraerLata(Expendedora expendedora) {
            if (!expendedora.Encendida) {
                Console.WriteLine("Maquina apagada");
                return;
            }
            if (expendedora.EstaVacia())
            {
                Console.WriteLine("Maquina Vacia");
                return;
            }
            ListarStockDetalle(expendedora);
            string codigoCompuesto = ConsolaHelper.PedirString("Codigo (formato 'codigo-volumen'): ");
            double dinero = ConsolaHelper.PedirDouble("Dinero: ");
            Lata lata;
            try
            {
                lata = expendedora.ExtraerLata(codigoCompuesto, dinero);
            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine("Lata extraida: " + lata);
        }

        private static void ObtenerBalance(Expendedora expendedora)
        {
            if (!expendedora.Encendida)
            {
                Console.WriteLine("Maquina apagada");
                return;
            }
            Console.WriteLine(expendedora.GetBalance());
        }

        private static void MostrarStock(Expendedora expendedora)
        {
            if (!expendedora.Encendida)
            {
                Console.WriteLine("Maquina apagada");
                return;
            }
            if (expendedora.EstaVacia())
            {
                Console.WriteLine("Maquina Vacia");
                return;
            }
            String stock = "";
            for (int i = 0; i < expendedora.Latas.Count; i++)
            {
                stock = stock + expendedora.Latas[i] + "\n";
            }
            Console.WriteLine(stock);
        }

    }
}
