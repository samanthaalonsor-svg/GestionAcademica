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
            DataGridViewCellStyle dgvEvaluacionesHead = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvEvaluacionesCell = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvEvaluacionesAlt = new DataGridViewCellStyle();
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
            lblEstudiante.Location = new Point(24, 52);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstudiante.Font = new Font("Segoe UI", 9.5F);
            lblEstudiante.Size = new Size(300, 20);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante";
            // 
            // cboEstudiante
            // 
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.Location = new Point(24, 74);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Font = new Font("Segoe UI", 10.5F);
            cboEstudiante.Size = new Size(300, 33);
            cboEstudiante.TabIndex = 1;
            // 
            // lblMateria
            // 
            lblMateria.Location = new Point(356, 52);
            lblMateria.Name = "lblMateria";
            lblMateria.ForeColor = Color.FromArgb(71, 85, 105);
            lblMateria.Font = new Font("Segoe UI", 9.5F);
            lblMateria.Size = new Size(300, 20);
            lblMateria.TabIndex = 2;
            lblMateria.Text = "Materia";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Location = new Point(356, 74);
            cboMateria.Name = "cboMateria";
            cboMateria.Font = new Font("Segoe UI", 10.5F);
            cboMateria.Size = new Size(300, 33);
            cboMateria.TabIndex = 3;
            // 
            // lblProfesor
            // 
            lblProfesor.Location = new Point(688, 52);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.ForeColor = Color.FromArgb(71, 85, 105);
            lblProfesor.Font = new Font("Segoe UI", 9.5F);
            lblProfesor.Size = new Size(285, 20);
            lblProfesor.TabIndex = 4;
            lblProfesor.Text = "Profesor";
            lblProfesor.Click += lblProfesor_Click;
            // 
            // cboProfesor
            // 
            cboProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesor.Location = new Point(688, 74);
            cboProfesor.Name = "cboProfesor";
            cboProfesor.Font = new Font("Segoe UI", 10.5F);
            cboProfesor.Size = new Size(285, 33);
            cboProfesor.TabIndex = 5;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(24, 112);
            lblEstado.Name = "lblEstado";
            lblEstado.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstado.Font = new Font("Segoe UI", 9.5F);
            lblEstado.Size = new Size(300, 20);
            lblEstado.TabIndex = 6;
            lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Location = new Point(24, 134);
            cboEstado.Name = "cboEstado";
            cboEstado.Font = new Font("Segoe UI", 10.5F);
            cboEstado.Size = new Size(300, 33);
            cboEstado.TabIndex = 7;
            // 
            // lblFechaEvaluacion
            // 
            lblFechaEvaluacion.Location = new Point(356, 112);
            lblFechaEvaluacion.Name = "lblFechaEvaluacion";
            lblFechaEvaluacion.ForeColor = Color.FromArgb(71, 85, 105);
            lblFechaEvaluacion.Font = new Font("Segoe UI", 9.5F);
            lblFechaEvaluacion.Size = new Size(300, 20);
            lblFechaEvaluacion.TabIndex = 8;
            lblFechaEvaluacion.Text = "Fecha de evaluación";
            // 
            // dtpFechaEvaluacion
            // 
            dtpFechaEvaluacion.Format = DateTimePickerFormat.Short;
            dtpFechaEvaluacion.Location = new Point(356, 134);
            dtpFechaEvaluacion.Name = "dtpFechaEvaluacion";
            dtpFechaEvaluacion.Font = new Font("Segoe UI", 10.5F);
            dtpFechaEvaluacion.Size = new Size(300, 33);
            dtpFechaEvaluacion.TabIndex = 9;
            // 
            // lblAsistencia
            // 
            lblAsistencia.Location = new Point(24, 52);
            lblAsistencia.Name = "lblAsistencia";
            lblAsistencia.ForeColor = Color.FromArgb(71, 85, 105);
            lblAsistencia.Font = new Font("Segoe UI", 9.5F);
            lblAsistencia.Size = new Size(170, 20);
            lblAsistencia.TabIndex = 10;
            lblAsistencia.Text = "Asistencia";
            // 
            // txtAsistencia
            // 
            txtAsistencia.BackColor = Color.White;
            txtAsistencia.Location = new Point(24, 74);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Font = new Font("Segoe UI", 10.5F);
            txtAsistencia.Size = new Size(150, 31);
            txtAsistencia.TabIndex = 11;
            // 
            // lblPuntosAsistencia
            // 
            lblPuntosAsistencia.Location = new Point(206, 52);
            lblPuntosAsistencia.Name = "lblPuntosAsistencia";
            lblPuntosAsistencia.ForeColor = Color.FromArgb(71, 85, 105);
            lblPuntosAsistencia.Font = new Font("Segoe UI", 9.5F);
            lblPuntosAsistencia.Size = new Size(170, 20);
            lblPuntosAsistencia.TabIndex = 12;
            lblPuntosAsistencia.Text = "Puntos de asistencia";
            // 
            // txtPuntosAsistencia
            // 
            txtPuntosAsistencia.BackColor = Color.White;
            txtPuntosAsistencia.Location = new Point(206, 74);
            txtPuntosAsistencia.Name = "txtPuntosAsistencia";
            txtPuntosAsistencia.Font = new Font("Segoe UI", 10.5F);
            txtPuntosAsistencia.Size = new Size(150, 31);
            txtPuntosAsistencia.TabIndex = 13;
            txtPuntosAsistencia.TextChanged += txtPuntosAsistencia_TextChanged;
            // 
            // lblParticipacion
            // 
            lblParticipacion.Location = new Point(388, 52);
            lblParticipacion.Name = "lblParticipacion";
            lblParticipacion.ForeColor = Color.FromArgb(71, 85, 105);
            lblParticipacion.Font = new Font("Segoe UI", 9.5F);
            lblParticipacion.Size = new Size(170, 20);
            lblParticipacion.TabIndex = 14;
            lblParticipacion.Text = "Participación";
            // 
            // txtParticipacion
            // 
            txtParticipacion.BackColor = Color.White;
            txtParticipacion.Location = new Point(388, 74);
            txtParticipacion.Name = "txtParticipacion";
            txtParticipacion.Font = new Font("Segoe UI", 10.5F);
            txtParticipacion.Size = new Size(150, 31);
            txtParticipacion.TabIndex = 15;
            txtParticipacion.TextChanged += txtParticipacion_TextChanged;
            // 
            // lblPruebas
            // 
            lblPruebas.Location = new Point(570, 52);
            lblPruebas.Name = "lblPruebas";
            lblPruebas.ForeColor = Color.FromArgb(71, 85, 105);
            lblPruebas.Font = new Font("Segoe UI", 9.5F);
            lblPruebas.Size = new Size(170, 20);
            lblPruebas.TabIndex = 16;
            lblPruebas.Text = "Pruebas";
            // 
            // txtPruebas
            // 
            txtPruebas.BackColor = Color.White;
            txtPruebas.Location = new Point(570, 74);
            txtPruebas.Name = "txtPruebas";
            txtPruebas.Font = new Font("Segoe UI", 10.5F);
            txtPruebas.Size = new Size(150, 31);
            txtPruebas.TabIndex = 17;
            txtPruebas.TextChanged += txtPruebas_TextChanged;
            // 
            // lblNotaFinal
            // 
            lblNotaFinal.Location = new Point(752, 52);
            lblNotaFinal.Name = "lblNotaFinal";
            lblNotaFinal.ForeColor = Color.FromArgb(71, 85, 105);
            lblNotaFinal.Font = new Font("Segoe UI", 9.5F);
            lblNotaFinal.Size = new Size(170, 20);
            lblNotaFinal.TabIndex = 18;
            lblNotaFinal.Text = "Nota final";
            // 
            // txtNotaFinal
            // 
            txtNotaFinal.BackColor = Color.FromArgb(241, 245, 249);
            txtNotaFinal.Location = new Point(752, 74);
            txtNotaFinal.Name = "txtNotaFinal";
            txtNotaFinal.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
            txtNotaFinal.ReadOnly = true;
            txtNotaFinal.Size = new Size(150, 31);
            txtNotaFinal.TabIndex = 19;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 54, 93);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(24, 124);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.TabIndex = 20;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = false;
            btnAgregar.Click += BtnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.White;
            btnEditar.FlatAppearance.BorderSize = 1;
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.FromArgb(27, 54, 93);
            btnEditar.Location = new Point(156, 124);
            btnEditar.Name = "btnEditar";
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 21;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatAppearance.BorderSize = 1;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Location = new Point(288, 124);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 226, 226);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += BtnEliminar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.FromArgb(226, 232, 240);
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.ForeColor = Color.FromArgb(51, 65, 85);
            btnLimpiar.Location = new Point(420, 124);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Size = new Size(120, 40);
            btnLimpiar.TabIndex = 23;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.White;
            btnActualizar.FlatAppearance.BorderSize = 1;
            btnActualizar.FlatStyle = FlatStyle.Flat;
            btnActualizar.ForeColor = Color.FromArgb(27, 54, 93);
            btnActualizar.Location = new Point(552, 124);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Font = new Font("Segoe UI", 10F);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "Recargar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(226, 232, 240);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.FromArgb(51, 65, 85);
            btnCerrar.Location = new Point(877, 124);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Size = new Size(120, 40);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // dgvEvaluaciones
            // 
            dgvEvaluacionesHead.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEvaluacionesHead.BackColor = Color.FromArgb(27, 54, 93);
            dgvEvaluacionesHead.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvEvaluacionesHead.ForeColor = Color.White;
            dgvEvaluacionesHead.Padding = new Padding(8, 0, 0, 0);
            dgvEvaluacionesHead.SelectionBackColor = Color.FromArgb(27, 54, 93);
            dgvEvaluacionesHead.SelectionForeColor = Color.White;
            dgvEvaluacionesHead.WrapMode = DataGridViewTriState.True;
            dgvEvaluacionesCell.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEvaluacionesCell.BackColor = Color.White;
            dgvEvaluacionesCell.Font = new Font("Segoe UI", 9.5F);
            dgvEvaluacionesCell.ForeColor = Color.FromArgb(30, 41, 59);
            dgvEvaluacionesCell.Padding = new Padding(8, 0, 0, 0);
            dgvEvaluacionesCell.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvEvaluacionesCell.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvEvaluacionesCell.WrapMode = DataGridViewTriState.False;
            dgvEvaluacionesAlt.BackColor = Color.FromArgb(248, 250, 252);
            dgvEvaluacionesAlt.ForeColor = Color.FromArgb(30, 41, 59);
            dgvEvaluacionesAlt.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvEvaluacionesAlt.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvEvaluaciones.AllowUserToAddRows = false;
            dgvEvaluaciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEvaluaciones.BackgroundColor = Color.White;

            dgvEvaluaciones.ColumnHeadersHeight = 40;
            dgvEvaluaciones.Location = new Point(24, 542);
            dgvEvaluaciones.MultiSelect = false;
            dgvEvaluaciones.Name = "dgvEvaluaciones";
            dgvEvaluaciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEvaluaciones.RowTemplate.Height = 34;
            dgvEvaluaciones.RowHeadersVisible = false;
            dgvEvaluaciones.GridColor = Color.FromArgb(226, 232, 240);
            dgvEvaluaciones.EnableHeadersVisualStyles = false;
            dgvEvaluaciones.DefaultCellStyle = dgvEvaluacionesCell;
            dgvEvaluaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEvaluaciones.ColumnHeadersDefaultCellStyle = dgvEvaluacionesHead;
            dgvEvaluaciones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEvaluaciones.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEvaluaciones.BorderStyle = BorderStyle.None;
            dgvEvaluaciones.AlternatingRowsDefaultCellStyle = dgvEvaluacionesAlt;
            dgvEvaluaciones.ReadOnly = true;
            dgvEvaluaciones.RowHeadersWidth = 62;
            dgvEvaluaciones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEvaluaciones.Size = new Size(997, 264);
            dgvEvaluaciones.TabIndex = 26;
            dgvEvaluaciones.SelectionChanged += DgvEvaluaciones_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(24, 498);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.ForeColor = Color.FromArgb(71, 85, 105);
            lblBuscar.Font = new Font("Segoe UI", 9.5F);
            lblBuscar.Size = new Size(60, 22);
            lblBuscar.TabIndex = 27;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.White;
            txtBuscar.Location = new Point(88, 490);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Font = new Font("Segoe UI", 10.5F);
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(340, 31);
            txtBuscar.TabIndex = 28;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(42, 90, 155);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(440, 489);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 54, 93);
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Size = new Size(100, 34);
            btnBuscar.TabIndex = 29;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(552, 489);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.ForeColor = Color.FromArgb(27, 54, 93);
            btnMostrarTodos.Font = new Font("Segoe UI", 10F);
            btnMostrarTodos.FlatStyle = FlatStyle.Flat;
            btnMostrarTodos.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnMostrarTodos.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnMostrarTodos.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnMostrarTodos.FlatAppearance.BorderSize = 1;
            btnMostrarTodos.Cursor = Cursors.Hand;
            btnMostrarTodos.BackColor = Color.White;
            btnMostrarTodos.Size = new Size(130, 34);
            btnMostrarTodos.TabIndex = 30;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(24, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 188);
            panel1.TabIndex = 31;
            // 
            // label1
            // 
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.ForeColor = Color.FromArgb(27, 54, 93);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Size = new Size(400, 26);
            label1.TabIndex = 10;
            label1.Text = "Información académica";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.BackColor = Color.FromArgb(27, 54, 93);
            panel2.Dock = DockStyle.Top;
            panel2.Size = new Size(1045, 64);
            panel2.TabIndex = 32;
            // 
            // label2
            // 
            label2.BackColor = Color.FromArgb(27, 54, 93);
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 8);
            label2.Name = "label2";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            label2.Padding = new Padding(24, 0, 0, 0);
            label2.Dock = DockStyle.Fill;
            label2.Size = new Size(1096, 46);
            label2.TabIndex = 33;
            label2.Text = "Gestión de evaluaciones finales";
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(lblNotaFinal);
            panel3.Controls.Add(txtNotaFinal);
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
            panel3.Location = new Point(24, 292);
            panel3.Name = "panel3";
            panel3.Size = new Size(997, 182);
            panel3.TabIndex = 33;
            // 
            // label3
            // 
            label3.Location = new Point(24, 14);
            label3.Name = "label3";
            label3.ForeColor = Color.FromArgb(27, 54, 93);
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Size = new Size(400, 26);
            label3.TabIndex = 11;
            label3.Text = "Componentes de evaluación";
            // 
            // FormEvaluacionesFinales
            // 
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1045, 830);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(dgvEvaluaciones);
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Name = "FormEvaluacionesFinales";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Evaluaciones finales";
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
