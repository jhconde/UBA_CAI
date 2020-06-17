using NLayer.Entidades;
using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClienteServicio servicio = new ClienteServicio();

                int cod = servicio.InsertarCliente(generarCliente());

                Console.WriteLine("Se ha insertado el cliente nro " + cod.ToString());

                List<Cliente> lst = servicio.TraerClientes();

                foreach (Cliente c in lst)
                {
                    Console.WriteLine(c);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            Console.ReadKey();
        }

        static Cliente generarCliente ()
        {
            Cliente cliente = new Cliente();
            cliente.Ape = "TEST APELLIDO";
            cliente.Nombre = "TEST NOMBRE";
            cliente.Direccion = "TEST DIRECCION";
            return cliente;
        }

    }
}
