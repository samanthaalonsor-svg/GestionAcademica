using GestionAcademica.Negocio;

namespace GestionAcademica.Forms
{
    public class FormRegistroUsuario : Form
    {
        private readonly UsuariosBL usuariosBL = new UsuariosBL();
        private readonly TextBox txtNombre = new();
        private readonly TextBox txtUsuario = new();
        private readonly TextBox txtContrasena = new();
        private readonly TextBox txtConfirmar = new();

        public FormRegistroUsuario()
        {
            Text = "Crear cuenta - Gestión Académica";
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            ClientSize = new Size(470, 510);
            BackColor = Color.White;
            Font = new Font("Segoe UI", 10F);

            Label titulo = new() { Text = "Crear una cuenta", Font = new Font("Segoe UI", 19F, FontStyle.Bold), ForeColor = Color.FromArgb(27, 54, 93), AutoSize = true, Location = new Point(35, 22) };
            Label subtitulo = new() { Text = "Complete los datos para registrar un usuario nuevo.", ForeColor = Color.FromArgb(100, 116, 139), AutoSize = true, Location = new Point(38, 66) };
            Controls.Add(titulo); Controls.Add(subtitulo);

            AgregarCampo("Nombre completo", txtNombre, 110, false);
            AgregarCampo("Nombre de usuario", txtUsuario, 190, false);
            AgregarCampo("Contraseña", txtContrasena, 270, true);
            AgregarCampo("Confirmar contraseña", txtConfirmar, 350, true);
            Label ayuda = new() { Text = "Mínimo 10 caracteres e incluir letras y números.", ForeColor = Color.FromArgb(100, 116, 139), AutoSize = true, Location = new Point(40, 416), Font = new Font("Segoe UI", 8.5F) };
            Controls.Add(ayuda);
            Button registrar = new() { Text = "Crear cuenta", BackColor = Color.FromArgb(27, 54, 93), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Location = new Point(40, 447), Size = new Size(185, 42) };
            registrar.FlatAppearance.BorderSize = 0; registrar.Click += Registrar_Click;
            Button cancelar = new() { Text = "Cancelar", BackColor = Color.FromArgb(226, 232, 240), ForeColor = Color.FromArgb(30, 41, 59), FlatStyle = FlatStyle.Flat, Location = new Point(240, 447), Size = new Size(185, 42), DialogResult = DialogResult.Cancel };
            cancelar.FlatAppearance.BorderSize = 0;
            Controls.Add(registrar); Controls.Add(cancelar);
            AcceptButton = registrar; CancelButton = cancelar;
        }

        private void AgregarCampo(string texto, TextBox caja, int y, bool secreto)
        {
            Controls.Add(new Label { Text = texto, Location = new Point(40, y), Size = new Size(385, 22), ForeColor = Color.FromArgb(71, 85, 105) });
            caja.Location = new Point(40, y + 25); caja.Size = new Size(385, 30); caja.MaxLength = secreto ? 128 : 150;
            caja.Font = new Font("Segoe UI", 11F); caja.UseSystemPasswordChar = secreto;
            Controls.Add(caja);
        }

        private void InitializeComponent()
        {

        }

        private void Registrar_Click(object? sender, EventArgs e)
        {
            try
            {
                usuariosBL.Registrar(txtNombre.Text, txtUsuario.Text, txtContrasena.Text, txtConfirmar.Text);
                MessageBox.Show("La cuenta se creó correctamente. Ya puede iniciar sesión.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Revise los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo registrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar la cuenta. Verifique la conexión con SQL Server y que se haya ejecutado el script de actualización de seguridad.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
