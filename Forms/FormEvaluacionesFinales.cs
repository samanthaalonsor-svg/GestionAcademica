using System.Data;
using System.Globalization;
using GestionAcademica.Entities;
using GestionAcademica.Negocio;

namespace GestionAcademica.Forms
{
    public partial class FormEvaluacionesFinales : Form
    {
        private readonly EvaluacionesFinalesBL evaluacionesBL = new EvaluacionesFinalesBL();
        private readonly CatalogosBL catalogosBL = new CatalogosBL();
        private int idSeleccionado = 0;

        public FormEvaluacionesFinales()
        {
            InitializeComponent();
            CargarCombos();
            CargarGrid();
        }

        private void CargarCombos()
        {
            try
            {
                DataTable estudiantes = catalogosBL.ObtenerEstudiantesParaCombo();
                cboEstudiante.DataSource = estudiantes;
                cboEstudiante.DisplayMember = "Alumno";
                cboEstudiante.ValueMember = "codigo_estudiante";

                DataTable materias = catalogosBL.ObtenerMaterias();
                cboMateria.DataSource = materias;
                cboMateria.DisplayMember = materias.Columns[1].ColumnName;
                cboMateria.ValueMember = materias.Columns[0].ColumnName;

                DataTable profesores = catalogosBL.ObtenerProfesores();
                cboProfesor.DataSource = profesores;
                cboProfesor.DisplayMember = profesores.Columns[1].ColumnName;
                cboProfesor.ValueMember = profesores.Columns[0].ColumnName;

                DataTable estados = catalogosBL.ObtenerEstados();
                cboEstado.DataSource = estados;
                cboEstado.DisplayMember = estados.Columns[1].ColumnName;
                cboEstado.ValueMember = estados.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las listas de apoyo (Estudiantes/Materias/Profesores/Estados).\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            try
            {
                dgvEvaluaciones.DataSource = evaluacionesBL.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ArmarEvaluacionDesdeFormulario(out EvaluacionFinal evaluacion, out string mensajeError)
        {
            evaluacion = new EvaluacionFinal();

            if (cboEstudiante.SelectedValue == null || cboMateria.SelectedValue == null ||
                cboProfesor.SelectedValue == null || cboEstado.SelectedValue == null)
            {
                mensajeError = "Seleccione estudiante, materia, profesor y estado.";
                return false;
            }

            if (!double.TryParse(txtAsistencia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double asistencia) ||
                !double.TryParse(txtPuntosAsistencia.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double puntos) ||
                !double.TryParse(txtParticipacion.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double participacion) ||
                !double.TryParse(txtPruebas.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double pruebas) ||
                !double.TryParse(txtNotaFinal.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out double notaFinal))
            {
                mensajeError = "Asistencia, Puntos Asistencia, Participación, Pruebas y Nota final deben ser números.";
                return false;
            }

            evaluacion.IdEvaluacion = idSeleccionado;
            evaluacion.CodigoEstudiante = cboEstudiante.SelectedValue.ToString() ?? string.Empty;
            evaluacion.Asistencia = asistencia;
            evaluacion.PuntosAsistencia = puntos;
            evaluacion.Participacion = participacion;
            evaluacion.Pruebas = pruebas;
            evaluacion.IdMateria = Convert.ToInt32(cboMateria.SelectedValue);
            evaluacion.IdProfesor = Convert.ToInt32(cboProfesor.SelectedValue);
            evaluacion.NotaFinal = notaFinal;
            evaluacion.IdEstado = Convert.ToInt32(cboEstado.SelectedValue);
            evaluacion.FechaEvaluacion = dtpFechaEvaluacion.Value.Date;

            mensajeError = string.Empty;
            return true;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if (!ArmarEvaluacionDesdeFormulario(out EvaluacionFinal evaluacion, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                evaluacionesBL.Insertar(evaluacion);
                CargarGrid();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la evaluación.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ArmarEvaluacionDesdeFormulario(out EvaluacionFinal evaluacion, out string mensajeError))
            {
                MessageBox.Show(mensajeError, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                evaluacionesBL.Actualizar(evaluacion);
                CargarGrid();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el registro.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro de la lista para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar esta evaluación?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    evaluacionesBL.Eliminar(idSeleccionado);
                    CargarGrid();
                    LimpiarCampos();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el registro.\n\n" + ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarCombos();
            CargarGrid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEvaluaciones.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                    ? evaluacionesBL.ObtenerTodos()
                    : evaluacionesBL.Buscar(txtBuscar.Text);
                dgvEvaluaciones.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo realizar la búsqueda.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnBuscar_Click(sender, e);
                e.SuppressKeyPress = true;
            }
        }

        private void BtnMostrarTodos_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            CargarGrid();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvEvaluaciones_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEvaluaciones.SelectedRows.Count == 0) return;

            var fila = dgvEvaluaciones.SelectedRows[0];
            idSeleccionado = Convert.ToInt32(fila.Cells["Id_Evaluacion"].Value);

            cboEstudiante.SelectedValue = fila.Cells["codigo_estudiante"].Value.ToString();
            cboMateria.SelectedValue = Convert.ToInt32(fila.Cells["id_materia"].Value);
            cboProfesor.SelectedValue = Convert.ToInt32(fila.Cells["id_profesor"].Value);
            cboEstado.SelectedValue = Convert.ToInt32(fila.Cells["estado"].Value);
            dtpFechaEvaluacion.Value = Convert.ToDateTime(fila.Cells["fecha_evaluacion"].Value);
            txtAsistencia.Text = fila.Cells["Asistencia"].Value.ToString();
            txtPuntosAsistencia.Text = fila.Cells["Puntos_Asistencia"].Value.ToString();
            txtParticipacion.Text = fila.Cells["Participacion"].Value.ToString();
            txtPruebas.Text = fila.Cells["Pruebas"].Value.ToString();
            txtNotaFinal.Text = fila.Cells["nota_final"].Value.ToString();
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            if (cboEstudiante.Items.Count > 0) cboEstudiante.SelectedIndex = 0;
            if (cboMateria.Items.Count > 0) cboMateria.SelectedIndex = 0;
            if (cboProfesor.Items.Count > 0) cboProfesor.SelectedIndex = 0;
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            dtpFechaEvaluacion.Value = DateTime.Now;
            txtAsistencia.Clear();
            txtPuntosAsistencia.Clear();
            txtParticipacion.Clear();
            txtPruebas.Clear();
            txtNotaFinal.Clear();
            dgvEvaluaciones.ClearSelection();


        }

        private void CalcularNotaFinal()
        {
            decimal.TryParse(txtPuntosAsistencia.Text, out decimal puntosAsistencia);
            decimal.TryParse(txtParticipacion.Text, out decimal participacion);
            decimal.TryParse(txtPruebas.Text, out decimal pruebas);
            decimal notaTotal = puntosAsistencia + participacion + pruebas;

            txtNotaFinal.Text = notaTotal.ToString("0.00");
        }

        private void txtParticipacion_TextChanged(object sender, EventArgs e)
        {
            CalcularNotaFinal();
        }

        private void txtPuntosAsistencia_TextChanged(object sender, EventArgs e)
        {
            CalcularNotaFinal();
        }

        private void txtPruebas_TextChanged(object sender, EventArgs e)
        {
            CalcularNotaFinal();
        }

        private void lblProfesor_Click(object sender, EventArgs e)
        {

        }

        private void FormEvaluacionesFinales_Load(object sender, EventArgs e)
        {

        }
    }
}
