using GestionAcademica.Negocio;

namespace GestionAcademica.Forms
{
    public partial class FormProcesosSegundoPlano : Form
    {
        private readonly ProcesosSegundoPlanoBL procesosBL = new ProcesosSegundoPlanoBL();
        private CancellationTokenSource? cancellationTokenSource;
        private bool ejecutando;

        public FormProcesosSegundoPlano()
        {
            InitializeComponent();
        }

        private async void BtnIniciar_Click(object sender, EventArgs e)
        {
            if (ejecutando)
                return;

            ejecutando = true;
            cancellationTokenSource = new CancellationTokenSource();

            btnIniciar.Enabled = false;
            btnCancelar.Enabled = true;
            btnCerrar.Enabled = false;
            progressBar.Value = 0;
            lblEstado.Text = "Ejecutando consultas en segundo plano...";
            txtResultado.Clear();

            var progreso = new Progress<int>(valor =>
            {
                progressBar.Value = Math.Max(0, Math.Min(100, valor));
                lblProgreso.Text = $"{progressBar.Value}%";
            });

            try
            {
                ResumenCarga resumen = await procesosBL.EjecutarCargaAsync(
                    cancellationTokenSource.Token,
                    progreso);

                lblEstado.Text = "Proceso completado correctamente.";
                txtResultado.Text =
                    "Carga realizada en segundo plano\r\n\r\n" +
                    $"Estudiantes: {resumen.Estudiantes}\r\n" +
                    $"Sesiones: {resumen.Sesiones}\r\n" +
                    $"Evaluaciones finales: {resumen.Evaluaciones}\r\n" +
                    $"Total de registros consultados: {resumen.Total}";
            }
            catch (OperationCanceledException)
            {
                progressBar.Value = 0;
                lblProgreso.Text = "0%";
                lblEstado.Text = "Proceso cancelado por el usuario.";
                txtResultado.Text = "La operación fue cancelada y la interfaz permanece disponible.";
            }
            catch (Exception ex)
            {
                lblEstado.Text = "El proceso terminó con un error.";
                txtResultado.Text = "No se pudo completar la operación:\r\n\r\n" + ex.Message;
            }
            finally
            {
                ejecutando = false;
                cancellationTokenSource?.Dispose();
                cancellationTokenSource = null;

                btnIniciar.Enabled = true;
                btnCancelar.Enabled = false;
                btnCerrar.Enabled = true;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (!ejecutando || cancellationTokenSource == null)
                return;

            lblEstado.Text = "Cancelando operación...";
            btnCancelar.Enabled = false;
            cancellationTokenSource.Cancel();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormProcesosSegundoPlano_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ejecutando && cancellationTokenSource != null)
            {
                cancellationTokenSource.Cancel();
                e.Cancel = true;
                MessageBox.Show(
                    "La operación está en curso. Se solicitó la cancelación; cierre la ventana cuando finalice.",
                    "Proceso en segundo plano",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
