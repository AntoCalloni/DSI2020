using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml;
using Newtonsoft.Json;
using System.CodeDom.Compiler;


namespace WindowsFormsApp1
{
    public partial class InicioSesion : Form
    {
        public static Vendedor vendedor = new Vendedor();

        public InicioSesion()
        {
            InitializeComponent();
            buttonIniciarSesion.Enabled = false;
        }
        
        public void TextBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            controlarTextoIngresadoUsuario();
        }
        public void controlarTextoIngresadoUsuario()
        {
            buttonIniciarSesion.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                errorProviderUsuario.SetError(textBoxUsuario, "Debe introducir el usuario");
            }
            else
            {
                if (!RegistroVendedor.vendedores.Any(x => x.Usuario == textBoxUsuario.Text))
                {
                    errorProviderUsuario.SetError(textBoxUsuario, "El usuario no existe");
                }
                else
                {
                    buttonIniciarSesion.Enabled = true;
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
           
            buttonIniciarSesion.Enabled = false;
            if (string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {
                errorProviderContraseña.SetError(textBoxContraseña, "Debe introducir la contraseña");
            }
            else
            {
                vendedor = RegistroVendedor.vendedores.First(x => x.Usuario == textBoxUsuario.Text);
                if (vendedor.Contraseña != textBoxContraseña.Text)
                {
                    errorProviderContraseña.SetError(textBoxContraseña, "La contraseña es incorrecta");
                }
                else
                {
                    buttonIniciarSesion.Enabled = true;
                    errorProviderContraseña.SetError(textBoxContraseña, "");
                }
            }
        }

        public void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            RegistroVendedor.vendedorLogueado = RegistroVendedor.vendedores.First(x => x.Usuario == textBoxUsuario.Text);

            Home ventanaHome = new Home();
            ventanaHome.ShowDialog();
        }

    }
}
