namespace GestionAcademica.Forms
{
    public partial class FormMenuPrincipal : Form
    {
        public FormMenuPrincipal()
        {
            InitializeComponent();
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

        private void BtnCerrarSesion_Click(object sender, EventArgs e)
        {
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
