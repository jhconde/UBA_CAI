using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Solucion.ExpendedoraNegocio.Entidades;
using Solucion.ExpendedoraNegocio.Helpers;

namespace Solucion.Forms
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new ExpendedorBaseForm());
            Expendedora expendedora = new Expendedora("Proveedor Test");
            ExpendedoraHelper.InicializarLatas(expendedora);
            Application.Run(new ExpendedoraBaseForm(expendedora));

        }
    }
}
