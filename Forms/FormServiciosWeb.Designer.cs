namespace GestionAcademica.Forms
{
    partial class FormServiciosWeb
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

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblDescripcion = new Label();
            lblPais = new Label();
            cboPais = new ComboBox();
            lblAnio = new Label();
            nudAnio = new NumericUpDown();
            btnConsultar = new Button();
            btnCancelar = new Button();
            btnExportar = new Button();
            lblEstado = new Label();
            tabResultados = new TabControl();
            tabFeriados = new TabPage();
            dgvFeriados = new DataGridView();
            tabSesiones = new TabPage();
            dgvSesiones = new DataGridView();
            tabJson = new TabPage();
            txtJson = new TextBox();
            lblProximo = new Label();
            btnCerrar = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAnio).BeginInit();
            tabResultados.SuspendLayout();
            tabFeriados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).BeginInit();
            tabSesiones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).BeginInit();
            tabJson.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(27, 54, 93);
            lblTitulo.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(38, 0, 0, 0);
            lblTitulo.Size = new Size(1450, 100);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Servicios web - Calendario de feriados";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescripcion.Location = new Point(38, 110);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(1375, 60);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Consume la API REST pública Nager.Date con HttpClient, procesa la respuesta JSON y la integra con las sesiones registradas en la base de datos.";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Segoe UI", 9.5F);
            lblPais.ForeColor = Color.FromArgb(71, 85, 105);
            lblPais.Location = new Point(38, 192);
            lblPais.Margin = new Padding(4, 0, 4, 0);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(49, 25);
            lblPais.TabIndex = 2;
            lblPais.Text = "País:";
            // 
            // cboPais
            // 
            cboPais.DropDownStyle = ComboBoxStyle.DropDownList;
            cboPais.Font = new Font("Segoe UI", 10.5F);
            cboPais.Location = new Point(95, 179);
            cboPais.Margin = new Padding(4, 4, 4, 4);
            cboPais.Name = "cboPais";
            cboPais.Size = new Size(286, 38);
            cboPais.TabIndex = 3;
            // 
            // lblAnio
            // 
            lblAnio.AutoSize = true;
            lblAnio.Font = new Font("Segoe UI", 9.5F);
            lblAnio.ForeColor = Color.FromArgb(71, 85, 105);
            lblAnio.Location = new Point(419, 192);
            lblAnio.Margin = new Padding(4, 0, 4, 0);
            lblAnio.Name = "lblAnio";
            lblAnio.Size = new Size(50, 25);
            lblAnio.TabIndex = 4;
            lblAnio.Text = "Año:";
            // 
            // nudAnio
            // 
            nudAnio.Font = new Font("Segoe UI", 10.5F);
            nudAnio.Location = new Point(481, 188);
            nudAnio.Margin = new Padding(4, 4, 4, 4);
            nudAnio.Maximum = new decimal(new int[] { 2100, 0, 0, 0 });
            nudAnio.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            nudAnio.Name = "nudAnio";
            nudAnio.Size = new Size(112, 35);
            nudAnio.TabIndex = 5;
            nudAnio.Value = new decimal(new int[] { 2026, 0, 0, 0 });
            // 
            // btnConsultar
            // 
            btnConsultar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnConsultar.Location = new Point(635, 181);
            btnConsultar.Margin = new Padding(4, 4, 4, 4);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(238, 45);
            btnConsultar.TabIndex = 6;
            btnConsultar.Text = "Buscar feriados";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += BtnConsultar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.Location = new Point(881, 182);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(150, 45);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Enabled = false;
            btnExportar.Font = new Font("Segoe UI", 10F);
            btnExportar.Location = new Point(1044, 182);
            btnExportar.Margin = new Padding(4, 4, 4, 4);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(188, 45);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar CSV";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += BtnExportar_Click;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 10F);
            lblEstado.ForeColor = Color.FromArgb(30, 41, 59);
            lblEstado.Location = new Point(38, 240);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(1375, 35);
            lblEstado.TabIndex = 9;
            lblEstado.Text = "Seleccione un país y un año, y presione \"Buscar feriados\".";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabResultados
            // 
            tabResultados.Controls.Add(tabFeriados);
            tabResultados.Controls.Add(tabSesiones);
            tabResultados.Controls.Add(tabJson);
            tabResultados.Font = new Font("Segoe UI", 9.5F);
            tabResultados.Location = new Point(38, 285);
            tabResultados.Margin = new Padding(4, 4, 4, 4);
            tabResultados.Name = "tabResultados";
            tabResultados.SelectedIndex = 0;
            tabResultados.Size = new Size(1375, 488);
            tabResultados.TabIndex = 10;
            // 
            // tabFeriados
            // 
            tabFeriados.Controls.Add(dgvFeriados);
            tabFeriados.Location = new Point(4, 34);
            tabFeriados.Margin = new Padding(4, 4, 4, 4);
            tabFeriados.Name = "tabFeriados";
            tabFeriados.Size = new Size(1367, 450);
            tabFeriados.TabIndex = 0;
            tabFeriados.Text = "Feriados (datos procesados)";
            tabFeriados.UseVisualStyleBackColor = true;
            // 
            // dgvFeriados
            // 
            dgvFeriados.AllowUserToAddRows = false;
            dgvFeriados.AllowUserToDeleteRows = false;
            dgvFeriados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvFeriados.BackgroundColor = Color.White;
            dgvFeriados.ColumnHeadersHeight = 34;
            dgvFeriados.Dock = DockStyle.Fill;
            dgvFeriados.Location = new Point(0, 0);
            dgvFeriados.Margin = new Padding(4, 4, 4, 4);
            dgvFeriados.Name = "dgvFeriados";
            dgvFeriados.ReadOnly = true;
            dgvFeriados.RowHeadersWidth = 62;
            dgvFeriados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvFeriados.Size = new Size(1367, 450);
            dgvFeriados.TabIndex = 0;
            // 
            // tabSesiones
            // 
            tabSesiones.Controls.Add(dgvSesiones);
            tabSesiones.Location = new Point(4, 34);
            tabSesiones.Margin = new Padding(4, 4, 4, 4);
            tabSesiones.Name = "tabSesiones";
            tabSesiones.Size = new Size(1367, 450);
            tabSesiones.TabIndex = 1;
            tabSesiones.Text = "Sesiones en días feriados";
            tabSesiones.UseVisualStyleBackColor = true;
            // 
            // dgvSesiones
            // 
            dgvSesiones.AllowUserToAddRows = false;
            dgvSesiones.AllowUserToDeleteRows = false;
            dgvSesiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSesiones.BackgroundColor = Color.White;
            dgvSesiones.ColumnHeadersHeight = 34;
            dgvSesiones.Dock = DockStyle.Fill;
            dgvSesiones.Location = new Point(0, 0);
            dgvSesiones.Margin = new Padding(4, 4, 4, 4);
            dgvSesiones.Name = "dgvSesiones";
            dgvSesiones.ReadOnly = true;
            dgvSesiones.RowHeadersWidth = 62;
            dgvSesiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSesiones.Size = new Size(1367, 450);
            dgvSesiones.TabIndex = 0;
            // 
            // tabJson
            // 
            tabJson.Controls.Add(txtJson);
            tabJson.Location = new Point(4, 34);
            tabJson.Margin = new Padding(4, 4, 4, 4);
            tabJson.Name = "tabJson";
            tabJson.Size = new Size(1367, 450);
            tabJson.TabIndex = 2;
            tabJson.Text = "Respuesta JSON";
            tabJson.UseVisualStyleBackColor = true;
            // 
            // txtJson
            // 
            txtJson.BackColor = Color.White;
            txtJson.Dock = DockStyle.Fill;
            txtJson.Font = new Font("Consolas", 10F);
            txtJson.Location = new Point(0, 0);
            txtJson.Margin = new Padding(4, 4, 4, 4);
            txtJson.Multiline = true;
            txtJson.Name = "txtJson";
            txtJson.ReadOnly = true;
            txtJson.ScrollBars = ScrollBars.Both;
            txtJson.Size = new Size(1367, 450);
            txtJson.TabIndex = 0;
            txtJson.WordWrap = false;
            // 
            // lblProximo
            // 
            lblProximo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProximo.ForeColor = Color.FromArgb(27, 54, 93);
            lblProximo.Location = new Point(38, 800);
            lblProximo.Margin = new Padding(4, 0, 4, 0);
            lblProximo.Name = "lblProximo";
            lblProximo.Size = new Size(1125, 45);
            lblProximo.TabIndex = 11;
            lblProximo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCerrar
            // 
            btnCerrar.Font = new Font("Segoe UI", 10F);
            btnCerrar.Location = new Point(1250, 800);
            btnCerrar.Margin = new Padding(4, 4, 4, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(162, 45);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // FormServiciosWeb
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1450, 875);
            Controls.Add(btnCerrar);
            Controls.Add(lblProximo);
            Controls.Add(tabResultados);
            Controls.Add(lblEstado);
            Controls.Add(btnExportar);
            Controls.Add(btnCancelar);
            Controls.Add(btnConsultar);
            Controls.Add(nudAnio);
            Controls.Add(lblAnio);
            Controls.Add(cboPais);
            Controls.Add(lblPais);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormServiciosWeb";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Servicios web";
            FormClosing += FormServiciosWeb_FormClosing;
            ((System.ComponentModel.ISupportInitialize)nudAnio).EndInit();
            tabResultados.ResumeLayout(false);
            tabFeriados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFeriados).EndInit();
            tabSesiones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvSesiones).EndInit();
            tabJson.ResumeLayout(false);
            tabJson.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblDescripcion;
        private Label lblPais;
        private ComboBox cboPais;
        private Label lblAnio;
        private NumericUpDown nudAnio;
        private Button btnConsultar;
        private Button btnCancelar;
        private Button btnExportar;
        private Label lblEstado;
        private TabControl tabResultados;
        private TabPage tabFeriados;
        private DataGridView dgvFeriados;
        private TabPage tabSesiones;
        private DataGridView dgvSesiones;
        private TabPage tabJson;
        private TextBox txtJson;
        private Label lblProximo;
        private Button btnCerrar;
    }
}
