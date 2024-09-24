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
        //private List<Usuario> _usuarios = new List<Usuario>();
        private List<Cliente> _clientes = new List<Cliente>();
        private List<Administrador> _administradores = new List<Administrador>();
        private List<Articulo> _articulos = new List<Articulo>();
        //private List<Publicacion> _publicaciones = new List<Publicacion>();

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

        public List<Cliente> Clientes { get { return _clientes; } }
        public List<Administrador> Administradores { get { return _administradores; } }
        public List<Articulo> Articulos { get {  return _articulos; } }
        //public List<Publicacion> Publicaciones { get {  return _publicaciones; } }

        private Sistema()
        {
            this.Precargar();
        }

        public void Precargar()
        {
            this.PrecargarClientes();
            this.PrecargarAdministradores();
        }

                    /*Precarga Usuarios*/
        private void PrecargarClientes()
        {
            Cliente cliente1 = new Cliente("Bruno", "Benvenuto", "brunob@test.com", "1234bruno", 123);
            Cliente cliente2 = new Cliente("Agustina", "Istebot", "agu@test.com", "1234agu", 1234);
            this.AgregarUsuario(cliente1);
            this.AgregarUsuario(cliente2);
        }

                    /*Precarga Administradores*/
        private void PrecargarAdministradores()
        {
            Administrador administrador1 = new Administrador("Jose", "Rodriguez", "jose@test.com", "1234jose");
            this.AgregarAdmin(administrador1);
        }

                    /*Metodos para clientes*/
        public void AgregarUsuario(Cliente unCliente)
        {
            try
            {
                this.ExisteCliente(unCliente);
                this._clientes.Add(unCliente);
            }
            catch (Exception e) 
            {
                throw new Exception(e.Message);
            }
        }

        public void ExisteCliente(Cliente otroCliente)
        {
            if (this._clientes.Contains(otroCliente))
            {
                throw new Exception("El cliente ya existe.");
            }
        }

                    /*Metodos para administradores*/
        public void AgregarAdmin(Administrador unAdmin)
        {
            try
            {
                this.ExisteAdmin(unAdmin);
                this._administradores.Add(unAdmin);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ExisteAdmin(Administrador otroAdmin)
        {
            if (this._administradores.Contains(otroAdmin))
            {
                throw new Exception("El administrador ya existe.");
            }
        }
    }
}
