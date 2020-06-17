using NLayer.Datos;
using NLayer.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Negocio
{
    public class ClienteServicio
    {
        private ClienteMapper mapper;
        public ClienteServicio() {
            mapper = new ClienteMapper();
        }

        public List<Cliente> TraerClientes()
        {
            List<Cliente> clientes = mapper.TraerTodos();
            return clientes;
        }

        public List<Cliente> TraerClientesPorEdadMayores(int edad)
        {
            List<Cliente> clientes = TraerClientes();
            List<Cliente> resultado = new List<Cliente>();
            foreach (Cliente c in clientes)
            {
                if (int.Parse(c.GetEdad()) > edad)
                {
                    resultado.Add(c);
                }
            }
            return resultado;
        }

        public List<Cliente> TraerClientesPorApellido(string apellido)
        {
            List<Cliente> clientes = TraerClientes();
            List<Cliente> resultado = new List<Cliente>();
            foreach (Cliente c in clientes)
            {
                if (c.Ape != null && c.Ape.ToLower() == apellido.ToLower())
                {
                    resultado.Add(c);
                }
            }
            return resultado;
        }

        public int InsertarCliente(Cliente cliente)
        {
            TransactionResult resultante = mapper.Insert(cliente);

            if (resultante.IsOk)
                return resultante.Id;
            else
                throw new Exception("Hubo un error en la petición al servidor. Detalle: " + resultante.Error);
        }

    }
}
