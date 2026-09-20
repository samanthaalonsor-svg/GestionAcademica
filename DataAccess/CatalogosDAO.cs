using System.Data;
using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public class CatalogosDAO
    {
        private DataTable EjecutarSpSinParametros(string nombreSp)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand(nombreSp, cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }
            return tabla;
        }

        public DataTable ObtenerEstados() => EjecutarSpSinParametros("sp_Estados_ObtenerTodos");

        public DataTable ObtenerNiveles() => EjecutarSpSinParametros("sp_Niveles_ObtenerTodos");

        public DataTable ObtenerMaterias() => EjecutarSpSinParametros("sp_Materias_ObtenerTodos");

        public DataTable ObtenerProfesores() => EjecutarSpSinParametros("sp_Profesores_ObtenerTodos");

        public DataTable ObtenerEstudiantesParaCombo() => EjecutarSpSinParametros("sp_Estudiantes_ObtenerParaCombo");
    }
}
