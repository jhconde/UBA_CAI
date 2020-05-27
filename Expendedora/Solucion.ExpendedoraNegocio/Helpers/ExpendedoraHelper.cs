using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.ExpendedoraNegocio.Helpers
{
    public class ExpendedoraHelper
    {

        // [0] codigo, [1] nombre, [2] marca, [3] sabor 
        private static List<string[]> catalogoLatas = new List<string[]>();

        private static void InicializarCatalogo()
        {
            if (catalogoLatas.Count == 0)
            {
                catalogoLatas.Add(new string[] { "CO1", "Coca Cola Regular", "Coca Cola", "Regular" });
                catalogoLatas.Add(new string[] { "CO2", "Coca Cola Zero", "Coca Cola", "Zero" });
                catalogoLatas.Add(new string[] { "SP1", "Sprite Regular", "Sprite", "Regular" });
                catalogoLatas.Add(new string[] { "SP2", "Sprite Zero", "Sprite", "Zero" });
                catalogoLatas.Add(new string[] { "FA1", "Fanta Regular", "Fanta", "Regular" });
                catalogoLatas.Add(new string[] { "FA2", "Fanta Zero", "Fanta", "Zero" });
            }
        }

        public static List<string> ObtenerCatalogo()
        {
            InicializarCatalogo();
            List<string> nombres = new List<string>();
            for (int i = 0; i < catalogoLatas.Count; i++)
            {
                nombres.Add(catalogoLatas[i][0] + " - " + catalogoLatas[i][1]);
            }
            return nombres;
        }

        public static string ObtenerSabor(string codigo)
        {
            InicializarCatalogo();
            string sabor = null;
            for (int i = 0; i < catalogoLatas.Count; i++)
            {
                if (catalogoLatas[i][0] == codigo)
                {
                    sabor = catalogoLatas[i][3];
                    break;
                }
            }
            return sabor;
        }

        public static string ObtenerMarca(string codigo)
        {
            InicializarCatalogo();
            string marca = null;
            for (int i = 0; i < catalogoLatas.Count; i++)
            {
                if (catalogoLatas[i][0] == codigo)
                {
                    marca = catalogoLatas[i][2];
                    break;
                }
            }
            return marca;
        }

        public static bool EsCodigoValido(string codigo)
        {
            InicializarCatalogo();
            for (int i = 0; i < catalogoLatas.Count; i++)
            {
                if (catalogoLatas[i][0] == codigo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
