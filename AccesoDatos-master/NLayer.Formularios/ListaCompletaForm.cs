using NLayer.Entidades;
using NLayer.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NLayer.Formularios
{
    public partial class ListaCompletaForm : Form
    {

        private ClienteServicio clienteServicio;
        public ListaCompletaForm(string tipoVista, string valorBusqueda)
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            inicializarTabla(tipoVista, valorBusqueda);
        }

        private void inicializarTabla(string tipoVista, string valorBusqueda)
        {
            
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Direccion";
            dataGridView1.Columns[3].Name = "Fecha de Nacimiento";
            dataGridView1.Columns[4].Name = "Edad";
            dataGridView1.Columns[5].Name = "Email";
            dataGridView1.Columns[6].Name = "Telefono";

            List<Cliente> clientes;
            switch (tipoVista)
            {
                case "edad":
                    clientes = clienteServicio.TraerClientesPorEdadMayores(int.Parse(valorBusqueda));
                    break;
                case "apellido":
                    clientes = clienteServicio.TraerClientesPorApellido(valorBusqueda);
                    break;
                default:
                    clientes = clienteServicio.TraerClientes();
                    break;
            }
            foreach (Cliente c in clientes)
            {
                string[] row = new string[] { c.Nombre, c.Ape, 
                    c.Direccion, c.FechaNacimiento.ToShortDateString(), c.GetEdad(), c.Email, c.Telefono };
                dataGridView1.Rows.Add(row);
            }
            
        }

    }
}
