﻿namespace NuevaPruebaGit.Entidades
{
    public class Producto 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public decimal Precio { get; set; }
        public int Stock { get; set; }

        
    }
}
