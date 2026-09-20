namespace GestionAcademica.Forms
{
    partial class FormMenuPrincipal
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
            pnlSuperior = new Panel();
            label1 = new Label();
            btnCalificaciones = new Button();
            btnProcesosSegundoPlano = new Button();
            btnCerrarSesion = new Button();
            btnEntregable6 = new Button();
            btnSesiones = new Button();
            lblTitulo = new Label();
            btnEstudiantes = new Button();
            pnlMenu = new Panel();
            panel1 = new Panel();
            pnlEvaluaciones = new Panel();
            label6 = new Label();
            pnlSesiones = new Panel();
            label5 = new Label();
            pnlEstudiantes = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlSuperior.SuspendLayout();
            pnlMenu.SuspendLayout();
            panel1.SuspendLayout();
            pnlEvaluaciones.SuspendLayout();
            pnlSesiones.SuspendLayout();
            pnlEstudiantes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.FromArgb(27, 54, 93);
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(878, 65);
            pnlSuperior.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 20);
            label1.Name = "label1";
            label1.Size = new Size(481, 38);
            label1.TabIndex = 5;
            label1.Text = "SISTEMA DE GESTIÓN ACADÉMICA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.BackColor = Color.FromArgb(27, 54, 93);
            btnCalificaciones.FlatAppearance.BorderSize = 0;
            btnCalificaciones.FlatStyle = FlatStyle.Flat;
            btnCalificaciones.ForeColor = Color.White;
            btnCalificaciones.Location = new Point(20, 175);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Size = new Size(160, 40);
            btnCalificaciones.TabIndex = 3;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.UseVisualStyleBackColor = false;
            btnCalificaciones.Click += BtnCalificaciones_Click;
            // 
            // btnProcesosSegundoPlano
            // 
            btnProcesosSegundoPlano.BackColor = Color.FromArgb(27, 54, 93);
            btnProcesosSegundoPlano.FlatAppearance.BorderSize = 0;
            btnProcesosSegundoPlano.FlatStyle = FlatStyle.Flat;
            btnProcesosSegundoPlano.ForeColor = Color.White;
            btnProcesosSegundoPlano.Location = new Point(20, 225);
            btnProcesosSegundoPlano.Name = "btnProcesosSegundoPlano";
            btnProcesosSegundoPlano.Size = new Size(160, 40);
            btnProcesosSegundoPlano.TabIndex = 4;
            btnProcesosSegundoPlano.Text = "Programación concurrente";
            btnProcesosSegundoPlano.UseVisualStyleBackColor = false;
            btnProcesosSegundoPlano.Click += BtnProcesosSegundoPlano_Click;
            // 
            // btnEntregable6
            // 
            btnEntregable6.BackColor = Color.FromArgb(27, 54, 93);
            btnEntregable6.FlatAppearance.BorderSize = 0;
            btnEntregable6.FlatStyle = FlatStyle.Flat;
            btnEntregable6.ForeColor = Color.White;
            btnEntregable6.Location = new Point(20, 275);
            btnEntregable6.Name = "btnEntregable6";
            btnEntregable6.Size = new Size(160, 40);
            btnEntregable6.TabIndex = 5;
            btnEntregable6.Text = "ORM y Reportes";
            btnEntregable6.UseVisualStyleBackColor = false;
            btnEntregable6.Click += BtnEntregable6_Click;
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.IndianRed;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(20, 327);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(160, 35);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // btnSesiones
            // 
            btnSesiones.BackColor = Color.FromArgb(27, 54, 93);
            btnSesiones.FlatAppearance.BorderSize = 0;
            btnSesiones.FlatStyle = FlatStyle.Flat;
            btnSesiones.ForeColor = Color.White;
            btnSesiones.Location = new Point(20, 125);
            btnSesiones.Name = "btnSesiones";
            btnSesiones.Size = new Size(160, 40);
            btnSesiones.TabIndex = 2;
            btnSesiones.Text = "Sesiones";
            btnSesiones.UseVisualStyleBackColor = false;
            btnSesiones.Click += BtnSesiones_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(20, 16);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(157, 40);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Inicio";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = Color.FromArgb(27, 54, 93);
            btnEstudiantes.FlatAppearance.BorderSize = 0;
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEstudiantes.ForeColor = Color.White;
            btnEstudiantes.Location = new Point(20, 75);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Size = new Size(160, 40);
            btnEstudiantes.TabIndex = 1;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += BtnEstudiantes_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(43, 84, 126);
            pnlMenu.Controls.Add(btnEstudiantes);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Controls.Add(btnSesiones);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(btnEntregable6);
            pnlMenu.Controls.Add(btnProcesosSegundoPlano);
            pnlMenu.Controls.Add(btnCalificaciones);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 65);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(200, 429);
            pnlMenu.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.Controls.Add(pnlEvaluaciones);
            panel1.Controls.Add(pnlSesiones);
            panel1.Controls.Add(pnlEstudiantes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(200, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 429);
            panel1.TabIndex = 8;
            // 
            // pnlEvaluaciones
            // 
            pnlEvaluaciones.BackColor = Color.White;
            pnlEvaluaciones.Controls.Add(label6);
            pnlEvaluaciones.Location = new Point(468, 167);
            pnlEvaluaciones.Name = "pnlEvaluaciones";
            pnlEvaluaciones.Size = new Size(183, 120);
            pnlEvaluaciones.TabIndex = 10;
            pnlEvaluaciones.Click += pnlEvaluaciones_Click;
            // 
            // label6
            // 
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(43, 84, 126);
            label6.Location = new Point(3, 14);
            label6.Name = "label6";
            label6.Size = new Size(177, 89);
            label6.TabIndex = 8;
            label6.Text = "EVALUACIONES";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            label6.Click += label6_Click_1;
            // 
            // pnlSesiones
            // 
            pnlSesiones.BackColor = Color.White;
            pnlSesiones.Controls.Add(label5);
            pnlSesiones.Location = new Point(250, 167);
            pnlSesiones.Name = "pnlSesiones";
            pnlSesiones.Size = new Size(180, 120);
            pnlSesiones.TabIndex = 9;
            pnlSesiones.Click += pnlSesiones_Click;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(43, 84, 126);
            label5.Location = new Point(3, 20);
            label5.Name = "label5";
            label5.Size = new Size(165, 77);
            label5.TabIndex = 8;
            label5.Text = "SESIONES";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click_1;
            // 
            // pnlEstudiantes
            // 
            pnlEstudiantes.BackColor = Color.White;
            pnlEstudiantes.Controls.Add(label4);
            pnlEstudiantes.Location = new Point(30, 167);
            pnlEstudiantes.Name = "pnlEstudiantes";
            pnlEstudiantes.Size = new Size(180, 120);
            pnlEstudiantes.TabIndex = 7;
            pnlEstudiantes.Click += pnlEstudiantes_Click;
            pnlEstudiantes.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(43, 84, 126);
            label4.Location = new Point(3, 20);
            label4.Name = "label4";
            label4.Size = new Size(165, 77);
            label4.TabIndex = 8;
            label4.Text = "ESTUDIANTES";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(43, 84, 126);
            label3.Location = new Point(70, 106);
            label3.Name = "label3";
            label3.Size = new Size(555, 44);
            label3.TabIndex = 6;
            label3.Text = "Seleccione una opción para comenzar";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(27, 54, 93);
            label2.Location = new Point(60, 3);
            label2.Name = "label2";
            label2.Size = new Size(555, 112);
            label2.TabIndex = 5;
            label2.Text = "Bienvenidos al\r\nSistema de Gestión Académica";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormMenuPrincipal
            // 
            BackColor = Color.FromArgb(226, 232, 240);
            ClientSize = new Size(878, 494);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            Controls.Add(pnlSuperior);
            MaximizeBox = false;
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión Académica ";
            pnlSuperior.ResumeLayout(false);
            pnlSuperior.PerformLayout();
            pnlMenu.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlEvaluaciones.ResumeLayout(false);
            pnlSesiones.ResumeLayout(false);
            pnlEstudiantes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlSuperior;
        private Label label1;
        private Button btnCalificaciones;
        private Button btnProcesosSegundoPlano;
        private Button btnCerrarSesion;
        private Button btnEntregable6;
        private Button btnSesiones;
        private Label lblTitulo;
        private Button btnEstudiantes;
        private Panel pnlMenu;
        private Panel panel1;
        private Panel pnlEstudiantes;
        private Label label3;
        private Label label2;
        private Panel pnlSesiones;
        private Label label5;
        private Label label4;
        private Panel pnlEvaluaciones;
        private Label label6;
    }
}
