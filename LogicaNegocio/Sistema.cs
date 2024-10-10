namespace LogicaNegocio
{
    public class Sistema
    {
        /*SINGLETON*/
        private static Sistema _instancia;

        /*Atributos*/
        private List<Usuario> _usuarios = new List<Usuario>();
        private List<Articulo> _articulos = new List<Articulo>();
        private List<Publicacion> _publicaciones = new List<Publicacion>();

        public static Sistema Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new Sistema();
                }
                return _instancia;
            }
        }

        public List<Usuario> Usuarios { get { return _usuarios; } }
        public List<Articulo> Articulos { get { return _articulos; } }
        public List<Publicacion> Publicaciones { get { return _publicaciones; } }

        private Sistema()
        {
            this.Precargar();
        }

        public void Precargar()
        {
            this.PrecargarClientes();
            this.PrecargarAdministradores();
            this.PrecargarArticulos();
            this.PrecargarVentas();
            this.PrecargarSubastas();
        }

        /*------------------------Precarga Usuarios------------------------*/
        private void PrecargarClientes()
        {
            List<Cliente> clientesAux = new List<Cliente>
            {
             new Cliente(
                "Bruno", "Benvenuto", "brunob@test.com", "1234bruno", 123),
            new Cliente(
                "Agustina", "Istebot", "agu@test.com", "1234agu", 1234),
            new Cliente(
                "María", "García López", "maria.garcia@email.com", "password1", 1250),
            new Cliente(
               "Juan", "Rodríguez Fernández", "juan.rodriguez@email.com", "password2", 8500),
            new Cliente(
                  "Sofía", "Martínez Gómez", "sofia.martinez@email.com", "password3", 1450),
            new Cliente(
                   "Pedro", "Sánchez Herrera", "pedro.sanchez@email.com", "password4", 620),
            new Cliente(
                   "Laura", "Fernández Ruiz", "laura.fernandez@email.com", "password5", 920),
            new Cliente(
                   "Andrés", "Gutiérrez Díaz", "andres.gutierrez@email.com", "password6", 1130),
            new Cliente(
                         "Carmen", "Torres Moreno", "carmen.torres@email.com", "password7", 785),
            new Cliente(
                       "Alejandro", "Mendoza Vargas", "alejandro.mendoza@email.com", "password10", 990)
        };

            foreach (Cliente c in clientesAux)
            {
                this.AgregarCliente(c);
            }

        }

        /*------------------------Precarga Administradores------------------------*/
        private void PrecargarAdministradores()
        {
            Administrador administrador1 = new Administrador(
                "Jose", "Rodriguez", "jose@gmail.com", "1234jose");
            Administrador administrador2 = new Administrador(
                "Mauro", "Daverio", "mdaverio@tremendomail.com", "ItsMeMario");

            this.AgregarAdmin(administrador1);
            this.AgregarAdmin(administrador2);
        }

        /*------------------------Precarga Articulos------------------------*/

        private void PrecargarArticulos()
        {
            List<Articulo> articulosAux = new List<Articulo>
            {
                new Articulo("Bicicleta de montaña", "Deportes", 1200.99m),
                new Articulo("Patineta", "Deportes", 85.50m),
                new Articulo("Balón de fútbol", "Deportes", 25.75m),
                new Articulo("Raqueta de tenis", "Deportes", 145.99m),
                new Articulo("Camiseta de running", "Ropa", 35.90m),
                new Articulo("Zapatillas deportivas", "Ropa", 79.99m),
                new Articulo("Pantalones cortos", "Ropa", 29.50m),
                new Articulo("Gorra de béisbol", "Accesorios", 19.99m),
                new Articulo("Taza", "Hogar", 27.50m),
                new Articulo("Gafas de sol", "Accesorios", 49.99m),
                new Articulo("Bicicleta de carrera", "Ciclismo", 1500.00m),
                new Articulo("Casco de ciclismo", "Ciclismo", 89.99m),
                new Articulo("Guantes de ciclismo", "Ciclismo", 25.49m),
                new Articulo("Bomba de aire", "Ciclismo", 15.75m),
                new Articulo("Botella de agua", "Accesorios", 12.50m),
                new Articulo("Mochila deportiva", "Accesorios", 45.00m),
                new Articulo("Kit de herramientas", "Automotriz", 75.99m),
                new Articulo("Linterna LED", "Hogar", 22.90m),
                new Articulo("Cargador portátil", "Electrónica", 35.50m),
                new Articulo("Auriculares Bluetooth", "Electrónica", 59.99m),
                new Articulo("Teclado mecánico", "Electrónica", 89.50m),
                new Articulo("Ratón inalámbrico", "Electrónica", 25.99m),
                new Articulo("Monitor LED", "Electrónica", 199.99m),
                new Articulo("Silla de oficina", "Muebles", 149.99m),
                new Articulo("Escritorio", "Muebles", 249.50m),
                new Articulo("Estantería", "Muebles", 99.75m),
                new Articulo("Lámpara de escritorio", "Hogar", 29.99m),
                new Articulo("Cafetera", "Hogar", 79.99m),
                new Articulo("Tetera eléctrica", "Hogar", 45.50m),
                new Articulo("Reloj de pared", "Decoración", 35.00m),
                new Articulo("Alfombra", "Decoración", 89.99m),
                new Articulo("Cojín decorativo", "Decoración", 19.50m),
                new Articulo("Espejo de pared", "Decoración", 129.99m),
                new Articulo("Marco de fotos", "Decoración", 15.99m),
                new Articulo("Sofá de 3 plazas", "Muebles", 499.99m),
                new Articulo("Mesa de centro", "Muebles", 125.00m),
                new Articulo("Taburete", "Muebles", 49.50m),
                new Articulo("Ventilador de torre", "Electrodomésticos", 89.99m),
                new Articulo("Aspiradora", "Electrodomésticos", 159.99m),
                new Articulo("Plancha de vapor", "Electrodomésticos", 39.90m),
                new Articulo("Set de cuchillos", "Cocina", 25.99m),
                new Articulo("Sartenes", "Cocina", 55.75m),
                new Articulo("Olla a presión", "Cocina", 79.50m),
                new Articulo("Tupperware", "Cocina", 19.99m),
                new Articulo("Cubertería", "Cocina", 45.00m),
                new Articulo("Jarra de vidrio", "Cocina", 15.75m),
                new Articulo("Set de vasos", "Cocina", 20.99m),
                new Articulo("Toallas de baño", "Baño", 29.50m),
                new Articulo("Esponjas", "Baño", 9.99m),
                new Articulo("Alfombra de baño", "Baño", 19.50m)
            };

            foreach (Articulo a in articulosAux)
            {
                this.AgregarArticulo(a);
            }
        }


        /*------------------------Precarga Ventas------------------------*/
        private void PrecargarVentas()
        {
            // Crear diferentes listas de artículos utilizando los artículos ya cargados en el sistema
            List<Articulo> articulos1 = new List<Articulo> { _articulos[0], _articulos[1] };
            List<Articulo> articulos2 = new List<Articulo> { _articulos[2], _articulos[3], _articulos[4] };
            List<Articulo> articulos3 = new List<Articulo> { _articulos[5], _articulos[6] };
            List<Articulo> articulos4 = new List<Articulo> { _articulos[7] };
            List<Articulo> articulos5 = new List<Articulo> { _articulos[8], _articulos[9], _articulos[10] };
            List<Articulo> articulos6 = new List<Articulo> { _articulos[11], _articulos[12] };
            List<Articulo> articulos7 = new List<Articulo> { _articulos[13], _articulos[14], _articulos[15], _articulos[16] };
            List<Articulo> articulos8 = new List<Articulo> { _articulos[17], _articulos[18] };
            List<Articulo> articulos9 = new List<Articulo> { _articulos[19], _articulos[20], _articulos[21] };
            List<Articulo> articulos10 = new List<Articulo> { _articulos[22], _articulos[23], _articulos[24], _articulos[25] };

            // Crear 10 ventas y agregarlas al sistema utilizando el método AgregarPublicacion
            AgregarPublicacion(new Venta("Deportes Extremos", Estado.Abierta, DateTime.Parse("08-03-2012"), null, 299.99m, articulos1, null, null, true));
            AgregarPublicacion(new Venta("Equipamiento Deportivo", Estado.Abierta, DateTime.Parse("30-12-2021"), null, 199.99m, articulos2, null, null, false));
            AgregarPublicacion(new Venta("Aventura en la Montaña", Estado.Abierta, DateTime.Parse("15-06-2010"), null, 349.99m, articulos3, null, null, true));
            AgregarPublicacion(new Venta("Ropa para Running", Estado.Abierta, DateTime.Parse("03-03-2018"), null, 159.99m, articulos4, null, null, false));
            AgregarPublicacion(new Venta("Ciclismo y Más", Estado.Abierta, DateTime.Parse("22-01-2020"), null, 299.99m, articulos5, null, null, true));
            AgregarPublicacion(new Venta("Verano Activo", Estado.Abierta, DateTime.Parse("03-03-2015"), null, 249.99m, articulos6, null, null, false));
            AgregarPublicacion(new Venta("Accesorios para Deportes", Estado.Abierta, DateTime.Parse("05-04-2017"), null, 189.99m, articulos7, null, null, true));
            AgregarPublicacion(new Venta("Entrenamiento al Aire Libre", Estado.Abierta, DateTime.Parse("08-08-2020"), null, 139.99m, articulos8, null, null, false));
            AgregarPublicacion(new Venta("Fitness Total", Estado.Abierta, DateTime.Parse("11-08-2023"), null, 219.99m, articulos9, null, null, true));
            AgregarPublicacion(new Venta("Ciclismo Profesional", Estado.Abierta, DateTime.Parse("11-01-2019"), null, 389.99m, articulos10, null, null, false));
        }

        /*------------------------Precarga Subastas ----------------------------*/
        private void PrecargarSubastas()
        {
            // Filtrar solo los clientes de la lista de usuarios del sistema
            List<Cliente> clientes = _usuarios.OfType<Cliente>().ToList();

            // Crear diferentes listas de artículos utilizando los artículos ya cargados en el sistema
            List<Articulo> articulos1 = new List<Articulo> { _articulos[26], _articulos[27], _articulos[28] };
            List<Articulo> articulos2 = new List<Articulo> { _articulos[29], _articulos[30] };
            List<Articulo> articulos3 = new List<Articulo> { _articulos[31], _articulos[32], _articulos[33], _articulos[34] };
            List<Articulo> articulos4 = new List<Articulo> { _articulos[35] };
            List<Articulo> articulos5 = new List<Articulo> { _articulos[36], _articulos[37] };
            List<Articulo> articulos6 = new List<Articulo> { _articulos[38], _articulos[39], _articulos[40] };
            List<Articulo> articulos7 = new List<Articulo> { _articulos[41], _articulos[42] };
            List<Articulo> articulos8 = new List<Articulo> { _articulos[43], _articulos[44], _articulos[45] };
            List<Articulo> articulos9 = new List<Articulo> { _articulos[46] };
            List<Articulo> articulos10 = new List<Articulo> { _articulos[47], _articulos[48], _articulos[49] };

            // Crear listas de ofertas
            List<Oferta> ofertasSubasta1 = new List<Oferta>
            {
                new Oferta(150m, DateTime.Parse("04-11-2021"), clientes[0]),
                new Oferta(200m, DateTime.Parse("23-01-2024"), clientes[1])
            };

            List<Oferta> ofertasSubasta2 = new List<Oferta>
            {
                new Oferta(300m, DateTime.Parse("29-06-2019"), clientes[2]),
                new Oferta(350m, DateTime.Parse("13-08-2020"), clientes[3]),
                new Oferta(500m, DateTime.Parse("15-08-2020"), clientes[2])
            };

            // Crear 10 subastas y agregarlas al sistema utilizando el método AgregarPublicacion
            AgregarPublicacion(new Subasta("Vuelta Ciclista", Estado.Abierta, DateTime.Parse("02-11-2021"), null, 500m, articulos1, null, ofertasSubasta1, null));
            AgregarPublicacion(new Subasta("Equipo de Camping", Estado.Abierta, DateTime.Parse("23-02-2019"), null, 250m, articulos2, null, ofertasSubasta2, null));
            AgregarPublicacion(new Subasta("Caza y Pesca", Estado.Abierta, DateTime.Parse("03-02-2023"), null, 600m, articulos3, null, null, null));
            AgregarPublicacion(new Subasta("Ropa de Montaña", Estado.Abierta, DateTime.Parse("18-03-2010"), null, 350m, articulos4, null, new List<Oferta>(), null));
            AgregarPublicacion(new Subasta("Equipamiento de Escalada", Estado.Abierta, DateTime.Parse("02-12-2022"), null, 450m, articulos5, null, new List<Oferta>(), null));
            AgregarPublicacion(new Subasta("Set de Viaje", Estado.Abierta, DateTime.Parse("03-09-2016"), null, 200m, articulos6, null, new List<Oferta>(), null));
            AgregarPublicacion(new Subasta("Camping de Lujo", Estado.Abierta, DateTime.Parse("12-08-2021"), null, 700m, articulos7, null, new List<Oferta>(), null));
            AgregarPublicacion(new Subasta("Aventura Extrema", Estado.Abierta, DateTime.Parse("27-08-2017"), null, 800m, articulos8, null, new List<Oferta>(), null));
            AgregarPublicacion(new Subasta("Mountain Bike", Estado.Abierta, DateTime.Parse("23-04-2015"), null, 900m, articulos9, null, new List<Oferta>(), null));
            AgregarPublicacion(new Subasta("Ropa para Esquí", Estado.Abierta, DateTime.Parse("15-05-2022"), null, 550m, articulos10, null, new List<Oferta>(), null));
        }


        /*------------------------Metodos para clientes------------------------*/
        public void AgregarCliente(Cliente unCliente)
        {
            try
            {
                this.ExisteCliente(unCliente);
                this._usuarios.Add(unCliente);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ExisteCliente(Cliente otroCliente)
        {
            if (this._usuarios.Contains(otroCliente))
            {
                throw new Exception("El usuario ya existe.");
            }
        }

        /*------------------------Metodos para administradores------------------------*/
        public void AgregarAdmin(Administrador unAdmin)
        {
            try
            {
                this.ExisteAdmin(unAdmin);
                this._usuarios.Add(unAdmin);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void ExisteAdmin(Administrador otroAdmin)
        {
            if (this._usuarios.Contains(otroAdmin))
            {
                throw new Exception("El usuario ya existe.");
            }
        }

        /*------------------------Lista de Clientes------------------------*/
        public List<Usuario> ObtenerClientes()
        {
            List<Usuario> aRetornar = new List<Usuario>();
            foreach (Usuario u in this._usuarios)
            {
                if (u is Cliente)
                {
                    aRetornar.Add(u);
                }
            }
            return aRetornar;
        }

        /*------------------------Metodo para Articulos------------------------*/

        public void AgregarArticulo(Articulo unArticulo)
        {
            try
            {
                this._articulos.Add(unArticulo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Articulo> BuscarArticulosPorCategoria(string unaCategoria)
        {
            List<Articulo> aRetornar = new List<Articulo>();
            foreach (Articulo unArticulo in this.Articulos)
            {
                if (unArticulo.Categoria.ToLower() == unaCategoria.ToLower())
                {
                    aRetornar.Add(unArticulo);
                }
            }
            if (aRetornar.Count == 0) throw new Exception("No existen publicaciones con ese genero");
            return aRetornar;
        }

        /*------------------------Metodo para Publicaciones------------------------*/
        public void AgregarPublicacion(Publicacion unaNuevaPublicacion)
        {
            try
            {
                this._publicaciones.Add(unaNuevaPublicacion);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public List<Publicacion> ListarPublicacionesEntreFechas(DateTime fechaInicio, DateTime fechaFinal)
        {
            List<Publicacion> listaPublicacionesFiltradas = new List<Publicacion>();
            foreach (Publicacion p in this._publicaciones)
            {

                if (p.FechaPublicacion >= fechaInicio && p.FechaPublicacion <= fechaFinal)
                {
                    listaPublicacionesFiltradas.Add(p);

                }
            }
            return listaPublicacionesFiltradas;
        }
    }
}
