using System;
using Xunit;
using WindowsFormsApp1;
using Newtonsoft.Json;
using System.Linq;


namespace XUnitTestProject1
{
    public class TestListaProductosDespacho
    {

        [Fact]
        public void LaListaNoEstaVacia()
        {
            Assert.NotNull(RegistroListadoDespacho.productos);
        }

        [Fact]
        public void ElStockEsValido()
        {
            bool esStockValido = true;
            foreach (var producto in RegistroListadoDespacho.productos)
            {


                int stock = producto.Stock;
                if (stock < 1)
                {
                    esStockValido = false;
                }
            }
            Assert.True(esStockValido);
        }

    }


    public class TestListaProductos
    {
        public Producto producto = new Producto();

        [Fact]
        public void StockCorrecto()
        {
            if (RegistroListadoDespacho.productos != null)
            {
                bool esValido = true;
                foreach (var producto in RegistroListadoDespacho.productos)
                {
                    var stock = RegistroProducto.productos.Where(x => x.IdProducto == producto.IdProducto).Select(x => x.Stock).Sum();
                    var stockDelProducto = producto.Stock;
                    if (stock < stockDelProducto)
                    {
                        esValido = false;
                    }
                }
                Assert.True(esValido);
            }
        }
    }

}
