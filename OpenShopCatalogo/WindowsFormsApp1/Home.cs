using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApp1
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto ventanaAgregarProducto = new AgregarProducto();
            ventanaAgregarProducto.ShowDialog();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            ModificarProducto ventanaModificarProducto = new ModificarProducto();
            ventanaModificarProducto.ShowDialog();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto ventanaEliminarProducto = new EliminarProducto();
            ventanaEliminarProducto.ShowDialog();
        }

        //Para actualizar con json de Despacho
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            RegistroListadoDespacho.CargarDatosExistentes();
            var productosAVender = new List<Producto>();
            var productosARecorrer = RegistroListadoDespacho.productos.Where(x => x.IdProducto == RegistroProducto.productoCargado.IdProducto).ToList();

            foreach (var productos in productosARecorrer)
            {
                var productoItem = new Producto();
                productoItem.IdProducto = productos.IdProducto;
                productoItem.Nombre = productos.Nombre;
                productoItem.Descripcion = productos.Descripcion;
                productoItem.Marca = productos.Marca;
                productoItem.Precio = productos.Precio;
                productoItem.Stock = productos.Stock;
                productosAVender.Add(productoItem);
            }

            var json = JsonConvert.SerializeObject(productosAVender);

            RegistroProducto.GuardarDatosEnJson();

            string message = "El json se ha actualizado correctamente!!!";
            string caption = "Success";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);

        }


        private void buttonTransferirListado_Click(object sender, EventArgs e)
        {
            EnvioDatosACarrito();
        }

        public void EnvioDatosACarrito()
        {
            RegistroProducto.CargarRegistroProducto();
            var productosAVender = new List<Producto>();
            var productosARecorrer = RegistroProducto.productos.ToList();

            foreach (var productos in productosARecorrer)
            {
                var productoItem = new Producto();
                productoItem.IdProducto = productos.IdProducto;
                productoItem.Nombre = productos.Nombre;
                productoItem.Descripcion = productos.Descripcion;
                productoItem.Marca = productos.Marca;
                productoItem.Precio = productos.Precio;
                productoItem.Stock = productos.Stock;

                productosAVender.Add(productoItem);
            }

            var json = JsonConvert.SerializeObject(productosAVender);

            RegistroListadoProducto.GuardarDatosEnJson();

            string message = "El json se ha creado correctamente!!!";
            string caption = "Success";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
        }

        public void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

    public static class RegistroListadoProducto
    {
        public static List<Producto> productos = new List<Producto>();
        public static Producto productoCargado;

        static RegistroListadoProducto()
        {
            if (System.IO.File.Exists("productosParaCarrito.json"))
            {
                string contenidoArchivoProductos = System.IO.File.ReadAllText("productosParaCarrito.json");
                List<Producto> productosEnArchivoJson = JsonConvert.DeserializeObject<List<Producto>>(contenidoArchivoProductos);
                if (productosEnArchivoJson.Count != 0)
                {
                    productos = productosEnArchivoJson;
                }
            }
        }

        public static void GuardarDatosEnJson()
        {
            var productosEnArchivoJson = JsonConvert.SerializeObject(productos, Formatting.Indented);
            System.IO.File.WriteAllText("productosParaCarrito.Json", productosEnArchivoJson);
        }
    }

    public static class RegistroListadoDespacho
    {
        public static List<Producto> productos = new List<Producto>();
        public static void CargarDatosExistentes()
        {
            if (System.IO.File.Exists("despacho.json"))
            {
                string contenidoArchivoDespacho = System.IO.File.ReadAllText("despacho.json");
                List<Producto> despachoEnArchivoJson = JsonConvert.DeserializeObject<List<Producto>>(contenidoArchivoDespacho);
                if (despachoEnArchivoJson.Count != 0)
                {
                    productos = despachoEnArchivoJson;
                }
            }
        }

    }
}
