using Solucion.ExpendedoraNegocio.Entidades;
using Solucion.ExpendedoraNegocio.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Solucion.Forms
{
    public partial class ExpendedoraBaseForm : Form
    {
        private Expendedora expendedora;

        public ExpendedoraBaseForm()
        {
            InitializeComponent();
            expendedora = new Expendedora("Proveedor Test");
            this.label1.Text = "Usando la expendedora del proveedor: " + expendedora.Proveedor;
            ActualizarEstado();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            expendedora.EncenderMaquina();
            MessageBox.Show("Maquina Encendida");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ListaLatasForm f = new ListaLatasForm();
            f.Owner = this;
            f.Show();
            // this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            if (expendedora.GetCapacidadRestante() == 0)
            {
                MessageBox.Show("Maquina llena");
                return;
            }
            AgregarLataForm f = new AgregarLataForm(expendedora);
            f.Owner = this;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
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
            ExtraerLataForm f = new ExtraerLataForm(expendedora);
            f.Owner = this;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            MessageBox.Show(expendedora.GetBalance());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            if (expendedora.EstaVacia())
            {
                MessageBox.Show("Maquina Vacia");
                return;
            }
            StockForm f = new StockForm(expendedora);
            f.Owner = this;
            f.Show();
        }

        private void ExpendedoraBaseForm_Enter(object sender, EventArgs e)
        {
            ActualizarEstado();
        }

        private void ActualizarEstado()
        {
            this.label3.Text = "Capacidad " + expendedora.Capacidad;
            this.label5.Text = "Capacidad Restante " + expendedora.GetCapacidadRestante();
            this.label4.Text = "Dinero $" + expendedora.Dinero;
        }

    }
}
