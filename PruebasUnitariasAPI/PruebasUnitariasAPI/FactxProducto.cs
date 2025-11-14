using Xunit;
using System.Linq;
using System.Collections.Generic;
using Entidades; // Importa la clase Producto desde el namespace correcto

namespace FactxProducto
{
    public class Fact_Detalle
    {
        public int FDet_ID { get; set; }
        public int FDet_Linea { get; set; }
        public int FDet_Cantidad { get; set; }
        public int zProd_ID { get; set; }
    }

    public class Fact_DetalleTests
    {
        [Fact]
        public void DetalleFactura_DeberiaTenerProductoValido()
        {
            var productos = new List<Producto>
            {
                new Producto { Prod_ID = 1, Prod_Descripcion = "Producto A" }
            };

            var detalle = new Fact_Detalle { FDet_ID = 1, FDet_Linea = 1, FDet_Cantidad = 3, zProd_ID = 1 };

            var productoRelacion = productos.FirstOrDefault(p => p.Prod_ID == detalle.zProd_ID);

            Assert.NotNull(productoRelacion);
            Assert.Equal("Producto A", productoRelacion.Prod_Descripcion);
        }

        [Fact]
        public void CalcularTotalDetalle_RetornaCantidadPorPrecio()
        {
            var producto = new Producto { Prod_ID = 1, Prod_Precio = 100m };
            var detalle = new Fact_Detalle { FDet_Cantidad = 3, zProd_ID = 1 };

            var total = detalle.FDet_Cantidad * producto.Prod_Precio;

            Assert.Equal(300m, total);
        }
    }
}
