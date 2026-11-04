..using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geek_store
{
    public class Tienda
    {
        private List<ArticuloTienda> inventario;

        public double SaldoCaja { get; set; }

        public Tienda()
        {
            inventario = new List<ArticuloTienda>();
            SaldoCaja = 1000.0;
        }

        public void AgregarAlInventario(
            ArticuloTienda nuevoArticulo,
            int cantidadAComprar)
        {
            SaldoCaja -= nuevoArticulo.PrecioCosto * cantidadAComprar;

            nuevoArticulo.Stock += cantidadAComprar;

            inventario.Add(nuevoArticulo);

            Console.WriteLine("Agregado al inventario");
        }

        public void MostrarInventario()
        {
            Console.WriteLine("\n===== INVENTARIO =====");

            foreach (ArticuloTienda articulo in inventario)
            {
                articulo.MostrarDetalles();
            }

            Console.WriteLine("\nSaldo de caja: " + SaldoCaja);
        }

        public void VenderArticulo(int idArticulo, int cantidadAVender)
        {
            ArticuloTienda articulo = inventario.FirstOrDefault(
                a => a.ID == idArticulo);

            if (articulo != null)
            {
                if (articulo.Stock >= cantidadAVender && cantidadAVender > 0)
                {
                    IComercializable comercializable =
                        (IComercializable)articulo;

                    double total = comercializable.CalcularTotalVenta(
                        cantidadAVender);

                    articulo.Stock -= cantidadAVender;
                    SaldoCaja += total;

                    Console.WriteLine("\n===== RECIBO DE VENTA =====");
                    Console.WriteLine("Articulo: " + articulo.Nombre);
                    Console.WriteLine("Cantidad: " + cantidadAVender);
                    Console.WriteLine("Total: Bs " + total);
                    Console.WriteLine("Venta realizada");
                }
                else
                {
                    Console.WriteLine("Stock insuficiente");
                }
            }
            else
            {
                Console.WriteLine("Articulo no encontrado");
            }
        }
    }
}
