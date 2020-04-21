using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoProgram
{
    // Int32.Parse convierte string a int
    class Program
    {

        string sistemaOperativo;
        string memoria;
        static void Main(string[] args) {
            
            Console.WriteLine("1) Agregar repuesto");
            Console.WriteLine("2) Quitar repuesto");
            Console.WriteLine("3) Modificar precio");
            Console.WriteLine("4) Agregar stock");
            Console.WriteLine("5) Quitar stock");
            Console.WriteLine("6) Traer por categoria");
            Console.WriteLine("X) Salir");

            bool recibirEntrada = true;
            VentaRepuestos ventaRepuestos = new VentaRepuestos("Local Ejemplo", "Direccion Ejemplo");
            do
            {
                Console.WriteLine();
                Console.Write("Ingrese una opcion: ");
                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Program.AgregarRepuesto(ventaRepuestos);
                        break;
                    case "2":
                        Program.QuitarRepuesto(ventaRepuestos);
                        break;
                    case "3":
                        Program.ModificarPrecio(ventaRepuestos);
                        break;
                    case "4":
                        Program.AgregarStock(ventaRepuestos);
                        break;
                    case "5":
                        Program.QuitarStock(ventaRepuestos);
                        break;
                    case "6":
                        Program.TraerPorCategoria(ventaRepuestos);
                        break;
                    case "x":
                        recibirEntrada = false;
                        Console.WriteLine("Gracias por usar la app.");
                        Console.ReadKey(); // pausa para que no se cierre la consola
                        break;
                }
            } while (recibirEntrada);
        }

        public static void AgregarRepuesto(VentaRepuestos ventaRepuestos)
        {
            Repuesto repuesto = new Repuesto();
            Console.Write("Codigo: ");
            repuesto.Codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nombre: ");
            repuesto.Nombre = Console.ReadLine();
            Console.Write("Precio: ");
            try
            {
                repuesto.Precio = Convert.ToDouble(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("error:" + e.Message);
                return;
            }
            Console.Write("Stock: ");
            repuesto.Stock = Convert.ToInt32(Console.ReadLine());
            Console.Write("Categoria (1: Ferreteria, 2: Herramientas, 3: Consumibles) : ");
            repuesto.Categoria = obtenerCategoria(Convert.ToInt32(Console.ReadLine()));
            
            ventaRepuestos.AgregarRepuesto(repuesto);
        }

        public static Categoria obtenerCategoria(int codigo)
        {
            Categoria categoria;
            switch (codigo)
            {
                case 1:
                    categoria = new Categoria();
                    categoria.Codigo = 1;
                    categoria.Nombre = "Ferreteria";
                    break;
                case 2:
                    categoria = new Categoria();
                    categoria.Codigo = 2;
                    categoria.Nombre = "Herramientas";
                    break;
                case 3:
                    categoria = new Categoria();
                    categoria.Codigo = 3;
                    categoria.Nombre = "Consumibles";
                    break;
                default:
                    categoria = null;
                    break;
            }
            return categoria;
        }

        public static void QuitarRepuesto(VentaRepuestos ventaRepuestos)
        {
            Console.Write("Codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            try
            {
                ventaRepuestos.QuitarRepuesto(codigo);
                Console.WriteLine("Repuesto " + codigo + " eliminado.");
            } catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public static void ModificarPrecio(VentaRepuestos ventaRepuestos)
        {
            Console.Write("Codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Precio: ");
            double precio = Convert.ToDouble(Console.ReadLine());

            try
            {
                ventaRepuestos.ModificarPrecio(codigo, precio);
            }
            catch (Exception e)
            {
                Console.WriteLine("error: " + e.Message);
                return;
            }
        }

        public static void AgregarStock(VentaRepuestos ventaRepuestos)
        {
            Console.Write("Codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            try
            {
                ventaRepuestos.AgregarStock(codigo, cantidad);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void QuitarStock(VentaRepuestos ventaRepuestos)
        {
            Console.Write("Codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cantidad: ");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            try
            {
                ventaRepuestos.QuitarStock(codigo, cantidad);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static void TraerPorCategoria(VentaRepuestos ventaRepuestos)
        {
            Console.Write("Codigo: ");
            int codigo = Convert.ToInt32(Console.ReadLine());

            List<Repuesto> repuestos = ventaRepuestos.TraerPorCategoria(codigo);
            
            if (repuestos.Any()) // Any retorna true si la lista no esta vacia
            {
                foreach (Repuesto repuesto in repuestos)
                {
                    Console.WriteLine(repuesto.ToString());
                }
            } else
            {
                Console.WriteLine("No hay repuestos para el codigo de categoria " + codigo);
            }
        }

    }
}
