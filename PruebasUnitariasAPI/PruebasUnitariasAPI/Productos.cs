using Xunit;
using System.Linq;
using System.Collections.Generic;
namespace Entidades // cambio de namespace para evitar conflictos
{
    public class Producto
    {
        public int Prod_ID { get; set; }
        public string? Prod_Descripcion { get; set; }
        public decimal Prod_Precio { get; set; }
        public decimal Prod_Costo { get; set; }
        public string? Prod_UM { get; set; }
    }
}
