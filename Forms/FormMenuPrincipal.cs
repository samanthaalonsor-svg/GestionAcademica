namespace GestionAcademica.Forms
{
    public partial class FormMenuPrincipal : Form
    {
        
        private CancellationTokenSource cancelacionReloj;
        private bool cerrandoSesion;

        public FormMenuPrincipal()
        {
            InitializeComponent();
        }
        private const int AnchoMenu = 240;
        private readonly System.Windows.Forms.Timer tmrMenu = new System.Windows.Forms.Timer { Interval = 12 };
        private int anchoMenuObjetivo = AnchoMenu;

        
        private static void AlternarGrupo(Panel submenu, Button encabezado, string titulo)
        {
            submenu.Visible = !submenu.Visible;
            encabezado.Text = titulo + (submenu.Visible ? "  \u25BE" : "  \u25B8");
        }

        private void BtnGrupoGestion_Click(object sender, EventArgs e)
        {
            AlternarGrupo(pnlSubGestion, btnGrupoGestion, "Gestión académica");
        }

        private void BtnGrupoHerramientas_Click(object sender, EventArgs e)
        {
            AlternarGrupo(pnlSubHerramientas, btnGrupoHerramientas, "Procesos y reportes");
        }
        private void BtnMenuToggle_Click(object sender, EventArgs e)
        {
            anchoMenuObjetivo = pnlMenu.Width > 0 ? 0 : AnchoMenu;
            tmrMenu.Tick -= TmrMenu_Tick;
            tmrMenu.Tick += TmrMenu_Tick;
            tmrMenu.Start();
        }

        private void TmrMenu_Tick(object sender, EventArgs e)
        {
            const int paso = 40;
            int ancho = pnlMenu.Width;

            if (ancho < anchoMenuObjetivo)
                ancho = Math.Min(ancho + paso, anchoMenuObjetivo);
            else
                ancho = Math.Max(ancho - paso, anchoMenuObjetivo);

            pnlMenu.Width = ancho;

            if (ancho == anchoMenuObjetivo)
                tmrMenu.Stop();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            IniciarReloj();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            cancelacionReloj?.Cancel();
            base.OnFormClosed(e);

            if (!cerrandoSesion)
                Application.Exit();
        }

        private void IniciarReloj()
        {
            cancelacionReloj = new CancellationTokenSource();
            CancellationToken token = cancelacionReloj.Token;

            Task.Run(async () =>
            {
                while (!token.IsCancellationRequested)
                {
                    string hora = DateTime.Now.ToString("ddd dd/MM/yyyy  HH:mm:ss");

                    try
                    {
                        BeginInvoke(new Action(() => lblReloj.Text = hora));
                        await Task.Delay(1000, token);
                    }
                    catch (OperationCanceledException)
                    {
                        break;
                    }
                    catch (InvalidOperationException)
                    {
                        
                        break;
                    }
                }
            }, token);
        }

        private void BtnEstudiantes_Click(object sender, EventArgs e)
        {
            new FormEstudiantes().Show();
        }

        private void BtnSesiones_Click(object sender, EventArgs e)
        {
            new FormAsistencias().Show();
        }

        private void BtnCalificaciones_Click(object sender, EventArgs e)
        {
            new FormEvaluacionesFinales().Show();
        }

        private void BtnProcesosSegundoPlano_Click(object sender, EventArgs e)
        {
            new FormProcesosSegundoPlano().Show();
        }

        private void BtnEntregable6_Click(object sender, EventArgs e)
        {
            new FormORM().Show();
        }

        private void BtnServiciosWeb_Click(object sender, EventArgs e)
        {
            new FormServiciosWeb().Show();
        }

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
            cerrandoSesion = true;
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlEstudiantes_Click(object sender, EventArgs e)
        {
            BtnEstudiantes_Click(sender, e);
        }

        private void pnlSesiones_Click(object sender, EventArgs e)
        {
            BtnSesiones_Click(sender, e);
        }

        private void pnlEvaluaciones_Click(object sender, EventArgs e)
        {
            BtnCalificaciones_Click(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            BtnEstudiantes_Click(sender, e);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            BtnSesiones_Click(sender, e);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            BtnCalificaciones_Click(sender, e);
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
            BtnSesiones_Click(sender, e);
        }

        private void label6_Click_1(object sender, EventArgs e)
        {
            BtnCalificaciones_Click(sender, e);
        }
    }
}
