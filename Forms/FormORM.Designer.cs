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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
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
            tabControl.Font = new Font("Segoe UI", 10F);
            tabControl.ItemSize = new Size(280, 34);
            tabControl.Location = new Point(25, 25);
            tabControl.Margin = new Padding(4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1400, 762);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.TabIndex = 0;
            // 
            // tabOrm
            // 
            tabOrm.BackColor = Color.FromArgb(241, 245, 249);
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
            tabOrm.Location = new Point(4, 38);
            tabOrm.Margin = new Padding(4);
            tabOrm.Name = "tabOrm";
            tabOrm.Padding = new Padding(4);
            tabOrm.Size = new Size(1392, 720);
            tabOrm.TabIndex = 0;
            tabOrm.Text = "Entity Framework Core";
            // 
            // lblOrmTitulo
            // 
            lblOrmTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblOrmTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblOrmTitulo.Location = new Point(38, 22);
            lblOrmTitulo.Margin = new Padding(4, 0, 4, 0);
            lblOrmTitulo.Name = "lblOrmTitulo";
            lblOrmTitulo.Size = new Size(1312, 44);
            lblOrmTitulo.TabIndex = 0;
            lblOrmTitulo.Text = "CRUD de estudiantes mediante ORM (Entity Framework Core)";
            lblOrmTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblCodigoOrm
            // 
            lblCodigoOrm.AutoSize = true;
            lblCodigoOrm.Font = new Font("Segoe UI", 9.5F);
            lblCodigoOrm.ForeColor = Color.FromArgb(71, 85, 105);
            lblCodigoOrm.Location = new Point(44, 94);
            lblCodigoOrm.Margin = new Padding(4, 0, 4, 0);
            lblCodigoOrm.Name = "lblCodigoOrm";
            lblCodigoOrm.Size = new Size(77, 25);
            lblCodigoOrm.TabIndex = 1;
            lblCodigoOrm.Text = "Código:";
            // 
            // txtCodigoOrm
            // 
            txtCodigoOrm.Font = new Font("Segoe UI", 10.5F);
            txtCodigoOrm.Location = new Point(144, 89);
            txtCodigoOrm.Margin = new Padding(4);
            txtCodigoOrm.Name = "txtCodigoOrm";
            txtCodigoOrm.Size = new Size(224, 35);
            txtCodigoOrm.TabIndex = 2;
            // 
            // lblAlumnoOrm
            // 
            lblAlumnoOrm.AutoSize = true;
            lblAlumnoOrm.Font = new Font("Segoe UI", 9.5F);
            lblAlumnoOrm.ForeColor = Color.FromArgb(71, 85, 105);
            lblAlumnoOrm.Location = new Point(400, 94);
            lblAlumnoOrm.Margin = new Padding(4, 0, 4, 0);
            lblAlumnoOrm.Name = "lblAlumnoOrm";
            lblAlumnoOrm.Size = new Size(104, 25);
            lblAlumnoOrm.TabIndex = 3;
            lblAlumnoOrm.Text = "Estudiante:";
            // 
            // txtAlumnoOrm
            // 
            txtAlumnoOrm.Font = new Font("Segoe UI", 10.5F);
            txtAlumnoOrm.Location = new Point(506, 89);
            txtAlumnoOrm.Margin = new Padding(4);
            txtAlumnoOrm.Name = "txtAlumnoOrm";
            txtAlumnoOrm.Size = new Size(349, 35);
            txtAlumnoOrm.TabIndex = 4;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Segoe UI", 9.5F);
            lblEstado.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstado.Location = new Point(888, 94);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(72, 25);
            lblEstado.TabIndex = 5;
            lblEstado.Text = "Estado:";
            // 
            // cboEstado
            // 
            cboEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstado.Font = new Font("Segoe UI", 10.5F);
            cboEstado.Location = new Point(956, 89);
            cboEstado.Margin = new Padding(4);
            cboEstado.Name = "cboEstado";
            cboEstado.Size = new Size(186, 38);
            cboEstado.TabIndex = 6;
            // 
            // btnNuevoOrm
            // 
            btnNuevoOrm.BackColor = Color.White;
            btnNuevoOrm.Cursor = Cursors.Hand;
            btnNuevoOrm.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnNuevoOrm.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnNuevoOrm.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnNuevoOrm.FlatStyle = FlatStyle.Flat;
            btnNuevoOrm.Font = new Font("Segoe UI", 10F);
            btnNuevoOrm.ForeColor = Color.FromArgb(27, 54, 93);
            btnNuevoOrm.Location = new Point(44, 150);
            btnNuevoOrm.Margin = new Padding(4);
            btnNuevoOrm.Name = "btnNuevoOrm";
            btnNuevoOrm.Size = new Size(150, 48);
            btnNuevoOrm.TabIndex = 7;
            btnNuevoOrm.Text = "Nuevo";
            btnNuevoOrm.UseVisualStyleBackColor = false;
            btnNuevoOrm.Click += BtnNuevoOrm_Click;
            // 
            // btnGuardarOrm
            // 
            btnGuardarOrm.BackColor = Color.FromArgb(27, 54, 93);
            btnGuardarOrm.Cursor = Cursors.Hand;
            btnGuardarOrm.FlatAppearance.BorderSize = 0;
            btnGuardarOrm.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnGuardarOrm.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnGuardarOrm.FlatStyle = FlatStyle.Flat;
            btnGuardarOrm.Font = new Font("Segoe UI", 10F);
            btnGuardarOrm.ForeColor = Color.White;
            btnGuardarOrm.Location = new Point(206, 150);
            btnGuardarOrm.Margin = new Padding(4);
            btnGuardarOrm.Name = "btnGuardarOrm";
            btnGuardarOrm.Size = new Size(175, 48);
            btnGuardarOrm.TabIndex = 8;
            btnGuardarOrm.Text = "Guardar ORM";
            btnGuardarOrm.UseVisualStyleBackColor = false;
            btnGuardarOrm.Click += BtnGuardarOrm_Click;
            // 
            // btnActualizarOrm
            // 
            btnActualizarOrm.BackColor = Color.White;
            btnActualizarOrm.Cursor = Cursors.Hand;
            btnActualizarOrm.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnActualizarOrm.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnActualizarOrm.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnActualizarOrm.FlatStyle = FlatStyle.Flat;
            btnActualizarOrm.Font = new Font("Segoe UI", 10F);
            btnActualizarOrm.ForeColor = Color.FromArgb(27, 54, 93);
            btnActualizarOrm.Location = new Point(394, 150);
            btnActualizarOrm.Margin = new Padding(4);
            btnActualizarOrm.Name = "btnActualizarOrm";
            btnActualizarOrm.Size = new Size(175, 48);
            btnActualizarOrm.TabIndex = 9;
            btnActualizarOrm.Text = "Actualizar ORM";
            btnActualizarOrm.UseVisualStyleBackColor = false;
            btnActualizarOrm.Click += BtnActualizarOrm_Click;
            // 
            // btnEliminarOrm
            // 
            btnEliminarOrm.BackColor = Color.White;
            btnEliminarOrm.Cursor = Cursors.Hand;
            btnEliminarOrm.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnEliminarOrm.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 226, 226);
            btnEliminarOrm.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnEliminarOrm.FlatStyle = FlatStyle.Flat;
            btnEliminarOrm.Font = new Font("Segoe UI", 10F);
            btnEliminarOrm.ForeColor = Color.FromArgb(220, 38, 38);
            btnEliminarOrm.Location = new Point(581, 150);
            btnEliminarOrm.Margin = new Padding(4);
            btnEliminarOrm.Name = "btnEliminarOrm";
            btnEliminarOrm.Size = new Size(175, 48);
            btnEliminarOrm.TabIndex = 10;
            btnEliminarOrm.Text = "Eliminar ORM";
            btnEliminarOrm.UseVisualStyleBackColor = false;
            btnEliminarOrm.Click += BtnEliminarOrm_Click;
            // 
            // dgvOrmEstudiantes
            // 
            dgvOrmEstudiantes.AllowUserToAddRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle7.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvOrmEstudiantes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvOrmEstudiantes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvOrmEstudiantes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrmEstudiantes.BackgroundColor = Color.White;
            dgvOrmEstudiantes.BorderStyle = BorderStyle.None;
            dgvOrmEstudiantes.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvOrmEstudiantes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.White;
            dataGridViewCellStyle8.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvOrmEstudiantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvOrmEstudiantes.ColumnHeadersHeight = 40;
            dgvOrmEstudiantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle9.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle9.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvOrmEstudiantes.DefaultCellStyle = dataGridViewCellStyle9;
            dgvOrmEstudiantes.EnableHeadersVisualStyles = false;
            dgvOrmEstudiantes.GridColor = Color.FromArgb(226, 232, 240);
            dgvOrmEstudiantes.Location = new Point(44, 225);
            dgvOrmEstudiantes.Margin = new Padding(4);
            dgvOrmEstudiantes.MultiSelect = false;
            dgvOrmEstudiantes.Name = "dgvOrmEstudiantes";
            dgvOrmEstudiantes.ReadOnly = true;
            dgvOrmEstudiantes.RowHeadersVisible = false;
            dgvOrmEstudiantes.RowHeadersWidth = 62;
            dgvOrmEstudiantes.RowTemplate.Height = 34;
            dgvOrmEstudiantes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrmEstudiantes.Size = new Size(1294, 438);
            dgvOrmEstudiantes.TabIndex = 11;
            dgvOrmEstudiantes.SelectionChanged += DgvOrmEstudiantes_SelectionChanged;
            // 
            // tabReportes
            // 
            tabReportes.BackColor = Color.FromArgb(241, 245, 249);
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
            tabReportes.Location = new Point(4, 38);
            tabReportes.Margin = new Padding(4);
            tabReportes.Name = "tabReportes";
            tabReportes.Padding = new Padding(4);
            tabReportes.Size = new Size(1392, 720);
            tabReportes.TabIndex = 1;
            tabReportes.Text = "Reportes ";
            // 
            // lblReporteTitulo
            // 
            lblReporteTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblReporteTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblReporteTitulo.Location = new Point(38, 19);
            lblReporteTitulo.Margin = new Padding(4, 0, 4, 0);
            lblReporteTitulo.Name = "lblReporteTitulo";
            lblReporteTitulo.Size = new Size(1312, 44);
            lblReporteTitulo.TabIndex = 0;
            lblReporteTitulo.Text = "Reportes \r\n";
            lblReporteTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.Font = new Font("Segoe UI", 9.5F);
            lblTipoReporte.ForeColor = Color.FromArgb(71, 85, 105);
            lblTipoReporte.Location = new Point(38, 85);
            lblTipoReporte.Margin = new Padding(4, 0, 4, 0);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(146, 25);
            lblTipoReporte.TabIndex = 1;
            lblTipoReporte.Text = "Tipo de reporte:";
            // 
            // cboTipoReporte
            // 
            cboTipoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoReporte.Font = new Font("Segoe UI", 10.5F);
            cboTipoReporte.Location = new Point(206, 80);
            cboTipoReporte.Margin = new Padding(4);
            cboTipoReporte.Name = "cboTipoReporte";
            cboTipoReporte.Size = new Size(336, 38);
            cboTipoReporte.TabIndex = 2;
            cboTipoReporte.SelectedIndexChanged += CboTipoReporte_SelectedIndexChanged;
            // 
            // lblFiltro
            // 
            lblFiltro.AutoSize = true;
            lblFiltro.Font = new Font("Segoe UI", 9.5F);
            lblFiltro.ForeColor = Color.FromArgb(71, 85, 105);
            lblFiltro.Location = new Point(569, 85);
            lblFiltro.Margin = new Padding(4, 0, 4, 0);
            lblFiltro.Name = "lblFiltro";
            lblFiltro.Size = new Size(186, 25);
            lblFiltro.TabIndex = 3;
            lblFiltro.Text = "Código o estudiante:";
            // 
            // txtFiltro
            // 
            txtFiltro.Font = new Font("Segoe UI", 10.5F);
            txtFiltro.Location = new Point(778, 75);
            txtFiltro.Margin = new Padding(4);
            txtFiltro.Name = "txtFiltro";
            txtFiltro.Size = new Size(274, 35);
            txtFiltro.TabIndex = 4;
            // 
            // lblEstadoReporte
            // 
            lblEstadoReporte.AutoSize = true;
            lblEstadoReporte.Font = new Font("Segoe UI", 9.5F);
            lblEstadoReporte.ForeColor = Color.FromArgb(71, 85, 105);
            lblEstadoReporte.Location = new Point(38, 135);
            lblEstadoReporte.Margin = new Padding(4, 0, 4, 0);
            lblEstadoReporte.Name = "lblEstadoReporte";
            lblEstadoReporte.Size = new Size(72, 25);
            lblEstadoReporte.TabIndex = 5;
            lblEstadoReporte.Text = "Estado:";
            // 
            // cboEstadoReporte
            // 
            cboEstadoReporte.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEstadoReporte.Font = new Font("Segoe UI", 10.5F);
            cboEstadoReporte.Location = new Point(206, 130);
            cboEstadoReporte.Margin = new Padding(4);
            cboEstadoReporte.Name = "cboEstadoReporte";
            cboEstadoReporte.Size = new Size(249, 38);
            cboEstadoReporte.TabIndex = 6;
            // 
            // lblDesde
            // 
            lblDesde.AutoSize = true;
            lblDesde.Font = new Font("Segoe UI", 9.5F);
            lblDesde.ForeColor = Color.FromArgb(71, 85, 105);
            lblDesde.Location = new Point(38, 135);
            lblDesde.Margin = new Padding(4, 0, 4, 0);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(68, 25);
            lblDesde.TabIndex = 7;
            lblDesde.Text = "Desde:";
            // 
            // dtpDesde
            // 
            dtpDesde.Font = new Font("Segoe UI", 10.5F);
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(206, 130);
            dtpDesde.Margin = new Padding(4);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(186, 35);
            dtpDesde.TabIndex = 8;
            dtpDesde.Value = new DateTime(2026, 9, 28, 0, 0, 0, 0);
            // 
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Font = new Font("Segoe UI", 9.5F);
            lblHasta.ForeColor = Color.FromArgb(71, 85, 105);
            lblHasta.Location = new Point(498, 143);
            lblHasta.Margin = new Padding(4, 0, 4, 0);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(63, 25);
            lblHasta.TabIndex = 9;
            lblHasta.Text = "Hasta:";
            lblHasta.Click += lblHasta_Click;
            // 
            // dtpHasta
            // 
            dtpHasta.Font = new Font("Segoe UI", 10.5F);
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(569, 135);
            dtpHasta.Margin = new Padding(4);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(186, 35);
            dtpHasta.TabIndex = 10;
            dtpHasta.Value = new DateTime(2026, 10, 28, 0, 0, 0, 0);
            // 
            // lblNotaMinima
            // 
            lblNotaMinima.AutoSize = true;
            lblNotaMinima.Font = new Font("Segoe UI", 9.5F);
            lblNotaMinima.ForeColor = Color.FromArgb(71, 85, 105);
            lblNotaMinima.Location = new Point(38, 135);
            lblNotaMinima.Margin = new Padding(4, 0, 4, 0);
            lblNotaMinima.Name = "lblNotaMinima";
            lblNotaMinima.Size = new Size(125, 25);
            lblNotaMinima.TabIndex = 11;
            lblNotaMinima.Text = "Nota mínima:";
            // 
            // txtNotaMinima
            // 
            txtNotaMinima.Font = new Font("Segoe UI", 10.5F);
            txtNotaMinima.Location = new Point(206, 130);
            txtNotaMinima.Margin = new Padding(4);
            txtNotaMinima.Name = "txtNotaMinima";
            txtNotaMinima.Size = new Size(124, 35);
            txtNotaMinima.TabIndex = 12;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.FromArgb(27, 54, 93);
            btnGenerarReporte.Cursor = Cursors.Hand;
            btnGenerarReporte.FlatAppearance.BorderSize = 0;
            btnGenerarReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnGenerarReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnGenerarReporte.FlatStyle = FlatStyle.Flat;
            btnGenerarReporte.Font = new Font("Segoe UI", 10F);
            btnGenerarReporte.ForeColor = Color.White;
            btnGenerarReporte.Location = new Point(38, 188);
            btnGenerarReporte.Margin = new Padding(4);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(188, 48);
            btnGenerarReporte.TabIndex = 13;
            btnGenerarReporte.Text = "Generar reporte";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += BtnGenerarReporte_Click;
            // 
            // btnLimpiarReporte
            // 
            btnLimpiarReporte.BackColor = Color.White;
            btnLimpiarReporte.Cursor = Cursors.Hand;
            btnLimpiarReporte.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnLimpiarReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnLimpiarReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnLimpiarReporte.FlatStyle = FlatStyle.Flat;
            btnLimpiarReporte.Font = new Font("Segoe UI", 10F);
            btnLimpiarReporte.ForeColor = Color.FromArgb(27, 54, 93);
            btnLimpiarReporte.Location = new Point(244, 188);
            btnLimpiarReporte.Margin = new Padding(4);
            btnLimpiarReporte.Name = "btnLimpiarReporte";
            btnLimpiarReporte.Size = new Size(150, 48);
            btnLimpiarReporte.TabIndex = 14;
            btnLimpiarReporte.Text = "Limpiar";
            btnLimpiarReporte.UseVisualStyleBackColor = false;
            btnLimpiarReporte.Click += BtnLimpiarReporte_Click;
            // 
            // btnExportarReporte
            // 
            btnExportarReporte.BackColor = Color.White;
            btnExportarReporte.Cursor = Cursors.Hand;
            btnExportarReporte.FlatAppearance.BorderColor = Color.FromArgb(27, 54, 93);
            btnExportarReporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(226, 232, 240);
            btnExportarReporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnExportarReporte.FlatStyle = FlatStyle.Flat;
            btnExportarReporte.Font = new Font("Segoe UI", 10F);
            btnExportarReporte.ForeColor = Color.FromArgb(27, 54, 93);
            btnExportarReporte.Location = new Point(412, 188);
            btnExportarReporte.Margin = new Padding(4);
            btnExportarReporte.Name = "btnExportarReporte";
            btnExportarReporte.Size = new Size(169, 48);
            btnExportarReporte.TabIndex = 15;
            btnExportarReporte.Text = "Exportar CSV";
            btnExportarReporte.UseVisualStyleBackColor = false;
            btnExportarReporte.Click += BtnExportarReporte_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblResultado.ForeColor = Color.FromArgb(27, 54, 93);
            lblResultado.Location = new Point(38, 250);
            lblResultado.Margin = new Padding(4, 0, 4, 0);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(246, 28);
            lblResultado.TabIndex = 16;
            lblResultado.Text = "Registros encontrados: 0";
            // 
            // dgvReporte
            // 
            dgvReporte.AllowUserToAddRows = false;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle10.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dgvReporte.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dgvReporte.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.BackgroundColor = Color.White;
            dgvReporte.BorderStyle = BorderStyle.None;
            dgvReporte.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReporte.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(27, 54, 93);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            dgvReporte.ColumnHeadersHeight = 40;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.White;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 9.5F);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle12.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(30, 41, 59);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgvReporte.DefaultCellStyle = dataGridViewCellStyle12;
            dgvReporte.EnableHeadersVisualStyles = false;
            dgvReporte.GridColor = Color.FromArgb(226, 232, 240);
            dgvReporte.Location = new Point(38, 288);
            dgvReporte.Margin = new Padding(4);
            dgvReporte.MultiSelect = false;
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 62;
            dgvReporte.RowTemplate.Height = 34;
            dgvReporte.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReporte.Size = new Size(1300, 375);
            dgvReporte.TabIndex = 20;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(226, 232, 240);
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatAppearance.MouseDownBackColor = Color.FromArgb(148, 163, 184);
            btnCerrar.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 213, 225);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.ForeColor = Color.FromArgb(51, 65, 85);
            btnCerrar.Location = new Point(1238, 806);
            btnCerrar.Margin = new Padding(4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(188, 48);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // FormORM
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1450, 875);
            Controls.Add(btnCerrar);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormORM";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ORM y Reportes";
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
