using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class Subasta : Publicacion
    {

        //Constructores
        public Subasta() : base() { }

        public Subasta(
            string unNombre,
            DateTime unaFechaPub,
            DateTime unaFechaFin,
            decimal unPrecioPub) : base(unNombre, unaFechaPub, unaFechaFin, unPrecioPub) { }   
    }
}
