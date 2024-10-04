using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Sistema
    {
        /*SINGLETON*/
        private static Sistema _instancia;

        /*Atributos*/
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public static Sistema Instancia
        {
            get
            {
                if(_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }

        public List<Usuario> Usuarios { get { return _usuarios; } }
        public List<Articulo> Articulos { get {  return _articulos; } }
        public List<Publicacion> Publicaciones { get {  return _publicaciones; } }

        private Sistema()
        {
            this.Precargar();
        }

        public void Precargar()
        {
            this.PrecargarClientes();
            this.PrecargarAdministradores();
            this.PrecargarArticulos();
            this.PrecargarPublicaciones();
        }

        /*------------------------Precarga Usuarios------------------------*/
        private void PrecargarClientes()
        {
            Cliente cliente1 = new Cliente(
                "Bruno", "Benvenuto", "brunob@test.com", "1234bruno", 123);
            Cliente cliente2 = new Cliente(
                "Agustina", "Istebot", "agu@test.com", "1234agu", 1234);
            Cliente cliente3 = new Cliente(
                "María", "García López", "maria.garcia@email.com", "password1", 1250);
            Cliente cliente4 = new Cliente(
                "Juan", "Rodríguez Fernández", "juan.rodriguez@email.com", "password2", 8500);
            Cliente cliente5 = new Cliente(
                "Sofía", "Martínez Gómez", "sofia.martinez@email.com", "password3", 1450);
            Cliente cliente6 = new Cliente(
                "Pedro", "Sánchez Herrera", "pedro.sanchez@email.com", "password4", 620);
            Cliente cliente7 = new Cliente(
                "Laura", "Fernández Ruiz", "laura.fernandez@email.com", "password5", 920);
            Cliente cliente8 = new Cliente(
                "Andrés", "Gutiérrez Díaz", "andres.gutierrez@email.com", "password6", 1130);
            Cliente cliente9 = new Cliente(
                "Carmen", "Torres Moreno", "carmen.torres@email.com", "password7", 785);
            Cliente cliente10 = new Cliente(
                "Alejandro", "Mendoza Vargas", "alejandro.mendoza@email.com", "password10", 990);

            this.AgregarCliente(cliente1);
            this.AgregarCliente(cliente2);
            this.AgregarCliente(cliente3);
            this.AgregarCliente(cliente4);
            this.AgregarCliente(cliente5);
            this.AgregarCliente(cliente6);
            this.AgregarCliente(cliente7);
            this.AgregarCliente(cliente8);
            this.AgregarCliente(cliente9);
            this.AgregarCliente(cliente10);
        }         

        /*------------------------Precarga Administradores------------------------*/
        private void PrecargarAdministradores()
        {
            Administrador administrador1 = new Administrador(
                "Jose", "Rodriguez", "jose@gmail.com", "1234jose");
            Administrador administrador2 = new Administrador(
                "Mauro", "Daverio", "mdaverio@tremendomail.com", "ItsMeMario");

            this.AgregarAdmin(administrador1);
            this.AgregarAdmin(administrador2);
        }

        /*------------------------Precarga Articulos------------------------*/
        private void PrecargarArticulos()
        {
            Articulo articulo1 = new Articulo("Caja", "Papeleria", 200);
            Articulo articulo2 = new Articulo("Cuaderno", "Papeleria", 300);
            Articulo articulo3 = new Articulo("Pintura Roja", "Pintura", 50);
            Articulo articulo4 = new Articulo("Caramelo", "Golosina", 3);
            Articulo articulo5 = new Articulo("Alfajor", "Golosina", 50);
            Articulo articulo6 = new Articulo("Caramelo de Miel", "Golosina", 4);
            Articulo articulo7 = new Articulo("Alfajor Juanito", "Golosina", 70);
            this.AgregarArticulo(articulo1);
            this.AgregarArticulo(articulo2);
            this.AgregarArticulo(articulo3);
            this.AgregarArticulo(articulo4);
            this.AgregarArticulo(articulo5);
            this.AgregarArticulo(articulo6);
            this.AgregarArticulo(articulo7);
        }

        /*------------------------Precarga Pulicaciones------------------------*/
        private void PrecargarPublicaciones()
        {

            Venta venta1 = new Venta(
                            "Guía de Papelería",
                            DateTime.Parse("24-04-1993"),
                            DateTime.Parse("30-04-1993"),
                            100,
                            true);

            Venta venta2 = new Venta(
                            "Catálogo de Arte",
                            DateTime.Parse("10-06-2001"),
                            DateTime.Parse("15-06-2001"),
                            3245,
                            false);

            Venta venta3 = new Venta(
                            "Revista de Tecnología",
                            DateTime.Parse("05-10-2020"),
                            DateTime.Parse("12-10-2020"),
                            6788,
                            true); 
            
            this.AgregarPublicacion(venta1);
            this.AgregarPublicacion(venta2);
            this.AgregarPublicacion(venta3);
        }

        /*------------------------Metodos para clientes------------------------*/
        public void AgregarCliente(Cliente unCliente)
        {
            try
            {
                this.ExisteCliente(unCliente);
                this._usuarios.Add(unCliente);
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        public void ExisteCliente(Cliente otroCliente)
        {
            if (this._usuarios.Contains(otroCliente))
            {
                throw new Exception("El usuario ya existe.");
            }
        }

        /*------------------------Metodos para administradores------------------------*/
        public void AgregarAdmin(Administrador unAdmin)
        {
            try
            {
                this.ExisteAdmin(unAdmin);
                this._usuarios.Add(unAdmin);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ExisteAdmin(Administrador otroAdmin)
        {
            if (this._usuarios.Contains(otroAdmin))
            {
                throw new Exception("El usuario ya existe.");
            }
        }

        /*------------------------Lista de Clientes------------------------*/
        public List<Usuario> ObtenerClientes()
        {
            List<Usuario> aRetornar = new List<Usuario>();
            foreach(Usuario u in this._usuarios)
            {
                if(u is Cliente)
                {
                    aRetornar.Add(u);
                }
            }
            return aRetornar;   
        }

        /*------------------------Metodo para Articulos------------------------*/

        public void AgregarArticulo(Articulo unArticulo)
        {
            try
            {
                this._articulos.Add(unArticulo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Articulo> BuscarArticulosPorCategoria(string unaCategoria) {
            List<Articulo> aRetornar = new List<Articulo>();
            foreach (Articulo unArticulo in this.Articulos)
            {
                if (unArticulo.Categoria.ToLower() == unaCategoria.ToLower())
                {
                    aRetornar.Add(unArticulo);
                }
            }
            if (aRetornar.Count == 0) throw new Exception("No existen publicaciones con ese genero");
            return aRetornar;
        }

        /*------------------------Metodo para Publicaciones------------------------*/
        public void AgregarPublicacion(Publicacion unaNuevaPublicacion)
        {
            try
            {
                this._publicaciones.Add(unaNuevaPublicacion);
                //NOTA NO SE OLVIDEN DE VALIDAR ALGO
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Publicacion> ListarPublicacionesEntreFechas(DateTime fechaInicio, DateTime fechaFinal) {
            Console.Clear();
            Console.WriteLine("-------------------------------\nEl resultado de la busqueda es:");
            List<Publicacion> listaPublicacionesFiltradas = new List<Publicacion>();
            foreach (Publicacion p in this.Publicaciones)
            {

                if (p.FechaPubliblicaion > fechaInicio && p.FechaPubliblicaion < fechaFinal) {
                    listaPublicacionesFiltradas.Add(p);

                }
            }
            return listaPublicacionesFiltradas;
        }
    }
}
