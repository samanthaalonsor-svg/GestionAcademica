using System.Data;
using GestionAcademica.DataAccess;
using GestionAcademica.Entities;

namespace GestionAcademica.Negocio
{
    public class AsistenciasBL
    {
        private readonly AsistenciasDAO asistenciasDAO = new AsistenciasDAO();

        public DataTable Buscar(string texto) => asistenciasDAO.Buscar(texto.Trim());

        public DataTable ObtenerTodos() => asistenciasDAO.ObtenerTodos();

        public bool Validar(Asistencia asistencia, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(asistencia.CodigoEstudiante))
            {
                mensajeError = "Debe seleccionar un estudiante.";
                return false;
            }

            if (asistencia.IdNivel <= 0)
            {
                mensajeError = "Debe seleccionar un nivel.";
                return false;
            }

            if (asistencia.IdMateria <= 0)
            {
                mensajeError = "Debe seleccionar una materia.";
                return false;
            }

            if (asistencia.IdProfesor <= 0)
            {
                mensajeError = "Debe seleccionar un profesor.";
                return false;
            }

            if (asistencia.Fecha > DateTime.Now.Date.AddDays(1))
            {
                mensajeError = "La fecha de la asistencia no puede ser futura.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }

        public void Insertar(Asistencia asistencia)
        {
            if (!Validar(asistencia, out string mensajeError))
                throw new InvalidOperationException(mensajeError);

            asistenciasDAO.Insertar(asistencia);
        }

        public void Actualizar(Asistencia asistencia)
        {
            if (!Validar(asistencia, out string mensajeError))
                throw new InvalidOperationException(mensajeError);

            asistenciasDAO.Actualizar(asistencia);
        }

        public void Eliminar(int idAsistencia)
        {
            if (idAsistencia <= 0)
                throw new InvalidOperationException("Debe seleccionar un registro para eliminar.");

            asistenciasDAO.Eliminar(idAsistencia);
        }
    }
}
