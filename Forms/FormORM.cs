using System.Data;
using System.Text;
using GestionAcademica.Entities;
using GestionAcademica.Negocio;
using GestionAcademica.ORM;

namespace GestionAcademica.Forms
{
    public partial class FormORM : Form
    {
        private readonly Entregable6OrmBL ormBL = new Entregable6OrmBL();
        private string codigoSeleccionado = string.Empty;
        private DataTable reporteActual;

        public FormORM()
        {
            InitializeComponent();
            CargarEstados();
            CargarEstudiantesOrm();
            ConfigurarReporte();
        }

        private void CargarEstados()
        {
            try
            {
                var estados = ormBL.ObtenerEstados();
                cboEstado.DataSource = estados;
                cboEstado.DisplayMember = nameof(EstadoOrm.Estado);
                cboEstado.ValueMember = nameof(EstadoOrm.IdEstado);

                var estadosReporte = estados.ToList();
                estadosReporte.Insert(0, new EstadoOrm { IdEstado = 0, Estado = "Todos" });
                cboEstadoReporte.DataSource = estadosReporte;
                cboEstadoReporte.DisplayMember = nameof(EstadoOrm.Estado);
                cboEstadoReporte.ValueMember = nameof(EstadoOrm.IdEstado);
                cboEstadoReporte.SelectedValue = 0;
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar los estados con Entity Framework Core.", ex);
            }
        }

        private void CargarEstudiantesOrm()
        {
            try
            {
                dgvOrmEstudiantes.DataSource = ormBL.ObtenerEstudiantes();
                dgvOrmEstudiantes.ClearSelection();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudieron cargar los estudiantes mediante ORM.", ex);
            }
        }

        private Estudiante ObtenerEstudianteFormulario()
        {
            return new Estudiante
            {
                CodigoEstudiante = txtCodigoOrm.Text.Trim(),
                Alumno = txtAlumnoOrm.Text.Trim(),
                IdEstado = cboEstado.SelectedValue == null ? 0 : Convert.ToInt32(cboEstado.SelectedValue)
            };
        }

        private void BtnNuevoOrm_Click(object sender, EventArgs e)
        {
            LimpiarOrm();
        }

        private void BtnGuardarOrm_Click(object sender, EventArgs e)
        {
            try
            {
                ormBL.InsertarEstudiante(ObtenerEstudianteFormulario());
                MessageBox.Show("Estudiante guardado mediante Entity Framework Core.", "ORM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstudiantesOrm();
                LimpiarOrm();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo guardar el estudiante con ORM.", ex);
            }
        }

        private void BtnActualizarOrm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoSeleccionado))
            {
                MessageBox.Show("Seleccione un estudiante de la tabla.", "ORM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                var estudiante = ObtenerEstudianteFormulario();
                estudiante.CodigoEstudiante = codigoSeleccionado;
                ormBL.ActualizarEstudiante(estudiante);
                MessageBox.Show("Estudiante actualizado mediante Entity Framework Core.", "ORM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstudiantesOrm();
                LimpiarOrm();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo actualizar el estudiante con ORM.", ex);
            }
        }

        private void BtnEliminarOrm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codigoSeleccionado))
            {
                MessageBox.Show("Seleccione un estudiante de la tabla.", "ORM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("¿Está seguro de eliminar este estudiante?", "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                ormBL.EliminarEstudiante(codigoSeleccionado);
                MessageBox.Show("Estudiante eliminado mediante Entity Framework Core.", "ORM", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarEstudiantesOrm();
                LimpiarOrm();
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo eliminar el estudiante con ORM. Si tiene registros relacionados, SQL Server puede impedir la eliminación.", ex);
            }
        }

        private void DgvOrmEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvOrmEstudiantes.SelectedRows.Count == 0)
                return;

            var fila = dgvOrmEstudiantes.SelectedRows[0];
            codigoSeleccionado = fila.Cells[nameof(Estudiante.CodigoEstudiante)].Value?.ToString() ?? string.Empty;
            txtCodigoOrm.Text = codigoSeleccionado;
            txtAlumnoOrm.Text = fila.Cells[nameof(Estudiante.Alumno)].Value?.ToString() ?? string.Empty;
            cboEstado.SelectedValue = Convert.ToInt32(fila.Cells[nameof(Estudiante.IdEstado)].Value);
            txtCodigoOrm.Enabled = false;
        }

        private void LimpiarOrm()
        {
            codigoSeleccionado = string.Empty;
            txtCodigoOrm.Clear();
            txtAlumnoOrm.Clear();
            txtCodigoOrm.Enabled = true;
            if (cboEstado.Items.Count > 0)
                cboEstado.SelectedIndex = 0;
            dgvOrmEstudiantes.ClearSelection();
        }

        private void ConfigurarReporte()
        {
            cboTipoReporte.Items.Clear();
            cboTipoReporte.Items.Add("Estudiantes por estado");
            cboTipoReporte.Items.Add("Sesiones por rango de fechas");
            cboTipoReporte.Items.Add("Evaluaciones por nota mínima");
            cboTipoReporte.SelectedIndex = 0;
            ActualizarControlesReporte();
        }

        private void CboTipoReporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizarControlesReporte();
        }

        private void ActualizarControlesReporte()
        {
            int tipo = cboTipoReporte.SelectedIndex;
            lblFiltro.Text = tipo switch
            {
                0 => "Código o estudiante:",
                1 => "Código, estudiante o materia:",
                _ => "Código, estudiante o materia:"
            };

            cboEstadoReporte.Visible = tipo == 0;
            lblEstadoReporte.Visible = tipo == 0;
            lblDesde.Visible = tipo == 1;
            dtpDesde.Visible = tipo == 1;
            lblHasta.Visible = tipo == 1;
            dtpHasta.Visible = tipo == 1;
            lblNotaMinima.Visible = tipo == 2;
            txtNotaMinima.Visible = tipo == 2;
        }

        private async void BtnGenerarReporte_Click(object sender, EventArgs e)
        {
            // Se leen y validan los controles en el hilo de la interfaz...
            int tipo = cboTipoReporte.SelectedIndex;
            string filtro = txtFiltro.Text.Trim();
            int idEstado = Convert.ToInt32(cboEstadoReporte.SelectedValue ?? 0);
            DateTime desde = dtpDesde.Value.Date;
            DateTime hasta = dtpHasta.Value.Date;
            double? notaMinima = null;

            if (tipo == 1 && desde > hasta)
            {
                MessageBox.Show("La fecha \"Desde\" no puede ser posterior a la fecha \"Hasta\".", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tipo == 2 && !string.IsNullOrWhiteSpace(txtNotaMinima.Text))
            {
                if (!double.TryParse(txtNotaMinima.Text.Trim(), out double valor) || valor < 0 || valor > 100)
                {
                    MessageBox.Show("La nota mínima debe ser un número entre 0 y 100.", "Validación",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                notaMinima = valor;
            }

            Func<DataTable> generar;
            switch (tipo)
            {
                case 0:
                    generar = () => ormBL.ReporteEstudiantes(filtro, idEstado > 0 ? idEstado : (int?)null);
                    break;
                case 1:
                    generar = () => ormBL.ReporteSesiones(filtro, desde, hasta);
                    break;
                default:
                    generar = () => ormBL.ReporteEvaluaciones(filtro, notaMinima);
                    break;
            }

            // ...y la consulta LINQ/EF Core corre en segundo plano para que la ventana no se congele.
            btnGenerarReporte.Enabled = false;
            lblResultado.Text = "Generando reporte...";

            try
            {
                DataTable resultado = await Task.Run(generar);
                if (IsDisposed)
                    return;

                reporteActual = resultado;
                dgvReporte.DataSource = reporteActual;
                lblResultado.Text = $"Registros encontrados: {reporteActual.Rows.Count}";
                dgvReporte.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
            catch (Exception ex)
            {
                if (IsDisposed)
                    return;

                lblResultado.Text = "Registros encontrados: 0";
                MostrarError("No se pudo generar el reporte dinámico con LINQ.", ex);
            }
            finally
            {
                if (!IsDisposed)
                    btnGenerarReporte.Enabled = true;
            }
        }

        private void BtnLimpiarReporte_Click(object sender, EventArgs e)
        {
            txtFiltro.Clear();
            txtNotaMinima.Clear();
            dtpDesde.Value = DateTime.Today.AddMonths(-1);
            dtpHasta.Value = DateTime.Today;
            if (cboEstadoReporte.Items.Count > 0)
                cboEstadoReporte.SelectedValue = 0;
            dgvReporte.DataSource = null;
            reporteActual = null;
            lblResultado.Text = "Registros encontrados: 0";
        }

        private void BtnExportarReporte_Click(object sender, EventArgs e)
        {
            if (reporteActual == null || reporteActual.Rows.Count == 0)
            {
                MessageBox.Show("Primero genere un reporte con datos.", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dialogo = new SaveFileDialog
            {
                Filter = "Archivo CSV (*.csv)|*.csv",
                FileName = "Reporte_GestionAcademica.csv",
                Title = "Guardar reporte"
            };

            if (dialogo.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                var sb = new StringBuilder();
                sb.AppendLine(string.Join(";", reporteActual.Columns.Cast<DataColumn>().Select(c => EscaparCsv(c.ColumnName))));
                foreach (DataRow fila in reporteActual.Rows)
                    sb.AppendLine(string.Join(";", fila.ItemArray.Select(x => EscaparCsv(x?.ToString() ?? string.Empty))));

                File.WriteAllText(dialogo.FileName, sb.ToString(), Encoding.UTF8);
                MessageBox.Show("Reporte exportado correctamente.", "Reporte", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MostrarError("No se pudo exportar el reporte.", ex);
            }
        }

        private static string EscaparCsv(string valor)
        {
            return $"\"{valor.Replace("\"", "\"\"")}\"";
        }

        private static void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show(mensaje + "\n\n" + ex.Message, "Entregable 6", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
