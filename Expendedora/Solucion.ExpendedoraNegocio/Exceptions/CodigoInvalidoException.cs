using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.ExpendedoraNegocio.Exceptions
{
    public class CodigoInvalidoException: Exception
    {
        public CodigoInvalidoException(string mensaje) : base(mensaje)
        {
        }
    }
}
