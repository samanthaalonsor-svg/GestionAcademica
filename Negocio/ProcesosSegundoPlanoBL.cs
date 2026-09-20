using System.Data;

namespace GestionAcademica.Negocio
{
    /// <summary>
    /// Coordina operaciones de consulta que pueden ejecutarse en segundo plano
    /// sin bloquear la interfaz de usuario.
    /// </summary>
    public class ProcesosSegundoPlanoBL
    {
        private readonly EstudiantesBL estudiantesBL = new EstudiantesBL();
        private readonly AsistenciasBL asistenciasBL = new AsistenciasBL();
        private readonly EvaluacionesFinalesBL evaluacionesBL = new EvaluacionesFinalesBL();

        public async Task<ResumenCarga> EjecutarCargaAsync(
            CancellationToken cancellationToken,
            IProgress<int>? progreso = null)
        {
            cancellationToken.ThrowIfCancellationRequested();

            int completadas = 0;

            Task<int> tareaEstudiantes = EjecutarConThread(
                estudiantesBL.ObtenerTodos,
                cancellationToken,
                () =>
                {
                    int totalCompletadas = Interlocked.Increment(ref completadas);
                    progreso?.Report(totalCompletadas * 30);
                });

            Task<int> tareaAsistencias = Task.Run(() =>
            {
                cancellationToken.ThrowIfCancellationRequested();
                DataTable tabla = asistenciasBL.ObtenerTodos();
                cancellationToken.ThrowIfCancellationRequested();
                int totalCompletadas = Interlocked.Increment(ref completadas);
                progreso?.Report(totalCompletadas * 30);
                return tabla.Rows.Count;
            }, cancellationToken);

            Task<int> tareaEvaluaciones = Task.Run(() =>
            {
                cancellationToken.ThrowIfCancellationRequested();
                DataTable tabla = evaluacionesBL.ObtenerTodos();
                cancellationToken.ThrowIfCancellationRequested();
                int totalCompletadas = Interlocked.Increment(ref completadas);
                progreso?.Report(totalCompletadas * 30);
                return tabla.Rows.Count;
            }, cancellationToken);

            int[] resultados = await Task.WhenAll(
                tareaEstudiantes,
                tareaAsistencias,
                tareaEvaluaciones);

            cancellationToken.ThrowIfCancellationRequested();
            progreso?.Report(100);

            return new ResumenCarga(
                resultados[0],
                resultados[1],
                resultados[2]);
        }

        /// <summary>
        /// Ejecuta una consulta en un Thread dedicado y la expone como Task
        /// para poder coordinarla con Task.WhenAll.
        /// </summary>
        private static Task<int> EjecutarConThread(
            Func<DataTable> consulta,
            CancellationToken cancellationToken,
            Action reportarCompletada)
        {
            var fuenteResultado = new TaskCompletionSource<int>(
                TaskCreationOptions.RunContinuationsAsynchronously);

            Thread hilo = new Thread(() =>
            {
                try
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    DataTable tabla = consulta();

                    cancellationToken.ThrowIfCancellationRequested();

                    reportarCompletada();
                    fuenteResultado.TrySetResult(tabla.Rows.Count);
                }
                catch (OperationCanceledException)
                {
                    fuenteResultado.TrySetCanceled(cancellationToken);
                }
                catch (Exception ex)
                {
                    fuenteResultado.TrySetException(ex);
                }
            });

            hilo.IsBackground = true;
            hilo.Start();

            return fuenteResultado.Task;
        }

    }

    public sealed class ResumenCarga
    {
        public int Estudiantes { get; }
        public int Sesiones { get; }
        public int Evaluaciones { get; }

        public ResumenCarga(int estudiantes, int sesiones, int evaluaciones)
        {
            Estudiantes = estudiantes;
            Sesiones = sesiones;
            Evaluaciones = evaluaciones;
        }

        public int Total => Estudiantes + Sesiones + Evaluaciones;
    }
}
