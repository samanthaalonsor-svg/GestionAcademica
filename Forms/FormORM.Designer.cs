namespace GestionAcademica.Forms
{
    partial class FormORM
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabOrm = new TabPage();
            lblOrmTitulo = new Label();
            lblCodigoOrm = new Label();
            txtCodigoOrm = new TextBox();
            lblAlumnoOrm = new Label();
            txtAlumnoOrm = new TextBox();
            lblEstado = new Label();
            cboEstado = new ComboBox();
            btnNuevoOrm = new Button();
            btnGuardarOrm = new Button();
            btnActualizarOrm = new Button();
            btnEliminarOrm = new Button();
            dgvOrmEstudiantes = new DataGridView();
            tabReportes = new TabPage();
            lblReporteTitulo = new Label();
            lblTipoReporte = new Label();
            cboTipoReporte = new ComboBox();
            lblFiltro = new Label();
            txtFiltro = new TextBox();
            lblEstadoReporte = new Label();
            cboEstadoReporte = new ComboBox();
            lblDesde = new Label();
            dtpDesde = new DateTimePicker();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            lblNotaMinima = new Label();
            txtNotaMinima = new TextBox();
            btnGenerarReporte = new Button();
            btnLimpiarReporte = new Button();
            btnExportarReporte = new Button();
            lblResultado = new Label();
            dgvReporte = new DataGridView();
            btnCerrar = new Button();
            tabControl.SuspendLayout();
            tabOrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrmEstudiantes).BeginInit();
            tabReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabOrm);
            tabControl.Controls.Add(tabReportes);
            tabControl.Location = new Point(18, 15);
            tabControl.Margin = new Padding(3, 2, 3, 2);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(980, 458);
            tabControl.TabIndex = 0;
            // 
            // tabOrm
            // 
            tabOrm.BackColor = Color.FromArgb(226, 232, 240);
            tabOrm.Controls.Add(lblOrmTitulo);
            tabOrm.Controls.Add(lblCodigoOrm);
            tabOrm.Controls.Add(txtCodigoOrm);
            tabOrm.Controls.Add(lblAlumnoOrm);
            tabOrm.Controls.Add(txtAlumnoOrm);
            tabOrm.Controls.Add(lblEstado);
            tabOrm.Controls.Add(cboEstado);
            tabOrm.Controls.Add(btnNuevoOrm);
            tabOrm.Controls.Add(btnGuardarOrm);
            tabOrm.Controls.Add(btnActualizarOrm);
            tabOrm.Controls.Add(btnEliminarOrm);
            tabOrm.Controls.Add(dgvOrmEstudiantes);
            tabOrm.Location = new Point(4, 24);
            tabOrm.Margin = new Padding(3, 2, 3, 2);
            tabOrm.Name = "tabOrm";
            tabOrm.Padding = new Padding(3, 2, 3, 2);
            tabOrm.Size = new Size(972, 430);
            tabOrm.TabIndex = 0;
            tabOrm.Text = "CRUD con Entity Framework Core";
            // 
            // lblOrmTitulo
            // 
            lblOrmTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrmTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblOrmTitulo.Location = new Point(3, 0);
            lblOrmTitulo.Name = "lblOrmTitulo";
            lblOrmTitulo.Size = new Size(919, 26);
            lblOrmTitulo.TabIndex = 0;
            lblOrmTitulo.Text = "CRUD de estudiantes mediante ORM (Entity Framework Core)";
            lblOrmTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCodigoOrm
            // 
            lblCodigoOrm.AutoSize = true;
            lblCodigoOrm.Location = new Point(68, 53);
            lblCodigoOrm.Name = "lblCodigoOrm";
            lblCodigoOrm.Size = new Size(49, 15);
            lblCodigoOrm.TabIndex = 1;
            lblCodigoOrm.Text = "Código:";
            // 
            // txtCodigoOrm
            // 
            txtCodigoOrm.Location = new Point(123, 50);
            txtCodigoOrm.Margin = new Padding(3, 2, 3, 2);
            txtCodigoOrm.Name = "txtCodigoOrm";
            txtCodigoOrm.Size = new Size(158, 23);
            txtCodigoOrm.TabIndex = 2;
            // 
            // lblAlumnoOrm
            // 
            lblAlumnoOrm.AutoSize = true;
            lblAlumnoOrm.Location = new Point(298, 53);
            lblAlumnoOrm.Name = "lblAlumnoOrm";
            lblAlumnoOrm.Size = new Size(65, 15);
            lblAlumnoOrm.TabIndex = 3;
            lblAlumnoOrm.Text = "Estudiante:";
            // 
            // txtAlumnoOrm
            // 
            txtAlumnoOrm.Location = new Point(369, 48);
            txtAlumnoOrm.Margin = new Padding(3, 2, 3, 2);
            txtAlumnoOrm.Name = "txtAlumnoOrm";
            txtAlumnoOrm.Size = new Size(246, 23);
            txtAlumnoOrm.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(621, 56);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(45, 15);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Location = new Point(669, 53);
            cboEstado.Margin = new Padding(3, 2, 3, 2);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(132, 23);
            cboEstado.TabIndex = 6;
            // 
            // btnNuevoOrm
            // 
            btnNuevoOrm.Location = new Point(81, 90);
            btnNuevoOrm.Margin = new Padding(3, 2, 3, 2);
            btnNuevoOrm.Name = "btnNuevoOrm";
            btnNuevoOrm.Size = new Size(105, 28);
            btnNuevoOrm.TabIndex = 7;
            btnNuevoOrm.Text = "Nuevo";
            btnNuevoOrm.UseVisualStyleBackColor = true;
            btnNuevoOrm.Click += BtnNuevoOrm_Click;
            // 
            // btnGuardarOrm
            // 
            btnGuardarOrm.BackColor = Color.FromArgb(27, 54, 93);
            btnGuardarOrm.FlatStyle = FlatStyle.Flat;
            btnGuardarOrm.ForeColor = Color.White;
            btnGuardarOrm.Location = new Point(241, 90);
            btnGuardarOrm.Margin = new Padding(3, 2, 3, 2);
            btnGuardarOrm.Name = "btnGuardarOrm";
            btnGuardarOrm.Size = new Size(122, 28);
            btnGuardarOrm.TabIndex = 8;
            btnGuardarOrm.Text = "Guardar ORM";
            btnGuardarOrm.UseVisualStyleBackColor = false;
            btnGuardarOrm.Click += BtnGuardarOrm_Click;
            // 
            // btnActualizarOrm
            // 
            btnActualizarOrm.Location = new Point(423, 90);
            btnActualizarOrm.Margin = new Padding(3, 2, 3, 2);
            btnActualizarOrm.Name = "btnActualizarOrm";
            btnActualizarOrm.Size = new Size(122, 28);
            btnActualizarOrm.TabIndex = 9;
            btnActualizarOrm.Text = "Actualizar ORM";
            btnActualizarOrm.Click += BtnActualizarOrm_Click;
            // 
            // btnEliminarOrm
            // 
            btnEliminarOrm.Location = new Point(669, 90);
            btnEliminarOrm.Margin = new Padding(3, 2, 3, 2);
            btnEliminarOrm.Name = "btnEliminarOrm";
            btnEliminarOrm.Size = new Size(122, 28);
            btnEliminarOrm.TabIndex = 10;
            btnEliminarOrm.Text = "Eliminar ORM";
            btnEliminarOrm.Click += BtnEliminarOrm_Click;
            // 
            // dgvOrmEstudiantes
            // 
            dgvOrmEstudiantes.AllowUserToAddRows = false;
            dgvOrmEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrmEstudiantes.BackgroundColor = Color.White;
            dgvOrmEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrmEstudiantes.Location = new Point(31, 135);
            dgvOrmEstudiantes.Margin = new Padding(3, 2, 3, 2);
            dgvOrmEstudiantes.MultiSelect = false;
            dgvOrmEstudiantes.Name = "dgvOrmEstudiantes";
            dgvOrmEstudiantes.ReadOnly = true;
            dgvOrmEstudiantes.RowHeadersVisible = false;
            dgvOrmEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrmEstudiantes.Size = new Size(906, 262);
            dgvOrmEstudiantes.TabIndex = 11;
            dgvOrmEstudiantes.SelectionChanged += DgvOrmEstudiantes_SelectionChanged;
            // 
            // tabReportes
            // 
            tabReportes.BackColor = Color.FromArgb(226, 232, 240);
            tabReportes.Controls.Add(lblReporteTitulo);
            tabReportes.Controls.Add(lblTipoReporte);
            tabReportes.Controls.Add(cboTipoReporte);
            tabReportes.Controls.Add(lblFiltro);
            tabReportes.Controls.Add(txtFiltro);
            tabReportes.Controls.Add(lblEstadoReporte);
            tabReportes.Controls.Add(cboEstadoReporte);
            tabReportes.Controls.Add(lblDesde);
            tabReportes.Controls.Add(dtpDesde);
            tabReportes.Controls.Add(lblHasta);
            tabReportes.Controls.Add(dtpHasta);
            tabReportes.Controls.Add(lblNotaMinima);
            tabReportes.Controls.Add(txtNotaMinima);
            tabReportes.Controls.Add(btnGenerarReporte);
            tabReportes.Controls.Add(btnLimpiarReporte);
            tabReportes.Controls.Add(btnExportarReporte);
            tabReportes.Controls.Add(lblResultado);
            tabReportes.Controls.Add(dgvReporte);
            tabReportes.Location = new Point(4, 24);
            tabReportes.Margin = new Padding(3, 2, 3, 2);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(3, 2, 3, 2);
            tabReportes.Size = new Size(972, 430);
            tabReportes.TabIndex = 1;
            tabReportes.Text = "Reportes dinámicos con LINQ";
            // 
            // lblReporteTitulo
            // 
            lblReporteTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReporteTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblReporteTitulo.Location = new Point(22, 11);
            lblReporteTitulo.Name = "lblReporteTitulo";
            lblReporteTitulo.Size = new Size(919, 26);
            lblReporteTitulo.TabIndex = 0;
            lblReporteTitulo.Text = "Reportes dinámicos integrados a la aplicación";
            lblReporteTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Location = new Point(26, 51);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(91, 15);
            lblTipoReporte.TabIndex = 1;
            lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // cboTipoReporte
            // 
            cboTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoReporte.Location = new Point(144, 48);
            cboTipoReporte.Margin = new Padding(3, 2, 3, 2);
            cboTipoReporte.Name = "cboTipoReporte";
            cboTipoReporte.Size = new Size(237, 23);
            cboTipoReporte.TabIndex = 2;
            cboTipoReporte.SelectedIndexChanged += CboTipoReporte_SelectedIndexChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Location = new Point(398, 51);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(117, 15);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Código o estudiante:";
            // 
            // txtFiltro
            // 
            txtFiltro.Location = new Point(634, 48);
            txtFiltro.Margin = new Padding(3, 2, 3, 2);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(193, 23);
            txtFiltro.TabIndex = 4;
            // 
            // lblEstadoReporte
            // 
            lblEstadoReporte.AutoSize = true;
            lblEstadoReporte.Location = new Point(26, 81);
            lblEstadoReporte.Name = "lblEstadoReporte";
            lblEstadoReporte.Size = new Size(45, 15);
            lblEstadoReporte.TabIndex = 5;
            lblEstadoReporte.Text = "Estado:";
            // 
            // cboEstadoReporte
            // 
            cboEstadoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoReporte.Location = new Point(144, 78);
            cboEstadoReporte.Margin = new Padding(3, 2, 3, 2);
            cboEstadoReporte.Name = "cboEstadoReporte";
            cboEstadoReporte.Size = new Size(176, 23);
            cboEstadoReporte.TabIndex = 6;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(26, 81);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(42, 15);
            lblDesde.TabIndex = 7;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(144, 78);
            dtpDesde.Margin = new Padding(3, 2, 3, 2);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(132, 23);
            dtpDesde.TabIndex = 8;
            dtpDesde.Value = new DateTime(2026, 9, 5, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(298, 81);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(40, 15);
            lblHasta.TabIndex = 9;
            lblHasta.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(359, 78);
            dtpHasta.Margin = new Padding(3, 2, 3, 2);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(132, 23);
            dtpHasta.TabIndex = 10;
            dtpHasta.Value = new DateTime(2026, 10, 5, 0, 0, 0, 0);
            // 
            // lblNotaMinima
            // 
            lblNotaMinima.AutoSize = true;
            lblNotaMinima.Location = new Point(26, 81);
            lblNotaMinima.Name = "lblNotaMinima";
            lblNotaMinima.Size = new Size(80, 15);
            lblNotaMinima.TabIndex = 11;
            lblNotaMinima.Text = "Nota mínima:";
            // 
            // txtNotaMinima
            // 
            txtNotaMinima.Location = new Point(144, 78);
            txtNotaMinima.Margin = new Padding(3, 2, 3, 2);
            txtNotaMinima.Name = "txtNotaMinima";
            txtNotaMinima.Size = new Size(88, 23);
            txtNotaMinima.TabIndex = 12;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(27, 54, 93);
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.ForeColor = Color.White;
            btnGenerarReporte.Location = new Point(26, 112);
            btnGenerarReporte.Margin = new Padding(3, 2, 3, 2);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(131, 28);
            btnGenerarReporte.TabIndex = 13;
            btnGenerarReporte.Text = "Generar reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += BtnGenerarReporte_Click;
            // 
            // btnLimpiarReporte
            // 
            btnLimpiarReporte.Location = new Point(171, 112);
            btnLimpiarReporte.Margin = new Padding(3, 2, 3, 2);
            btnLimpiarReporte.Name = "btnLimpiarReporte";
            btnLimpiarReporte.Size = new Size(105, 28);
            btnLimpiarReporte.TabIndex = 14;
            btnLimpiarReporte.Text = "Limpiar";
            btnLimpiarReporte.Click += BtnLimpiarReporte_Click;
            // 
            // btnExportarReporte
            // 
            btnExportarReporte.Location = new Point(289, 112);
            btnExportarReporte.Margin = new Padding(3, 2, 3, 2);
            btnExportarReporte.Name = "btnExportarReporte";
            btnExportarReporte.Size = new Size(118, 28);
            btnExportarReporte.TabIndex = 15;
            btnExportarReporte.Text = "Exportar CSV";
            btnExportarReporte.Click += BtnExportarReporte_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(26, 150);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(136, 15);
            lblResultado.TabIndex = 16;
            lblResultado.Text = "Registros encontrados: 0";
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Location = new Point(26, 172);
            dgvReporte.Margin = new Padding(3, 2, 3, 2);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(910, 225);
            dgvReporte.TabIndex = 20;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(783, 486);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(131, 28);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // FormORM
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(1015, 525);
            Controls.Add(btnCerrar);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Entregable 6 - ORM y Reportes";
            tabControl.ResumeLayout(false);
            tabOrm.ResumeLayout(false);
            tabOrm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOrmEstudiantes).EndInit();
            tabReportes.ResumeLayout(false);
            tabReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        private TabControl tabControl;
        private TabPage tabOrm;
        private Label lblOrmTitulo;
        private Label lblCodigoOrm;
        private TextBox txtCodigoOrm;
        private Label lblAlumnoOrm;
        private TextBox txtAlumnoOrm;
        private Label lblEstado;
        private ComboBox cboEstado;
        private Button btnNuevoOrm;
        private Button btnGuardarOrm;
        private Button btnActualizarOrm;
        private Button btnEliminarOrm;
        private DataGridView dgvOrmEstudiantes;
        private TabPage tabReportes;
        private Label lblReporteTitulo;
        private Label lblTipoReporte;
        private ComboBox cboTipoReporte;
        private Label lblFiltro;
        private TextBox txtFiltro;
        private Label lblEstadoReporte;
        private ComboBox cboEstadoReporte;
        private Label lblDesde;
        private DateTimePicker dtpDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Label lblNotaMinima;
        private TextBox txtNotaMinima;
        private Button btnGenerarReporte;
        private Button btnLimpiarReporte;
        private Button btnExportarReporte;
        private Label lblResultado;
        private DataGridView dgvReporte;
        private Button btnCerrar;
    }
}
