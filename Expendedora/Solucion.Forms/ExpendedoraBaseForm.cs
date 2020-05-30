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
        private Expendedora _expendedora;
        private static Label _label3;
        private static Label _label4;
        private static Label _label5;

        public ExpendedoraBaseForm(Expendedora expendedoraParametro)
        {
            InitializeComponent();
            _expendedora = expendedoraParametro;
            this.label1.Text = "Usando la expendedora del proveedor: " + _expendedora.Proveedor;
            _label3 = this.label3;
            _label4 = this.label4;
            _label5 = this.label5;
            ActualizarEstado(_expendedora);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _expendedora.EncenderMaquina();
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
            if (!_expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            if (_expendedora.GetCapacidadRestante() == 0)
            {
                MessageBox.Show("Maquina llena");
                return;
            }
            AgregarLataForm f = new AgregarLataForm(_expendedora);
            f.Owner = this;
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!_expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            if (_expendedora.EstaVacia())
            {
                MessageBox.Show("Maquina Vacia");
                return;
            }
            ExtraerLataForm f = new ExtraerLataForm(_expendedora);
            f.Owner = this;
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!_expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            MessageBox.Show(_expendedora.GetBalance());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!_expendedora.Encendida)
            {
                MessageBox.Show("Maquina apagada");
                return;
            }
            if (_expendedora.EstaVacia())
            {
                MessageBox.Show("Maquina Vacia");
                return;
            }
            StockForm f = new StockForm(_expendedora);
            f.Owner = this;
            f.Show();
        }

        public static void ActualizarEstado(Expendedora expendedora)
        {
            _label3.Text = "Capacidad " + expendedora.Capacidad;
            _label5.Text = "Capacidad Restante " + expendedora.GetCapacidadRestante();
            _label4.Text = "Dinero $" + expendedora.Dinero;
        }

    }
}
