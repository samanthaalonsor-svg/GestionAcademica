namespace GestionAcademica.Forms
{
    partial class FormProcesosSegundoPlano
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
            progressBar = new ProgressBar();
            lblProgreso = new Label();
            lblEstado = new Label();
            txtResultado = new TextBox();
            btnIniciar = new Button();
            btnCancelar = new Button();
            btnCerrar = new Button();
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
            lblTitulo.Padding = new Padding(30, 0, 0, 0);
            lblTitulo.Size = new Size(920, 80);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Procesos en segundo plano";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.ForeColor = Color.FromArgb(71, 85, 105);
            lblDescripcion.Location = new Point(0, 80);
            lblDescripcion.Margin = new Padding(4, 0, 4, 0);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(752, 55);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Ejecuta consultas de estudiantes, sesiones y evaluaciones mediante tareas concurrentes sin bloquear la interfaz.";
            lblDescripcion.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(13, 175);
            progressBar.Margin = new Padding(4, 4, 4, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(797, 32);
            progressBar.TabIndex = 2;
            // 
            // lblProgreso
            // 
            lblProgreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProgreso.ForeColor = Color.FromArgb(27, 54, 93);
            lblProgreso.Location = new Point(818, 175);
            lblProgreso.Margin = new Padding(4, 0, 4, 0);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(65, 32);
            lblProgreso.TabIndex = 3;
            lblProgreso.Text = "0%";
            lblProgreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(42, 90, 155);
            lblEstado.Location = new Point(30, 222);
            lblEstado.Margin = new Padding(4, 0, 4, 0);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(752, 35);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Listo para iniciar.";
            lblEstado.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Font = new Font("Segoe UI", 10F);
            txtResultado.ForeColor = Color.FromArgb(30, 41, 59);
            txtResultado.Location = new Point(30, 268);
            txtResultado.Margin = new Padding(4, 4, 4, 4);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(780, 186);
            txtResultado.TabIndex = 5;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(27, 54, 93);
            btnIniciar.Cursor = Cursors.Hand;
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnIniciar.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.Font = new Font("Segoe UI", 10F);
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(30, 485);
            btnIniciar.Margin = new Padding(4, 4, 4, 4);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(200, 50);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar proceso";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += BtnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.White;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(220, 38, 38);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 226, 226);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(254, 242, 242);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.Font = new Font("Segoe UI", 10F);
            btnCancelar.ForeColor = Color.FromArgb(220, 38, 38);
            btnCancelar.Location = new Point(261, 485);
            btnCancelar.Margin = new Padding(4, 4, 4, 4);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(200, 50);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += BtnCancelar_Click;
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
            btnCerrar.Location = new Point(610, 485);
            btnCerrar.Margin = new Padding(4, 4, 4, 4);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(200, 50);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // FormProcesosSegundoPlano
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(923, 597);
            Controls.Add(btnCerrar);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(txtResultado);
            Controls.Add(lblEstado);
            Controls.Add(lblProgreso);
            Controls.Add(progressBar);
            Controls.Add(lblDescripcion);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProcesosSegundoPlano";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Procesos en segundo plano";
            FormClosing += FormProcesosSegundoPlano_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitulo;
        private Label lblDescripcion;
        private ProgressBar progressBar;
        private Label lblProgreso;
        private Label lblEstado;
        private TextBox txtResultado;
        private Button btnIniciar;
        private Button btnCancelar;
        private Button btnCerrar;
    }
}
