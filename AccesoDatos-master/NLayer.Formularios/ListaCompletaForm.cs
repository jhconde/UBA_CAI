﻿using NLayer.Entidades;
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
        public ListaCompletaForm()
        {
            InitializeComponent();
            clienteServicio = new ClienteServicio();
            inicializarTabla();
        }

        private void inicializarTabla()
        {
            
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Nombre";
            dataGridView1.Columns[1].Name = "Apellido";
            dataGridView1.Columns[2].Name = "Direccion";
            dataGridView1.Columns[3].Name = "Fecha de Nacimiento";
            dataGridView1.Columns[4].Name = "Edad";

            List<Cliente> clientes = clienteServicio.TraerClientes();
            foreach (Cliente c in clientes)
            {
                string[] row = new string[] { c.Nombre, c.Ape, 
                    c.Direccion, c.FechaNacimiento, c.GetEdad() };
                dataGridView1.Rows.Add(row);
            }
            
        }

    }
}