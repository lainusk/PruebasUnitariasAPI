using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace Personas
{
  
    public class Persona
    {
        public int Per_ID { get; set; }
        public string? Per_Nombre { get; set; }
        public string? Per_Apellido { get; set; }
        public string? Per_TipoDocumento { get; set; }
        public string? Per_Documento { get; set; }
    }

    public class PersonaTests
    {
        [Fact]
        public void Yudy_DeberiaSerUnicaConID5_YValidarDatos()
        {
        
            var personas = new List<Persona>
            {
                new Persona { Per_ID = 5, Per_Nombre = "Yudy", Per_Apellido = "Munera", Per_TipoDocumento = "CC", Per_Documento = "9005005050" },
                new Persona { Per_ID = 6, Per_Nombre = "Carlos", Per_Apellido = "Pérez", Per_TipoDocumento = "CC", Per_Documento = "1122334455" },
                new Persona { Per_ID = 7, Per_Nombre = "Ana", Per_Apellido = "Gómez", Per_TipoDocumento = "CC", Per_Documento = "9988776655" }
            };

           
            var personaDb = personas.FirstOrDefault(p => p.Per_ID == 5);
            var countId5 = personas.Count(p => p.Per_ID == 5);

          
            Assert.NotNull(personaDb);
            Assert.Equal(1, countId5);
            Assert.Equal("Yudy", personaDb.Per_Nombre);
            Assert.Equal("Munera", personaDb.Per_Apellido);
            Assert.Equal("CC", personaDb.Per_TipoDocumento);
            Assert.Equal("9005005050", personaDb.Per_Documento);
        }

        [Fact]
        public void Persona_NoExistente_DeberiaSerNull()
        {
          
            var personas = new List<Persona>
            {
                new Persona { Per_ID = 1, Per_Nombre = "Juan", Per_Apellido = "Lopez" }
            };

            
            var personaDb = personas.FirstOrDefault(p => p.Per_ID == 99);

           
            Assert.Null(personaDb);
        }

        [Fact]
        public void ContarPersonas_DeberiaRetornarCantidadCorrecta()
        {
            
            var personas = new List<Persona>
            {
                new Persona { Per_ID = 1 },
                new Persona { Per_ID = 2 },
                new Persona { Per_ID = 3 }
            };

          
            var total = personas.Count();

         
            Assert.Equal(3, total);
        }

        [Fact]
        public void Suma_DosMasDos_RetornaCuatro()
        {
           
            int resultado = 2 + 2;

           
            Assert.Equal(4, resultado);
        }
    }
}

