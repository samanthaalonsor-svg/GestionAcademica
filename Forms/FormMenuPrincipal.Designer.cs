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
            lblLineaSuperior = new Label();
            lblReloj = new Label();
            label1 = new Label();
            btnMenuToggle = new Button();
            pnlMenu = new Panel();
            btnCerrarSesion = new Button();
            pnlSubHerramientas = new Panel();
            btnServiciosWeb = new Button();
            btnEntregable6 = new Button();
            btnProcesosSegundoPlano = new Button();
            btnGrupoHerramientas = new Button();
            pnlSubGestion = new Panel();
            btnCalificaciones = new Button();
            btnSesiones = new Button();
            btnEstudiantes = new Button();
            btnGrupoGestion = new Button();
            lblTitulo = new Label();
            panel1 = new Panel();
            pnlOrm = new Panel();
            lblOrmAbrir = new Label();
            lblOrmDesc = new Label();
            lblOrmTitulo = new Label();
            lblFranjaOrm = new Label();
            pnlProcesos = new Panel();
            lblProcesosAbrir = new Label();
            lblProcesosDesc = new Label();
            lblProcesosTitulo = new Label();
            lblFranjaProcesos = new Label();
            pnlEvaluaciones = new Panel();
            lblAbrirEvaluaciones = new Label();
            lblDescEvaluaciones = new Label();
            label6 = new Label();
            lblFranjaEvaluaciones = new Label();
            pnlSesiones = new Panel();
            lblAbrirSesiones = new Label();
            lblDescSesiones = new Label();
            label5 = new Label();
            lblFranjaSesiones = new Label();
            pnlEstudiantes = new Panel();
            lblAbrirEstudiantes = new Label();
            lblDescEstudiantes = new Label();
            label4 = new Label();
            lblFranjaEstudiantes = new Label();
            label3 = new Label();
            label2 = new Label();
            pnlSuperior.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlSubHerramientas.SuspendLayout();
            pnlSubGestion.SuspendLayout();
            panel1.SuspendLayout();
            pnlOrm.SuspendLayout();
            pnlProcesos.SuspendLayout();
            pnlEvaluaciones.SuspendLayout();
            pnlSesiones.SuspendLayout();
            pnlEstudiantes.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSuperior
            // 
            pnlSuperior.BackColor = Color.White;
            pnlSuperior.Controls.Add(lblLineaSuperior);
            pnlSuperior.Controls.Add(lblReloj);
            pnlSuperior.Controls.Add(label1);
            pnlSuperior.Controls.Add(btnMenuToggle);
            pnlSuperior.Dock = DockStyle.Top;
            pnlSuperior.Location = new Point(0, 0);
            pnlSuperior.Margin = new Padding(4, 4, 4, 4);
            pnlSuperior.Name = "pnlSuperior";
            pnlSuperior.Size = new Size(1500, 84);
            pnlSuperior.TabIndex = 6;
            // 
            // lblLineaSuperior
            // 
            lblLineaSuperior.BackColor = Color.FromArgb(203, 213, 225);
            lblLineaSuperior.Dock = DockStyle.Bottom;
            lblLineaSuperior.Location = new Point(0, 82);
            lblLineaSuperior.Margin = new Padding(4, 0, 4, 0);
            lblLineaSuperior.Name = "lblLineaSuperior";
            lblLineaSuperior.Size = new Size(1500, 2);
            lblLineaSuperior.TabIndex = 7;
            // 
            // lblReloj
            // 
            lblReloj.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblReloj.Font = new Font("Segoe UI", 10F);
            lblReloj.ForeColor = Color.FromArgb(71, 85, 105);
            lblReloj.Location = new Point(937, 26);
            lblReloj.Margin = new Padding(4, 0, 4, 0);
            lblReloj.Name = "lblReloj";
            lblReloj.Size = new Size(435, 36);
            lblReloj.TabIndex = 6;
            lblReloj.Text = "--/--/---- --:--:--";
            lblReloj.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(27, 54, 93);
            label1.Location = new Point(96, 15);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(780, 54);
            label1.TabIndex = 5;
            label1.Text = "Sistema de gestión académica";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnMenuToggle
            // 
            btnMenuToggle.BackColor = Color.White;
            btnMenuToggle.Cursor = Cursors.Hand;
            btnMenuToggle.FlatAppearance.BorderSize = 0;
            btnMenuToggle.FlatAppearance.MouseOverBackColor = Color.FromArgb(241, 245, 249);
            btnMenuToggle.FlatStyle = FlatStyle.Flat;
            btnMenuToggle.Font = new Font("Segoe MDL2 Assets", 14F);
            btnMenuToggle.ForeColor = Color.FromArgb(27, 54, 93);
            btnMenuToggle.Location = new Point(15, 12);
            btnMenuToggle.Margin = new Padding(4, 4, 4, 4);
            btnMenuToggle.Name = "btnMenuToggle";
            btnMenuToggle.Size = new Size(66, 60);
            btnMenuToggle.TabIndex = 0;
            btnMenuToggle.Text = "";
            btnMenuToggle.UseVisualStyleBackColor = false;
            btnMenuToggle.Click += BtnMenuToggle_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(27, 54, 93);
            pnlMenu.Controls.Add(btnCerrarSesion);
            pnlMenu.Controls.Add(pnlSubHerramientas);
            pnlMenu.Controls.Add(btnGrupoHerramientas);
            pnlMenu.Controls.Add(pnlSubGestion);
            pnlMenu.Controls.Add(btnGrupoGestion);
            pnlMenu.Controls.Add(lblTitulo);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 84);
            pnlMenu.Margin = new Padding(4, 4, 4, 4);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(360, 756);
            pnlMenu.TabIndex = 8;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(27, 54, 93);
            btnCerrarSesion.Cursor = Cursors.Hand;
            btnCerrarSesion.Dock = DockStyle.Bottom;
            btnCerrarSesion.FlatAppearance.BorderSize = 0;
            btnCerrarSesion.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnCerrarSesion.FlatAppearance.MouseOverBackColor = Color.FromArgb(76, 29, 29);
            btnCerrarSesion.FlatStyle = FlatStyle.Flat;
            btnCerrarSesion.Font = new Font("Segoe UI", 10F);
            btnCerrarSesion.ForeColor = Color.FromArgb(252, 165, 165);
            btnCerrarSesion.Location = new Point(0, 681);
            btnCerrarSesion.Margin = new Padding(4, 4, 4, 4);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Padding = new Padding(30, 0, 0, 0);
            btnCerrarSesion.Size = new Size(360, 75);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "Cerrar sesión";
            btnCerrarSesion.TextAlign = ContentAlignment.MiddleLeft;
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += BtnCerrarSesion_Click;
            // 
            // pnlSubHerramientas
            // 
            pnlSubHerramientas.BackColor = Color.FromArgb(21, 43, 76);
            pnlSubHerramientas.Controls.Add(btnServiciosWeb);
            pnlSubHerramientas.Controls.Add(btnEntregable6);
            pnlSubHerramientas.Controls.Add(btnProcesosSegundoPlano);
            pnlSubHerramientas.Dock = DockStyle.Top;
            pnlSubHerramientas.Location = new Point(0, 435);
            pnlSubHerramientas.Margin = new Padding(4, 4, 4, 4);
            pnlSubHerramientas.Name = "pnlSubHerramientas";
            pnlSubHerramientas.Size = new Size(360, 207);
            pnlSubHerramientas.TabIndex = 4;
            // 
            // btnServiciosWeb
            // 
            btnServiciosWeb.BackColor = Color.FromArgb(21, 43, 76);
            btnServiciosWeb.Cursor = Cursors.Hand;
            btnServiciosWeb.Dock = DockStyle.Top;
            btnServiciosWeb.FlatAppearance.BorderSize = 0;
            btnServiciosWeb.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnServiciosWeb.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnServiciosWeb.FlatStyle = FlatStyle.Flat;
            btnServiciosWeb.Font = new Font("Segoe UI", 10F);
            btnServiciosWeb.ForeColor = Color.FromArgb(203, 213, 225);
            btnServiciosWeb.Location = new Point(0, 138);
            btnServiciosWeb.Margin = new Padding(4, 4, 4, 4);
            btnServiciosWeb.Name = "btnServiciosWeb";
            btnServiciosWeb.Padding = new Padding(60, 0, 0, 0);
            btnServiciosWeb.Size = new Size(360, 69);
            btnServiciosWeb.TabIndex = 2;
            btnServiciosWeb.Text = "Servicios web";
            btnServiciosWeb.TextAlign = ContentAlignment.MiddleLeft;
            btnServiciosWeb.UseVisualStyleBackColor = false;
            btnServiciosWeb.Click += BtnServiciosWeb_Click;
            // 
            // btnEntregable6
            // 
            btnEntregable6.BackColor = Color.FromArgb(21, 43, 76);
            btnEntregable6.Cursor = Cursors.Hand;
            btnEntregable6.Dock = DockStyle.Top;
            btnEntregable6.FlatAppearance.BorderSize = 0;
            btnEntregable6.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnEntregable6.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnEntregable6.FlatStyle = FlatStyle.Flat;
            btnEntregable6.Font = new Font("Segoe UI", 10F);
            btnEntregable6.ForeColor = Color.FromArgb(203, 213, 225);
            btnEntregable6.Location = new Point(0, 69);
            btnEntregable6.Margin = new Padding(4, 4, 4, 4);
            btnEntregable6.Name = "btnEntregable6";
            btnEntregable6.Padding = new Padding(60, 0, 0, 0);
            btnEntregable6.Size = new Size(360, 69);
            btnEntregable6.TabIndex = 1;
            btnEntregable6.Text = "ORM y reportes";
            btnEntregable6.TextAlign = ContentAlignment.MiddleLeft;
            btnEntregable6.UseVisualStyleBackColor = false;
            btnEntregable6.Click += BtnEntregable6_Click;
            // 
            // btnProcesosSegundoPlano
            // 
            btnProcesosSegundoPlano.BackColor = Color.FromArgb(21, 43, 76);
            btnProcesosSegundoPlano.Cursor = Cursors.Hand;
            btnProcesosSegundoPlano.Dock = DockStyle.Top;
            btnProcesosSegundoPlano.FlatAppearance.BorderSize = 0;
            btnProcesosSegundoPlano.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnProcesosSegundoPlano.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnProcesosSegundoPlano.FlatStyle = FlatStyle.Flat;
            btnProcesosSegundoPlano.Font = new Font("Segoe UI", 10F);
            btnProcesosSegundoPlano.ForeColor = Color.FromArgb(203, 213, 225);
            btnProcesosSegundoPlano.Location = new Point(0, 0);
            btnProcesosSegundoPlano.Margin = new Padding(4, 4, 4, 4);
            btnProcesosSegundoPlano.Name = "btnProcesosSegundoPlano";
            btnProcesosSegundoPlano.Padding = new Padding(60, 0, 0, 0);
            btnProcesosSegundoPlano.Size = new Size(360, 69);
            btnProcesosSegundoPlano.TabIndex = 0;
            btnProcesosSegundoPlano.Text = "Programación concurrente";
            btnProcesosSegundoPlano.TextAlign = ContentAlignment.MiddleLeft;
            btnProcesosSegundoPlano.UseVisualStyleBackColor = false;
            btnProcesosSegundoPlano.Click += BtnProcesosSegundoPlano_Click;
            // 
            // btnGrupoHerramientas
            // 
            btnGrupoHerramientas.BackColor = Color.FromArgb(36, 70, 122);
            btnGrupoHerramientas.Cursor = Cursors.Hand;
            btnGrupoHerramientas.Dock = DockStyle.Top;
            btnGrupoHerramientas.FlatAppearance.BorderSize = 0;
            btnGrupoHerramientas.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnGrupoHerramientas.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnGrupoHerramientas.FlatStyle = FlatStyle.Flat;
            btnGrupoHerramientas.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGrupoHerramientas.ForeColor = Color.White;
            btnGrupoHerramientas.Location = new Point(0, 366);
            btnGrupoHerramientas.Margin = new Padding(4, 4, 4, 4);
            btnGrupoHerramientas.Name = "btnGrupoHerramientas";
            btnGrupoHerramientas.Padding = new Padding(30, 0, 0, 0);
            btnGrupoHerramientas.Size = new Size(360, 69);
            btnGrupoHerramientas.TabIndex = 3;
            btnGrupoHerramientas.Text = "Procesos y reportes  ▾";
            btnGrupoHerramientas.TextAlign = ContentAlignment.MiddleLeft;
            btnGrupoHerramientas.UseVisualStyleBackColor = false;
            btnGrupoHerramientas.Click += BtnGrupoHerramientas_Click;
            // 
            // pnlSubGestion
            // 
            pnlSubGestion.BackColor = Color.FromArgb(21, 43, 76);
            pnlSubGestion.Controls.Add(btnCalificaciones);
            pnlSubGestion.Controls.Add(btnSesiones);
            pnlSubGestion.Controls.Add(btnEstudiantes);
            pnlSubGestion.Dock = DockStyle.Top;
            pnlSubGestion.Location = new Point(0, 159);
            pnlSubGestion.Margin = new Padding(4, 4, 4, 4);
            pnlSubGestion.Name = "pnlSubGestion";
            pnlSubGestion.Size = new Size(360, 207);
            pnlSubGestion.TabIndex = 2;
            // 
            // btnCalificaciones
            // 
            btnCalificaciones.BackColor = Color.FromArgb(21, 43, 76);
            btnCalificaciones.Cursor = Cursors.Hand;
            btnCalificaciones.Dock = DockStyle.Top;
            btnCalificaciones.FlatAppearance.BorderSize = 0;
            btnCalificaciones.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnCalificaciones.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnCalificaciones.FlatStyle = FlatStyle.Flat;
            btnCalificaciones.Font = new Font("Segoe UI", 10F);
            btnCalificaciones.ForeColor = Color.FromArgb(203, 213, 225);
            btnCalificaciones.Location = new Point(0, 138);
            btnCalificaciones.Margin = new Padding(4, 4, 4, 4);
            btnCalificaciones.Name = "btnCalificaciones";
            btnCalificaciones.Padding = new Padding(60, 0, 0, 0);
            btnCalificaciones.Size = new Size(360, 69);
            btnCalificaciones.TabIndex = 2;
            btnCalificaciones.Text = "Calificaciones";
            btnCalificaciones.TextAlign = ContentAlignment.MiddleLeft;
            btnCalificaciones.UseVisualStyleBackColor = false;
            btnCalificaciones.Click += BtnCalificaciones_Click;
            // 
            // btnSesiones
            // 
            btnSesiones.BackColor = Color.FromArgb(21, 43, 76);
            btnSesiones.Cursor = Cursors.Hand;
            btnSesiones.Dock = DockStyle.Top;
            btnSesiones.FlatAppearance.BorderSize = 0;
            btnSesiones.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnSesiones.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnSesiones.FlatStyle = FlatStyle.Flat;
            btnSesiones.Font = new Font("Segoe UI", 10F);
            btnSesiones.ForeColor = Color.FromArgb(203, 213, 225);
            btnSesiones.Location = new Point(0, 69);
            btnSesiones.Margin = new Padding(4, 4, 4, 4);
            btnSesiones.Name = "btnSesiones";
            btnSesiones.Padding = new Padding(60, 0, 0, 0);
            btnSesiones.Size = new Size(360, 69);
            btnSesiones.TabIndex = 1;
            btnSesiones.Text = "Sesiones";
            btnSesiones.TextAlign = ContentAlignment.MiddleLeft;
            btnSesiones.UseVisualStyleBackColor = false;
            btnSesiones.Click += BtnSesiones_Click;
            // 
            // btnEstudiantes
            // 
            btnEstudiantes.BackColor = Color.FromArgb(21, 43, 76);
            btnEstudiantes.Cursor = Cursors.Hand;
            btnEstudiantes.Dock = DockStyle.Top;
            btnEstudiantes.FlatAppearance.BorderSize = 0;
            btnEstudiantes.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnEstudiantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnEstudiantes.FlatStyle = FlatStyle.Flat;
            btnEstudiantes.Font = new Font("Segoe UI", 10F);
            btnEstudiantes.ForeColor = Color.FromArgb(203, 213, 225);
            btnEstudiantes.Location = new Point(0, 0);
            btnEstudiantes.Margin = new Padding(4, 4, 4, 4);
            btnEstudiantes.Name = "btnEstudiantes";
            btnEstudiantes.Padding = new Padding(60, 0, 0, 0);
            btnEstudiantes.Size = new Size(360, 69);
            btnEstudiantes.TabIndex = 0;
            btnEstudiantes.Text = "Estudiantes";
            btnEstudiantes.TextAlign = ContentAlignment.MiddleLeft;
            btnEstudiantes.UseVisualStyleBackColor = false;
            btnEstudiantes.Click += BtnEstudiantes_Click;
            // 
            // btnGrupoGestion
            // 
            btnGrupoGestion.BackColor = Color.FromArgb(36, 70, 122);
            btnGrupoGestion.Cursor = Cursors.Hand;
            btnGrupoGestion.Dock = DockStyle.Top;
            btnGrupoGestion.FlatAppearance.BorderSize = 0;
            btnGrupoGestion.FlatAppearance.MouseDownBackColor = Color.FromArgb(22, 45, 78);
            btnGrupoGestion.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 90, 155);
            btnGrupoGestion.FlatStyle = FlatStyle.Flat;
            btnGrupoGestion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGrupoGestion.ForeColor = Color.White;
            btnGrupoGestion.Location = new Point(0, 90);
            btnGrupoGestion.Margin = new Padding(4, 4, 4, 4);
            btnGrupoGestion.Name = "btnGrupoGestion";
            btnGrupoGestion.Padding = new Padding(30, 0, 0, 0);
            btnGrupoGestion.Size = new Size(360, 69);
            btnGrupoGestion.TabIndex = 1;
            btnGrupoGestion.Text = "Gestión académica  ▾";
            btnGrupoGestion.TextAlign = ContentAlignment.MiddleLeft;
            btnGrupoGestion.UseVisualStyleBackColor = false;
            btnGrupoGestion.Click += BtnGrupoGestion_Click;
            // 
            // lblTitulo
            // 
            lblTitulo.BackColor = Color.FromArgb(22, 45, 78);
            lblTitulo.Dock = DockStyle.Top;
            lblTitulo.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(0, 0);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Padding = new Padding(30, 0, 0, 0);
            lblTitulo.Size = new Size(360, 90);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Menú principal";
            lblTitulo.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(241, 245, 249);
            panel1.Controls.Add(pnlOrm);
            panel1.Controls.Add(pnlProcesos);
            panel1.Controls.Add(pnlEvaluaciones);
            panel1.Controls.Add(pnlSesiones);
            panel1.Controls.Add(pnlEstudiantes);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(360, 84);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1140, 756);
            panel1.TabIndex = 9;
            // 
            // pnlOrm
            // 
            pnlOrm.BackColor = Color.White;
            pnlOrm.Controls.Add(lblOrmAbrir);
            pnlOrm.Controls.Add(lblOrmDesc);
            pnlOrm.Controls.Add(lblOrmTitulo);
            pnlOrm.Controls.Add(lblFranjaOrm);
            pnlOrm.Cursor = Cursors.Hand;
            pnlOrm.Location = new Point(588, 447);
            pnlOrm.Margin = new Padding(4, 4, 4, 4);
            pnlOrm.Name = "pnlOrm";
            pnlOrm.Size = new Size(504, 150);
            pnlOrm.TabIndex = 6;
            pnlOrm.Click += BtnEntregable6_Click;
            // 
            // lblOrmAbrir
            // 
            lblOrmAbrir.Cursor = Cursors.Hand;
            lblOrmAbrir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblOrmAbrir.ForeColor = Color.FromArgb(190, 24, 93);
            lblOrmAbrir.Location = new Point(30, 99);
            lblOrmAbrir.Margin = new Padding(4, 0, 4, 0);
            lblOrmAbrir.Name = "lblOrmAbrir";
            lblOrmAbrir.Size = new Size(444, 33);
            lblOrmAbrir.TabIndex = 2;
            lblOrmAbrir.Text = "Abrir  →";
            lblOrmAbrir.Click += BtnEntregable6_Click;
            // 
            // lblOrmDesc
            // 
            lblOrmDesc.Cursor = Cursors.Hand;
            lblOrmDesc.Font = new Font("Segoe UI", 9.5F);
            lblOrmDesc.ForeColor = Color.FromArgb(100, 116, 139);
            lblOrmDesc.Location = new Point(30, 78);
            lblOrmDesc.Margin = new Padding(4, 0, 4, 0);
            lblOrmDesc.Name = "lblOrmDesc";
            lblOrmDesc.Size = new Size(444, 60);
            lblOrmDesc.TabIndex = 1;
            lblOrmDesc.Text = "Entity Framework Core y consultas LINQ.";
            lblOrmDesc.Click += BtnEntregable6_Click;
            // 
            // lblOrmTitulo
            // 
            lblOrmTitulo.Cursor = Cursors.Hand;
            lblOrmTitulo.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblOrmTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblOrmTitulo.Location = new Point(30, 30);
            lblOrmTitulo.Margin = new Padding(4, 0, 4, 0);
            lblOrmTitulo.Name = "lblOrmTitulo";
            lblOrmTitulo.Size = new Size(444, 42);
            lblOrmTitulo.TabIndex = 0;
            lblOrmTitulo.Text = "ORM y reportes";
            lblOrmTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblOrmTitulo.Click += BtnEntregable6_Click;
            // 
            // lblFranjaOrm
            // 
            lblFranjaOrm.BackColor = Color.FromArgb(190, 24, 93);
            lblFranjaOrm.Cursor = Cursors.Hand;
            lblFranjaOrm.Dock = DockStyle.Top;
            lblFranjaOrm.Location = new Point(0, 0);
            lblFranjaOrm.Margin = new Padding(4, 0, 4, 0);
            lblFranjaOrm.Name = "lblFranjaOrm";
            lblFranjaOrm.Size = new Size(504, 8);
            lblFranjaOrm.TabIndex = 3;
            lblFranjaOrm.Click += BtnEntregable6_Click;
            // 
            // pnlProcesos
            // 
            pnlProcesos.BackColor = Color.White;
            pnlProcesos.Controls.Add(lblProcesosAbrir);
            pnlProcesos.Controls.Add(lblProcesosDesc);
            pnlProcesos.Controls.Add(lblProcesosTitulo);
            pnlProcesos.Controls.Add(lblFranjaProcesos);
            pnlProcesos.Cursor = Cursors.Hand;
            pnlProcesos.Location = new Point(48, 447);
            pnlProcesos.Margin = new Padding(4, 4, 4, 4);
            pnlProcesos.Name = "pnlProcesos";
            pnlProcesos.Size = new Size(504, 150);
            pnlProcesos.TabIndex = 5;
            pnlProcesos.Click += BtnProcesosSegundoPlano_Click;
            // 
            // lblProcesosAbrir
            // 
            lblProcesosAbrir.Cursor = Cursors.Hand;
            lblProcesosAbrir.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblProcesosAbrir.ForeColor = Color.FromArgb(180, 83, 9);
            lblProcesosAbrir.Location = new Point(30, 99);
            lblProcesosAbrir.Margin = new Padding(4, 0, 4, 0);
            lblProcesosAbrir.Name = "lblProcesosAbrir";
            lblProcesosAbrir.Size = new Size(444, 33);
            lblProcesosAbrir.TabIndex = 2;
            lblProcesosAbrir.Text = "Abrir  →";
            lblProcesosAbrir.Click += BtnProcesosSegundoPlano_Click;
            // 
            // lblProcesosDesc
            // 
            lblProcesosDesc.Cursor = Cursors.Hand;
            lblProcesosDesc.Font = new Font("Segoe UI", 9.5F);
            lblProcesosDesc.ForeColor = Color.FromArgb(100, 116, 139);
            lblProcesosDesc.Location = new Point(30, 78);
            lblProcesosDesc.Margin = new Padding(4, 0, 4, 0);
            lblProcesosDesc.Name = "lblProcesosDesc";
            lblProcesosDesc.Size = new Size(444, 60);
            lblProcesosDesc.TabIndex = 1;
            lblProcesosDesc.Text = "Procesos en segundo plano con Task y Thread.";
            lblProcesosDesc.Click += BtnProcesosSegundoPlano_Click;
            // 
            // lblProcesosTitulo
            // 
            lblProcesosTitulo.Cursor = Cursors.Hand;
            lblProcesosTitulo.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            lblProcesosTitulo.ForeColor = Color.FromArgb(27, 54, 93);
            lblProcesosTitulo.Location = new Point(30, 30);
            lblProcesosTitulo.Margin = new Padding(4, 0, 4, 0);
            lblProcesosTitulo.Name = "lblProcesosTitulo";
            lblProcesosTitulo.Size = new Size(444, 42);
            lblProcesosTitulo.TabIndex = 0;
            lblProcesosTitulo.Text = "Programación concurrente";
            lblProcesosTitulo.TextAlign = ContentAlignment.MiddleLeft;
            lblProcesosTitulo.Click += BtnProcesosSegundoPlano_Click;
            // 
            // lblFranjaProcesos
            // 
            lblFranjaProcesos.BackColor = Color.FromArgb(180, 83, 9);
            lblFranjaProcesos.Cursor = Cursors.Hand;
            lblFranjaProcesos.Dock = DockStyle.Top;
            lblFranjaProcesos.Location = new Point(0, 0);
            lblFranjaProcesos.Margin = new Padding(4, 0, 4, 0);
            lblFranjaProcesos.Name = "lblFranjaProcesos";
            lblFranjaProcesos.Size = new Size(504, 8);
            lblFranjaProcesos.TabIndex = 3;
            lblFranjaProcesos.Click += BtnProcesosSegundoPlano_Click;
            // 
            // pnlEvaluaciones
            // 
            pnlEvaluaciones.BackColor = Color.White;
            pnlEvaluaciones.Controls.Add(lblAbrirEvaluaciones);
            pnlEvaluaciones.Controls.Add(lblDescEvaluaciones);
            pnlEvaluaciones.Controls.Add(label6);
            pnlEvaluaciones.Controls.Add(lblFranjaEvaluaciones);
            pnlEvaluaciones.Cursor = Cursors.Hand;
            pnlEvaluaciones.Location = new Point(768, 186);
            pnlEvaluaciones.Margin = new Padding(4, 4, 4, 4);
            pnlEvaluaciones.Name = "pnlEvaluaciones";
            pnlEvaluaciones.Size = new Size(324, 225);
            pnlEvaluaciones.TabIndex = 4;
            pnlEvaluaciones.Click += pnlEvaluaciones_Click;
            // 
            // lblAbrirEvaluaciones
            // 
            lblAbrirEvaluaciones.Cursor = Cursors.Hand;
            lblAbrirEvaluaciones.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAbrirEvaluaciones.ForeColor = Color.FromArgb(109, 40, 217);
            lblAbrirEvaluaciones.Location = new Point(30, 174);
            lblAbrirEvaluaciones.Margin = new Padding(4, 0, 4, 0);
            lblAbrirEvaluaciones.Name = "lblAbrirEvaluaciones";
            lblAbrirEvaluaciones.Size = new Size(264, 33);
            lblAbrirEvaluaciones.TabIndex = 2;
            lblAbrirEvaluaciones.Text = "Abrir  →";
            lblAbrirEvaluaciones.Click += pnlEvaluaciones_Click;
            // 
            // lblDescEvaluaciones
            // 
            lblDescEvaluaciones.Cursor = Cursors.Hand;
            lblDescEvaluaciones.Font = new Font("Segoe UI", 9.5F);
            lblDescEvaluaciones.ForeColor = Color.FromArgb(100, 116, 139);
            lblDescEvaluaciones.Location = new Point(30, 78);
            lblDescEvaluaciones.Margin = new Padding(4, 0, 4, 0);
            lblDescEvaluaciones.Name = "lblDescEvaluaciones";
            lblDescEvaluaciones.Size = new Size(264, 60);
            lblDescEvaluaciones.TabIndex = 1;
            lblDescEvaluaciones.Text = "Componentes y nota final de cada estudiante.";
            lblDescEvaluaciones.Click += pnlEvaluaciones_Click;
            // 
            // label6
            // 
            label6.Cursor = Cursors.Hand;
            label6.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(27, 54, 93);
            label6.Location = new Point(30, 30);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(264, 42);
            label6.TabIndex = 0;
            label6.Text = "Evaluaciones";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            label6.Click += label6_Click_1;
            // 
            // lblFranjaEvaluaciones
            // 
            lblFranjaEvaluaciones.BackColor = Color.FromArgb(109, 40, 217);
            lblFranjaEvaluaciones.Cursor = Cursors.Hand;
            lblFranjaEvaluaciones.Dock = DockStyle.Top;
            lblFranjaEvaluaciones.Location = new Point(0, 0);
            lblFranjaEvaluaciones.Margin = new Padding(4, 0, 4, 0);
            lblFranjaEvaluaciones.Name = "lblFranjaEvaluaciones";
            lblFranjaEvaluaciones.Size = new Size(324, 8);
            lblFranjaEvaluaciones.TabIndex = 3;
            lblFranjaEvaluaciones.Click += pnlEvaluaciones_Click;
            // 
            // pnlSesiones
            // 
            pnlSesiones.BackColor = Color.White;
            pnlSesiones.Controls.Add(lblAbrirSesiones);
            pnlSesiones.Controls.Add(lblDescSesiones);
            pnlSesiones.Controls.Add(label5);
            pnlSesiones.Controls.Add(lblFranjaSesiones);
            pnlSesiones.Cursor = Cursors.Hand;
            pnlSesiones.Location = new Point(408, 186);
            pnlSesiones.Margin = new Padding(4, 4, 4, 4);
            pnlSesiones.Name = "pnlSesiones";
            pnlSesiones.Size = new Size(324, 225);
            pnlSesiones.TabIndex = 3;
            pnlSesiones.Click += pnlSesiones_Click;
            // 
            // lblAbrirSesiones
            // 
            lblAbrirSesiones.Cursor = Cursors.Hand;
            lblAbrirSesiones.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAbrirSesiones.ForeColor = Color.FromArgb(15, 118, 110);
            lblAbrirSesiones.Location = new Point(30, 174);
            lblAbrirSesiones.Margin = new Padding(4, 0, 4, 0);
            lblAbrirSesiones.Name = "lblAbrirSesiones";
            lblAbrirSesiones.Size = new Size(264, 33);
            lblAbrirSesiones.TabIndex = 2;
            lblAbrirSesiones.Text = "Abrir  →";
            lblAbrirSesiones.Click += pnlSesiones_Click;
            // 
            // lblDescSesiones
            // 
            lblDescSesiones.Cursor = Cursors.Hand;
            lblDescSesiones.Font = new Font("Segoe UI", 9.5F);
            lblDescSesiones.ForeColor = Color.FromArgb(100, 116, 139);
            lblDescSesiones.Location = new Point(30, 78);
            lblDescSesiones.Margin = new Padding(4, 0, 4, 0);
            lblDescSesiones.Name = "lblDescSesiones";
            lblDescSesiones.Size = new Size(264, 60);
            lblDescSesiones.TabIndex = 1;
            lblDescSesiones.Text = "Control de asistencia por materia y profesor.";
            lblDescSesiones.Click += pnlSesiones_Click;
            // 
            // label5
            // 
            label5.Cursor = Cursors.Hand;
            label5.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(27, 54, 93);
            label5.Location = new Point(30, 30);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(264, 42);
            label5.TabIndex = 0;
            label5.Text = "Sesiones";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            label5.Click += label5_Click_1;
            // 
            // lblFranjaSesiones
            // 
            lblFranjaSesiones.BackColor = Color.FromArgb(15, 118, 110);
            lblFranjaSesiones.Cursor = Cursors.Hand;
            lblFranjaSesiones.Dock = DockStyle.Top;
            lblFranjaSesiones.Location = new Point(0, 0);
            lblFranjaSesiones.Margin = new Padding(4, 0, 4, 0);
            lblFranjaSesiones.Name = "lblFranjaSesiones";
            lblFranjaSesiones.Size = new Size(324, 8);
            lblFranjaSesiones.TabIndex = 3;
            lblFranjaSesiones.Click += pnlSesiones_Click;
            // 
            // pnlEstudiantes
            // 
            pnlEstudiantes.BackColor = Color.White;
            pnlEstudiantes.Controls.Add(lblAbrirEstudiantes);
            pnlEstudiantes.Controls.Add(lblDescEstudiantes);
            pnlEstudiantes.Controls.Add(label4);
            pnlEstudiantes.Controls.Add(lblFranjaEstudiantes);
            pnlEstudiantes.Cursor = Cursors.Hand;
            pnlEstudiantes.Location = new Point(48, 186);
            pnlEstudiantes.Margin = new Padding(4, 4, 4, 4);
            pnlEstudiantes.Name = "pnlEstudiantes";
            pnlEstudiantes.Size = new Size(324, 225);
            pnlEstudiantes.TabIndex = 2;
            pnlEstudiantes.Click += pnlEstudiantes_Click;
            pnlEstudiantes.Paint += panel2_Paint;
            // 
            // lblAbrirEstudiantes
            // 
            lblAbrirEstudiantes.Cursor = Cursors.Hand;
            lblAbrirEstudiantes.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAbrirEstudiantes.ForeColor = Color.FromArgb(42, 90, 155);
            lblAbrirEstudiantes.Location = new Point(30, 174);
            lblAbrirEstudiantes.Margin = new Padding(4, 0, 4, 0);
            lblAbrirEstudiantes.Name = "lblAbrirEstudiantes";
            lblAbrirEstudiantes.Size = new Size(264, 33);
            lblAbrirEstudiantes.TabIndex = 2;
            lblAbrirEstudiantes.Text = "Abrir  →";
            lblAbrirEstudiantes.Click += pnlEstudiantes_Click;
            // 
            // lblDescEstudiantes
            // 
            lblDescEstudiantes.Cursor = Cursors.Hand;
            lblDescEstudiantes.Font = new Font("Segoe UI", 9.5F);
            lblDescEstudiantes.ForeColor = Color.FromArgb(100, 116, 139);
            lblDescEstudiantes.Location = new Point(30, 78);
            lblDescEstudiantes.Margin = new Padding(4, 0, 4, 0);
            lblDescEstudiantes.Name = "lblDescEstudiantes";
            lblDescEstudiantes.Size = new Size(264, 60);
            lblDescEstudiantes.TabIndex = 1;
            lblDescEstudiantes.Text = "Registrar, modificar y consultar estudiantes.";
            lblDescEstudiantes.Click += pnlEstudiantes_Click;
            // 
            // label4
            // 
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Segoe UI", 12.5F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(27, 54, 93);
            label4.Location = new Point(30, 30);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(264, 42);
            label4.TabIndex = 0;
            label4.Text = "Estudiantes";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            label4.Click += label4_Click;
            // 
            // lblFranjaEstudiantes
            // 
            lblFranjaEstudiantes.BackColor = Color.FromArgb(42, 90, 155);
            lblFranjaEstudiantes.Cursor = Cursors.Hand;
            lblFranjaEstudiantes.Dock = DockStyle.Top;
            lblFranjaEstudiantes.Location = new Point(0, 0);
            lblFranjaEstudiantes.Margin = new Padding(4, 0, 4, 0);
            lblFranjaEstudiantes.Name = "lblFranjaEstudiantes";
            lblFranjaEstudiantes.Size = new Size(324, 8);
            lblFranjaEstudiantes.TabIndex = 3;
            lblFranjaEstudiantes.Click += pnlEstudiantes_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 11F);
            label3.ForeColor = Color.FromArgb(100, 116, 139);
            label3.Location = new Point(66, 90);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(1044, 39);
            label3.TabIndex = 1;
            label3.Text = "Seleccione una opción del menú para comenzar.";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(27, 54, 93);
            label2.Location = new Point(48, 39);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(1044, 66);
            label2.TabIndex = 0;
            label2.Text = "Bienvenido al Sistema de Gestión Académica";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // FormMenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(144F, 144F);
            AutoScaleMode = AutoScaleMode.Dpi;
            BackColor = Color.FromArgb(241, 245, 249);
            ClientSize = new Size(1500, 840);
            Controls.Add(panel1);
            Controls.Add(pnlMenu);
            Controls.Add(pnlSuperior);
            Margin = new Padding(4, 4, 4, 4);
            MinimumSize = new Size(1129, 692);
            Name = "FormMenuPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión académica";
            pnlSuperior.ResumeLayout(false);
            pnlMenu.ResumeLayout(false);
            pnlSubHerramientas.ResumeLayout(false);
            pnlSubGestion.ResumeLayout(false);
            panel1.ResumeLayout(false);
            pnlOrm.ResumeLayout(false);
            pnlProcesos.ResumeLayout(false);
            pnlEvaluaciones.ResumeLayout(false);
            pnlSesiones.ResumeLayout(false);
            pnlEstudiantes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSuperior;
        private Button btnMenuToggle;
        private Label label1;
        private Label lblReloj;
        private Label lblLineaSuperior;
        private Panel pnlMenu;
        private Label lblTitulo;
        private Button btnGrupoGestion;
        private Panel pnlSubGestion;
        private Button btnEstudiantes;
        private Button btnSesiones;
        private Button btnCalificaciones;
        private Button btnGrupoHerramientas;
        private Panel pnlSubHerramientas;
        private Button btnProcesosSegundoPlano;
        private Button btnEntregable6;
        private Button btnServiciosWeb;
        private Button btnCerrarSesion;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Panel pnlEstudiantes;
        private Label label4;
        private Label lblDescEstudiantes;
        private Label lblAbrirEstudiantes;
        private Label lblFranjaEstudiantes;
        private Panel pnlSesiones;
        private Label label5;
        private Label lblDescSesiones;
        private Label lblAbrirSesiones;
        private Label lblFranjaSesiones;
        private Panel pnlEvaluaciones;
        private Label label6;
        private Label lblDescEvaluaciones;
        private Label lblAbrirEvaluaciones;
        private Label lblFranjaEvaluaciones;
        private Panel pnlProcesos;
        private Label lblProcesosTitulo;
        private Label lblProcesosDesc;
        private Label lblProcesosAbrir;
        private Label lblFranjaProcesos;
        private Panel pnlOrm;
        private Label lblOrmTitulo;
        private Label lblOrmDesc;
        private Label lblOrmAbrir;
        private Label lblFranjaOrm;
    }
}
