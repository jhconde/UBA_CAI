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
    public partial class StockForm : Form
    {

        private Expendedora _expendedora;

        public StockForm(Expendedora expendedora)
        {
            InitializeComponent();
            InicializarStockLista();
        }

        private void InicializarStockLista()
        {
            for (int i = 0; i < _expendedora.Latas.Count; i++)
            {
                this.listView1.Items.Add(_expendedora.Latas[i].ToString());
            }
        }

    }
}
