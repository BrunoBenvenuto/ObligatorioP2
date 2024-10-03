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
       private DateTime _fechaPublicacion;
       private DateTime _fechaFinalizacion;
       private decimal _precioPublicacion;

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


       /* Constructores */

        public Publicacion()
        {
            this._id = Publicacion.s_ultimoId++;
        }

        public Publicacion(string unNombre, DateTime unaFechaPub, DateTime unaFechaFin, decimal unPrecioPub)
        {
            this._id = Publicacion.s_ultimoId++;
            this._nombre = unNombre;
            this._fechaPublicacion = unaFechaPub;
            this._fechaFinalizacion = unaFechaFin;
            this._precioPublicacion = unPrecioPub;
        }
    }
}
