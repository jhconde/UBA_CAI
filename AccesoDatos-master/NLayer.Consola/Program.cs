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
            ClienteServicio servicio = new ClienteServicio();

            List<Cliente> lst = servicio.TraerClientes();

            foreach(Cliente c in lst)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();
        }
    }
}
