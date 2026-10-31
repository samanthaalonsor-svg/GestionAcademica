# Entregable 6 - Entity Framework Core y generación de reportes

## Qué se implementó

El proyecto conserva el acceso ADO.NET existente y agrega un complemento mediante Entity Framework Core.

### 1. Entity Framework Core
- `DataAccess/GestionAcademicaDbContext.cs` contiene el `DbContext`.
- Se mapearon las tablas existentes: `Estudiantes`, `Estados`, `Niveles`, `Materias`, `Profesores`, `Asistencias_Sesiones` y `Evaluaciones_Finales`.
- No se eliminaron los DAO ni los procedimientos almacenados anteriores.

### 2. LINQ
`Negocio/Entregable6OrmBL.cs` utiliza consultas LINQ para:
- consultar estudiantes;
- consultar sesiones relacionando (JOIN) estudiante, nivel, materia y profesor;
- consultar evaluaciones relacionando estudiante, materia, profesor y estado;
- aplicar filtros dinámicos.

### 3. CRUD con ORM
La pestaña **CRUD con Entity Framework Core** permite:
- insertar estudiantes;
- actualizar estudiantes;
- eliminar estudiantes;
- consultar estudiantes.

Estas operaciones utilizan `DbContext`, `Add`, `FirstOrDefault`, `Remove` y `SaveChanges`.

### 4. Reportes dinámicos
La pestaña **Reportes dinámicos con LINQ** incluye:
- estudiantes por estado;
- sesiones por rango de fechas;
- evaluaciones por nota mínima;
- filtro por texto;
- contador de registros encontrados;
- exportación a CSV.

## Base de datos

El archivo `Script_EFCore_Complemento.sql` únicamente verifica que las tablas necesarias existan. No reemplaza el script de instalación ni modifica la estructura existente.

## Acceso

Desde el menú principal se agregó la opción **ORM y Reportes** para acceder a esta funcionalidad.

## Nota sobre los catálogos (Niveles, Materias, Profesores, Estados)

EF Core solo usa la **llave** de estas tablas (`id_nivel`, `id_materia`, `id_profesor`, `id_estado`) para los JOIN de LINQ.
El **texto** (nombre del nivel, materia, profesor o estado) se lee del catálogo ADO.NET existente y se detecta
automáticamente la columna de texto, de modo que los reportes funcionan aunque en su base de datos esas columnas
tengan otro nombre distinto al del script de instalación.

## Ejecución

`Program.Main` está marcado con `[STAThread]`, requisito de WinForms para los cuadros de diálogo (guardar/abrir archivo).
Los reportes se generan en segundo plano (`Task.Run`) para no congelar la ventana.
