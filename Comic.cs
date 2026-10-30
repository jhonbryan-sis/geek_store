using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace geek_store
{
    internal class Comic : ArticuloTienda, IComercializable
    {
        public int Volumen { get; set; }
        public bool EsVariante { get; set; }

        public Comic(string nombre, double precioVenta, int volumen, bool esVariante)
        {
            Nombre = nombre;
            PrecioVenta = precioVenta;
            Volumen = volumen;
            EsVariante = esVariante;
        }

        public double CalcularTotalVenta(int cantidad)
        {
            double total = PrecioVenta * cantidad;

            if (EsVariante == true)
            {
                total = total * 1.20;
            }

            return total;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("----- COMIC -----");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + PrecioVenta);
            Console.WriteLine("Volumen: " + Volumen);
            Console.WriteLine("Es variante: " + EsVariante);
        }
    }
}
