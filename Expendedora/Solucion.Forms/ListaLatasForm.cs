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
    public partial class ListaLatasForm : Form
    {
        public ListaLatasForm()
        {
            InitializeComponent();
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
    }
}
