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
        }

        /*------------------------Precarga Usuarios------------------------*/
        private void PrecargarClientes()
        {
            Cliente cliente1 = new Cliente("Bruno", "Benvenuto", "brunob@test.com", "1234bruno", 123);
            Cliente cliente2 = new Cliente("Agustina", "Istebot", "agu@test.com", "1234agu", 1234);
            this.AgregarCliente(cliente1);
            this.AgregarCliente(cliente2);
        }

        /*------------------------Precarga Administradores------------------------*/
        private void PrecargarAdministradores()
        {
            Administrador administrador1 = new Administrador("Jose", "Rodriguez", "jose@test.com", "1234jose");
            this.AgregarAdmin(administrador1);
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
                if (unArticulo.Categoria == unaCategoria)
                {
                    aRetornar.Add(unArticulo);
                }
            }
            if (aRetornar.Count == 0) throw new Exception("No existen publicaciones con ese genero");
            return aRetornar;
        }
    }
}
