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
    public partial class ClienteBaseForm : Form
    {
        public ClienteBaseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListaCompletaForm form = new ListaCompletaForm(null, null);
            form.Owner = this;
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            bool esNumero = validarNumero(this.textBox1.Text);
            if (esNumero)
            {
                ListaCompletaForm form = new ListaCompletaForm("edad", this.textBox1.Text);
                form.Owner = this;
                form.Show();
            } else
            {
                MessageBox.Show("Edad incorrecta");
            }
            
        }

        private bool validarNumero(string valor)
        {
            return int.TryParse(valor, out _);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListaCompletaForm form = new ListaCompletaForm("apellido", this.textBox2.Text);
            form.Owner = this;
            form.Show();
        }
    }
}
