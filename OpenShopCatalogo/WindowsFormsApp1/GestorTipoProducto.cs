using System;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    public class GestorTipoProducto
    {
        public static TipoProducto Televisores = new TipoProducto();
        public static TipoProducto Celulares = new TipoProducto();
        public static TipoProducto Futbol = new TipoProducto();
        public static TipoProducto Tenis = new TipoProducto();
        public static TipoProducto Calzado = new TipoProducto();
        public static TipoProducto Pantalones = new TipoProducto();
        public static TipoProducto ProductosLiquidos = new TipoProducto();
        public static TipoProducto Desinfectantes = new TipoProducto();

        public static List<TipoProducto> ListaTIpoProductos = new List<TipoProducto>();

        public static void AgregarTipoProducto()
        {

            Televisores.IdTipoProducto = 0;
            Televisores.Nombre = "Televisor";
            Televisores.Categoria = GestorCategoria.Tecnologia;

            Celulares.IdTipoProducto = 1;
            Celulares.Nombre = "Celulares";
            Celulares.Categoria = GestorCategoria.Tecnologia;

            Futbol.IdTipoProducto = 2;
            Futbol.Nombre = "Futbol";
            Futbol.Categoria = GestorCategoria.Deporte;

            Tenis.IdTipoProducto = 3;
            Tenis.Nombre = "Tenis";
            Tenis.Categoria = GestorCategoria.Deporte;

            Calzado.IdTipoProducto = 4;
            Calzado.Nombre = "Calzado";
            Calzado.Categoria = GestorCategoria.Indumentaria;

            Pantalones.IdTipoProducto = 5;
            Pantalones.Nombre = "Pantalones";
            Pantalones.Categoria = GestorCategoria.Indumentaria;

            ProductosLiquidos.IdTipoProducto = 6;
            ProductosLiquidos.Nombre = "Productos Liquidos";
            ProductosLiquidos.Categoria = GestorCategoria.Limpieza;

            Desinfectantes.IdTipoProducto = 7;
            Desinfectantes.Nombre = "Desinfectantes";
            Desinfectantes.Categoria = GestorCategoria.Limpieza;


            ListaTIpoProductos.Add(new TipoProducto(Televisores.IdTipoProducto, Televisores.Nombre, Televisores.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(Celulares.IdTipoProducto, Celulares.Nombre, Celulares.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(Futbol.IdTipoProducto, Futbol.Nombre, Futbol.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(Tenis.IdTipoProducto, Tenis.Nombre, Tenis.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(Calzado.IdTipoProducto, Calzado.Nombre, Calzado.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(Pantalones.IdTipoProducto, Pantalones.Nombre, Pantalones.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(ProductosLiquidos.IdTipoProducto, ProductosLiquidos.Nombre, ProductosLiquidos.Categoria));
            ListaTIpoProductos.Add(new TipoProducto(Desinfectantes.IdTipoProducto, Desinfectantes.Nombre, Desinfectantes.Categoria));

        }

        public static void MostrarTiposProductos()
        {
            foreach (var todosLosTiposProdctos in ListaTIpoProductos)
            {
                Console.WriteLine("ID: " + todosLosTiposProdctos.IdTipoProducto + " Nombre: " + todosLosTiposProdctos.Nombre);
            }
        }
    }
}

