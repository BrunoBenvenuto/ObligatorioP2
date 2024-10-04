using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Venta : Publicacion
    {
        // Atributos
        private bool _ofertaRelampago;

        public bool OfertaRelampago
        {
            get { return _ofertaRelampago; }
            set { _ofertaRelampago = value; }
        }

        /*Constructores*/
        public Venta() : base() { }

        public Venta(
            string unNombre,
            Estado unEstado,
            DateTime unaFechaPub,
            DateTime unaFechaFin,
            decimal unPrecioPub,
            List<Articulo> articulos,
            bool unaOferta) : base(unNombre, unEstado, unaFechaPub, unaFechaFin, unPrecioPub, articulos)
        {
            this._ofertaRelampago = unaOferta;
        }

    }
}

