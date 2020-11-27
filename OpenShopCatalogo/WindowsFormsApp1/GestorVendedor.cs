using System;
using System.Collections.Generic;


namespace WindowsFormsApp1
{
    public class GestorVendedor
    {
        public static Vendedor VendedorA = new Vendedor();
        public static Vendedor VendedorB = new Vendedor();
        public static Vendedor VendedorC = new Vendedor();

        public static List<Vendedor> ListaVendedores = new List<Vendedor>();



        public static void AgregarVendedores()
        {
            VendedorA.IdVendedor = 0;
            VendedorA.Usuario = "antocalloni";
            VendedorA.Contraseña = "123456";

            ListaVendedores.Add(new Vendedor(VendedorA.IdVendedor, VendedorA.Usuario, VendedorA.Contraseña));

        }

    }
}