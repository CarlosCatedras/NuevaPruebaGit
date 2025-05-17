namespace NuevaPruebaGit.Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menú Principal ---");
            Console.WriteLine("1. Crear Registro");
            Console.WriteLine("2. Leer Registros");
            Console.WriteLine("3. Actualizar Registro");
            Console.WriteLine("4. Eliminar Registro");
            Console.WriteLine("5. Salir");
            Console.WriteLine("Seleccione una opción: ");
            string? opcion = Console.ReadLine();
        }
    }
}
