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
            InicializarStockLista();
        }

        private void InicializarStockLista()
        {
            for (int i = 0; i < _expendedora.Latas.Count; i++)
            {
                Lata lata = _expendedora.Latas[i];
                this.listView1.Items.Add(lata.Codigo + " - " + lata.Nombre + " " + 
                    lata.Sabor + " " + lata.Volumen + "ml $" + lata.Precio);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
        }
    }
}
