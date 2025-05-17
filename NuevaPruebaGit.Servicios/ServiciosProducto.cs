using NuevaPruebaGit.Datos;
using NuevaPruebaGit.Entidades;

namespace NuevaPruebaGit.Servicios
{
    public class ServiciosProducto
    {
        private readonly RepositorioProductos? repositorioProductos;
        public ServiciosProducto()
        {
            repositorioProductos = new RepositorioProductos();
        }
        public List<Producto> GetLista()
        {
            return repositorioProductos!.GetLista();
        }

    }
}
