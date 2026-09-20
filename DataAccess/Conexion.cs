using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public static class Conexion
    {
        
        private static readonly string cadenaConexion =
            @"Server=localhost\SQLEXPRESS;Database=Gestion Academica;Trusted_Connection=True;TrustServerCertificate=True;";

        public static string ObtenerCadenaConexion() => cadenaConexion;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}
