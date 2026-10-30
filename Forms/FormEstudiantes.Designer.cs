namespace GestionAcademica.Forms
{
    partial class FormEstudiantes
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
            DataGridViewCellStyle dgvEstudiantesHead = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvEstudiantesCell = new DataGridViewCellStyle();
            DataGridViewCellStyle dgvEstudiantesAlt = new DataGridViewCellStyle();
            lblCodigo = new Label();
            txtCodigo = new TextBox();
            lblAlumno = new Label();
            txtAlumno = new TextBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnEliminar = new Button();
            btnLimpiar = new Button();
            btnActualizar = new Button();
            btnCerrar = new Button();
            dgvEstudiantes = new DataGridView();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnMostrarTodos = new Button();
            pnlSuperior = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).BeginInit();
            pnlSuperior.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.Location = new Point(24, 52);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.ForeColor = Color.FromArgb(71, 85, 105);
            lblCodigo.Font = new Font("Segoe UI", 9.5F);
            lblCodigo.Size = new Size(200, 20);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.Location = new Point(24, 74);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Font = new Font("Segoe UI", 10.5F);
            txtCodigo.Size = new Size(220, 31);
            txtCodigo.TabIndex = 1;
            // 
            // lblAlumno
            // 
            lblAlumno.Location = new Point(276, 52);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.ForeColor = Color.FromArgb(71, 85, 105);
            lblAlumno.Font = new Font("Segoe UI", 9.5F);
            lblAlumno.Size = new Size(250, 20);
            lblAlumno.TabIndex = 2;
            lblAlumno.Text = "Nombre del alumno";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(276, 74);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Font = new Font("Segoe UI", 10.5F);
            txtAlumno.Size = new Size(340, 31);
            txtAlumno.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(648, 52);
            lblEstado.Name = "lblEstado";
            lblEstado.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstado.Font = new Font("Segoe UI", 9.5F);
            lblEstado.Size = new Size(200, 20);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado";
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.White;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Location = new Point(648, 74);
            cboEstado.Name = "cboEstado";
            cboEstado.Font = new Font("Segoe UI", 10.5F);
            cboEstado.Size = new Size(220, 33);
            cboEstado.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(27, 54, 93);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(24, 126);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Font = new Font("Segoe UI", 10F);
            btnAgregar.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnAgregar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnAgregar.Cursor = Cursors.Hand;
            btnAgregar.Size = new Size(120, 40);
            btnAgregar.TabIndex = 6;
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
            btnEditar.Location = new Point(156, 126);
            btnEditar.Name = "btnEditar";
            btnEditar.Font = new Font("Segoe UI", 10F);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Size = new Size(120, 40);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminar.Location = new Point(288, 126);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Font = new Font("Segoe UI", 10F);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 226, 226);
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnEliminar.FlatAppearance.BorderSize = 1;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.Size = new Size(120, 40);
            btnEliminar.TabIndex = 8;
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
            btnLimpiar.Location = new Point(420, 126);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Font = new Font("Segoe UI", 10F);
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Size = new Size(120, 40);
            btnLimpiar.TabIndex = 9;
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
            btnActualizar.Location = new Point(552, 126);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Font = new Font("Segoe UI", 10F);
            btnActualizar.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnActualizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnActualizar.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnActualizar.Cursor = Cursors.Hand;
            btnActualizar.Size = new Size(120, 40);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Recargar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(877, 126);
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
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantesHead.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEstudiantesHead.BackColor = Color.FromArgb(27, 54, 93);
            dgvEstudiantesHead.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dgvEstudiantesHead.ForeColor = Color.White;
            dgvEstudiantesHead.Padding = new Padding(8, 0, 0, 0);
            dgvEstudiantesHead.SelectionBackColor = Color.FromArgb(27, 54, 93);
            dgvEstudiantesHead.SelectionForeColor = Color.White;
            dgvEstudiantesHead.WrapMode = DataGridViewTriState.True;
            dgvEstudiantesCell.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvEstudiantesCell.BackColor = Color.White;
            dgvEstudiantesCell.Font = new Font("Segoe UI", 9.5F);
            dgvEstudiantesCell.ForeColor = Color.FromArgb(30, 41, 59);
            dgvEstudiantesCell.Padding = new Padding(8, 0, 0, 0);
            dgvEstudiantesCell.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvEstudiantesCell.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvEstudiantesCell.WrapMode = DataGridViewTriState.False;
            dgvEstudiantesAlt.BackColor = Color.FromArgb(248, 250, 252);
            dgvEstudiantesAlt.ForeColor = Color.FromArgb(30, 41, 59);
            dgvEstudiantesAlt.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dgvEstudiantesAlt.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.BackgroundColor = Color.White;
            dgvEstudiantes.BorderStyle = BorderStyle.None;

            dgvEstudiantes.ColumnHeadersHeight = 40;
            dgvEstudiantes.Location = new Point(24, 340);
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvEstudiantes.RowTemplate.Height = 34;
            dgvEstudiantes.RowHeadersVisible = false;
            dgvEstudiantes.GridColor = Color.FromArgb(226, 232, 240);
            dgvEstudiantes.EnableHeadersVisualStyles = false;
            dgvEstudiantes.DefaultCellStyle = dgvEstudiantesCell;
            dgvEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle = dgvEstudiantesHead;
            dgvEstudiantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvEstudiantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEstudiantes.AlternatingRowsDefaultCellStyle = dgvEstudiantesAlt;
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersWidth = 62;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(997, 336);
            dgvEstudiantes.TabIndex = 16;
            dgvEstudiantes.SelectionChanged += DgvEstudiantes_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(24, 296);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.ForeColor = Color.FromArgb(71, 85, 105);
            lblBuscar.Font = new Font("Segoe UI", 9.5F);
            lblBuscar.Size = new Size(60, 22);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(88, 288);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Font = new Font("Segoe UI", 10.5F);
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(340, 31);
            txtBuscar.TabIndex = 13;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(42, 90, 155);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(440, 287);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Font = new Font("Segoe UI", 10F);
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(27, 54, 93);
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.Size = new Size(100, 34);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(552, 287);
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
            btnMostrarTodos.TabIndex = 15;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = false;
            btnMostrarTodos.Click += BtnMostrarTodos_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.BackColor = Color.FromArgb(27, 54, 93);
            pnlSuperior.Size = new Size(1045, 64);
            pnlSuperior.TabIndex = 17;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(27, 54, 93);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            label1.Padding = new Padding(24, 0, 0, 0);
            label1.Dock = DockStyle.Fill;
            label1.Size = new Size(1039, 40);
            label1.TabIndex = 18;
            label1.Text = "Gestión de estudiantes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblCodigo);
            panel1.Controls.Add(btnCerrar);
            panel1.Controls.Add(btnActualizar);
            panel1.Controls.Add(btnEliminar);
            panel1.Controls.Add(btnEditar);
            panel1.Controls.Add(btnLimpiar);
            panel1.Controls.Add(btnAgregar);
            panel1.Controls.Add(cboEstado);
            panel1.Controls.Add(lblEstado);
            panel1.Controls.Add(txtAlumno);
            panel1.Controls.Add(lblAlumno);
            panel1.Controls.Add(txtCodigo);
            panel1.Location = new Point(24, 88);
            panel1.Name = "panel1";
            panel1.Size = new Size(997, 180);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.Location = new Point(24, 14);
            label2.Name = "label2";
            label2.ForeColor = Color.FromArgb(27, 54, 93);
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Size = new Size(300, 26);
            label2.TabIndex = 19;
            label2.Text = "Datos del estudiante";
            // 
            // FormEstudiantes
            // 
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1045, 700);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(dgvEstudiantes);
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            Name = "FormEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de estudiantes";
            ((System.ComponentModel.ISupportInitialize)dgvEstudiantes).EndInit();
            pnlSuperior.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cboEstado;
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
        private System.Windows.Forms.DataGridView dgvEstudiantes;
        private Panel pnlSuperior;
        private Label label1;
        private Panel panel1;
        private Label label2;
    }
}
