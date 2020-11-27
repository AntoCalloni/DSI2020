using System;

namespace WindowsFormsApp1
{
    public class Vendedor
    {
        public Guid IdVendedor { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }

        public Vendedor()
        {

        }


        public Vendedor(Guid idVendedor, string usuario, string contraseña)
        {
            IdVendedor = idVendedor;
            Usuario = usuario;
            Contraseña = contraseña;
        }
    }
}