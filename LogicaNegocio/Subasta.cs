using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Subasta : Publicacion
    {
        //Atributo
        private List<Oferta> _clientesOfertas;

        //Propiedad
        public List<Oferta> ClientesOfertas
        {
            get { return _clientesOfertas; } 
            // VA EL SET????
        }

        //Constructores
        public Subasta() : base() { }

        public Subasta(
            string unNombre,
            Estado unEstado,
            DateTime unaFechaPub,
            DateTime unaFechaFin,
            decimal unPrecioPub,
            List<Articulo> articulos,
            List<Oferta> clientesOfertas
            ) : base(unNombre, unEstado, unaFechaPub, unaFechaFin, unPrecioPub, articulos) 
        {
            this._clientesOfertas = clientesOfertas;
        }   
    }
}
