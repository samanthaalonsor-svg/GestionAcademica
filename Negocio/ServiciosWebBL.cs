using System.Data;
using System.Globalization;
using GestionAcademica.DataAccess;
using GestionAcademica.Servicios;
using Microsoft.EntityFrameworkCore;

namespace GestionAcademica.Negocio
{
    public class PaisServicio
    {
        public string Codigo { get; }
        public string Nombre { get; }

        public PaisServicio(string codigo, string nombre)
        {
            Codigo = codigo;
            Nombre = nombre;
        }
    }

    public class ResultadoFeriados
    {
        public DataTable Feriados { get; set; } = new DataTable();
        public DataTable SesionesEnFeriado { get; set; } = new DataTable();
        public string JsonOriginal { get; set; } = string.Empty;
        public string ProximoFeriado { get; set; } = string.Empty;
        public string AvisoSesiones { get; set; } = string.Empty;
    }

    
    public class ServiciosWebBL
    {
        private static readonly CultureInfo cultura = new CultureInfo("es");
        private readonly FeriadosApiClient api = new FeriadosApiClient();

        public List<PaisServicio> ObtenerPaises()
        {
            return new List<PaisServicio>
            {
                new PaisServicio("NI", "Nicaragua"),
                new PaisServicio("CR", "Costa Rica"),
                new PaisServicio("SV", "El Salvador"),
                new PaisServicio("GT", "Guatemala"),
                new PaisServicio("HN", "Honduras"),
                new PaisServicio("PA", "Panamá"),
                new PaisServicio("MX", "México"),
                new PaisServicio("ES", "España"),
                new PaisServicio("US", "Estados Unidos")
            };
        }

        public async Task<ResultadoFeriados> ConsultarFeriadosAsync(
            string codigoPais, int anio, CancellationToken cancellationToken)
        {
            if (anio < 2000 || anio > 2100)
                throw new InvalidOperationException("El año debe estar entre 2000 y 2100.");

           
            RespuestaFeriados respuesta = await api.ObtenerFeriadosAsync(codigoPais, anio, cancellationToken);

            var resultado = new ResultadoFeriados
            {
                JsonOriginal = respuesta.JsonOriginal,
                Feriados = ConstruirTablaFeriados(respuesta.Feriados),
                ProximoFeriado = BuscarProximo(respuesta.Feriados)
            };

           
            try
            {
                resultado.SesionesEnFeriado = await ConsultarSesionesEnFeriadosAsync(
                    respuesta.Feriados, anio, cancellationToken);

                resultado.AvisoSesiones = resultado.SesionesEnFeriado.Rows.Count == 0
                    ? "No hay sesiones registradas en días feriados."
                    : $"Hay {resultado.SesionesEnFeriado.Rows.Count} sesión(es) registradas en días feriados.";
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (Exception ex)
            {
                resultado.SesionesEnFeriado = CrearTablaSesiones();
                resultado.AvisoSesiones = "No se pudo cruzar con las sesiones de la base de datos: " + ex.Message;
            }

            return resultado;
        }

        private async Task<DataTable> ConsultarSesionesEnFeriadosAsync(
            List<FeriadoApi> feriados, int anio, CancellationToken cancellationToken)
        {
            DataTable tabla = CrearTablaSesiones();

            var porFecha = feriados
                .GroupBy(f => f.Fecha.Date)
                .ToDictionary(g => g.Key, g => g.First().NombreLocal);

            DateTime inicio = new DateTime(anio, 1, 1);
            DateTime fin = inicio.AddYears(1);

            using (var db = new GestionAcademicaDbContext())
            {
                var consulta =
                    from a in db.Asistencias.AsNoTracking()
                    join e in db.Estudiantes.AsNoTracking() on a.CodigoEstudiante equals e.CodigoEstudiante
                    where a.Fecha >= inicio && a.Fecha < fin
                    orderby a.Fecha
                    select new { a.CodigoEstudiante, e.Alumno, a.Fecha };

                var sesiones = await consulta.ToListAsync(cancellationToken);

                foreach (var s in sesiones.Where(x => porFecha.ContainsKey(x.Fecha.Date)))
                {
                    tabla.Rows.Add(
                        s.CodigoEstudiante,
                        s.Alumno,
                        s.Fecha.ToString("dd/MM/yyyy"),
                        porFecha[s.Fecha.Date]);
                }
            }

            return tabla;
        }

        private static DataTable CrearTablaSesiones()
        {
            var tabla = new DataTable();
            tabla.Columns.Add("Código");
            tabla.Columns.Add("Estudiante");
            tabla.Columns.Add("Fecha de la sesión");
            tabla.Columns.Add("Feriado");
            return tabla;
        }

        private static DataTable ConstruirTablaFeriados(List<FeriadoApi> feriados)
        {
            var tabla = new DataTable();
            tabla.Columns.Add("Fecha");
            tabla.Columns.Add("Día");
            tabla.Columns.Add("Feriado");
            tabla.Columns.Add("Nombre internacional");
            tabla.Columns.Add("Alcance");
            tabla.Columns.Add("Tipo");

            foreach (FeriadoApi f in feriados)
            {
                tabla.Rows.Add(
                    f.Fecha.ToString("dd/MM/yyyy"),
                    cultura.TextInfo.ToTitleCase(f.Fecha.ToString("dddd", cultura)),
                    f.NombreLocal,
                    f.Nombre,
                    f.Global ? "Nacional" : "Regional",
                    string.Join(", ", f.Tipos));
            }

            return tabla;
        }

        private static string BuscarProximo(List<FeriadoApi> feriados)
        {
            FeriadoApi proximo = feriados.FirstOrDefault(f => f.Fecha.Date >= DateTime.Today);
            if (proximo == null)
                return "Sin feriados próximos en el año consultado.";

            int dias = (proximo.Fecha.Date - DateTime.Today).Days;
            string cuando = dias == 0 ? "hoy" : dias == 1 ? "mañana" : $"en {dias} días";
            return $"Próximo feriado: {proximo.NombreLocal} ({proximo.Fecha:dd/MM/yyyy}), {cuando}.";
        }
    }
}
