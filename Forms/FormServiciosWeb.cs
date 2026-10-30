using System.Data;
using System.Text;
using GestionAcademica.Estilo;
using GestionAcademica.Negocio;
using GestionAcademica.Servicios;

namespace GestionAcademica.Forms
{
    /// <summary>
    /// Entregable 7 - Integración de servicios web.
    /// Aplicación de escritorio -> HttpClient -> API REST -> JSON -> información integrada en la aplicación.
    /// </summary>
    public partial class FormServiciosWeb : Form
    {
        private readonly ServiciosWebBL serviciosBL = new ServiciosWebBL();
        private CancellationTokenSource cancelacion;
        private bool consultando;
        private DataTable feriadosActuales;
        private readonly ResendEmailApiClient correoApi = new ResendEmailApiClient();

        public FormServiciosWeb()
        {
            InitializeComponent();

            cboPais.DataSource = serviciosBL.ObtenerPaises();
            cboPais.DisplayMember = nameof(PaisServicio.Nombre);
            cboPais.ValueMember = nameof(PaisServicio.Codigo);

            nudAnio.Value = Math.Min(nudAnio.Maximum, Math.Max(nudAnio.Minimum, DateTime.Today.Year));

            InicializarPestanaNotificaciones();
            TemaVisual.Aplicar(this);
        }

        private async void BtnConsultar_Click(object sender, EventArgs e)
        {
            if (consultando)
                return;

            if (cboPais.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un país.", "Servicios web", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string pais = cboPais.SelectedValue.ToString();
            int anio = (int)nudAnio.Value;

            consultando = true;
            cancelacion = new CancellationTokenSource();
            btnConsultar.Enabled = false;
            btnCancelar.Enabled = true;
            btnExportar.Enabled = false;
            lblEstado.Text = "Consultando el servicio web...";
            lblProximo.Text = string.Empty;

            try
            {
                ResultadoFeriados resultado =
                    await serviciosBL.ConsultarFeriadosAsync(pais, anio, cancelacion.Token);

                if (IsDisposed)
                    return;

                feriadosActuales = resultado.Feriados;
                dgvFeriados.DataSource = resultado.Feriados;
                dgvSesiones.DataSource = resultado.SesionesEnFeriado;
                txtJson.Text = resultado.JsonOriginal.Replace("\r\n", "\n").Replace("\n", "\r\n");

                dgvFeriados.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
                dgvSesiones.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

                lblEstado.Text = $"Feriados recibidos: {resultado.Feriados.Rows.Count}. {resultado.AvisoSesiones}";
                lblProximo.Text = resultado.ProximoFeriado;
                btnExportar.Enabled = resultado.Feriados.Rows.Count > 0;
            }
            catch (OperationCanceledException)
            {
                if (!IsDisposed)
                    lblEstado.Text = "Consulta cancelada por el usuario.";
            }
            catch (Exception ex)
            {
                if (IsDisposed)
                    return;

                lblEstado.Text = "No se pudo completar la consulta.";
                MessageBox.Show(ex.Message, "Servicios web", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                consultando = false;
                cancelacion?.Dispose();
                cancelacion = null;

                if (!IsDisposed)
                {
                    btnConsultar.Enabled = true;
                    btnCancelar.Enabled = false;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            if (!consultando || cancelacion == null)
                return;

            btnCancelar.Enabled = false;
            lblEstado.Text = "Cancelando consulta...";
            cancelacion.Cancel();
        }

        private void BtnExportar_Click(object sender, EventArgs e)
        {
            if (feriadosActuales == null || feriadosActuales.Rows.Count == 0)
            {
                MessageBox.Show("Primero consulte los feriados.", "Servicios web", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using (var dialogo = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                FileName = $"Feriados_{cboPais.SelectedValue}_{(int)nudAnio.Value}.csv",
                Title = "Guardar feriados"
            })
            {
                if (dialogo.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    var sb = new StringBuilder();
                    sb.AppendLine(string.Join(";", feriadosActuales.Columns.Cast<DataColumn>().Select(c => EscaparCsv(c.ColumnName))));
                    foreach (DataRow fila in feriadosActuales.Rows)
                        sb.AppendLine(string.Join(";", fila.ItemArray.Select(x => EscaparCsv(x?.ToString() ?? string.Empty))));

                    File.WriteAllText(dialogo.FileName, sb.ToString(), Encoding.UTF8);
                    MessageBox.Show("Feriados exportados correctamente.", "Servicios web", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo exportar el archivo.\n\n" + ex.Message, "Servicios web",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private static string EscaparCsv(string valor)
        {
            return $"\"{valor.Replace("\"", "\"\"")}\"";
        }


        private TextBox txtCorreoDestinatario;
        private TextBox txtCorreoEstudiante;
        private TextBox txtCorreoAsunto;
        private TextBox txtCorreoMensaje;
        private Button btnEnviarCorreo;
        private Label lblEstadoCorreo;

        /// <summary>Agrega la pantalla de notificaciones sin modificar el diseñador existente.</summary>
        private void InicializarPestanaNotificaciones()
        {
            var tab = new TabPage("Notificaciones por correo");
            var descripcion = new Label
            {
                Text = "Envía una notificación académica mediante la API REST de Resend. Requiere configurar una clave API.",
                AutoSize = false, Location = new Point(24, 20), Size = new Size(1280, 42),
                Font = new Font("Segoe UI", 10F), ForeColor = Color.FromArgb(71, 85, 105)
            };
            var lblDestinatario = CrearEtiquetaCorreo("Correo del destinatario:", 28, 82);
            txtCorreoDestinatario = CrearCampoCorreo(250, 78, 700);
            txtCorreoDestinatario.PlaceholderText = "estudiante@ejemplo.com";

            var lblEstudiante = CrearEtiquetaCorreo("Nombre del estudiante:", 28, 132);
            txtCorreoEstudiante = CrearCampoCorreo(250, 128, 700);
            txtCorreoEstudiante.PlaceholderText = "Nombre completo";

            var lblAsunto = CrearEtiquetaCorreo("Asunto:", 28, 182);
            txtCorreoAsunto = CrearCampoCorreo(250, 178, 1000);
            txtCorreoAsunto.Text = "Notificación académica - Gestión Académica";

            var lblMensaje = CrearEtiquetaCorreo("Mensaje:", 28, 232);
            txtCorreoMensaje = new TextBox
            {
                Location = new Point(250, 228), Size = new Size(1000, 120), Multiline = true,
                ScrollBars = ScrollBars.Vertical, Font = new Font("Segoe UI", 10F), MaxLength = 5000,
                PlaceholderText = "Escriba aquí la información académica que desea comunicar."
            };

            btnEnviarCorreo = new Button
            {
                Text = "Enviar notificación", Location = new Point(250, 370), Size = new Size(210, 42),
                Font = new Font("Segoe UI", 10F, FontStyle.Bold), BackColor = Color.FromArgb(42, 91, 151),
                ForeColor = Color.White, FlatStyle = FlatStyle.Flat
            };
            btnEnviarCorreo.FlatAppearance.BorderSize = 0;
            btnEnviarCorreo.Click += BtnEnviarCorreo_Click;

            lblEstadoCorreo = new Label
            {
                Text = "Listo para enviar. Configure RESEND_API_KEY en Windows antes de usar esta función.",
                Location = new Point(480, 370), Size = new Size(770, 48), AutoEllipsis = true,
                Font = new Font("Segoe UI", 9.5F), ForeColor = Color.FromArgb(71, 85, 105),
                TextAlign = ContentAlignment.MiddleLeft
            };

            tab.Controls.AddRange(new Control[] { descripcion, lblDestinatario, txtCorreoDestinatario,
                lblEstudiante, txtCorreoEstudiante, lblAsunto, txtCorreoAsunto, lblMensaje,
                txtCorreoMensaje, btnEnviarCorreo, lblEstadoCorreo });
            tabResultados.TabPages.Add(tab);
        }

        private static Label CrearEtiquetaCorreo(string texto, int x, int y)
        {
            return new Label
            {
                Text = texto, Location = new Point(x, y), Size = new Size(210, 30),
                Font = new Font("Segoe UI", 9.5F, FontStyle.Bold),
                ForeColor = Color.FromArgb(30, 41, 59), TextAlign = ContentAlignment.MiddleLeft
            };
        }

        private static TextBox CrearCampoCorreo(int x, int y, int ancho)
        {
            return new TextBox
            {
                Location = new Point(x, y), Size = new Size(ancho, 32),
                Font = new Font("Segoe UI", 10F), MaxLength = 254, Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
        }

        private async void BtnEnviarCorreo_Click(object sender, EventArgs e)
        {
            if (btnEnviarCorreo == null || btnEnviarCorreo.Enabled == false)
                return;

            btnEnviarCorreo.Enabled = false;
            lblEstadoCorreo.Text = "Enviando notificación al servicio de correo...";

            try
            {
                string id = await correoApi.EnviarNotificacionAsync(
                    txtCorreoDestinatario.Text,
                    txtCorreoEstudiante.Text,
                    txtCorreoAsunto.Text,
                    txtCorreoMensaje.Text);

                lblEstadoCorreo.Text = "Solicitud aceptada por Resend. Identificador: " + id;
                MessageBox.Show(
                    "La API aceptó la solicitud de envío. Esto no garantiza por sí solo que el mensaje haya llegado a la bandeja de entrada.",
                    "Notificación académica", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                lblEstadoCorreo.Text = "No se pudo enviar la notificación.";
                MessageBox.Show(ex.Message, "Servicio de correo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (!IsDisposed)
                    btnEnviarCorreo.Enabled = true;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormServiciosWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si hay una solicitud en curso se cancela para no actualizar una ventana cerrada.
            cancelacion?.Cancel();
        }
    }
}
