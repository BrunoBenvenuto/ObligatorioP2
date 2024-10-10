namespace LogicaNegocio
{
    public class Cliente : Usuario
    {
        /*Atributos*/
        private decimal _saldoBilletera;

        /*Propiedades*/
        public decimal SaldoBilletera
        {
            get { return _saldoBilletera; }
            set { _saldoBilletera = value; }
        }

        /*Constructores*/
        public Cliente() : base() { }

        public Cliente(
            string unNombre, 
            string unApellido, 
            string unMail, 
            string unaContrasenia, 
            decimal unSaldo) : base(unNombre, unApellido, unMail, unaContrasenia)
        {
            this._saldoBilletera = unSaldo;
        }

        public override bool Equals(object? obj)
        {
            if(obj == null || !(obj is Cliente))
            {
                return false;
            }
            Cliente otroCliente = obj as Cliente;
            return otroCliente.Id == this.Id;
        }

        /*----------------------- Metodo ToString ----------------------*/
        public override string ToString()
        {
            return " - Id: " + this.Id +
                "\n - Nombre: " + this.Nombre +
                "\n - Email: " + this.Mail +
                "\n - Saldo: " + this.SaldoBilletera;
        }
    }
}
