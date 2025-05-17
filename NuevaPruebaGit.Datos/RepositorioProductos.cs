using NuevaPruebaGit.Entidades;

namespace NuevaPruebaGit.Datos
{
    public class RepositorioProductos
    {
        private  List<Producto> productos;

        public RepositorioProductos()
        {
            productos = new List<Producto>()
            {
                new Producto { Id = 1, Nombre = "Laptop Dell XPS 15", Precio = 1599.99m, Stock = 5 },
                new Producto { Id = 2, Nombre = "Monitor LG 27UL850", Precio = 449.00m, Stock = 10 },
                new Producto { Id = 3, Nombre = "Teclado Mecánico Corsair K70", Precio = 129.50m, Stock = 7 },
                new Producto { Id = 4, Nombre = "Mouse Logitech MX Master 3", Precio = 99.95m, Stock = 12 },
                new Producto { Id = 5, Nombre = "SSD Samsung 970 EVO Plus 1TB", Precio = 179.99m, Stock = 8 },
                new Producto { Id = 6, Nombre = "Tarjeta Gráfica NVIDIA GeForce RTX 3070", Precio = 599.00m, Stock = 3 },
                new Producto { Id = 7, Nombre = "Memoria RAM Corsair Vengeance LPX 16GB (2x8GB)", Precio = 79.99m, Stock = 15 },
                new Producto { Id = 8, Nombre = "Auriculares Sony WH-1000XM4", Precio = 349.00m, Stock = 6 },
                new Producto { Id = 9, Nombre = "Webcam Logitech C920s", Precio = 79.99m, Stock = 20 },
                new Producto { Id = 10, Nombre = "Impresora HP LaserJet Pro M15w", Precio = 119.00m, Stock = 9 }
            };
        }

        public void Agregar(Producto producto)
        {
            productos.Add(producto);
        }

        public List<Producto> GetLista()
        {
            return productos;
        }




    }
}
