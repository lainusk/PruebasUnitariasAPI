using Xunit;
using System.Linq;
using System.Collections.Generic;
using Personas; // Importa aquí el namespace de Persona

namespace FactxPersona
{
    public class Fact_Encabezado
    {
        public int FEnc_ID { get; set; }
        public string? FEnc_Numero { get; set; }
        public DateTime FEnc_Fecha { get; set; }
        public int zPer_ID { get; set; } // relación con Persona
    }

    public class Fact_EncabezadoTests
    {
        [Fact]
        public void Factura_DeberiaTenerPersonaValida()
        {
            var personas = new List<Persona>
            {
                new Persona { Per_ID = 1, Per_Nombre = "Juan" }
            };

            var factura = new Fact_Encabezado
            {
                FEnc_ID = 1,
                FEnc_Numero = "FAC001",
                FEnc_Fecha = DateTime.Today,
                zPer_ID = 1
            };

            var personaRelacionada = personas.FirstOrDefault(p => p.Per_ID == factura.zPer_ID);

            Assert.NotNull(personaRelacionada);
            Assert.Equal("Juan", personaRelacionada.Per_Nombre);
        }
    }
}
