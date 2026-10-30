using System.Data;
using GestionAcademica.Entities;
using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public class UsuariosDAO
    {
        public Usuario? ObtenerPorNombreUsuario(string nombreUsuario)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new SqlCommand(
                "SELECT IdUsuario, NombreUsuario, NombreCompleto, ContrasenaHash FROM dbo.Usuarios WHERE NombreUsuario = @NombreUsuario AND Activo = 1;", cn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;
            cn.Open();
            using SqlDataReader lector = cmd.ExecuteReader();
            if (!lector.Read()) return null;
            return new Usuario
            {
                IdUsuario = Convert.ToInt32(lector["IdUsuario"]),
                NombreUsuario = lector["NombreUsuario"].ToString() ?? string.Empty,
                NombreCompleto = lector["NombreCompleto"].ToString() ?? string.Empty,
                ContrasenaHash = lector["ContrasenaHash"].ToString() ?? string.Empty
            };
        }

        public bool Registrar(string nombreUsuario, string nombreCompleto, string hashContrasena)
        {
            using SqlConnection cn = Conexion.ObtenerConexion();
            using SqlCommand cmd = new SqlCommand(@"
                INSERT INTO dbo.Usuarios (NombreUsuario, ContrasenaHash, NombreCompleto, Activo)
                SELECT @NombreUsuario, @ContrasenaHash, @NombreCompleto, 1
                WHERE NOT EXISTS (SELECT 1 FROM dbo.Usuarios WHERE NombreUsuario = @NombreUsuario);", cn);
            cmd.Parameters.Add("@NombreUsuario", SqlDbType.NVarChar, 50).Value = nombreUsuario;
            cmd.Parameters.Add("@ContrasenaHash", SqlDbType.NVarChar, 256).Value = hashContrasena;
            cmd.Parameters.Add("@NombreCompleto", SqlDbType.NVarChar, 100).Value = nombreCompleto;
            cn.Open();
            try { return cmd.ExecuteNonQuery() == 1; }
            catch (SqlException ex) when (ex.Number == 2601 || ex.Number == 2627) { return false; }
        }
    }
}
