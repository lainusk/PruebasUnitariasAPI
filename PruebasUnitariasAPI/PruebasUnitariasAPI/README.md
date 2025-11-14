
# PruebasUnitariasAPI

Este proyecto es un conjunto de pruebas unitarias en C# para un ejemplo de manejo de Personas, Facturas y Productos, usando xUnit como framework de test. Está diseñado como demostración de cómo crear y ejecutar pruebas unitarias en PowerShell sobre un proyecto .NET.

> Nota: Este proyecto de pruebas es independiente y **no está acoplado al proyecto principal Magnetron_PT**, por lo que no requiere conexión a base de datos ni dependencias externas. Esto permite ejecutar las pruebas de manera aislada para evaluar la lógica de las clases y sus relaciones.
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
- **Persona**  
  Clase con propiedades: `Per_ID`, `Per_Nombre`, `Per_Apellido`, `Per_TipoDocumento`, `Per_Documento`.  
  Pruebas verifican:
  - Existencia de una persona específica por ID.
  - No obtención de personas inexistentes.
  - Conteo correcto de personas.
- **Producto**  
  Clase con propiedades: `Prod_ID`, `Prod_Descripcion`, `Prod_Precio`, `Prod_Costo`, `Prod_UM`.  
  Pruebas verifican:
  - Que el precio sea mayor que el costo.
  - Que se pueda buscar un producto por ID en una lista.

- **FactxPersona**  
  Clase `FactxPersona` representa la factura principal con `FEnc_ID`, `FEnc_Numero`, `FEnc_Fecha` y `zPer_ID` (relación con Persona).  
  Pruebas verifican:
  - Que la factura tenga una persona asociada válida.

- **FactxProducto**  
  Clase `Fact_Detalle` representa los detalles de la factura con `FDet_ID`, `FDet_Linea`, `FDet_Cantidad` y `zProd_ID` (relación con Producto).  
  Pruebas verifican:
  - Que el detalle tenga un producto válido.
  - Que el total calculado (cantidad × precio) sea correcto.

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
## Patrones de diseño aplicados

Este proyecto, aunque sencillo, demuestra algunos patrones de diseño:

- **Factory / Creación de objetos:** Las listas de prueba (`List<Persona>`, `List<Producto>`) simulan la creación centralizada de objetos para tests.  
- **Repository (simulado):** Las listas en memoria funcionan como un repositorio de datos, separando la lógica de negocio de la fuente de datos.  
- **Builder (sugerido):** Para objetos con muchas propiedades (Persona, Producto), se podría usar un Builder para simplificar la creación de instancias en los tests.

---

## Cómo ejecutar las pruebas

> Importante: Estas pruebas se ejecutan **solo en PowerShell** usando .NET.

1. Abrir PowerShell y navegar a la carpeta del proyecto:
```powershell
cd "C:\..\..\Magnetron\PruebasUnitariasAPI\PruebasUnitariasAPI"
```
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
