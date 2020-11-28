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
    public partial class ModificarProducto : Form
    {
        public ModificarProducto()
        {
            InitializeComponent();
            RellenarDataGrid();
        }

        public void RellenarDataGrid()
        {
            //Para cuando conecte producto con vendedor
            //var productoSeleccionado = RegistroProducto.productos.Where(x => x.Nombre == RegistroVendedor.vendedorLogueado.).ToList();
            dataGridViewProductos.DataSource = RegistroProducto.productos.Select(x => new
            {
                x.IdProducto,
                x.Nombre,
                x.Marca,
                x.Precio,
                x.Descripcion,
                x.Stock, 
                x.Imagen,
                x.TipoProducto.IdTipoProducto,
            }).ToList();     
        }

        public void TextBoxPrecio_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoPrecio();
        }
        public float controlarTextoIngresadoPrecio()
        {
            buttonModificar.Enabled = false;
            float precioIngresado=0;
            bool esPrecio = float.TryParse(textBoxPrecio.Text.Trim(), out precioIngresado);
            if (esPrecio == false)
            {
                errorProviderPrecio.SetError(textBoxPrecio, "Deben ser sólo numeros");
            }
            else
            {
                buttonModificar.Enabled = true;
                errorProviderPrecio.SetError(textBoxPrecio, "");
            }
            
            return precioIngresado;
        }

        public void TextBoxStock_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoStock();
        }
        public int controlarTextoIngresadoStock()
        {
            buttonModificar.Enabled = false;
            int stockIngresado=0;
            bool esStock = int.TryParse(textBoxStock.Text.Trim(), out stockIngresado);
            if (esStock == false)
            {
                errorProviderStock.SetError(textBoxStock, "Debe introducir el Stock en números");
            }
            else
            {
                buttonModificar.Enabled = true;
                errorProviderStock.SetError(textBoxStock, "");
            }
             return stockIngresado;
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedCells.Count == 0)
            {
                errorProviderProducto.SetError(dataGridViewProductos, "Debe seleccionar un producto");
            }
            else
            {
                errorProviderProducto.SetError(dataGridViewProductos, "");
                var idSeleccionado = dataGridViewProductos.CurrentCell.Value.ToString();
                var productoSeleccionado = RegistroProducto.productos.Single(x => x.IdProducto.ToString() == idSeleccionado);
                if (!string.IsNullOrWhiteSpace(textBoxStock.Text))
                {
                    int stock = 0;
                    stock = controlarTextoIngresadoStock();
                    productoSeleccionado.Stock = stock;
                }
                if (!string.IsNullOrWhiteSpace(textBoxPrecio.Text))
                {
                    float precio = 0;
                    precio = controlarTextoIngresadoPrecio();
                    productoSeleccionado.Precio = precio;
                }

                RellenarDataGrid();
                dataGridViewProductos.Update();
                dataGridViewProductos.Refresh();

                RegistroProducto.GuardarDatosEnJson();

                textBoxPrecio.Clear();
                textBoxStock.Clear();

                string message = "El producto se ha modificado correctamente!!!";
                string caption = "Success";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
            } 
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewProductos.CurrentCell.ColumnIndex != 0)
            {
                errorProviderProducto.SetError(dataGridViewProductos, "Debe seleccionar un id");
            }
            else
            {
                errorProviderProducto.SetError(dataGridViewProductos, "");
            }
        }
    }
}
