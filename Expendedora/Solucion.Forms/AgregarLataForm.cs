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
    public partial class AgregarLataForm : Form
    {

        private Expendedora _expendedora;

        public AgregarLataForm(Expendedora expendedora)
        {
            InitializeComponent();
            _expendedora = expendedora;
            InicializarLista();
        }

        private void InicializarLista()
        {
            List<string> catalogo = ExpendedoraHelper.ObtenerCatalogo();
            for (int i = 0; i < catalogo.Count; i++)
            {
                this.listView1.Items.Add(catalogo[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Length == 0 ||
                this.textBox2.Text.Length == 0 ||
                this.textBox3.Text.Length == 0)
            {
                MessageBox.Show("Complete todos los campos");
                return;
            }

            string codigo = this.textBox1.Text;
            if (!ExpendedoraHelper.EsCodigoValido(codigo))
            {
                MessageBox.Show("Codigo invalido");
                return;
            }
            double precio = Double.Parse(this.textBox2.Text);
            double volumen = Double.Parse(this.textBox3.Text);
            string marca = ExpendedoraHelper.ObtenerMarca(codigo);
            string sabor = ExpendedoraHelper.ObtenerSabor(codigo);
            Lata lata = new Lata(codigo, marca, sabor, precio, volumen);
            _expendedora.AgregarLata(lata);
            MessageBox.Show("Lata Agregada");
            ExpendedoraBaseForm.ActualizarEstado(_expendedora);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = "";
            this.textBox2.Text = "";
            this.textBox3.Text = "";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                string textoLata = listView1.SelectedItems[0].Text;
                this.textBox1.Text = textoLata.Substring(0, 3);
            }
        }
    }
}
