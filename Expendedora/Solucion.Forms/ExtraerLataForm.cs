using Solucion.ExpendedoraNegocio.Entidades;
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
    public partial class ExtraerLataForm : Form
    {
        private Expendedora _expendedora;

        public ExtraerLataForm(Expendedora expendedora)
        {
            InitializeComponent();
            _expendedora = expendedora;
            ActualizarStockLista();
        }

        private void ActualizarStockLista()
        {
            this.listView1.Items.Clear();
            for (int i = 0; i < _expendedora.Latas.Count; i++)
            {
                Lata lata = _expendedora.Latas[i];
                this.listView1.Items.Add(lata.Codigo + " - " + lata.Nombre + " " + 
                    lata.Sabor + " " + lata.Volumen + "ml $" + lata.Precio);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0 || this.textBox2.Text.Length == 0) {
                MessageBox.Show("Complete los campos");
                return;
            }

            string codigoCompuesto = this.textBox1.Text;
            double dinero = Double.Parse(this.textBox2.Text);
            Lata lata;
            try
            {
                lata = _expendedora.ExtraerLata(codigoCompuesto, dinero);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Lata extraida: " + lata);
            ActualizarStockLista();
            ExpendedoraBaseForm.ActualizarEstado(_expendedora);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Lata lataSeleccionada = _expendedora.Latas[ObtenerIndiceSeleccionado(listView1)];
            this.textBox1.Text = lataSeleccionada.Codigo + "-" + lataSeleccionada.Volumen;
        }

        private int ObtenerIndiceSeleccionado(ListView listView)
        {
            if (listView.SelectedItems.Count > 0)
            {
                for (int i = 0; i < listView.Items.Count; i++)
                {
                    if (listView.Items[i].Selected)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }

    }
}
