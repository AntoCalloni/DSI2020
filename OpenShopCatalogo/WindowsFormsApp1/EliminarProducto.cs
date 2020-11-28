using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EliminarProducto : Form
    {
        public EliminarProducto()
        {
            InitializeComponent();
            RellenarDataGrid();
        }

        public void RellenarDataGrid()
        {
            //var productoSeleccionado = RegistroProducto.productos.Where(x => x.Nombre == RegistroProducto.productoCargado.Nombre).ToList();
            dataGridViewProductos.DataSource = RegistroProducto.productos.Select(x => new
            {
                x.IdProducto,
                x.Nombre,
                x.Marca,
                x.Precio,
                x.Descripcion,
                x.Stock,
            }).ToList();
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedCells.Count == 0)
            {
                errorProviderProducto.SetError(dataGridViewProductos, "Debe seleccionar un producto");
            }
            else
            {
                string message = "¿Está seguro de que desea eliminarlo?";
                string caption = "Attention";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;
                result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    var idSeleccionado = dataGridViewProductos.CurrentCell.Value.ToString();
                    var productoSeleccionado = RegistroProducto.productos.First(x => x.IdProducto.ToString() == idSeleccionado);

                    RegistroProducto.productos.Remove(productoSeleccionado);

                    RellenarDataGrid();
                    dataGridViewProductos.Update();
                    dataGridViewProductos.Refresh();
                    RegistroProducto.GuardarDatosEnJson();
                }
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
