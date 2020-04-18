using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoProgram
{
    class VentaRepuestos
    {
		private List<Repuesto> _listaProductos;

		private string _nombreComercio;

		private string _direccion;

		public VentaRepuestos(string _nombreComercio, string _direccion)
		{
			this._nombreComercio = _nombreComercio;
			this._direccion = _direccion;
			this._listaProductos = new List<Repuesto>();
		}

		public void AgregarRepuesto(Repuesto repuesto)
		{
			_listaProductos.Add(repuesto);
		}

		public void QuitarRepuesto(int codigo)
		{
			Repuesto repuesto = this._listaProductos.SingleOrDefault(producto => producto.Codigo == codigo);

			if (repuesto != null)
			{
				this._listaProductos.Remove(repuesto);
			}
			else
			{
				throw new Exception("El repuesto no está en la lista.");
			}
		}

		public void ModificarPrecio(int codigo, double precio)
		{
			Repuesto repuesto = this._listaProductos.SingleOrDefault(producto => producto.Codigo == codigo);
			if (repuesto != null)
			{
				repuesto.Precio = precio;
			}
			else
			{
				throw new Exception("El repuesto no está en la lista.");
			}
		}

		public void AgregarStock(int codigo, int cantidad)
		{
			if (cantidad < 1)
			{
				throw new Exception("No es una cantidad de stock valida.");
			}
			Repuesto repuesto = this._listaProductos.SingleOrDefault(producto => producto.Codigo == codigo);
			if (repuesto != null)
			{
				repuesto.Stock = repuesto.Stock + cantidad;
			}
			else
			{
				throw new Exception("El repuesto no está en la lista.");
			}
		}

		public void QuitarStock(int codigo, int cantidad)
		{
			if (cantidad < 1)
			{
				throw new Exception("No es una cantidad de stock valida.");
			}
			Repuesto repuesto = this._listaProductos.SingleOrDefault(producto => producto.Codigo == codigo);
			if (repuesto != null)
			{
				repuesto.Stock = repuesto.Stock - cantidad;
			}
			else
			{
				throw new Exception("El repuesto no está en la lista.");
			}
		}

		public List<Repuesto> TraerPorCategoria(int codigoCategoria)
		{
			List<Repuesto> resultado = new List<Repuesto>();
			foreach (Repuesto repuesto in _listaProductos)
			{
				if (repuesto.Categoria.Codigo == codigoCategoria)
				{
					resultado.Add(repuesto);
				}
			}
			return resultado;
		}

		public string Direccion
		{
			get { return _direccion; }
			set { _direccion = value; }
		}


		public string NombreComercio
		{
			get { return _nombreComercio; }
			set { _nombreComercio = value; }
		}


		public List<Repuesto> ListaProductos
		{
			get { return _listaProductos; }
			set { _listaProductos = value; }
		}


	}
}
