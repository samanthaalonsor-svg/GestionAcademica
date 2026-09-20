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
            lblTitulo.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblTitulo.Location = new Point(30, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(580, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Procesos en segundo plano";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDescripcion
            // 
            lblDescripcion.Font = new Font("Segoe UI", 10F);
            lblDescripcion.Location = new Point(45, 72);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(550, 58);
            lblDescripcion.TabIndex = 1;
            lblDescripcion.Text = "Ejecuta consultas de estudiantes, sesiones y evaluaciones mediante tareas concurrentes sin bloquear la interfaz.";
            lblDescripcion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(55, 150);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(500, 28);
            progressBar.TabIndex = 2;
            // 
            // lblProgreso
            // 
            lblProgreso.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblProgreso.Location = new Point(560, 150);
            lblProgreso.Name = "lblProgreso";
            lblProgreso.Size = new Size(50, 28);
            lblProgreso.TabIndex = 3;
            lblProgreso.Text = "0%";
            lblProgreso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblEstado
            // 
            lblEstado.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblEstado.ForeColor = Color.FromArgb(43, 84, 126);
            lblEstado.Location = new Point(45, 195);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(550, 35);
            lblEstado.TabIndex = 4;
            lblEstado.Text = "Listo para iniciar.";
            lblEstado.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.White;
            txtResultado.Location = new Point(55, 245);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(555, 125);
            txtResultado.TabIndex = 5;
            // 
            // btnIniciar
            // 
            btnIniciar.BackColor = Color.FromArgb(27, 54, 93);
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatStyle = FlatStyle.Flat;
            btnIniciar.ForeColor = Color.White;
            btnIniciar.Location = new Point(120, 390);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(140, 38);
            btnIniciar.TabIndex = 6;
            btnIniciar.Text = "Iniciar proceso";
            btnIniciar.UseVisualStyleBackColor = false;
            btnIniciar.Click += BtnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.Location = new Point(270, 390);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(140, 38);
            btnCancelar.TabIndex = 7;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += BtnCancelar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(420, 390);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(140, 38);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += BtnCerrar_Click;
            // 
            // FormProcesosSegundoPlano
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(650, 455);
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
