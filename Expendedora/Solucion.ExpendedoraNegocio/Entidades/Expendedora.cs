using Solucion.ExpendedoraNegocio.Exceptions;
using Solucion.ExpendedoraNegocio.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.ExpendedoraNegocio.Entidades
{
    public class Expendedora
    {

        private static int CAPACIDAD_DEFAULT = 20;

        private List<Lata> _latas;
        private string _proveedor;
        private int _capacidad;
        private double _dinero;
        private bool _encendida;

        public Expendedora(string _proveedorParam)
        {
            _proveedor = _proveedorParam;
            _encendida = false;
            _capacidad = CAPACIDAD_DEFAULT;
            _dinero = 0;
            _latas = InicializarLatas();
        }

        private List<Lata> InicializarLatas()
        {
            // agregamos 12 latas al azar
            List<Lata> latas = new List<Lata>();
            string codigoCocaRegular = "CO1";
            string codigoCocaZero = "CO2";
            string codigoSpriteRegular = "SP1";
            string codigoSpriteZero = "SP2";
            string codigoFantaRegular = "FA1";
            string codigoFantaZero = "FA2";
            latas.Add(new Lata(codigoCocaRegular, ExpendedoraHelper.ObtenerMarca(codigoCocaRegular), ExpendedoraHelper.ObtenerSabor(codigoCocaRegular), 100, 350));
            latas.Add(new Lata(codigoCocaRegular, ExpendedoraHelper.ObtenerMarca(codigoCocaRegular), ExpendedoraHelper.ObtenerSabor(codigoCocaRegular), 200, 500));
            latas.Add(new Lata(codigoCocaZero, ExpendedoraHelper.ObtenerMarca(codigoCocaZero), ExpendedoraHelper.ObtenerSabor(codigoCocaZero), 100, 350));
            latas.Add(new Lata(codigoCocaZero, ExpendedoraHelper.ObtenerMarca(codigoCocaZero), ExpendedoraHelper.ObtenerSabor(codigoCocaZero), 200, 500));
            latas.Add(new Lata(codigoSpriteRegular, ExpendedoraHelper.ObtenerMarca(codigoSpriteRegular), ExpendedoraHelper.ObtenerSabor(codigoSpriteRegular), 100, 350));
            latas.Add(new Lata(codigoSpriteRegular, ExpendedoraHelper.ObtenerMarca(codigoSpriteRegular), ExpendedoraHelper.ObtenerSabor(codigoSpriteRegular), 200, 500));
            latas.Add(new Lata(codigoSpriteZero, ExpendedoraHelper.ObtenerMarca(codigoSpriteZero), ExpendedoraHelper.ObtenerSabor(codigoSpriteZero), 100, 350));
            latas.Add(new Lata(codigoSpriteZero, ExpendedoraHelper.ObtenerMarca(codigoSpriteZero), ExpendedoraHelper.ObtenerSabor(codigoSpriteZero), 200, 500));
            latas.Add(new Lata(codigoFantaRegular, ExpendedoraHelper.ObtenerMarca(codigoFantaRegular), ExpendedoraHelper.ObtenerSabor(codigoFantaRegular), 100, 350));
            latas.Add(new Lata(codigoFantaRegular, ExpendedoraHelper.ObtenerMarca(codigoFantaRegular), ExpendedoraHelper.ObtenerSabor(codigoFantaRegular), 200, 500));
            latas.Add(new Lata(codigoFantaZero, ExpendedoraHelper.ObtenerMarca(codigoFantaZero), ExpendedoraHelper.ObtenerSabor(codigoFantaZero), 100, 350));
            latas.Add(new Lata(codigoFantaZero, ExpendedoraHelper.ObtenerMarca(codigoFantaZero), ExpendedoraHelper.ObtenerSabor(codigoFantaZero), 200, 500));
            return latas;
        }

        public void AgregarLata(Lata lata)
        {
            _latas.Add(lata);

        }

        public Lata ExtraerLata(string codigoLata, double dinero)
        {
            if (!codigoLata.Contains("-"))
            {
                throw new CodigoInvalidoException("Formato de codigo incorrecto");
            }
            string[] codigoLataArray = codigoLata.Split('-');
            string codigo = codigoLataArray[0];
            double volumen = Double.Parse(codigoLataArray[1]);
            Lata lata = null;
            for  (int i = 0; i < _latas.Count; i++)
            {
                if (_latas[i].Codigo == codigo && _latas[i].Volumen == volumen)
                {
                    lata = _latas[i];
                    break;
                }
            }

            if (lata == null)
            {
                throw new SinStockException("Actualmente no hay stock de " + codigoLata);
            }

            if (lata.Precio > dinero)
            {
                throw new DineroInsuficienteException("La lata sale " + lata.Precio + ", el usuario ingresó " + dinero);
            }

            _latas.Remove(lata);
            return lata;
        }

        public string GetBalance()
        {
            return "Dinero: " + _dinero + ", latas: " + _latas.Count;
        }

        public List<string> GetStockDetalle()
        {
            List<string> stockDetalle = new List<string>();
            for (int i = 0; i < _latas.Count; i++)
            {
                stockDetalle.Add(_latas[i].Codigo + " - " + _latas[i].Nombre + ", vol " + _latas[i].Volumen + " $" + _latas[i].Precio);
            }
            return stockDetalle;
        }

        public int GetCapacidadRestante()
        {
            return this.Capacidad - this.Latas.Count;
        }

        public void EncenderMaquina()
        {
            _encendida = true;
        }

        public bool EstaVacia()
        {
            return _latas.Count == 0;
        }

        // Getters/Setters
        public List<Lata> Latas
        {
            get { return _latas; }
            set { _latas = value; }
        }

        public string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public int Capacidad
        {
            get { return _capacidad; }
            set { _capacidad = value; }
        }

        public double Dinero
        {
            get { return _dinero; }
            set { _dinero = value; }
        }

        public bool Encendida
        {
            get { return _encendida; }
            set { _encendida = value; }
        }
    }
}
