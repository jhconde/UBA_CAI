using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoProgram
{
    class Producto
    {

        private int _codigo;

        private string _nombre;

        private double _precio;

        private int _stock;

        private Categoria _categoria;

        public int Codigo
        {
            get { return _codigo; }
            set { _codigo = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public int Stock
        {
            get { return _stock; }
            set {
                if (value < 0)
                {
                    throw new Exception("Stock negativo");
                }
                _stock = value; 
            }
        }
        public Categoria Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

    }
}
