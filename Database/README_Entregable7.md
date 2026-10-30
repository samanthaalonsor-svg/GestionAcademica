# Entregable 7 - Integración de servicios web

## Qué se implementó

La aplicación de escritorio consume un servicio web REST público y muestra la información dentro del sistema.
Cadena del entregable: **Aplicación de escritorio → HttpClient → API REST → JSON → información integrada**.

### Servicio consumido
API pública **Nager.Date** (sin clave de acceso):

`GET https://date.nager.at/api/v3/PublicHolidays/{año}/{código de país}`

### Archivos nuevos (no se modificó ningún archivo existente salvo el menú)
| Archivo | Función |
|---|---|
| `Servicios/FeriadosApiClient.cs` | `HttpClient` reutilizable, solicitud GET asíncrona, manejo de errores (sin conexión, tiempo agotado, país sin datos, JSON inválido) y cancelación. |
| `Servicios/FeriadoApi.cs` | Modelo del JSON (`System.Text.Json`, `[JsonPropertyName]`). |
| `Negocio/ServiciosWebBL.cs` | Capa de negocio: arma las tablas, calcula el próximo feriado y **cruza los feriados con las sesiones de la base de datos** usando EF Core + LINQ. |
| `Forms/FormServiciosWeb.cs` / `.Designer.cs` | Pantalla: país, año, buscar, cancelar, exportar CSV y tres pestañas. |

### Cambios en archivos existentes
- `Forms/FormMenuPrincipal.cs` y `.Designer.cs`: botón **Servicios web** en el grupo "Procesos y reportes".
- `Forms/FormORM.cs`: la nota mínima del reporte ahora acepta punto o coma decimal (antes dependía de la configuración regional).

### Pestañas de la pantalla
1. **Feriados (datos procesados):** fecha, día, nombre local, nombre internacional, alcance y tipo.
2. **Sesiones en días feriados:** información integrada; sesiones de `Asistencias_Sesiones` cuya fecha coincide con un feriado.
3. **Respuesta JSON:** el JSON original recibido, con formato.

También muestra el **próximo feriado** y permite exportar la tabla a CSV.

## Requisitos
- Conexión a Internet.
- Si la API no tiene datos para un país/año, la pantalla lo informa y se puede elegir otro.
- Los países disponibles en la lista están en `ServiciosWebBL.ObtenerPaises()`.
