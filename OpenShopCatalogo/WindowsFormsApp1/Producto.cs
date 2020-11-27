using System;

namespace WindowsFormsApp1
{
    public class Producto
    {
        public Guid IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public float Precio { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string Imagen { get; set; }
        //public Vendedor Vendedor { get; set; }
        public TipoProducto TipoProducto { get; set; }


        public Producto()
        {

        }


        public Producto(Guid idProducto, string nombre, string marca, float precio, string descripcion, int stock, string imagen, TipoProducto tipoProducto) //Vendedor vendedor
        {
            IdProducto = idProducto;
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Descripcion = descripcion;
            Stock = stock;
            Imagen = imagen;
            TipoProducto = tipoProducto;
            //Vendedor = vendedor;
        }

    }
}