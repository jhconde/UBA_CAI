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
            ListaCompletaForm form = new ListaCompletaForm();
            form.Owner = this;
            form.Show();
        }
    }
}
