
using Xunit;
using System.Linq;
using System.Collections.Generic;
using Entidades; // Importamos la clase Producto desde el namespace correcto

namespace PruebasProducto
{
    public class ProductoTests
    {
        [Fact]
        public void Producto_DeberiaTenerPrecioMayorACosto()
        {
            var producto = new Producto { Prod_ID = 1, Prod_Descripcion = "Producto A", Prod_Precio = 1000m, Prod_Costo = 700m, Prod_UM = "Unidad" };

            Assert.True(producto.Prod_Precio > producto.Prod_Costo);
        }

        [Fact]
        public void ListaProductos_DeberiaContenerProductoConID()
        {
            var productos = new List<Producto>
            {
                new Producto { Prod_ID = 1, Prod_Descripcion = "Producto A" },
                new Producto { Prod_ID = 2, Prod_Descripcion = "Producto B" }
            };

            var prod = productos.FirstOrDefault(p => p.Prod_ID == 2);

            Assert.NotNull(prod);
            Assert.Equal("Producto B", prod.Prod_Descripcion);
        }
    }
}
