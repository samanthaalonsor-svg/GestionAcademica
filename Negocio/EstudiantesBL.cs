using System.Data;
using GestionAcademica.DataAccess;
using GestionAcademica.Entities;

namespace GestionAcademica.Negocio
{
    public class EstudiantesBL
    {
        private readonly EstudiantesDAO estudiantesDAO = new EstudiantesDAO();

        public DataTable Buscar(string texto) => estudiantesDAO.Buscar(texto.Trim());

        public DataTable ObtenerTodos() => estudiantesDAO.ObtenerTodos();
        public bool Validar(Estudiante estudiante, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(estudiante.CodigoEstudiante))
            {
                mensajeError = "El código del estudiante es obligatorio.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(estudiante.Alumno))
            {
                mensajeError = "El nombre del alumno es obligatorio.";
                return false;
            }

            if (estudiante.IdEstado <= 0)
            {
                mensajeError = "Debe seleccionar un estado válido.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }

        public void Insertar(Estudiante estudiante)
        {
            if (!Validar(estudiante, out string mensajeError))
                throw new InvalidOperationException(mensajeError);

            estudiantesDAO.Insertar(estudiante);
        }

        public void Actualizar(Estudiante estudiante)
        {
            if (!Validar(estudiante, out string mensajeError))
                throw new InvalidOperationException(mensajeError);

            estudiantesDAO.Actualizar(estudiante);
        }

        public void Eliminar(string codigoEstudiante)
        {
            if (string.IsNullOrWhiteSpace(codigoEstudiante))
                throw new InvalidOperationException("Debe seleccionar un estudiante para eliminar.");

            estudiantesDAO.Eliminar(codigoEstudiante);
        }
    }
}
