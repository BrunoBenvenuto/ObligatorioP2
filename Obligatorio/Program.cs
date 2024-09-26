using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using LogicaNegocio;

namespace Obligatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = Sistema.Instancia;
            string seleccion = "";
            while (seleccion != "0")
            {
                Console.Clear();
                MostrarMenu();
                seleccion = Console.ReadLine();
                switch(seleccion)
                {
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Hasta Luego.");
                        break;
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Listado de Clientes:");
                        MostrarClientes();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Dado un nombre de categoría listar todos los artículos de esa categoría");
                        MostrarCategorias();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Alta de Articulo: ");
                        bool seIngreso = false;
                        while (!seIngreso)
                        {
                            try
                            {
                                Articulo articulo = new Articulo();
                                Console.WriteLine("Ingrese el nombre: ");
                                string nombre = Console.ReadLine();
                                //Articulo.ValidarNombre(nombre);
                                articulo.Nombre = nombre;
                                Console.WriteLine("Ingrese la categoria: ");
                                string categoria = Console.ReadLine();
                                //Articulo.ValidarCategoria(categoria);
                                articulo.Categoria = categoria;
                                Console.WriteLine("Ingrese el precio: ");
                                decimal precioArticulo = decimal.Parse(Console.ReadLine());
                                //Articulo.ValidarPrecio(precioArticulo);
                                articulo.PrecioArticulo = precioArticulo;

                                sistema.AgregarArticulo(articulo);
                                seIngreso = true;
                                Console.Clear();
                                Console.WriteLine("Se ingresó el artículo: \n" + articulo);
                                Console.WriteLine("Presione enter para volver al menu.");
                                Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Dadas dos fechas listar las publicaciones entre esas fechas. Mostrar Id, nombre estado y fecha de publicación.");
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Opción inválida. Presione enter para volver al menu.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void MostrarClientes()
        {
            Sistema sistema = Sistema.Instancia;
            foreach (Usuario unUsuario in sistema.ObtenerClientes())
            {
                Console.WriteLine($"{unUsuario.Nombre} {unUsuario.Apellido}");
                Console.WriteLine("----------------------------");
            }
            Console.ReadLine();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("Obligatorio");
            Console.WriteLine("1 - Ver listado de clientes");
            Console.WriteLine("2 - Ver artículos de una categoría");
            Console.WriteLine("3 - Alta de artículo");
            Console.WriteLine("4 - Publicaciones existentes en fechas especificas");
            Console.WriteLine("0 - Salir");
        }

        static void MostrarCategorias()
        {
            Sistema sistema = Sistema.Instancia;
            List<string> categoriasUnicas = new List<string>();

            Console.WriteLine("Lista de Categorias:");
            foreach (Articulo unArticulo in sistema.Articulos)
            {
                if (!categoriasUnicas.Contains(unArticulo.Categoria))
                {
                    categoriasUnicas.Add(unArticulo.Categoria);
                    Console.WriteLine("- " + unArticulo.Categoria);
                }
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Escriba el nombre de la categoria que desea filtrar:");
            string categiruaABuscar = Console.ReadLine();
            Console.WriteLine("---------------------------------\n\nResultado de la busqueda:\n");

            try {
                foreach (Articulo unArticulo in sistema.BuscarArticulosPorCategoria(categiruaABuscar))
                {
                    Console.WriteLine(unArticulo);
                    Console.WriteLine("----------------------");
                }
                Console.WriteLine("\n\nPreciona cualquier tecla para volver al menu");
                Console.ReadLine();
            } 
            catch (Exception e) {
                Console.WriteLine("Error Categoria invalida... Presione cualquier letra para volver al menu");
                Console.ReadLine();
            }
            
        }
    }
}
