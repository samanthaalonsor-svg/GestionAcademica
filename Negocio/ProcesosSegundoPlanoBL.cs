using System.Data;

namespace GestionAcademica.Negocio
{
    
    public class ProcesosSegundoPlanoBL
    {
        private readonly EstudiantesBL estudiantesBL = new EstudiantesBL();
        private readonly AsistenciasBL asistenciasBL = new AsistenciasBL();
        private readonly EvaluacionesFinalesBL evaluacionesBL = new EvaluacionesFinalesBL();

        
        public static int PausaSimuladaMs { get; set; } = 2500;

        private static void SimularCargaPesada(CancellationToken cancellationToken, int factor)
        {
            if (PausaSimuladaMs <= 0)
                return;

            
            cancellationToken.WaitHandle.WaitOne(PausaSimuladaMs * factor);
            cancellationToken.ThrowIfCancellationRequested();
        }

        public async Task<ResumenCarga> EjecutarCargaAsync(
            CancellationToken cancellationToken,
            IProgress<int>? progreso = null)
        {
            cancellationToken.ThrowIfCancellationRequested();

            int completadas = 0;

            Task<int> tareaEstudiantes = EjecutarConThread(
                () =>
                {
                    DataTable tabla = estudiantesBL.ObtenerTodos();
                    SimularCargaPesada(cancellationToken, 1);
                    return tabla;
                },
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
                SimularCargaPesada(cancellationToken, 2);
                cancellationToken.ThrowIfCancellationRequested();
                int totalCompletadas = Interlocked.Increment(ref completadas);
                progreso?.Report(totalCompletadas * 30);
                return tabla.Rows.Count;
            }, cancellationToken);

            Task<int> tareaEvaluaciones = Task.Run(() =>
            {
                cancellationToken.ThrowIfCancellationRequested();
                DataTable tabla = evaluacionesBL.ObtenerTodos();
                SimularCargaPesada(cancellationToken, 3);
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
