using System.Security.Cryptography;
using System.Text;
using GestionAcademica.DataAccess;
using GestionAcademica.Entities;

namespace GestionAcademica.Negocio
{   
    public class UsuariosBL
    {
        private readonly UsuariosDAO usuariosDAO = new UsuariosDAO();
        public Usuario? Autenticar(string nombreUsuario, string contrasena)
        {
            if (string.IsNullOrWhiteSpace(nombreUsuario) || string.IsNullOrWhiteSpace(contrasena))
                return null;

            string hash = CalcularHash(contrasena);
            return usuariosDAO.ValidarCredenciales(nombreUsuario.Trim(), hash);
        }

        private static string CalcularHash(string texto)
        {
            byte[] bytes = SHA256.HashData(Encoding.UTF8.GetBytes(texto));
            StringBuilder sb = new StringBuilder(bytes.Length * 2);
            foreach (byte b in bytes)
                sb.Append(b.ToString("X2"));
            return sb.ToString();
        }
    }
}
