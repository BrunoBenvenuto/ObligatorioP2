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
            DateTime? unaFechaFin,
            decimal unPrecioPub,
            List<Articulo> articulos,
            Cliente? clienteCompra,
            Usuario? unUsuarioFinalizador,
            bool unaOferta) : base(unNombre, unEstado, unaFechaPub, unaFechaFin, unPrecioPub, articulos, clienteCompra, unUsuarioFinalizador)
        {
            this._ofertaRelampago = unaOferta;
        }

    }
}

