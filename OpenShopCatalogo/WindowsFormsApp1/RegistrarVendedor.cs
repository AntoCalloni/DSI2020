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
    public partial class RegistrarVendedor : Form
    {
        public RegistrarVendedor()
        {
            InitializeComponent();
            buttonRegistrar.Enabled = false;
        }

        public void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoUsuario();
        }
        public void controlarTextoIngresadoUsuario()
        {
            buttonRegistrar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                errorProviderUsuario.SetError(textBoxUsuario, "Debe introducir su Usuario");
            }
            else
            {
                if (RegistroVendedor.vendedores.Any(x => x.Usuario == textBoxUsuario.Text))
                {
                    errorProviderUsuario.SetError(textBoxUsuario, "El usuario ya existe. Elija otro");
                }
                else
                {
                    errorProviderUsuario.SetError(textBoxUsuario, "");
                }

            }
        }

        public void TextBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoContraseña();
        }
        public void controlarTextoIngresadoContraseña()
        {
            buttonRegistrar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                errorProviderContraseña.SetError(textBoxContraseña, "Debe introducir su Contraseña");
            }
            else
            {
                if (textBoxContraseña.Text.Trim().Length < 8)
                {
                    errorProviderContraseña.SetError(textBoxContraseña, "Debe introducir más de 8 caracteres");
                }
                else
                {
                    errorProviderContraseña.SetError(textBoxContraseña, "");
                }
            }
        }

        public void TextBoxContraseña2da_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoContraseña2da();
        }
        public void controlarTextoIngresadoContraseña2da()
        {
            buttonRegistrar.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxContraseña2da.Text))
            {
                errorProviderContraseña2da.SetError(textBoxContraseña2da, "Debe validar su contraseña ingresándola nuevamente");
            }
            else
            {
                if (textBoxContraseña.Text != textBoxContraseña2da.Text)
                {
                    errorProviderContraseña2da.SetError(textBoxContraseña2da, "La contraseña no es la misma");
                }
                else
                {
                    buttonRegistrar.Enabled = true;
                    errorProviderContraseña2da.SetError(textBoxContraseña2da, "");
                }
            }
        }

        public void buttonRegistrar_Click(object sender, EventArgs e)
        {
            RegistrarAlVendedor();
            string message = "Usuario registrado";
            string caption = "Success";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show(message, caption, buttons);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
            }
        }

        public void RegistrarAlVendedor()
        {
            Guid idVendedor= Guid.NewGuid();

            /*DateTime fechaCreacionCatalogo = DateTime.Now;
            DateTime fechaModificacionCatalogo = DateTime.Now;
            Guid idCatalogo = Guid.NewGuid();
            Catalogo catalogo = new Catalogo (idCarrito, fechaCreacionCarrito, fechaModificacionCarrito);*/

            Vendedor vendedor = new Vendedor (idVendedor, textBoxUsuario.Text, textBoxContraseña.Text);
            RegistroVendedor.vendedores.Add(vendedor);
            var vendedorEnArchivoJson = JsonConvert.SerializeObject(RegistroVendedor.vendedores, Formatting.Indented);
            System.IO.File.WriteAllText("vendedores.Json", vendedorEnArchivoJson);
        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


    //El registro en json
    public static class RegistroVendedor
    {
        public static List<Vendedor> vendedores = new List<Vendedor>();
        public static Vendedor vendedorLogueado;

        static RegistroVendedor()
        {
            if (System.IO.File.Exists("vendedores.json"))
            {
                string contenidoArchivoVendedores = System.IO.File.ReadAllText("vendedores.json");
                List<Vendedor> vendedoresEnArchivoJson = JsonConvert.DeserializeObject<List<Vendedor>>(contenidoArchivoVendedores);
                if (vendedoresEnArchivoJson.Count != 0)
                {
                    vendedores = vendedoresEnArchivoJson;
                }
            }
        }
    }
}
