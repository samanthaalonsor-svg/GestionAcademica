namespace GestionAcademica.Forms
{
    partial class FormAsistencias
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            lblEstudiante = new Label();
            cboEstudiante = new ComboBox();
            lblFecha = new Label();
            dtpFecha = new DateTimePicker();
            lblNivel = new Label();
            cboNivel = new ComboBox();
            lblMateria = new Label();
            cboMateria = new ComboBox();
            lblProfesor = new Label();
            cboProfesor = new ComboBox();
            lblIdAsistencia = new Label();
            txtIdAsistencia = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            dgvAsistencias = new DataGridView();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblEstudiante
            // 
            lblEstudiante.Location = new Point(15, 13);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(90, 23);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante:";
            // 
            // cboEstudiante
            // 
            cboEstudiante.BackColor = Color.White;
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.Location = new Point(120, 13);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(250, 33);
            cboEstudiante.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(15, 133);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(60, 23);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha:";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(114, 125);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(250, 31);
            dtpFecha.TabIndex = 3;
            // 
            // lblNivel
            // 
            lblNivel.Location = new Point(15, 62);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(90, 23);
            lblNivel.TabIndex = 4;
            lblNivel.Text = "Nivel:";
            // 
            // cboNivel
            // 
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.Location = new Point(120, 52);
            cboNivel.Name = "cboNivel";
            cboNivel.Size = new Size(250, 33);
            cboNivel.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.Location = new Point(425, 62);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(81, 25);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "Materia:";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Location = new Point(521, 52);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(250, 33);
            cboMateria.TabIndex = 7;
            // 
            // lblProfesor
            // 
            lblProfesor.Location = new Point(425, 16);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(90, 23);
            lblProfesor.TabIndex = 8;
            lblProfesor.Text = "Profesor:";
            // 
            // cboProfesor
            // 
            cboProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesor.Location = new Point(521, 16);
            cboProfesor.Name = "cboProfesor";
            cboProfesor.Size = new Size(250, 33);
            cboProfesor.TabIndex = 9;
            // 
            // lblIdAsistencia
            // 
            lblIdAsistencia.Location = new Point(425, 130);
            lblIdAsistencia.Name = "lblIdAsistencia";
            lblIdAsistencia.Size = new Size(90, 23);
            lblIdAsistencia.TabIndex = 10;
            lblIdAsistencia.Text = "ID Asistencia:";
            lblIdAsistencia.Click += lblIdAsistencia_Click;
            // 
            // txtIdAsistencia
            // 
            txtIdAsistencia.BackColor = Color.White;
            txtIdAsistencia.Location = new Point(521, 122);
            txtIdAsistencia.Name = "txtIdAsistencia";
            txtIdAsistencia.ReadOnly = true;
            txtIdAsistencia.Size = new Size(80, 31);
            txtIdAsistencia.TabIndex = 11;
            txtIdAsistencia.TabStop = false;
            txtIdAsistencia.Text = "(nuevo)";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(43, 84, 126);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(15, 210);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 32);
            btnAgregar.TabIndex = 12;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.FromArgb(43, 84, 126);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(137, 210);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 32);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(197, 48, 48);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(312, 210);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(43, 84, 126);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(443, 210);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.FromArgb(43, 84, 126);
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.White;
            btnActualizar.Location = new Point(565, 210);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 32);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Recargar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(681, 210);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 32);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // dgvAsistencias
            // 
            dgvAsistencias.AllowUserToAddRows = false;
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencias.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 84, 126);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvAsistencias.ColumnHeadersHeight = 34;
            dgvAsistencias.Location = new Point(20, 419);
            dgvAsistencias.MultiSelect = false;
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.ReadOnly = true;
            dgvAsistencias.RowHeadersWidth = 62;
            dgvAsistencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsistencias.Size = new Size(875, 300);
            dgvAsistencias.TabIndex = 22;
            dgvAsistencias.SelectionChanged += DgvAsistencias_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(20, 379);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(60, 23);
            lblBuscar.TabIndex = 18;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(84, 371);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(300, 31);
            txtBuscar.TabIndex = 19;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(43, 84, 126);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(398, 371);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(494, 371);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(110, 28);
            btnMostrarTodos.TabIndex = 21;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += BtnMostrarTodos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(lblEstudiante);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(txtIdAsistencia);
            panel1.Controls.Add(lblIdAsistencia);
            panel1.Controls.Add(dtpFecha);
            panel1.Controls.Add(lblFecha);
            panel1.Controls.Add(cboEstudiante);
            panel1.Controls.Add(lblNivel);
            panel1.Controls.Add(cboMateria);
            panel1.Controls.Add(lblMateria);
            panel1.Controls.Add(cboNivel);
            panel1.Controls.Add(lblProfesor);
            panel1.Controls.Add(cboProfesor);
            panel1.Location = new Point(20, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 263);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 46);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(27, 54, 93);
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.Size = new Size(956, 37);
            label1.TabIndex = 18;
            label1.Text = "Gestion De Sesiones";
            // 
            // FormAsistencias
            // 
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(959, 701);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(dgvAsistencias);
            Name = "FormAsistencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Asistencias / Sesiones";
            ((System.ComponentModel.ISupportInitialize)dgvAsistencias).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ComboBox cboNivel;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.Label lblIdAsistencia;
        private System.Windows.Forms.TextBox txtIdAsistencia;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
    }
}
