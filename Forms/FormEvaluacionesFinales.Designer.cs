namespace GestionAcademica.Forms
{
    partial class FormEvaluacionesFinales
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
            lblMateria = new Label();
            cboMateria = new ComboBox();
            lblProfesor = new Label();
            cboProfesor = new ComboBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            lblFechaEvaluacion = new Label();
            dtpFechaEvaluacion = new DateTimePicker();
            lblAsistencia = new Label();
            txtAsistencia = new TextBox();
            lblPuntosAsistencia = new Label();
            txtPuntosAsistencia = new TextBox();
            lblParticipacion = new Label();
            txtParticipacion = new TextBox();
            lblPruebas = new Label();
            txtPruebas = new TextBox();
            lblNotaFinal = new Label();
            txtNotaFinal = new TextBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            dgvEvaluaciones = new DataGridView();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            panel3 = new Panel();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // lblEstudiante
            // 
            lblEstudiante.Location = new Point(15, 77);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.Size = new Size(90, 23);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante:";
            // 
            // cboEstudiante
            // 
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.Location = new Point(125, 67);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Size = new Size(230, 33);
            cboEstudiante.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.Location = new Point(409, 67);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(82, 20);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia:";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Location = new Point(519, 67);
            cboMateria.Name = "cboMateria";
            cboMateria.Size = new Size(200, 33);
            cboMateria.TabIndex = 3;
            // 
            // lblProfesor
            // 
            lblProfesor.Location = new Point(409, 119);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.Size = new Size(70, 23);
            lblProfesor.TabIndex = 4;
            lblProfesor.Text = "Profesor:";
            lblProfesor.Click += lblProfesor_Click;
            // 
            // cboProfesor
            // 
            cboProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesor.Location = new Point(519, 109);
            cboProfesor.Name = "cboProfesor";
            cboProfesor.Size = new Size(200, 33);
            cboProfesor.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(15, 119);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(90, 23);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Location = new Point(125, 109);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(230, 33);
            cboEstado.TabIndex = 7;
            // 
            // lblFechaEvaluacion
            // 
            lblFechaEvaluacion.Location = new Point(15, 165);
            lblFechaEvaluacion.Name = "lblFechaEvaluacion";
            lblFechaEvaluacion.Size = new Size(80, 23);
            lblFechaEvaluacion.TabIndex = 8;
            lblFechaEvaluacion.Text = "Fecha eval.:";
            // 
            // dtpFechaEvaluacion
            // 
            dtpFechaEvaluacion.Format = DateTimePickerFormat.Short;
            dtpFechaEvaluacion.Location = new Point(125, 165);
            dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            dtpFechaEvaluacion.Size = new Size(200, 31);
            dtpFechaEvaluacion.TabIndex = 9;
            // 
            // lblAsistencia
            // 
            lblAsistencia.Location = new Point(24, 65);
            lblAsistencia.Name = "lblAsistencia";
            lblAsistencia.Size = new Size(90, 23);
            lblAsistencia.TabIndex = 10;
            lblAsistencia.Text = "Asistencia:";
            // 
            // txtAsistencia
            // 
            txtAsistencia.BackColor = Color.White;
            txtAsistencia.Location = new Point(132, 65);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Size = new Size(100, 31);
            txtAsistencia.TabIndex = 11;
            // 
            // lblPuntosAsistencia
            // 
            lblPuntosAsistencia.Location = new Point(259, 73);
            lblPuntosAsistencia.Name = "lblPuntosAsistencia";
            lblPuntosAsistencia.Size = new Size(120, 23);
            lblPuntosAsistencia.TabIndex = 12;
            lblPuntosAsistencia.Text = "Puntos Asistencia:";
            // 
            // txtPuntosAsistencia
            // 
            txtPuntosAsistencia.BackColor = Color.White;
            txtPuntosAsistencia.Location = new Point(342, 65);
            txtPuntosAsistencia.Name = "txtPuntosAsistencia";
            txtPuntosAsistencia.Size = new Size(90, 31);
            txtPuntosAsistencia.TabIndex = 13;
            txtPuntosAsistencia.TextChanged += txtPuntosAsistencia_TextChanged;
            // 
            // lblParticipacion
            // 
            lblParticipacion.Location = new Point(465, 73);
            lblParticipacion.Name = "lblParticipacion";
            lblParticipacion.Size = new Size(100, 23);
            lblParticipacion.TabIndex = 14;
            lblParticipacion.Text = "Participación:";
            // 
            // txtParticipacion
            // 
            txtParticipacion.BackColor = Color.White;
            txtParticipacion.Location = new Point(571, 73);
            txtParticipacion.Name = "txtParticipacion";
            txtParticipacion.Size = new Size(90, 31);
            txtParticipacion.TabIndex = 15;
            txtParticipacion.TextChanged += txtParticipacion_TextChanged;
            // 
            // lblPruebas
            // 
            lblPruebas.Location = new Point(686, 76);
            lblPruebas.Name = "lblPruebas";
            lblPruebas.Size = new Size(70, 23);
            lblPruebas.TabIndex = 16;
            lblPruebas.Text = "Pruebas:";
            // 
            // txtPruebas
            // 
            txtPruebas.BackColor = Color.White;
            txtPruebas.Location = new Point(762, 73);
            txtPruebas.Name = "txtPruebas";
            txtPruebas.Size = new Size(90, 31);
            txtPruebas.TabIndex = 17;
            txtPruebas.TextChanged += txtPruebas_TextChanged;
            // 
            // lblNotaFinal
            // 
            lblNotaFinal.Location = new Point(297, 481);
            lblNotaFinal.Name = "lblNotaFinal";
            lblNotaFinal.Size = new Size(118, 28);
            lblNotaFinal.TabIndex = 18;
            lblNotaFinal.Text = "Nota final:";
            // 
            // txtNotaFinal
            // 
            txtNotaFinal.BackColor = Color.White;
            txtNotaFinal.Location = new Point(421, 478);
            txtNotaFinal.Name = "txtNotaFinal";
            txtNotaFinal.ReadOnly = true;
            txtNotaFinal.Size = new Size(143, 31);
            txtNotaFinal.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(43, 84, 126);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(24, 134);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 32);
            btnAgregar.TabIndex = 20;
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
            btnEditar.Location = new Point(143, 134);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 32);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(197, 48, 48);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(292, 134);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 22;
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
            btnLimpiar.Location = new Point(413, 134);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 23;
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
            btnActualizar.Location = new Point(541, 134);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 32);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "Recargar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(43, 84, 126);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(651, 134);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 32);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluaciones.AllowUserToAddRows = false;
            dgvEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvaluaciones.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 84, 126);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEvaluaciones.ColumnHeadersHeight = 34;
            dgvEvaluaciones.Location = new Point(12, 583);
            dgvEvaluaciones.MultiSelect = false;
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.ReadOnly = true;
            dgvEvaluaciones.RowHeadersWidth = 62;
            dgvEvaluaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluaciones.Size = new Size(1051, 352);
            dgvEvaluaciones.TabIndex = 26;
            dgvEvaluaciones.SelectionChanged += DgvEvaluaciones_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(36, 535);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(60, 23);
            lblBuscar.TabIndex = 27;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.Location = new Point(104, 532);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(300, 31);
            txtBuscar.TabIndex = 28;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(43, 84, 126);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(421, 535);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(531, 535);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(110, 28);
            btnMostrarTodos.TabIndex = 30;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += BtnMostrarTodos_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblEstudiante);
            panel1.Controls.Add(dtpFechaEvaluacion);
            panel1.Controls.Add(lblFechaEvaluacion);
            panel1.Controls.Add(cboProfesor);
            panel1.Controls.Add(lblProfesor);
            panel1.Controls.Add(cboMateria);
            panel1.Controls.Add(lblMateria);
            panel1.Controls.Add(cboEstudiante);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(cboEstado);
            panel1.Location = new Point(12, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(1051, 209);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.Location = new Point(15, 17);
            label1.Name = "label1";
            label1.Size = new Size(231, 30);
            label1.TabIndex = 10;
            label1.Text = "Informacion Academica";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1073, 54);
            panel2.TabIndex = 32;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(27, 54, 93);
            label2.Font = new Font("Segoe UI", 15F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.Size = new Size(1096, 46);
            label2.TabIndex = 33;
            label2.Text = "Gestion de Evaluaciones Finales";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblAsistencia);
            panel3.Controls.Add(txtAsistencia);
            panel3.Controls.Add(txtPruebas);
            panel3.Controls.Add(lblPruebas);
            panel3.Controls.Add(btnCerrar);
            panel3.Controls.Add(btnActualizar);
            panel3.Controls.Add(btnLimpiar);
            panel3.Controls.Add(btnEliminar);
            panel3.Controls.Add(btnEditar);
            panel3.Controls.Add(btnAgregar);
            panel3.Controls.Add(txtParticipacion);
            panel3.Controls.Add(lblParticipacion);
            panel3.Controls.Add(txtPuntosAsistencia);
            panel3.Controls.Add(lblPuntosAsistencia);
            panel3.Location = new Point(12, 276);
            panel3.Name = "panel3";
            panel3.Size = new Size(1051, 181);
            panel3.TabIndex = 33;
            // 
            // label3
            // 
            label3.Location = new Point(24, 19);
            label3.Name = "label3";
            label3.Size = new Size(261, 25);
            label3.TabIndex = 11;
            label3.Text = "Componentes de evaluacion";
            // 
            // FormEvaluacionesFinales
            // 
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1102, 969);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblNotaFinal);
            Controls.Add(txtNotaFinal);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(dgvEvaluaciones);
            Name = "FormEvaluacionesFinales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " Evaluaciones Finales";
            Load += FormEvaluacionesFinales_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEvaluaciones).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblEstudiante;
        private System.Windows.Forms.ComboBox cboEstudiante;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.ComboBox cboMateria;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox cboProfesor;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Label lblFechaEvaluacion;
        private System.Windows.Forms.DateTimePicker dtpFechaEvaluacion;
        private System.Windows.Forms.Label lblAsistencia;
        private System.Windows.Forms.TextBox txtAsistencia;
        private System.Windows.Forms.Label lblPuntosAsistencia;
        private System.Windows.Forms.TextBox txtPuntosAsistencia;
        private System.Windows.Forms.Label lblParticipacion;
        private System.Windows.Forms.TextBox txtParticipacion;
        private System.Windows.Forms.Label lblPruebas;
        private System.Windows.Forms.TextBox txtPruebas;
        private System.Windows.Forms.Label lblNotaFinal;
        private System.Windows.Forms.TextBox txtNotaFinal;
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
        private System.Windows.Forms.DataGridView dgvEvaluaciones;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label3;
    }
}
