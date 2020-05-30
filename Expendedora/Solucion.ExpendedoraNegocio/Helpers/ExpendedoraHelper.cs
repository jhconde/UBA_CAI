using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Solucion.ExpendedoraNegocio.Entidades;

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

        public static void InicializarLatas(Expendedora expendedora)
        {
            // agregamos 12 latas al azar
            string codigoCocaRegular = "CO1";
            string codigoCocaZero = "CO2";
            string codigoSpriteRegular = "SP1";
            string codigoSpriteZero = "SP2";
            string codigoFantaRegular = "FA1";
            string codigoFantaZero = "FA2";
            expendedora.Latas = new List<Lata>();
            expendedora.Latas.Add(new Lata(codigoCocaRegular, ObtenerMarca(codigoCocaRegular), ObtenerSabor(codigoCocaRegular), 100, 350));
            expendedora.Latas.Add(new Lata(codigoCocaRegular, ObtenerMarca(codigoCocaRegular), ObtenerSabor(codigoCocaRegular), 200, 500));
            expendedora.Latas.Add(new Lata(codigoCocaZero, ObtenerMarca(codigoCocaZero), ObtenerSabor(codigoCocaZero), 100, 350));
            expendedora.Latas.Add(new Lata(codigoCocaZero, ObtenerMarca(codigoCocaZero), ObtenerSabor(codigoCocaZero), 200, 500));
            expendedora.Latas.Add(new Lata(codigoSpriteRegular, ObtenerMarca(codigoSpriteRegular), ObtenerSabor(codigoSpriteRegular), 100, 350));
            expendedora.Latas.Add(new Lata(codigoSpriteRegular, ObtenerMarca(codigoSpriteRegular), ObtenerSabor(codigoSpriteRegular), 200, 500));
            expendedora.Latas.Add(new Lata(codigoSpriteZero, ObtenerMarca(codigoSpriteZero), ObtenerSabor(codigoSpriteZero), 100, 350));
            expendedora.Latas.Add(new Lata(codigoSpriteZero, ObtenerMarca(codigoSpriteZero), ObtenerSabor(codigoSpriteZero), 200, 500));
            expendedora.Latas.Add(new Lata(codigoFantaRegular, ObtenerMarca(codigoFantaRegular), ObtenerSabor(codigoFantaRegular), 100, 350));
            expendedora.Latas.Add(new Lata(codigoFantaRegular, ObtenerMarca(codigoFantaRegular), ObtenerSabor(codigoFantaRegular), 200, 500));
            expendedora.Latas.Add(new Lata(codigoFantaZero, ObtenerMarca(codigoFantaZero), ObtenerSabor(codigoFantaZero), 100, 350));
            expendedora.Latas.Add(new Lata(codigoFantaZero, ObtenerMarca(codigoFantaZero), ObtenerSabor(codigoFantaZero), 200, 500));
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
