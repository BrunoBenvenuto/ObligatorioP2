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
        }

                    /*Precarga Usuarios*/
        private void PrecargarClientes()
        {
            Cliente cliente1 = new Cliente("Bruno", "Benvenuto", "brunob@test.com", "1234bruno", 123);
            Cliente cliente2 = new Cliente("Agustina", "Istebot", "agu@test.com", "1234agu", 1234);
            this.AgregarCliente(cliente1);
            this.AgregarCliente(cliente2);
        }

                    /*Precarga Administradores*/
        private void PrecargarAdministradores()
        {
            Administrador administrador1 = new Administrador("Jose", "Rodriguez", "jose@test.com", "1234jose");
            this.AgregarAdmin(administrador1);
        }


                    /*Metodos para clientes*/
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

                    /*Metodos para administradores*/
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

                    /*Lista de Clientes*/
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
    }
}
