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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            lblCodigo.Location = new Point(10, 61);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(80, 23);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Código:";
            // 
            // txtCodigo
            // 
            txtCodigo.BackColor = Color.White;
            txtCodigo.Location = new Point(96, 53);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(150, 31);
            txtCodigo.TabIndex = 1;
            // 
            // lblAlumno
            // 
            lblAlumno.Location = new Point(10, 102);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(80, 23);
            lblAlumno.TabIndex = 2;
            lblAlumno.Text = "Alumno:";
            // 
            // txtAlumno
            // 
            txtAlumno.Location = new Point(96, 94);
            txtAlumno.Name = "txtAlumno";
            txtAlumno.Size = new Size(220, 31);
            txtAlumno.TabIndex = 3;
            // 
            // lblEstado
            // 
            lblEstado.Location = new Point(10, 155);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(80, 23);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.BackColor = Color.White;
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Location = new Point(96, 145);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(220, 33);
            cboEstado.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.BackColor = Color.FromArgb(43, 84, 126);
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatStyle = FlatStyle.Flat;
            btnAgregar.ForeColor = Color.White;
            btnAgregar.Location = new Point(10, 198);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(100, 32);
            btnAgregar.TabIndex = 6;
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
            btnEditar.Location = new Point(151, 198);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(130, 32);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += BtnEditar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(197, 48, 48);
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(477, 198);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 32);
            btnEliminar.TabIndex = 8;
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
            btnLimpiar.Location = new Point(325, 198);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(100, 32);
            btnLimpiar.TabIndex = 9;
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
            btnActualizar.Location = new Point(611, 198);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(90, 32);
            btnActualizar.TabIndex = 10;
            btnActualizar.Text = "Recargar";
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += BtnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(731, 198);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(90, 32);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // dgvEstudiantes
            // 
            dgvEstudiantes.AllowUserToAddRows = false;
            dgvEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEstudiantes.BackgroundColor = Color.White;
            dgvEstudiantes.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(43, 84, 126);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEstudiantes.ColumnHeadersHeight = 34;
            dgvEstudiantes.Location = new Point(12, 363);
            dgvEstudiantes.MultiSelect = false;
            dgvEstudiantes.Name = "dgvEstudiantes";
            dgvEstudiantes.ReadOnly = true;
            dgvEstudiantes.RowHeadersWidth = 62;
            dgvEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEstudiantes.Size = new Size(1021, 300);
            dgvEstudiantes.TabIndex = 16;
            dgvEstudiantes.SelectionChanged += DgvEstudiantes_SelectionChanged;
            // 
            // lblBuscar
            // 
            lblBuscar.Location = new Point(12, 323);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(60, 23);
            lblBuscar.TabIndex = 12;
            lblBuscar.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(87, 315);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escriba para buscar...";
            txtBuscar.Size = new Size(300, 31);
            txtBuscar.TabIndex = 13;
            txtBuscar.KeyDown += TxtBuscar_KeyDown;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.FromArgb(43, 84, 126);
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.White;
            btnBuscar.Location = new Point(403, 318);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(90, 28);
            btnBuscar.TabIndex = 14;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += BtnBuscar_Click;
            // 
            // btnMostrarTodos
            // 
            btnMostrarTodos.Location = new Point(520, 315);
            btnMostrarTodos.Name = "btnMostrarTodos";
            btnMostrarTodos.Size = new Size(110, 28);
            btnMostrarTodos.TabIndex = 15;
            btnMostrarTodos.Text = "Mostrar todos";
            btnMostrarTodos.UseVisualStyleBackColor = true;
            btnMostrarTodos.Click += BtnMostrarTodos_Click;
            // 
            // pnlSuperior
            // 
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1045, 49);
            pnlSuperior.TabIndex = 17;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(27, 54, 93);
            label1.Font = new Font("Segoe UI", 14F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(1039, 40);
            label1.TabIndex = 18;
            label1.Text = "GESTION DE ESTUDIANTES";
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
            panel1.Location = new Point(12, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(1021, 250);
            panel1.TabIndex = 18;
            // 
            // label2
            // 
            label2.Location = new Point(10, 14);
            label2.Name = "label2";
            label2.Size = new Size(189, 24);
            label2.TabIndex = 19;
            label2.Text = "Datos del estudiante";
            // 
            // FormEstudiantes
            // 
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1045, 675);
            Controls.Add(panel1);
            Controls.Add(pnlSuperior);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(btnMostrarTodos);
            Controls.Add(dgvEstudiantes);
            Name = "FormEstudiantes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Estudiantes";
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
