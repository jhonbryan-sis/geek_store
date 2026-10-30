using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_store
{
    internal class Merchandising : ArticuloTienda, IComercializable
    {
        public string Tipo { get; set; }
        public string Talla { get; set; }

        public Merchandising(string nombre, double precioVenta, string tipo, string talla)
        {
            Nombre = nombre;
            PrecioVenta = precioVenta;
            Tipo = tipo;
            Talla = talla;
        }

        public double CalcularTotalVenta(int cantidad)
        {
            return PrecioVenta * cantidad;
        }

        public override void MostrarDetalles()
        {
            Console.WriteLine("----- MERCHANDISING -----");
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Precio: " + PrecioVenta);
            Console.WriteLine("Tipo: " + Tipo);
            Console.WriteLine("Talla: " + Talla);
        }
    }
}
