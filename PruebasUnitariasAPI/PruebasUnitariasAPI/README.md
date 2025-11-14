# PruebasUnitariasAPI

Repositorio con ejemplo de **pruebas unitarias en C#** usando **xUnit**, aplicadas a una estructura de facturación con tablas de Persona, Producto, Fact_Encabezado y Fact_Detalle.  

Este proyecto sirve como referencia para aprender a estructurar pruebas unitarias, manejar relaciones entre clases y calcular valores derivados (totales de detalle de facturas).

---

##  Estructura de carpetas
PruebasUnitariasAPI/

│

├─ PruebasUnitariasAPI/ <- Proyecto principal

│ ├─ Prueba.cs <- Pruebas para la clase Persona

│ ├─ FactxPersona.cs <- Pruebas para Fact_Encabezado

│ ├─ Producto.cs <- Clase y pruebas de Producto

│ ├─ FactxProducto.cs <- Pruebas para Fact_Detalle

│ ├─ PruebasUnitariasAPI.csproj

│ └─ ... <- Otros archivos de proyecto

│

├─ .gitignore <- Archivos y carpetas ignoradas por Git

└─ README.md

---

## Clases y Tablas simuladas

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

## Comandos principales

### Restaurar dependencias
```bash
dotnet restore
```

### Compilar proyecto
```
dotnet build
```
### Ejecutar pruebas
```
dotnet test
```
### Todos los tests deberían pasar correctamente, mostrando un resumen al final:
```
Resumen de pruebas: total: 5; con errores: 0; correcto: 5; omitido: 0; duración: X s
```
### Ejemplos de pruebas unitarias
- Persona
Verifica que una persona con Per_ID = 5 exista y tenga los datos correctos.
Comprueba que no exista una persona con un Per_ID inexistente.
Cuenta la cantidad total de personas.

- Producto
Comprueba que Prod_Precio > Prod_Costo.
Valida que un producto exista en una lista por Prod_ID

-FactxPersona
Verifica que cada factura tenga una persona asociada válida.

- FactxProducto
Valida que cada detalle tenga un producto relacionado.
Calcula el total por detalle (FDet_Cantidad * Prod_Precio).

### Cómo contribuir

Hacer un fork del repositorio.

Crear una rama para tu feature: git checkout -b mi-rama

Hacer commit de tus cambios: git commit -m "Agrego nuevas pruebas"

Subir tu rama: git push origin mi-rama

Abrir un Pull Request en este repositorio.

## AUTORA
### Kelly P. Diaz Granados N.
### Desarrolladora .NET | Apasionada por arquitectura limpia, optimización y buenas prácticas DevOps
- Correo: lainusk@gmail.com
- GitHub: lainusk
