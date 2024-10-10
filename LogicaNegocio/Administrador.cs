namespace LogicaNegocio
{
    public class Administrador : Usuario
    {
        public Administrador() : base() { }

        public Administrador(
            string unNombre,
            string unApellido,
            string unMail,
            string unaContrasenia
            ) : base(unNombre, unApellido, unMail, unaContrasenia) { }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Administrador))
            {
                return false;
            }
            Administrador otroAdmin = obj as Administrador;
            return otroAdmin.Id == this.Id;
        }
    }
}
