using System.Data;
using GestionAcademica.DataAccess;
using GestionAcademica.Entities;
using GestionAcademica.ORM;
using Microsoft.EntityFrameworkCore;

namespace GestionAcademica.Negocio
{
    /// <summary>
    /// Operaciones de Entity Framework Core y consultas LINQ del Entregable 6.
    /// Convive con el acceso ADO.NET existente y no reemplaza los DAO actuales.
    /// </summary>
    public class Entregable6OrmBL
    {
        private readonly CatalogosBL catalogosBL = new CatalogosBL();

        public List<Estudiante> ObtenerEstudiantes()
        {
            using var db = new GestionAcademicaDbContext();
            return db.Estudiantes.AsNoTracking().OrderBy(e => e.Alumno).ToList();
        }

        public List<EstadoOrm> ObtenerEstados()
        {
            // El texto de los catálogos se lee del acceso ADO.NET existente (SELECT * de cada catálogo),
            // detectando la columna de texto: así funciona aunque la base ya creada use otros nombres de columna.
            var estados = LeerCatalogo(catalogosBL.ObtenerEstados(), "estado", "nombre_estado", "NombreEstado", "nombre");

            return estados
                .Select(x => new EstadoOrm { IdEstado = x.Key, Estado = x.Value })
                .OrderBy(x => x.Estado)
                .ToList();
        }

        /// <summary>
        /// Convierte una tabla de catálogo (id, texto) en un diccionario id -> texto.
        /// La primera columna es el id; el texto es la primera columna candidata que exista o, si no,
        /// la primera columna de tipo texto.
        /// </summary>
        private static Dictionary<int, string> LeerCatalogo(DataTable tabla, params string[] columnasCandidatas)
        {
            var resultado = new Dictionary<int, string>();
            if (tabla.Columns.Count == 0)
                return resultado;

            DataColumn columnaId = tabla.Columns[0];
            DataColumn columnaTexto = null;

            foreach (string nombre in columnasCandidatas)
            {
                if (tabla.Columns.Contains(nombre))
                {
                    columnaTexto = tabla.Columns[nombre];
                    break;
                }
            }

            if (columnaTexto == null)
                columnaTexto = tabla.Columns.Cast<DataColumn>()
                    .FirstOrDefault(col => col != columnaId && col.DataType == typeof(string));

            if (columnaTexto == null && tabla.Columns.Count > 1)
                columnaTexto = tabla.Columns[1];

            foreach (DataRow fila in tabla.Rows)
            {
                int id = Convert.ToInt32(fila[columnaId]);
                resultado[id] = columnaTexto == null ? id.ToString() : Convert.ToString(fila[columnaTexto]) ?? string.Empty;
            }

            return resultado;
        }

        private static string TextoDe(Dictionary<int, string> catalogo, int id)
        {
            return catalogo.TryGetValue(id, out string texto) ? texto : id.ToString();
        }

        public void InsertarEstudiante(Estudiante estudiante)
        {
            ValidarEstudiante(estudiante);
            using var db = new GestionAcademicaDbContext();
            if (db.Estudiantes.Any(e => e.CodigoEstudiante == estudiante.CodigoEstudiante))
                throw new InvalidOperationException("Ya existe un estudiante con ese código.");

            db.Estudiantes.Add(estudiante);
            db.SaveChanges();
        }

        public void ActualizarEstudiante(Estudiante estudiante)
        {
            ValidarEstudiante(estudiante);
            using var db = new GestionAcademicaDbContext();
            var existente = db.Estudiantes.FirstOrDefault(e => e.CodigoEstudiante == estudiante.CodigoEstudiante);
            if (existente == null)
                throw new InvalidOperationException("No se encontró el estudiante seleccionado.");

            existente.Alumno = estudiante.Alumno;
            existente.IdEstado = estudiante.IdEstado;
            db.SaveChanges();
        }

        public void EliminarEstudiante(string codigo)
        {
            if (string.IsNullOrWhiteSpace(codigo))
                throw new InvalidOperationException("Seleccione un estudiante.");

            using var db = new GestionAcademicaDbContext();
            var existente = db.Estudiantes.FirstOrDefault(e => e.CodigoEstudiante == codigo);
            if (existente == null)
                throw new InvalidOperationException("No se encontró el estudiante seleccionado.");

            db.Estudiantes.Remove(existente);
            db.SaveChanges();
        }

        public DataTable ReporteEstudiantes(string texto, int? idEstado)
        {
            using var db = new GestionAcademicaDbContext();

            var query = db.Estudiantes.AsNoTracking().Select(e => new
            {
                Codigo = e.CodigoEstudiante,
                Estudiante = e.Alumno,
                IdEstado = e.IdEstado
            });

            if (!string.IsNullOrWhiteSpace(texto))
                query = query.Where(x => x.Codigo.Contains(texto) || x.Estudiante.Contains(texto));

            if (idEstado.HasValue)
                query = query.Where(x => x.IdEstado == idEstado.Value);

            var datos = query.OrderBy(x => x.Estudiante).ToList();
            var estados = ObtenerEstados().ToDictionary(x => x.IdEstado, x => x.Estado);

            return CrearTabla(
                new[] { "Código", "Estudiante", "Estado" },
                datos.Select(x => new[]
                {
                    x.Codigo, x.Estudiante,
                    estados.TryGetValue(x.IdEstado, out string nombre) ? nombre : x.IdEstado.ToString()
                }));
        }

        public DataTable ReporteSesiones(string texto, DateTime? desde, DateTime? hasta)
        {
            var niveles = LeerCatalogo(catalogosBL.ObtenerNiveles(), "nivel", "nombre_nivel", "NombreNivel", "nombre");
            var materias = LeerCatalogo(catalogosBL.ObtenerMaterias(), "materia", "nombre_materia", "NombreMateria", "nombre");
            var profesores = LeerCatalogo(catalogosBL.ObtenerProfesores(), "profesor", "nombre_profesor", "NombreProfesor", "nombre", "nombre_completo");

            // Materias cuyo nombre coincide con el texto buscado (el filtro se traduce a un IN en SQL).
            List<int> idsMateria = BuscarIds(materias, texto);

            using var db = new GestionAcademicaDbContext();

            var query =
                from a in db.Asistencias.AsNoTracking()
                join e in db.Estudiantes.AsNoTracking() on a.CodigoEstudiante equals e.CodigoEstudiante
                join n in db.Niveles.AsNoTracking() on a.IdNivel equals n.IdNivel
                join m in db.Materias.AsNoTracking() on a.IdMateria equals m.IdMateria
                join p in db.Profesores.AsNoTracking() on a.IdProfesor equals p.IdProfesor
                select new
                {
                    Codigo = a.CodigoEstudiante,
                    Estudiante = e.Alumno,
                    Fecha = a.Fecha,
                    IdNivel = n.IdNivel,
                    IdMateria = m.IdMateria,
                    IdProfesor = p.IdProfesor
                };

            if (!string.IsNullOrWhiteSpace(texto))
                query = query.Where(x => x.Codigo.Contains(texto) || x.Estudiante.Contains(texto) || idsMateria.Contains(x.IdMateria));
            if (desde.HasValue)
                query = query.Where(x => x.Fecha >= desde.Value.Date);
            if (hasta.HasValue)
                query = query.Where(x => x.Fecha < hasta.Value.Date.AddDays(1));

            var datos = query.OrderByDescending(x => x.Fecha).ToList();
            return CrearTabla(
                new[] { "Código", "Estudiante", "Fecha", "Nivel", "Materia", "Profesor" },
                datos.Select(x => new[]
                {
                    x.Codigo, x.Estudiante, x.Fecha.ToString("dd/MM/yyyy"),
                    TextoDe(niveles, x.IdNivel), TextoDe(materias, x.IdMateria), TextoDe(profesores, x.IdProfesor)
                }));
        }

        public DataTable ReporteEvaluaciones(string texto, double? notaMinima)
        {
            var materias = LeerCatalogo(catalogosBL.ObtenerMaterias(), "materia", "nombre_materia", "NombreMateria", "nombre");
            var profesores = LeerCatalogo(catalogosBL.ObtenerProfesores(), "profesor", "nombre_profesor", "NombreProfesor", "nombre", "nombre_completo");
            var estados = ObtenerEstados().ToDictionary(x => x.IdEstado, x => x.Estado);

            List<int> idsMateria = BuscarIds(materias, texto);

            using var db = new GestionAcademicaDbContext();

            // El filtro de nota mínima se aplica sobre la entidad, antes de proyectar.
            IQueryable<EvaluacionFinal> evaluaciones = db.EvaluacionesFinales.AsNoTracking();
            if (notaMinima.HasValue)
                evaluaciones = evaluaciones.Where(ev => ev.NotaFinal >= notaMinima.Value);

            var query =
                from ev in evaluaciones
                join e in db.Estudiantes.AsNoTracking() on ev.CodigoEstudiante equals e.CodigoEstudiante
                join m in db.Materias.AsNoTracking() on ev.IdMateria equals m.IdMateria
                join p in db.Profesores.AsNoTracking() on ev.IdProfesor equals p.IdProfesor
                select new
                {
                    Codigo = ev.CodigoEstudiante,
                    Estudiante = e.Alumno,
                    IdMateria = m.IdMateria,
                    IdProfesor = p.IdProfesor,
                    Nota = ev.NotaFinal,
                    IdEstado = ev.IdEstado,
                    Fecha = ev.FechaEvaluacion
                };

            if (!string.IsNullOrWhiteSpace(texto))
                query = query.Where(x => x.Codigo.Contains(texto) || x.Estudiante.Contains(texto) || idsMateria.Contains(x.IdMateria));
            var datos = query.OrderByDescending(x => x.Nota).ToList();

            return CrearTabla(
                new[] { "Código", "Estudiante", "Materia", "Profesor", "Nota final", "Estado", "Fecha" },
                datos.Select(x => new[]
                {
                    x.Codigo, x.Estudiante, TextoDe(materias, x.IdMateria), TextoDe(profesores, x.IdProfesor),
                    x.Nota.ToString("0.00"), TextoDe(estados, x.IdEstado), x.Fecha.ToString("dd/MM/yyyy")
                }));
        }

        private static List<int> BuscarIds(Dictionary<int, string> catalogo, string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return new List<int>();

            return catalogo
                .Where(x => x.Value.Contains(texto.Trim(), StringComparison.OrdinalIgnoreCase))
                .Select(x => x.Key)
                .ToList();
        }

        private static void ValidarEstudiante(Estudiante estudiante)
        {
            if (estudiante == null || string.IsNullOrWhiteSpace(estudiante.CodigoEstudiante))
                throw new InvalidOperationException("El código del estudiante es obligatorio.");
            if (string.IsNullOrWhiteSpace(estudiante.Alumno))
                throw new InvalidOperationException("El nombre del estudiante es obligatorio.");
            if (estudiante.IdEstado <= 0)
                throw new InvalidOperationException("Seleccione un estado válido.");
        }

        private static DataTable CrearTabla(string[] columnas, IEnumerable<string[]> filas)
        {
            var tabla = new DataTable();
            foreach (string columna in columnas)
                tabla.Columns.Add(columna);

            foreach (string[] fila in filas)
                tabla.Rows.Add(fila);

            return tabla;
        }
    }
}
