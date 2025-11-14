
# PruebasUnitariasAPI

Este proyecto es un conjunto de pruebas unitarias en C# para un ejemplo de manejo de Personas, Facturas y Productos, usando xUnit como framework de test. Está diseñado como demostración de cómo crear y ejecutar pruebas unitarias en PowerShell sobre un proyecto .NET.

---


##  Estructura de carpetas

PruebasUnitariasAPI/

├─ PruebasUnitariasAPI/       # Proyecto principal de pruebas

│  ├─ PersonaTests.cs         # Pruebas para la clase Persona

│  ├─ FactxPersonaTests.cs    # Pruebas para Facturas y relación con Persona

│  ├─ FactxProductoTests.cs   # Pruebas para Detalle de Factura y Producto

│  └─ ProductoTests.cs        # Pruebas para la clase Producto

├─ PruebasUnitariasAPI.sln    # Solución .NET

└─ README.md                  # Este archivo

---
### Clases y pruebas incluidas
- Persona
  Clase Persona con propiedades como Per_ID, Per_Nombre, Per_Apellido, Per_TipoDocumento y Per_Documento.
  Pruebas verifican:
  Que exista una persona específica por ID.
  Que no se obtenga una persona inexistente.
  Conteo de personas.
- Producto
  Clase Producto con Prod_ID, Prod_Descripcion, Prod_Precio, Prod_Costo y Prod_UM.
  Pruebas verifican:
  Que el precio sea mayor que el costo.
  Que se pueda buscar un producto en una lista por ID.
-FactxPersona
  Clase FactxPersona representa la factura principal.
  Contiene FEnc_ID, FEnc_Numero, FEnc_Fecha y zPer_ID (relación con Persona).
  Pruebas verifican que la factura esté relacionada con una persona válida.
  Verifica que cada factura tenga una persona asociada válida.

- FactxProducto
  Clase Fact_Detalle para los detalles de la factura.
  Contiene FDet_ID, FDet_Linea, FDet_Cantidad y zProd_ID (relación con Producto).
  Pruebas verifican:
  Que el detalle tenga un producto válido.
  Que el total calculado (cantidad × precio) sea correcto.

##  Tablas simuladas

| Clase / Tabla       | Campos principales                                       |
|--------------------|----------------------------------------------------------|
| **Persona**        | `Per_ID`, `Per_Nombre`, `Per_Apellido`, `Per_TipoDocumento`, `Per_Documento` |
| **Producto**       | `Prod_ID`, `Prod_Descripcion`, `Prod_Precio`, `Prod_Costo`, `Prod_UM` |
| **Fact_Encabezado**| `FEnc_ID`, `FEnc_Numero`, `FEnc_Fecha`, `zPer_ID` (relación con Persona) |
| **Fact_Detalle**   | `FDet_ID`, `FDet_Linea`, `FDet_Cantidad`, `zProd_ID` (relación con Producto) |

---

## Requisitos

- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- Visual Studio 2022 / VS Code (opcional)
- xUnit (ya incluido en el proyecto via NuGet)

---
## Dependencias y limitaciones

Estas pruebas son independientes y no están integradas al proyecto principal de facturación.
Funcionan como un sandbox de ejemplo, mostrando cómo crear y ejecutar pruebas unitarias en .NET con xUnit.
La ejecución está pensada para PowerShell, debido a la configuración del entorno .NET y la ruta de trabajo del proyecto.
No requieren base de datos ni referencias externas, todo se simula con listas en memoria.

## Cómo ejecutar las pruebas

Importante: Estas pruebas se ejecutan en PowerShell usando .NET.
Abrir PowerShell y navegar a la carpeta del proyecto:
cd "C:\..\..\Magnetron\PruebasUnitariasAPI\PruebasUnitariasAPI"


Restaurar dependencias y compilar:
```
dotnet build
```

Ejecutar todas las pruebas:
```
dotnet test
```
Al final verás un resumen con el total de pruebas, cuántas pasaron y si hubo errores.
## Objetivo

El propósito de este es demostrar el flujo de pruebas unitarias en .NET, simulando un pequeño sistema de facturación. Cada clase y prueba muestra buenas prácticas de:
Organización de tests por entidad.
Validación de relaciones entre clases (Factura ↔ Persona, Detalle ↔ Producto).
Cálculos simples y validaciones de datos.

## AUTORA
### Kelly P. Diaz Granados N.
### Desarrolladora .NET | Apasionada por arquitectura limpia, optimización y buenas prácticas DevOps
- Correo: lainusk@gmail.com
- GitHub: lainusk
