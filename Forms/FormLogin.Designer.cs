namespace GestionAcademica.Forms
{
    partial class FormLogin
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
            pnlMarca = new Panel();
            lblAcceso = new Label();
            lblLema = new Label();
            lblTitulo = new Label();
            lblLogo = new Label();
            panel1 = new Panel();
            btnSalir = new Button();
            btnRegistrar = new Button();
            btnIngresar = new Button();
            txtContrasena = new TextBox();
            lblContrasena = new Label();
            txtUsuario = new TextBox();
            lblUsuario = new Label();
            lblSubtitulo = new Label();
            label1 = new Label();
            pnlMarca.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMarca
            // 
            pnlMarca.BackColor = Color.FromArgb(27, 54, 93);
            pnlMarca.Controls.Add(lblAcceso);
            pnlMarca.Controls.Add(lblLema);
            pnlMarca.Controls.Add(lblTitulo);
            pnlMarca.Controls.Add(lblLogo);
            pnlMarca.Dock = DockStyle.Left;
            pnlMarca.Location = new Point(0, 0);
            pnlMarca.Name = "pnlMarca";
            pnlMarca.Size = new Size(342, 467);
            pnlMarca.TabIndex = 8;
            // 
            // lblAcceso
            // 
            lblAcceso.Font = new Font("Segoe UI", 9F);
            lblAcceso.ForeColor = Color.FromArgb(147, 180, 224);
            lblAcceso.Location = new Point(32, 409);
            lblAcceso.Name = "lblAcceso";
            lblAcceso.Size = new Size(240, 31);
            lblAcceso.TabIndex = 3;
            lblAcceso.Text = "Acceso protegido";
            // 
            // lblLema
            // 
            lblLema.Font = new Font("Segoe UI", 10F);
            lblLema.ForeColor = Color.FromArgb(191, 211, 242);
            lblLema.Location = new Point(32, 240);
            lblLema.Name = "lblLema";
            lblLema.Size = new Size(261, 100);
            lblLema.TabIndex = 2;
            lblLema.Text = "Estudiantes, sesiones y calificaciones en un solo lugar.";
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(3, 129);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(359, 103);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Sistema de Gestión Académica";
            // 
            // lblLogo
            // 
            lblLogo.BackColor = Color.FromArgb(42, 90, 155);
            lblLogo.Font = new Font("Segoe MDL2 Assets", 26F);
            lblLogo.ForeColor = Color.White;
            lblLogo.Location = new Point(32, 56);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(64, 64);
            lblLogo.TabIndex = 0;
            lblLogo.Text = "";
            lblLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(lblContrasena);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(lblSubtitulo);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(342, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(484, 467);
            panel1.TabIndex = 7;
            // 
            // btnRegistrar
            btnRegistrar.BackColor = Color.FromArgb(226, 232, 240);
            btnRegistrar.FlatAppearance.BorderSize = 0;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F);
            btnRegistrar.ForeColor = Color.FromArgb(30, 41, 59);
            btnRegistrar.Location = new Point(48, 372);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(384, 42);
            btnRegistrar.TabIndex = 4;
            btnRegistrar.Text = "Crear cuenta nueva";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.FromArgb(226, 232, 240);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F);
            btnSalir.ForeColor = Color.FromArgb(30, 41, 59);
            btnSalir.Location = new Point(48, 438);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(384, 42);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(27, 54, 93);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 11F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(48, 310);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(384, 46);
            btnIngresar.TabIndex = 3;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // txtContrasena
            // 
            txtContrasena.Font = new Font("Segoe UI", 12F);
            txtContrasena.Location = new Point(48, 261);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(384, 39);
            txtContrasena.TabIndex = 2;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // lblContrasena
            // 
            lblContrasena.Font = new Font("Segoe UI", 9.5F);
            lblContrasena.ForeColor = Color.FromArgb(71, 85, 105);
            lblContrasena.Location = new Point(48, 225);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(384, 22);
            lblContrasena.TabIndex = 4;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            txtUsuario.Font = new Font("Segoe UI", 12F);
            txtUsuario.Location = new Point(48, 167);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(384, 39);
            txtUsuario.TabIndex = 1;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblUsuario
            // 
            lblUsuario.Font = new Font("Segoe UI", 9.5F);
            lblUsuario.ForeColor = Color.FromArgb(71, 85, 105);
            lblUsuario.Location = new Point(48, 129);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(384, 22);
            lblUsuario.TabIndex = 2;
            lblUsuario.Text = "Usuario:";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.Font = new Font("Segoe UI", 10F);
            lblSubtitulo.ForeColor = Color.FromArgb(100, 116, 139);
            lblSubtitulo.Location = new Point(48, 76);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(384, 35);
            lblSubtitulo.TabIndex = 1;
            lblSubtitulo.Text = "Ingrese sus credenciales para continuar.";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(27, 54, 93);
            label1.Location = new Point(48, 27);
            label1.Name = "label1";
            label1.Size = new Size(384, 49);
            label1.TabIndex = 0;
            label1.Text = "Iniciar sesión";
            // 
            // FormLogin
            // 
            AcceptButton = btnIngresar;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(826, 510);
            Controls.Add(panel1);
            Controls.Add(pnlMarca);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Académica - Inicio de Sesión";
            pnlMarca.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMarca;
        private Label lblLogo;
        private System.Windows.Forms.Label lblTitulo;
        private Label lblLema;
        private Label lblAcceso;
        private Panel panel1;
        private Label label1;
        private Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnRegistrar;
    }
}
