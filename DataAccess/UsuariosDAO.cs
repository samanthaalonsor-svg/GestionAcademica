using System.Data;
using GestionAcademica.Entities;
using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public class UsuariosDAO
    {
        public Usuario? ValidarCredenciales(string nombreUsuario, string contrasenaHash)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Usuarios_ValidarCredenciales", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreUsuario", nombreUsuario);
                cmd.Parameters.AddWithValue("@ContrasenaHash", contrasenaHash);

                cn.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                {
                    if (lector.Read())
                    {
                        return new Usuario
                        {
                            IdUsuario = Convert.ToInt32(lector["IdUsuario"]),
                            NombreUsuario = lector["NombreUsuario"].ToString() ?? string.Empty,
                            NombreCompleto = lector["NombreCompleto"].ToString() ?? string.Empty
                        };
                    }
                }
            }

            return null;
        }
    }
}
