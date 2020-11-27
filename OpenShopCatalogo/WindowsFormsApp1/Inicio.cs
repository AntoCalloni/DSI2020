using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inicio : Form
    {
        public Vendedor vendedores = new Vendedor();

        public Inicio()
        {
            InitializeComponent();
           // buttonIniciarSesion.Enabled = false;
        }

        public void buttonRegistrarVendedor_Click(object sender, EventArgs e)
        {
            RegistrarVendedor ventanaRegistrarVendedor = new RegistrarVendedor();
            ventanaRegistrarVendedor.ShowDialog();
        }

        public void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            InicioSesion ventanaInicioSesion = new InicioSesion();
            ventanaInicioSesion.ShowDialog();
        }
    }
}
