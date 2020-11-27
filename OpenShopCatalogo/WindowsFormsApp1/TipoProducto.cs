using System;

namespace WindowsFormsApp1
{
    public class TipoProducto
    {
        public int IdTipoProducto { get; set; }
        public string Nombre { get; set; }
        public Categoria Categoria { get; set; }

        public TipoProducto()
        {

        }

        public TipoProducto(int idTipoProducto, string nombre, Categoria categoria)
        {
            IdTipoProducto = idTipoProducto;
            Nombre = nombre; 
            Categoria = categoria;
        }

    }
}