using System.Data;
using GestionAcademica.DataAccess;
using GestionAcademica.Entities;

namespace GestionAcademica.Negocio
{
    public class EvaluacionesFinalesBL
    {
        private const double NotaMinima = 0;
        private const double NotaMaxima = 100;

        private readonly EvaluacionesFinalesDAO evaluacionesDAO = new EvaluacionesFinalesDAO();

        public DataTable Buscar(string texto) => evaluacionesDAO.Buscar(texto.Trim());

        public DataTable ObtenerTodos() => evaluacionesDAO.ObtenerTodos();

        public bool Validar(EvaluacionFinal evaluacion, out string mensajeError)
        {
            if (string.IsNullOrWhiteSpace(evaluacion.CodigoEstudiante))
            {
                mensajeError = "Debe seleccionar un estudiante.";
                return false;
            }

            if (evaluacion.IdMateria <= 0)
            {
                mensajeError = "Debe seleccionar una materia.";
                return false;
            }

            if (evaluacion.IdProfesor <= 0)
            {
                mensajeError = "Debe seleccionar un profesor.";
                return false;
            }

            if (evaluacion.IdEstado <= 0)
            {
                mensajeError = "Debe seleccionar un estado válido.";
                return false;
            }

            if (!EnRango(evaluacion.Asistencia) || !EnRango(evaluacion.PuntosAsistencia) ||
                !EnRango(evaluacion.Participacion) || !EnRango(evaluacion.Pruebas) ||
                !EnRango(evaluacion.NotaFinal))
            {
                mensajeError = $"Asistencia, Puntos Asistencia, Participación, Pruebas y Nota final " +
                                $"deben estar entre {NotaMinima} y {NotaMaxima}.";
                return false;
            }

            mensajeError = string.Empty;
            return true;
        }

        private static bool EnRango(double valor) => valor >= NotaMinima && valor <= NotaMaxima;

        public void Insertar(EvaluacionFinal evaluacion)
        {
            if (!Validar(evaluacion, out string mensajeError))
                throw new InvalidOperationException(mensajeError);

            evaluacionesDAO.Insertar(evaluacion);
        }

        public void Actualizar(EvaluacionFinal evaluacion)
        {
            if (!Validar(evaluacion, out string mensajeError))
                throw new InvalidOperationException(mensajeError);

            evaluacionesDAO.Actualizar(evaluacion);
        }

        public void Eliminar(int idEvaluacion)
        {
            if (idEvaluacion <= 0)
                throw new InvalidOperationException("Debe seleccionar un registro para eliminar.");

            evaluacionesDAO.Eliminar(idEvaluacion);
        }
    }
}
