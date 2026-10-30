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
            DataGridViewCellStyle dgvAsistenciasHead = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvAsistenciasCell = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvAsistenciasAlt = new DataGridViewCellStyle();
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
            lblEstudiante.Location = new Point(24, 18);
            lblEstudiante.Name = "lblEstudiante";
            lblEstudiante.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstudiante.Font = new Font("Segoe UI", 9.5F);
            lblEstudiante.Size = new Size(290, 20);
            lblEstudiante.TabIndex = 0;
            lblEstudiante.Text = "Estudiante";
            // 
            // cboEstudiante
            // 
            cboEstudiante.BackColor = Color.White;
            cboEstudiante.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstudiante.Location = new Point(24, 40);
            cboEstudiante.Name = "cboEstudiante";
            cboEstudiante.Font = new Font("Segoe UI", 10.5F);
            cboEstudiante.Size = new Size(290, 33);
            cboEstudiante.TabIndex = 1;
            // 
            // lblFecha
            // 
            lblFecha.Location = new Point(353, 88);
            lblFecha.Name = "lblFecha";
            lblFecha.ForeColor = Color.FromArgb(71, 85, 105);
            lblFecha.Font = new Font("Segoe UI", 9.5F);
            lblFecha.Size = new Size(290, 20);
            lblFecha.TabIndex = 2;
            lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            dtpFecha.Location = new Point(353, 110);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Font = new Font("Segoe UI", 10.5F);
            dtpFecha.Size = new Size(290, 33);
            dtpFecha.TabIndex = 3;
            // 
            // lblNivel
            // 
            lblNivel.Location = new Point(353, 18);
            lblNivel.Name = "lblNivel";
            lblNivel.ForeColor = Color.FromArgb(71, 85, 105);
            lblNivel.Font = new Font("Segoe UI", 9.5F);
            lblNivel.Size = new Size(290, 20);
            lblNivel.TabIndex = 4;
            lblNivel.Text = "Nivel";
            // 
            // cboNivel
            // 
            cboNivel.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNivel.Location = new Point(353, 40);
            cboNivel.Name = "cboNivel";
            cboNivel.Font = new Font("Segoe UI", 10.5F);
            cboNivel.Size = new Size(290, 33);
            cboNivel.TabIndex = 5;
            // 
            // lblMateria
            // 
            lblMateria.Location = new Point(682, 18);
            lblMateria.Name = "lblMateria";
            lblMateria.ForeColor = Color.FromArgb(71, 85, 105);
            lblMateria.Font = new Font("Segoe UI", 9.5F);
            lblMateria.Size = new Size(290, 20);
            lblMateria.TabIndex = 6;
            lblMateria.Text = "Materia";
            // 
            // cboMateria
            // 
            cboMateria.DropDownStyle = ComboBoxStyle.DropDownList;
            cboMateria.Location = new Point(682, 40);
            cboMateria.Name = "cboMateria";
            cboMateria.Font = new Font("Segoe UI", 10.5F);
            cboMateria.Size = new Size(290, 33);
            cboMateria.TabIndex = 7;
            // 
            // lblProfesor
            // 
            lblProfesor.Location = new Point(24, 88);
            lblProfesor.Name = "lblProfesor";
            lblProfesor.ForeColor = Color.FromArgb(71, 85, 105);
            lblProfesor.Font = new Font("Segoe UI", 9.5F);
            lblProfesor.Size = new Size(290, 20);
            lblProfesor.TabIndex = 8;
            lblProfesor.Text = "Profesor";
            // 
            // cboProfesor
            // 
            cboProfesor.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProfesor.Location = new Point(24, 110);
            cboProfesor.Name = "cboProfesor";
            cboProfesor.Font = new Font("Segoe UI", 10.5F);
            cboProfesor.Size = new Size(290, 33);
            cboProfesor.TabIndex = 9;
            // 
            // lblIdAsistencia
            // 
            lblIdAsistencia.Location = new Point(682, 88);
            lblIdAsistencia.Name = "lblIdAsistencia";
            lblIdAsistencia.ForeColor = Color.FromArgb(71, 85, 105);
            lblIdAsistencia.Font = new Font("Segoe UI", 9.5F);
            lblIdAsistencia.Size = new Size(140, 20);
            lblIdAsistencia.TabIndex = 10;
            lblIdAsistencia.Text = "ID asistencia";
            lblIdAsistencia.Click += lblIdAsistencia_Click;
            // 
            // txtIdAsistencia
            // 
            txtIdAsistencia.BackColor = Color.FromArgb(241, 245, 249);
            txtIdAsistencia.Location = new Point(682, 110);
            txtIdAsistencia.Name = "txtIdAsistencia";
            txtIdAsistencia.Font = new Font("Segoe UI", 10.5F);
            txtIdAsistencia.ReadOnly = true;
            txtIdAsistencia.Size = new Size(140, 33);
            txtIdAsistencia.TabIndex = 11;
            txtIdAsistencia.TabStop = false;
            txtIdAsistencia.Text = "(nuevo)";
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 54, 93);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(24, 168);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.TabIndex = 12;
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
            btnEditar.Location = new Point(156, 168);
            btnEditar.Name = "btnEditar";
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Location = new Point(288, 168);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 226, 226);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnEliminar.FlatAppearance.BorderSize = 1;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 14;
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
            btnLimpiar.Location = new Point(420, 168);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Size = new Size(120, 40);
            btnLimpiar.TabIndex = 15;
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
            btnActualizar.Location = new Point(552, 168);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Font = new Font("Segoe UI", 10F);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.TabIndex = 16;
            btnActualizar.Text = "Recargar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(877, 168);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.ForeColor = Color.FromArgb(51, 65, 85);
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.BackColor = Color.FromArgb(226, 232, 240);
            btnCerrar.Size = new Size(120, 40);
            btnCerrar.TabIndex = 17;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // dgvAsistencias
            // 
            dgvAsistenciasHead.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAsistenciasHead.BackColor = Color.FromArgb(27, 54, 93);
            dgvAsistenciasHead.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvAsistenciasHead.ForeColor = Color.White;
            dgvAsistenciasHead.Padding = new Padding(8, 0, 0, 0);
            dgvAsistenciasHead.SelectionBackColor = Color.FromArgb(27, 54, 93);
            dgvAsistenciasHead.SelectionForeColor = Color.White;
            dgvAsistenciasHead.WrapMode = DataGridViewTriState.True;
            dgvAsistenciasCell.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvAsistenciasCell.BackColor = Color.White;
            dgvAsistenciasCell.Font = new Font("Segoe UI", 9.5F);
            dgvAsistenciasCell.ForeColor = Color.FromArgb(30, 41, 59);
            dgvAsistenciasCell.Padding = new Padding(8, 0, 0, 0);
            dgvAsistenciasCell.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvAsistenciasCell.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvAsistenciasCell.WrapMode = DataGridViewTriState.False;
            dgvAsistenciasAlt.BackColor = Color.FromArgb(248, 250, 252);
            dgvAsistenciasAlt.ForeColor = Color.FromArgb(30, 41, 59);
            dgvAsistenciasAlt.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvAsistenciasAlt.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvAsistencias.AllowUserToAddRows = false;
            dgvAsistencias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAsistencias.BackgroundColor = Color.White;

            dgvAsistencias.ColumnHeadersHeight = 40;
            dgvAsistencias.Location = new Point(24, 388);
            dgvAsistencias.MultiSelect = false;
            dgvAsistencias.Name = "dgvAsistencias";
            dgvAsistencias.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvAsistencias.RowTemplate.Height = 34;
            dgvAsistencias.RowHeadersVisible = false;
            dgvAsistencias.GridColor = Color.FromArgb(226, 232, 240);
            dgvAsistencias.EnableHeadersVisualStyles = false;
            dgvAsistencias.DefaultCellStyle = dgvAsistenciasCell;
            dgvAsistencias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvAsistencias.ColumnHeadersDefaultCellStyle = dgvAsistenciasHead;
            dgvAsistencias.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvAsistencias.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvAsistencias.BorderStyle = BorderStyle.None;
            dgvAsistencias.AlternatingRowsDefaultCellStyle = dgvAsistenciasAlt;
            dgvAsistencias.ReadOnly = true;
            dgvAsistencias.RowHeadersWidth = 62;
            dgvAsistencias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAsistencias.Size = new Size(997, 328);
            dgvAsistencias.TabIndex = 22;
            dgvAsistencias.SelectionChanged += DgvAsistencias_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(24, 344);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.ForeColor = Color.FromArgb(71, 85, 105);
            lblBuscar.Font = new Font("Segoe UI", 9.5F);
            lblBuscar.Size = new Size(60, 22);
            lblBuscar.TabIndex = 18;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(88, 336);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Font = new Font("Segoe UI", 10.5F);
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(340, 31);
            txtBuscar.TabIndex = 19;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(42, 90, 155);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(440, 335);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 54, 93);
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Size = new Size(100, 34);
            btnBuscar.TabIndex = 20;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(552, 335);
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
            btnMostrarTodos.TabIndex = 21;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = false;
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
            panel1.Location = new Point(24, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 232);
            panel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.BackColor = Color.FromArgb(27, 54, 93);
            panel2.Size = new Size(1045, 64);
            panel2.TabIndex = 24;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(27, 54, 93);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 9);
            label1.Name = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Padding = new Padding(24, 0, 0, 0);
            label1.Dock = DockStyle.Fill;
            label1.Size = new Size(956, 37);
            label1.TabIndex = 18;
            label1.Text = "Gestión de sesiones";
            // 
            // FormAsistencias
            // 
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1045, 740);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(dgvAsistencias);
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Name = "FormAsistencias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de sesiones";
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
