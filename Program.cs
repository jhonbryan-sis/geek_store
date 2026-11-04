using System;

namespace geek_store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Tienda tienda = new Tienda();

            int opcion = 0;

           
            while (opcion != 5)
            {
                Console.WriteLine("\n========================");
                Console.WriteLine("       GEEK STORE");
                Console.WriteLine("========================");
                Console.WriteLine("1. Ver inventario y saldo de caja");
                Console.WriteLine("2. Añadir nuevo Comic");
                Console.WriteLine("3. Añadir nuevo Merchandising");
                Console.WriteLine("4. Realizar una venta");
                Console.WriteLine("5. Salir");
                Console.WriteLine("========================");

                Console.Write("Seleccione una opcion: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    
                    case 1:
                        {
                            Console.WriteLine("\n--- INVENTARIO ---");

                            tienda.MostrarInventario();

                            Console.WriteLine("\nSaldo de caja: " + tienda.SaldoCaja);

                            break;
                        }

                    
                    case 2:
                        {
                            Console.WriteLine("\n--- NUEVO COMIC ---");

                            Console.Write("ID: ");
                            int idComic = int.Parse(Console.ReadLine());

                            Console.Write("Nombre: ");
                            string nombreComic = Console.ReadLine();

                            Console.Write("Precio de venta: ");
                            double ventaComic = double.Parse(Console.ReadLine());

                            Console.Write("Volumen: ");
                            int volumen = int.Parse(Console.ReadLine());

                            Console.Write("Es variante (true/false): ");
                            bool variante = bool.Parse(Console.ReadLine());

                            Console.Write("Precio de costo: ");
                            double costoComic = double.Parse(Console.ReadLine());

                            Console.Write("Stock: ");
                            int stockComic = int.Parse(Console.ReadLine());

                            Comic comic = new Comic(
                                idComic,
                                nombreComic,
                                ventaComic,
                                volumen,
                                variante,
                                costoComic,
                                stockComic
                            );

                            Console.Write("Cantidad a comprar: ");
                            int cantidadComic = int.Parse(Console.ReadLine());

                            tienda.AgregarAlInventario(comic, cantidadComic);

                            Console.WriteLine("Comic agregado correctamente.");

                            break;
                        }

                  
                    case 3:
                        {
                            Console.WriteLine("\n--- NUEVO MERCHANDISING ---");

                            Console.Write("ID: ");
                            int idMerch = int.Parse(Console.ReadLine());

                            Console.Write("Nombre: ");
                            string nombreMerch = Console.ReadLine();

                            Console.Write("Precio de venta: ");
                            double ventaMerch = double.Parse(Console.ReadLine());

                            Console.Write("Tipo (Polera/Taza): ");
                            string tipo = Console.ReadLine();

                            Console.Write("Talla: ");
                            string talla = Console.ReadLine();

                            Console.Write("Precio de costo: ");
                            double costoMerch = double.Parse(Console.ReadLine());

                            Console.Write("Stock: ");
                            int stockMerch = int.Parse(Console.ReadLine());

                            Merchandising merch = new Merchandising(
                                idMerch,
                                nombreMerch,
                                ventaMerch,
                                tipo,
                                talla,
                                costoMerch,
                                stockMerch
                            );

                            Console.Write("Cantidad a comprar: ");
                            int cantidadMerch = int.Parse(Console.ReadLine());

                            tienda.AgregarAlInventario(merch, cantidadMerch);

                            Console.WriteLine("Merchandising agregado correctamente.");

                            break;
                        }

                    // OPCION 4
                    case 4:
                        {
                            Console.WriteLine("\n--- REALIZAR VENTA ---");

                            Console.Write("Ingrese ID del articulo: ");
                            int id = int.Parse(Console.ReadLine());

                            Console.Write("Ingrese cantidad a vender: ");
                            int cantidad = int.Parse(Console.ReadLine());

                            tienda.VenderArticulo(id, cantidad);

                            break;
                        }

                    // OPCION 5
                    case 5:
                        {
                            Console.WriteLine("\nGracias por visitar GEEK STORE.");

                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Opcion incorrecta.");

                            break;
                        }
                }
            }
        }
    }
}