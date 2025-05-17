using NuevaPruebaGit.Datos;

namespace NuevaPruebaGit.Servicios
{
    public class ServiciosProducto
    {
        private readonly RepositorioProductos? repositorioProductos;
        public ServiciosProducto()
        {
            repositorioProductos = new RepositorioProductos();
        }
    }
}
