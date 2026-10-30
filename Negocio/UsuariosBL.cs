using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using GestionAcademica.DataAccess;
using GestionAcademica.Entities;

namespace GestionAcademica.Negocio
{
    public class UsuariosBL
    {
        private readonly UsuariosDAO usuariosDAO = new UsuariosDAO();
        private const int Iteraciones = 210_000;

        public Usuario? Autenticar(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrEmpty(contrasena)) return null;
            Usuario? usuario = usuariosDAO.ObtenerPorNombreUsuario(nombreUsuario.Trim());
            if (usuario == null || !VerificarContrasena(contrasena, usuario.ContrasenaHash)) return null;
            usuario.ContrasenaHash = string.Empty;
            return usuario;
        }

        public void Registrar(string nombreCompleto, string nombreUsuario, string contrasena, string confirmarContrasena)
        {
            nombreCompleto = (nombreCompleto ?? string.Empty).Trim();
            nombreUsuario = (nombreUsuario ?? string.Empty).Trim();
            if (nombreCompleto.Length < 3 || nombreCompleto.Length > 100 || nombreCompleto.Any(char.IsControl))
                throw new ArgumentException("El nombre completo debe tener entre 3 y 100 caracteres.");
            if (!Regex.IsMatch(nombreUsuario, @"\A[a-zA-Z0-9._-]{4,50}\z"))
                throw new ArgumentException("El usuario debe tener entre 4 y 50 caracteres y solo puede usar letras, números, punto, guion o guion bajo.");
            if (contrasena.Length < 10 || contrasena.Length > 128 || !contrasena.Any(char.IsLetter) || !contrasena.Any(char.IsDigit))
                throw new ArgumentException("La contraseña debe tener al menos 10 caracteres e incluir letras y números.");
            if (contrasena != confirmarContrasena)
                throw new ArgumentException("Las contraseñas no coinciden.");

            string hash = CrearHash(contrasena);
            if (!usuariosDAO.Registrar(nombreUsuario, nombreCompleto, hash))
                throw new InvalidOperationException("Ese nombre de usuario ya existe. Elegí otro.");
        }

        private static string CrearHash(string contrasena)
        {
            byte[] salt = RandomNumberGenerator.GetBytes(16);
            byte[] hash = Rfc2898DeriveBytes.Pbkdf2(contrasena, salt, Iteraciones, HashAlgorithmName.SHA256, 32);
            return $"PBKDF2${Iteraciones}${Convert.ToBase64String(salt)}${Convert.ToBase64String(hash)}";
        }

        private static bool VerificarContrasena(string contrasena, string hashGuardado)
        {
            
            if (!hashGuardado.StartsWith("PBKDF2$", StringComparison.Ordinal))
            {
                byte[] actual = SHA256.HashData(Encoding.UTF8.GetBytes(contrasena));
                string hexadecimal = Convert.ToHexString(actual);
                return CryptographicOperations.FixedTimeEquals(
                    Encoding.ASCII.GetBytes(hexadecimal), Encoding.ASCII.GetBytes(hashGuardado.Trim()));
            }
            try
            {
                string[] partes = hashGuardado.Split('$');
                if (partes.Length != 4 || !int.TryParse(partes[1], out int iteraciones) || iteraciones < 100_000) return false;
                byte[] salt = Convert.FromBase64String(partes[2]);
                byte[] esperado = Convert.FromBase64String(partes[3]);
                byte[] actual = Rfc2898DeriveBytes.Pbkdf2(contrasena, salt, iteraciones, HashAlgorithmName.SHA256, esperado.Length);
                return CryptographicOperations.FixedTimeEquals(actual, esperado);
            }
            catch (FormatException) { return false; }
        }
    }
}
