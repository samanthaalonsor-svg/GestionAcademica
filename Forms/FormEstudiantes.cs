using System.Data;
using GestionAcademica.Entities;
using GestionAcademica.Negocio;

namespace GestionAcademica.Forms
{
    public partial class FormEstudiantes : Form
    {
        private readonly EstudiantesBL estudiantesBL = new EstudiantesBL();
        private readonly CatalogosBL catalogosBL = new CatalogosBL();
        private string codigoSeleccionado = string.Empty;

        public FormEstudiantes()
        {
            InitializeComponent();
            CargarEstados();
            CargarGrid();
        }

        private void CargarEstados()
        {
            try
            {
                DataTable estados = catalogosBL.ObtenerEstados();
                cboEstado.DataSource = estados;
                cboEstado.DisplayMember = estados.Columns[1].ColumnName; // segunda columna = texto
                cboEstado.ValueMember = estados.Columns[0].ColumnName;   // primera columna = id
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la lista de Estados.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarGrid()
        {
            try
            {
                dgvEstudiantes.DataSource = estudiantesBL.ObtenerTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos.\n\n" + ex.Message,
                    "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Estudiante ArmarEstudianteDesdeFormulario()
        {
            return new Estudiante
            {
                CodigoEstudiante = txtCodigo.Text.Trim(),
                Alumno = txtAlumno.Text.Trim(),
                IdEstado = cboEstado.SelectedValue != null ? Convert.ToInt32(cboEstado.SelectedValue) : 0
            };
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                estudiantesBL.Insertar(ArmarEstudianteDesdeFormulario());
                CargarGrid();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo agregar el estudiante.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoSeleccionado))
            {
                MessageBox.Show("Seleccione un estudiante de la lista para editar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                Estudiante estudiante = ArmarEstudianteDesdeFormulario();
                estudiante.CodigoEstudiante = codigoSeleccionado;
                estudiantesBL.Actualizar(estudiante);
                CargarGrid();
                LimpiarCampos();
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar el estudiante.\n\n" + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(codigoSeleccionado))
            {
                MessageBox.Show("Seleccione un estudiante de la lista para eliminar.", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult confirmacion = MessageBox.Show("¿Está seguro de eliminar este estudiante?",
                "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                try
                {
                    estudiantesBL.Eliminar(codigoSeleccionado);
                    CargarGrid();
                    LimpiarCampos();
                }
                catch (InvalidOperationException ex)
                {
                    MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar (revisa que no tenga asistencias asociadas).\n\n" + ex.Message,
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
            CargarEstados();
            CargarGrid();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                dgvEstudiantes.DataSource = string.IsNullOrWhiteSpace(txtBuscar.Text)
                    ? estudiantesBL.ObtenerTodos()
                    : estudiantesBL.Buscar(txtBuscar.Text);
                dgvEstudiantes.ClearSelection();
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

        private void DgvEstudiantes_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvEstudiantes.SelectedRows.Count == 0) return;

            var fila = dgvEstudiantes.SelectedRows[0];
            codigoSeleccionado = fila.Cells["codigo_estudiante"].Value.ToString() ?? string.Empty;

            txtCodigo.Text = codigoSeleccionado;
            txtAlumno.Text = fila.Cells["Alumno"].Value.ToString();
            cboEstado.SelectedValue = Convert.ToInt32(fila.Cells["id_estado"].Value);
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtAlumno.Clear();
            if (cboEstado.Items.Count > 0) cboEstado.SelectedIndex = 0;
            codigoSeleccionado = string.Empty;
            dgvEstudiantes.ClearSelection();
        }
    }
}
