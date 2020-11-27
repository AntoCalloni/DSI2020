using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;



namespace WindowsFormsApp1
{
    public class GestorProducto
    {

        public static List<Producto> ListaProductos = new List<Producto>();
        public static List<Producto> JsonList = new List<Producto>();

        public static Producto TelevisorLg = new Producto();
        public static Producto CelularIphone = new Producto();
        public static Producto FutbolPelota = new Producto();
        public static Producto TenisRaqueta = new Producto();
        public static Producto CalzadoNike = new Producto();
        public static Producto PantalonAdidas = new Producto();
        public static Producto ProductoPerfumina = new Producto();
        public static Producto DesinfectanteLysoform = new Producto();


        public static void AgregarProducto()
        {

            TelevisorLg.IdProducto = 0;
            TelevisorLg.Nombre = "LG0254DF";
            TelevisorLg.Marca = "LG";
            TelevisorLg.Precio = 99.999m;
            TelevisorLg.Descripcion = "Televisor LG 4k 55'' SmartTV ";
            TelevisorLg.Stock = 15;
            TelevisorLg.Imagen = "televisor.jpg";
            TelevisorLg.TipoProducto = GestorTipoProducto.Televisores;
            // TelevisorLg.Vendedor = GestorVendedor.VendedorA;

            CelularIphone.IdProducto = 1;
            CelularIphone.Nombre = "7 Plus";
            CelularIphone.Marca = " Iphone";
            CelularIphone.Precio = 55000m;
            CelularIphone.Descripcion = "Iphone 7 Plus 128gb con Accesorios";
            CelularIphone.Stock = 10;
            CelularIphone.Imagen = "iphone.jpg";
            CelularIphone.TipoProducto = GestorTipoProducto.Celulares;
            // CelularIphone.Vendedor = GestorVendedor.VendedorA;

            FutbolPelota.IdProducto = 2;
            FutbolPelota.Nombre = "ADF50";
            FutbolPelota.Marca = "Adidas";
            FutbolPelota.Precio = 5000m;
            FutbolPelota.Descripcion = "Pelota de Fútbol mundial 1998";
            FutbolPelota.Stock = 60;
            FutbolPelota.Imagen = "pelota.jpg";
            FutbolPelota.TipoProducto = GestorTipoProducto.Futbol;
            //  FutbolPelota.Vendedor = GestorVendedor.VendedorA;

            TenisRaqueta.IdProducto = 3;
            TenisRaqueta.Nombre = "l20SS";
            TenisRaqueta.Marca = "Wilson";
            TenisRaqueta.Precio = 22000m;
            TenisRaqueta.Descripcion = "Raqueta de Tenis de grafito";
            TenisRaqueta.Stock = 30;
            TenisRaqueta.Imagen = "raqueta.jpg";
            TenisRaqueta.TipoProducto = GestorTipoProducto.Tenis;
            //  TenisRaqueta.Vendedor = GestorVendedor.VendedorA;

            CalzadoNike.IdProducto = 4;
            CalzadoNike.Nombre = "Air Force";
            CalzadoNike.Marca = "Nike";
            CalzadoNike.Precio = 10000;
            CalzadoNike.Descripcion = "Zapatillas Nike Air Force 1 Mid";
            CalzadoNike.Stock = 120;
            CalzadoNike.Imagen = "airforce.jpg";
            CalzadoNike.TipoProducto = GestorTipoProducto.Calzado;
            //   CalzadoNike.Vendedor = GestorVendedor.VendedorA;

            PantalonAdidas.IdProducto = 5;
            PantalonAdidas.Nombre = "Jogger";
            PantalonAdidas.Marca = "Adidas";
            PantalonAdidas.Precio = 3500;
            PantalonAdidas.Descripcion = "Pantalon Jogger Informal urbano";
            PantalonAdidas.Stock = 230;
            PantalonAdidas.Imagen = "adidaspantalon.jpg";
            PantalonAdidas.TipoProducto = GestorTipoProducto.Pantalones;
            // PantalonAdidas.Vendedor = GestorVendedor.VendedorA;

            ProductoPerfumina.IdProducto = 6;
            ProductoPerfumina.Nombre = "Perfumina";
            ProductoPerfumina.Marca = "Procenex";
            ProductoPerfumina.Precio = 120m;
            ProductoPerfumina.Descripcion = "Perfumina Procenex aroma Lavanda";
            ProductoPerfumina.Stock = 1500;
            ProductoPerfumina.Imagen = "perfumina.jpg";
            ProductoPerfumina.TipoProducto = GestorTipoProducto.ProductosLiquidos;
            //   ProductoPerfumina.Vendedor = GestorVendedor.VendedorA;

            DesinfectanteLysoform.IdProducto = 7;
            DesinfectanteLysoform.Nombre = "Desinfectante";
            DesinfectanteLysoform.Marca = "Lysoform";
            DesinfectanteLysoform.Precio = 80;
            DesinfectanteLysoform.Descripcion = "Desinfectante Lysoform aroma Limón";
            DesinfectanteLysoform.Stock = 5000;
            DesinfectanteLysoform.Imagen = "desinfectante.jpg";
            DesinfectanteLysoform.TipoProducto = GestorTipoProducto.Desinfectantes;
            //   DesinfectanteLysoform.Vendedor = GestorVendedor.VendedorA;



            ListaProductos.Add(new Producto(TelevisorLg.IdProducto, TelevisorLg.Nombre, TelevisorLg.Marca, TelevisorLg.Precio, TelevisorLg.Descripcion, TelevisorLg.Stock, TelevisorLg.Imagen, TelevisorLg.TipoProducto));
            ListaProductos.Add(new Producto(CelularIphone.IdProducto, CelularIphone.Nombre, CelularIphone.Marca, CelularIphone.Precio, CelularIphone.Descripcion, CelularIphone.Stock, CelularIphone.Imagen, CelularIphone.TipoProducto));
            ListaProductos.Add(new Producto(FutbolPelota.IdProducto, FutbolPelota.Nombre, FutbolPelota.Marca, FutbolPelota.Precio, FutbolPelota.Descripcion, FutbolPelota.Stock, FutbolPelota.Imagen, FutbolPelota.TipoProducto));
            ListaProductos.Add(new Producto(TenisRaqueta.IdProducto, TenisRaqueta.Nombre, TenisRaqueta.Marca, TenisRaqueta.Precio, TenisRaqueta.Descripcion, TenisRaqueta.Stock, TenisRaqueta.Imagen, TenisRaqueta.TipoProducto));
            ListaProductos.Add(new Producto(CalzadoNike.IdProducto, CalzadoNike.Nombre, CalzadoNike.Marca, CalzadoNike.Precio, CalzadoNike.Descripcion, CalzadoNike.Stock, CalzadoNike.Imagen, CalzadoNike.TipoProducto));
            ListaProductos.Add(new Producto(PantalonAdidas.IdProducto, PantalonAdidas.Nombre, PantalonAdidas.Marca, PantalonAdidas.Precio, PantalonAdidas.Descripcion, PantalonAdidas.Stock, PantalonAdidas.Imagen, PantalonAdidas.TipoProducto));
            ListaProductos.Add(new Producto(ProductoPerfumina.IdProducto, ProductoPerfumina.Nombre, ProductoPerfumina.Marca, ProductoPerfumina.Precio, ProductoPerfumina.Descripcion, ProductoPerfumina.Stock, ProductoPerfumina.Imagen, ProductoPerfumina.TipoProducto));
            ListaProductos.Add(new Producto(DesinfectanteLysoform.IdProducto, DesinfectanteLysoform.Nombre, DesinfectanteLysoform.Marca, DesinfectanteLysoform.Precio, DesinfectanteLysoform.Descripcion, DesinfectanteLysoform.Stock, DesinfectanteLysoform.Imagen, DesinfectanteLysoform.TipoProducto));

        }





        public static void MostrarTodosProductos()
        {
            foreach (var productos in ListaProductos)
            {
                Console.WriteLine("ID: " + productos.IdProducto + " Nombre: " + productos.Nombre + " Marca: " + productos.Marca + " Precio: " + productos.Precio + "$ Descripción: " + productos.Descripcion + " Stock: " + productos.Stock + " Tipo De Producto: " + productos.TipoProducto.Nombre);


            }
        }
        public static void MostrarTodosProductosPosition()
        {
            var posicion = 0;
            foreach (var productos in ListaProductos)
            {
                Console.WriteLine("POSICIÓN:" + posicion + " ID: " + productos.IdProducto + " Nombre: " + productos.Nombre + " Marca: " + productos.Marca + " Precio: " + productos.Precio + "$ Descripción: " + productos.Descripcion + " Stock: " + productos.Stock + " Tipo De Producto: " + productos.TipoProducto.Nombre);
                posicion++;

            }
        }
        public static void UltimoId()
        {
            Console.WriteLine("ID utilizados:");
            foreach (var productos in ListaProductos)
            {
                Console.Write("||  " + productos.IdProducto + "  ||  ");
            }
            Console.WriteLine();

        }

        public static void ModificarSeleccion(int productoSeleccinadoId)
        {
            foreach (var productoSeleccion in ListaProductos)
            {
                if (productoSeleccion.IdProducto == productoSeleccinadoId)
                {

                    Console.WriteLine("Coloque el nombre del producto: ");
                    productoSeleccion.Nombre = Console.ReadLine();

                    Console.WriteLine("Coloque la marca del producto: ");
                    productoSeleccion.Marca = Console.ReadLine();

                    Console.WriteLine("Coloque el precio del producto (numero): ");
                    productoSeleccion.Precio = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Coloque la descripcion del producto: ");
                    productoSeleccion.Descripcion = Console.ReadLine();

                    Console.WriteLine("Coloque el stock del producto (numero): ");
                    productoSeleccion.Stock = Int32.Parse(Console.ReadLine());

                    Console.WriteLine("Coloque la imagen del producto: ");
                    productoSeleccion.Imagen = Console.ReadLine();


                }
            }


        }


        public static void EliminarSeleccion(int productoSeleccinado)
        {

            ListaProductos.Remove(ListaProductos[productoSeleccinado]);


            Console.WriteLine();
            Console.WriteLine("Producto Eliminado");
            Console.WriteLine();

        }


        public static void CreateJson()
        {
            foreach (var productos in ListaProductos)
            {
                JsonList.Add(new Producto(productos.IdProducto, productos.Nombre, productos.Marca, productos.Precio, productos.Descripcion, productos.Stock, productos.Imagen, productos.TipoProducto));


            }
            var JsonCatalogo = JsonConvert.SerializeObject(JsonList, Formatting.Indented);
            Console.WriteLine(JsonCatalogo);
            File.WriteAllText("JsonCatalogo.txt", JsonCatalogo);


        }

    }

}
