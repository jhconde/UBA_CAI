using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Restaurante
{
    class Restaurante
    {
        string nombre;
        string especialidad;
        string sucursal;
        float capital = 0;

        public void facturar(int numeroMesa, float importe)
        {
            Console.WriteLine("Facturando a la mesa " + numeroMesa + " $" + importe);
            capital += importe; // aca el comporamiento cambia estado
        }

        public void atenderMesa(int numeroMesa)
        {
            Console.WriteLine("Atendiendo mesa " + numeroMesa);
            if (especialidad == "pasta") { // aca el valor del estado decide que accion tomar
                servirPlato("hondo");
            } else {
                servirPlato("comun");
            }
            Console.WriteLine("Mesa atendida " + numeroMesa);
        }

        private void servirPlato(string tipo)
        {
            Console.WriteLine("Sirviendo plato " + tipo);
        }
        
        public float getCapital()
        {
            return capital;
        }

        public string getNombre()
        {
            return nombre;
        }

        public void setNombre(string nombreParametro)
        {
            nombre = nombreParametro;
        }

    }
}
