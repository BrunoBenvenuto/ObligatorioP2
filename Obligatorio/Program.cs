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
                        Console.WriteLine("Adios Profe! No se olvide poner buena nota :)");
                        break;
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Listado de Clientes:\n");
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
                                articulo.Nombre = nombre;
                                Console.WriteLine("Ingrese la categoria: ");
                                string categoria = Console.ReadLine();
                                articulo.Categoria = categoria;
                                Console.WriteLine("Ingrese el precio: ");
                                decimal precioArticulo = decimal.Parse(Console.ReadLine());
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
                        Console.WriteLine("Publicaciones entre dos fechas.");
                        MostrarPublicaciones();
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

            if (sistema.ObtenerClientes().Count == 0) 
            {
                Console.WriteLine("No existen Clientes");
            }
            else
            {
                foreach (Usuario unUsuario in sistema.ObtenerClientes())
                {
                    Console.WriteLine(unUsuario);
                    Console.WriteLine("----------------------------");
                }
            }
            Console.WriteLine("Presione cualquier tecla para volver al menu");
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
            string categoriaABuscar = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Resultado de la busqueda: " + categoriaABuscar + "\n");

            try {
                foreach (Articulo unArticulo in sistema.BuscarArticulosPorCategoria(categoriaABuscar))
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

        static void MostrarPublicaciones() {
            Sistema sistema = Sistema.Instancia;
            bool seIngreso4 = false;
            while (!seIngreso4)
            {
                try
                {
                    Console.WriteLine("Teniendo en cuenta el siguiente formato dd-mm-aaaa\nIngrese la fecha de inicio:");
                    string fechaIngresada1 = Console.ReadLine();
                    DateTime fechaInicio = DateTime.Parse(fechaIngresada1);

                    Console.WriteLine("Ingrese la fecha de finalizacion:");
                    string fechaIngresada2 = Console.ReadLine();
                    DateTime fechaFinal = DateTime.Parse(fechaIngresada2);

                    Console.WriteLine("\n\nLas fechas ingresada son:\nFecha Inicial: " + fechaInicio + "\nFecha Final: " + fechaFinal);
                    Console.WriteLine("\n---------------------\nSi la solicitud es correcta escriba SI");
                    string respuesta = Console.ReadLine();
                    if (respuesta.ToLower() == "si")
                    {
                        seIngreso4 = true;
                    }
                    try
                    {
                        List<Publicacion> lista = sistema.ListarPublicacionesEntreFechas(fechaInicio, fechaFinal);

                        if (lista.Count == 0)
                        {
                            Console.WriteLine("\nNo se encontraron resultados\nVuelve a intentarlo con nuevas fechas...");
                        }
                        else
                        {
                            foreach (Publicacion unaPublicacion in lista)
                            {
                                Console.WriteLine(unaPublicacion);
                                Console.WriteLine("----------------------");
                            }
                                Console.WriteLine("\n\nPreciona cualquier tecla para volver al menu");
                        }
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error Categoria invalida... Presione cualquier letra para volver al menu");
                        Console.ReadLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
