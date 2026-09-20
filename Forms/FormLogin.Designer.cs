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
            lblTitulo = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            btnIngresar = new Button();
            btnSalir = new Button();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitulo.Location = new Point(106, 22);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(370, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Sistema de Gestión Académica";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            lblUsuario.Location = new Point(45, 59);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(80, 23);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(45, 110);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(180, 31);
            txtUsuario.TabIndex = 2;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // lblContrasena
            // 
            lblContrasena.Location = new Point(45, 162);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(105, 28);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contraseña:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(45, 212);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(180, 31);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(43, 84, 126);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 10F);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(45, 285);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(180, 45);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += BtnIngresar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = SystemColors.AppWorkspace;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(80, 355);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(110, 35);
            btnSalir.TabIndex = 6;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += BtnSalir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lblUsuario);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(btnSalir);
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtContrasena);
            panel1.Controls.Add(lblContrasena);
            panel1.Location = new Point(133, 63);
            panel1.Name = "panel1";
            panel1.Size = new Size(343, 423);
            panel1.TabIndex = 7;
            // 
            // label1
            // 
            label1.Location = new Point(45, 15);
            label1.Name = "label1";
            label1.Size = new Size(180, 27);
            label1.TabIndex = 7;
            label1.Text = "INICIO DE SESIÓN";
            // 
            // FormLogin
            // 
            AcceptButton = btnIngresar;
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(627, 536);
            Controls.Add(panel1);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Académica - Inicio de Sesión";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
        private Panel panel1;
        private Label label1;
    }
}
