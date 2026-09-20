using System.Data;
using GestionAcademica.Entities;
using GestionAcademica.Negocio;

namespace GestionAcademica.Forms
{
    public partial class FormAsistencias : Form
    {
        private readonly AsistenciasBL asistenciasBL = new AsistenciasBL();
        private readonly CatalogosBL catalogosBL = new CatalogosBL();
        private int idSeleccionado = 0;

        public FormAsistencias()
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

                DataTable niveles = catalogosBL.ObtenerNiveles();
                cboNivel.DataSource = niveles;
                cboNivel.DisplayMember = niveles.Columns[1].ColumnName;
                cboNivel.ValueMember = niveles.Columns[0].ColumnName;

                DataTable materias = catalogosBL.ObtenerMaterias();
                cboMateria.DataSource = materias;
                cboMateria.DisplayMember = materias.Columns[1].ColumnName;
                cboMateria.ValueMember = materias.Columns[0].ColumnName;

                DataTable profesores = catalogosBL.ObtenerProfesores();
                cboProfesor.DataSource = profesores;
                cboProfesor.DisplayMember = profesores.Columns[1].ColumnName;
                cboProfesor.ValueMember = profesores.Columns[0].ColumnName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron cargar las listas de apoyo (Estudiantes/Niveles/Materias/Profesores).\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            try
            {
                dgvAsistencias.DataSource = asistenciasBL.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Asistencia ArmarAsistenciaDesdeFormulario()
        {
            return new Asistencia
            {
                IdAsistencia = idSeleccionado,
                CodigoEstudiante = cboEstudiante.SelectedValue?.ToString() ?? string.Empty,
                Fecha = dtpFecha.Value.Date,
                IdNivel = cboNivel.SelectedValue != null ? Convert.ToInt32(cboNivel.SelectedValue) : 0,
                IdMateria = cboMateria.SelectedValue != null ? Convert.ToInt32(cboMateria.SelectedValue) : 0,
                IdProfesor = cboProfesor.SelectedValue != null ? Convert.ToInt32(cboProfesor.SelectedValue) : 0
            };
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                asistenciasBL.Insertar(ArmarAsistenciaDesdeFormulario());
                CargarGrid();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo registrar la asistencia.\n\n" + ex.Message,
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

            try
            {
                asistenciasBL.Actualizar(ArmarAsistenciaDesdeFormulario());
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

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este registro de asistencia?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    asistenciasBL.Eliminar(idSeleccionado);
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
                dgvAsistencias.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                    ? asistenciasBL.ObtenerTodos()
                    : asistenciasBL.Buscar(txtBuscar.Text);
                dgvAsistencias.ClearSelection();
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

        private void DgvAsistencias_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAsistencias.SelectedRows.Count == 0) return;

            var fila = dgvAsistencias.SelectedRows[0];
            idSeleccionado = Convert.ToInt32(fila.Cells["id_asistencia"].Value);
            txtIdAsistencia.Text = idSeleccionado.ToString();

            cboEstudiante.SelectedValue = fila.Cells["codigo_estudiante"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["Fecha"].Value);
            cboNivel.SelectedValue = Convert.ToInt32(fila.Cells["Id_Nivel"].Value);
            cboMateria.SelectedValue = Convert.ToInt32(fila.Cells["Id_Materia"].Value);
            cboProfesor.SelectedValue = Convert.ToInt32(fila.Cells["Id_Profesor"].Value);
        }

        private void LimpiarCampos()
        {
            idSeleccionado = 0;
            txtIdAsistencia.Text = "(nuevo)";
            dtpFecha.Value = DateTime.Now;
            if (cboEstudiante.Items.Count > 0) cboEstudiante.SelectedIndex = 0;
            if (cboNivel.Items.Count > 0) cboNivel.SelectedIndex = 0;
            if (cboMateria.Items.Count > 0) cboMateria.SelectedIndex = 0;
            if (cboProfesor.Items.Count > 0) cboProfesor.SelectedIndex = 0;
            dgvAsistencias.ClearSelection();
        }

        private void lblIdAsistencia_Click(object sender, EventArgs e)
        {

        }
    }
}
