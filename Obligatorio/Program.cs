using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using LogicaNegocio;

namespace Obligatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Alta de Articulo");
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
            foreach (Cliente unCliente in sistema.Clientes)
            {
                Console.WriteLine($"{unCliente.Nombre} {unCliente.Apellido}");
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
    }
}
