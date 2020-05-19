using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.ExpendedoraNegocio.Entidades
{
    public class Expendedora
    {

        private static int CAPACIDAD_DEFAULT = 10;

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
            _latas = new List<Lata>();
        }

        public void AgregarLata(Lata lata)
        {
            // completar
        }

        public Lata ExtraerLata(string codigoLata, double dinero)
        {
            // completar
            return new Lata();
        }

        public string GetBalance()
        {
            // completar
            return "";
        }

        public int GetCapacidadRestante()
        {
            // completar
            return this.Capacidad - this.Latas.Count;
        }

        public void EncenderMaquina()
        {
            // completar
        }

        public bool EstaVacia()
        {
            // completar
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
