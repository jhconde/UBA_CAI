using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.ExpendedoraNegocio.Entidades
{
    public class Lata
    {
        private string _codigo;
        private string _nombre;
        private string _sabor;
        private double _precio;
        private double _volumen;

        public Lata(string codigo, string nombre, string sabor, double precio, double volumen)
        {
            _codigo = codigo;
            _nombre = nombre;
            _sabor = sabor;
            _precio = precio;
            _volumen = volumen;
        }

        private double GetPrecioPorLitro()
        {
            return 1000 * _precio / _volumen;
        }

        // Getters/Setters
        public string Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Sabor
        {
            get { return _sabor; }
            set { _sabor = value; }
        }

        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public double Volumen
        {
            get { return _volumen; }
            set { _volumen = value; }
        }

        public override string ToString()
        {
            return _nombre + " - " + _sabor + " $" + _precio + " /  $/L " + (int) GetPrecioPorLitro();
        }
    }
}
