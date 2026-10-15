# Ejemplo web .Net — SIPVEP

Ejemplo de aplicación .NET con arquitectura en capas para la gestión de artículos y proveedores de una papelería (base de datos `Papeleria` en SQL Server). Incluye validaciones de reglas de negocio en la capa lógica y pruebas unitarias con MSTest.

> Nota: a pesar del nombre del repositorio, la interfaz incluida es una aplicación Windows Forms (no web); el proyecto sirve como ejemplo de la arquitectura en capas.

## Arquitectura

```
SIPVEP.sln
├── SIPVEP.Entidades         # Entidades del dominio: Articulo, Provedor, Articulo_Provedor
├── SIPVEP.CapaDatos         # Acceso a datos con Entity Framework 6 (Model.edmx, EF/)
├── SIPVEP.CapaLogica        # Reglas de negocio y validaciones: ArticuloLogica, ProvedorLogica
├── SIPVEP.WindowsForm       # Interfaz de usuario (Form1: alta y listado de artículos)
└── SIPVEP.PruebasUnitarias  # Pruebas unitarias (MSTest): ArticuloUT, ProvedorUT
```

## Reglas de negocio (ejemplos)

**Artículos** (`ArticuloLogica`):

- El SKU (código de barras) es obligatorio y único.
- El nombre debe tener entre 5 y 50 caracteres; la descripción, máximo 200.
- El precio de compra debe ser mayor a 0 y el precio de venta al menos 5 % superior al de compra.
- El stock debe ser mayor a 0; `Merma` y `AumentaExistencias` ajustan existencias sin dejarlas en negativo.
- En `Modificar`, la cantidad (stock) no puede alterarse directamente.

**Proveedores** (`ProvedorLogica`):

- RFC de 12 o 13 caracteres; razón social entre 10 y 100 caracteres.
- Dirección fiscal entre 10 y 100 caracteres, código postal de 5 dígitos, ciudad/estado de máximo 30, alias de máximo 10.
- Correo fiscal con formato válido y teléfono de 10 dígitos.

## Prerrequisitos

- Visual Studio 2015 o superior
- .NET Framework (ver la versión objetivo en cada `.csproj`)
- SQL Server (o LocalDB) con una base de datos llamada `Papeleria`
- Entity Framework 6 (se restaura vía NuGet a partir de `packages.config`)

## Puesta en marcha

1. Crear la base de datos `Papeleria` en SQL Server. El script del modelo está en `SIPVEP.CapaDatos/Model.edmx.sql`.
2. Ajustar la cadena de conexión `ModelContainer` en `SIPVEP.CapaDatos/App.Config` (por defecto apunta a `localhost` con seguridad integrada).
3. Abrir `SIPVEP.sln` en Visual Studio y compilar la solución.
4. Establecer `SIPVEP.WindowsForm` como proyecto de inicio y ejecutar (F5).
5. Para correr las pruebas: Test Explorer → Run All (`SIPVEP.PruebasUnitarias`).

## Licencia

GPL-3.0 — ver el archivo `LICENSE`.
