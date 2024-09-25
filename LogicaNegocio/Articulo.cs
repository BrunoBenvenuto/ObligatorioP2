using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Articulo
    {
        /* Atributo estatico */
        private static int s_ultimoId = 0;

        /* Atributos */
        private int _id;
        private string _nombre;
        private string _categoria;
        private decimal _precioArticulo;

        /* Métodos */
        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Categoria
        {
            get { return _categoria; }
            set { _categoria = value; }
        }

        public decimal PrecioArticulo
        {
            get { return _precioArticulo; }
            set { _precioArticulo = value; }
        }

        /* Constructores */
        public Articulo()
        {
            this._id = Articulo.s_ultimoId++;
        }

        public Articulo(string unNombre, string unaCategoria, decimal unPrecioArticulo)
        {
            this._id = Articulo.s_ultimoId++;
            this._nombre = unNombre;
            this._categoria = unaCategoria;
            this._precioArticulo = unPrecioArticulo;
        }

        /*----------------------- Metodo ToString ----------------------*/
        public override string ToString()
        {
            return " - Id: " + this.Id +
                "\n - Nombre: " + this.Nombre +
                "\n - Categoria: " + this.Categoria +
                "\n - Precio: " + this.PrecioArticulo;
        }
    }
}
