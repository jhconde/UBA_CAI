using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VentaRepuestoProgram
{
    class Repuesto : Producto
    {

        // sobreescribir el metodo ToString() de la clase object
        public override string ToString() {
            return "Repuesto codigo: " + Codigo + ", nombre: " + Nombre + ", stock: " 
                + Stock + ", precio: " + Precio;
        }

    }
}
