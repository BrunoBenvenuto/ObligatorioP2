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
            DateTime? unaFechaFin,
            decimal unPrecioPub,
            List<Articulo> articulos,
            Cliente? clienteCompra,
            List<Oferta> clientesOfertas,
            Usuario? unUsuarioFinalizador
            ) : base(unNombre, unEstado, unaFechaPub, unaFechaFin, unPrecioPub, articulos, clienteCompra, unUsuarioFinalizador) 
        {
            this._clientesOfertas = clientesOfertas;
        }   
    }
}
