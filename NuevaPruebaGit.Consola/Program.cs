using NuevaPruebaGit.Entidades;
using NuevaPruebaGit.Servicios;

namespace NuevaPruebaGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var seguir = true;
            var servicio = new ServiciosProducto();
            do
            {
                Console.WriteLine("*--- Menú Principal ---*");
                Console.WriteLine("1. Crear Registro");
                Console.WriteLine("2. Leer Registros");
                Console.WriteLine("3. Actualizar Registro");
                Console.WriteLine("4. Eliminar Registro");
                Console.WriteLine("5. Salir");
                Console.WriteLine("Seleccione una opción: ");
                string? opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "2":
                        LeerRegistros(servicio);
                        break;
                    default:
                        break;
                }
            } while (seguir);
        }

        private static void LeerRegistros(ServiciosProducto servicio)
        {
            Console.Clear();
            Console.WriteLine("Listado de Productos");
            foreach (Producto p in servicio.GetLista())
            {
                Console.WriteLine($"{p.Nombre}");
            }
            Console.ReadLine();
        }
    }
}
