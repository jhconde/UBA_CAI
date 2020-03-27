using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00_Restaurante
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurante rodizio = new Restaurante();
            rodizio.setNombre("Rodizio");
            rodizio.atenderMesa(1);
            rodizio.atenderMesa(2);
            rodizio.facturar(2, 100);
            rodizio.facturar(1, 50);

            Console.WriteLine("Facturacion de " + rodizio.getNombre() + ": " + rodizio.getCapital());
            Console.ReadLine();

        }
    }
}
