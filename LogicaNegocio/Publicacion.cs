using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public abstract class Publicacion
    {
        /* Atributo estatico */
        private static int s_ultimoId = 0;

        /* Atributos */
        private int _id;
        private string _nombre;
        private Estado _estado;
        private DateTime _fechaPublicacion;
        private DateTime _fechaFinalizacion;
        private decimal _precioPublicacion;
        private List<Articulo> _articulos;

        /* Propiedades */
        public int Id
        {
            get { return _id; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public Estado Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public DateTime FechaPubliblicaion
        {
            get { return _fechaPublicacion; }
            set { _fechaPublicacion = value; }
        }

        public DateTime FechaFinalizacion
        {
            get { return _fechaFinalizacion; }
            set { _fechaFinalizacion = value; }
        }

        public decimal PrecioPublicacion
        {
            get { return _precioPublicacion; }
            set { _precioPublicacion = value; }
        }

        public List<Articulo> Articulos
        {
            get { return _articulos; }
        }


        /* Constructores */

        public Publicacion()
        {
            this._id = Publicacion.s_ultimoId++;
        }

        public Publicacion(string unNombre, Estado unEstado, DateTime unaFechaPub, DateTime unaFechaFin, decimal unPrecioPub, List<Articulo> articulos)
        {
            this._id = Publicacion.s_ultimoId++;
            this._nombre = unNombre;
            this._estado = unEstado;
            this._fechaPublicacion = unaFechaPub;
            this._fechaFinalizacion = unaFechaFin;
            this._precioPublicacion = unPrecioPub;
            this._articulos = articulos;
        }

        /*----------------------- Metodo ToString ----------------------*/
        public override string ToString()
        {
            return " - Id: " + this.Id +
                "\n - Nombre: " + this.Nombre +
                "\n - Estado: " + this.Estado +
                "\n - Fecha Publicacion: " + this.FechaPubliblicaion +
                "\n - Fecha Finalizacion: " + this.FechaFinalizacion +
                "\n - Precio: " + this.PrecioPublicacion;
        }
    }
}
