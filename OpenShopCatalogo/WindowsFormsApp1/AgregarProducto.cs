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
using System.CodeDom.Compiler;

namespace WindowsFormsApp1
{
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
            buttonAgregar.Enabled = false;
            RellenarComboBox();
        }

        public void RellenarComboBox()
        {
            var marcas = RegistroProducto.productos.Select(x => x.Marca).Distinct();
            comboBoxMarca.DataSource = marcas.ToArray();

            var tipoProductos = RegistroProducto.productos.Select(x => x.TipoProducto.Nombre).Distinct();
            comboBoxTipoProducto.DataSource = tipoProductos.ToArray();

        }

        public void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoNombre();
        }
        public void controlarTextoIngresadoNombre()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxNombre.Text))
            {
                errorProviderNombre.SetError(textBoxNombre, "Debe introducir el nombre del producto");
            }
            else
            {
                if (!textBoxNombre.Text.All(x => char.IsLetter(x)))
                {
                    errorProviderNombre.SetError(textBoxNombre, "Debe introducir solo letras");
                }
                else
                {
                    buttonAgregar.Enabled = true;
                    errorProviderNombre.SetError(textBoxNombre, "");
                }
            }
        }

        /*public void TextBoxMarca_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoMarca();
        }
        public void controlarTextoIngresadoMarca()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxMarca.Text))
            {
                errorProviderMarca.SetError(textBoxMarca, "Debe introducir la marca");
            }
            else
            {
                buttonAgregar.Enabled = true;
                errorProviderMarca.SetError(textBoxMarca, "");
            }
        }*/

        public void TextBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoPrecio();
        }
        public void controlarTextoIngresadoPrecio()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxPrecio.Text))
            {
                errorProviderPrecio.SetError(textBoxPrecio, "Debe introducir el precio");
            }
            else
            {
                float precioIngresado;
                bool esPrecio = float.TryParse(textBoxPrecio.Text.Trim(), out precioIngresado);
                if (esPrecio == false)
                {
                    errorProviderPrecio.SetError(textBoxPrecio, "Deben ser sólo numeros");
                }
                else
                {
                    buttonAgregar.Enabled = true;
                    errorProviderPrecio.SetError(textBoxPrecio, "");
                }
            }
        }

        public void TextBoxDescripcion_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoDescripcion();
        }
        public void controlarTextoIngresadoDescripcion()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxDescripcion.Text))
            {
                errorProviderDescripcion.SetError(textBoxDescripcion, "Debe introducir una descripción");
            }
            else
            {
                buttonAgregar.Enabled = true;
                errorProviderDescripcion.SetError(textBoxDescripcion, "");
            }
        }

        public void TextBoxStock_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoStock();
        }
        public void controlarTextoIngresadoStock()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxStock.Text))
            {
                errorProviderStock.SetError(textBoxStock, "Debe introducir el Stock");
            }
            else
            {
                int stockIngresado;
                bool esStock = int.TryParse(textBoxStock.Text.Trim(), out stockIngresado);
                if (esStock == false)
                {
                    errorProviderStock.SetError(textBoxStock, "Debe introducir el Stock en números");
                }
                else
                {
                    buttonAgregar.Enabled = true;
                    errorProviderStock.SetError(textBoxStock, "");
                }
                
            }
        }

        public void TextBoxImagen_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoImagen();
        }
        public void controlarTextoIngresadoImagen()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxImagen.Text))
            {
                errorProviderImagen.SetError(textBoxImagen, "Debe ingresar una url para su imagen");
            }
            else
            {
                buttonAgregar.Enabled = true;
                errorProviderImagen.SetError(textBoxImagen, "");
            }
        }

        /*public void TextBoxNombreCategoria_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoNombreCategoria();
        }
        public void controlarTextoIngresadoNombreCategoria()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxNombreCategoria.Text))
            {
                errorProviderNombreCategoria.SetError(textBoxNombreCategoria, "Debe introducir la categoría");
            }
            else
            {  
                buttonAgregar.Enabled = true;
                errorProviderNombreCategoria.SetError(textBoxNombreCategoria, "");
            }
        }

        public void TextBoxTipoProducto_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoTipoProducto();
        }
        public void controlarTextoIngresadoTipoProducto()
        {
            buttonAgregar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxTipoProducto.Text))
            {
                errorProviderTipoProducto.SetError(textBoxTipoProducto, "Debe introducir el tipo de producto");
            }
            else
            {
                buttonAgregar.Enabled = true;
                errorProviderTipoProducto.SetError(textBoxTipoProducto, "");
            }
        }*/

        public void buttonAgregar_Click(object sender, EventArgs e)
        {
            RegistrarProducto();
        }

        public void RegistrarProducto()
        {
            Guid idProducto = Guid.NewGuid();
            var stock = int.Parse(textBoxStock.Text);
            var precio = float.Parse(textBoxStock.Text);
            
            //Vendedor vendedor = new Vendedor();
            //vendedor = RegistroVendedor.vendedores.First(x => x.Usuario == InicioSesion.textBoxUsuario.Text);
            //InicioSesion.vendedor;

            //Ver de relacionar directamente tipo producto con categoría
            TipoProducto tipoProducto = new TipoProducto();
            tipoProducto.Nombre = comboBoxTipoProducto.Text;
           
            Producto producto = new Producto(idProducto, textBoxNombre.Text, comboBoxMarca.Text, precio, textBoxDescripcion.Text, stock, textBoxImagen.Text, tipoProducto);
            RegistroProducto.productos.Add(producto);
            var productoEnArchivoJson = JsonConvert.SerializeObject(RegistroProducto.productos, Formatting.Indented);
            System.IO.File.WriteAllText("productos.Json", productoEnArchivoJson);

            string message = "El producto se ha agregado correctamente!!!";
            string caption = "Success";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        private void buttonAtrás_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }


    public static class RegistroProducto
    {
        public static List<Producto> productos = new List<Producto>();
        public static Producto productoCargado;

        static RegistroProducto()
        {
            if (System.IO.File.Exists("productos.json"))
            {
                string contenidoArchivoProductos = System.IO.File.ReadAllText("productos.json");
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
            System.IO.File.WriteAllText("productos.Json", productosEnArchivoJson);
        }
    }
}
