using System.Data;
using GestionAcademica.Entities;
using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public class AsistenciasDAO
    {
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Asistencias_ObtenerTodos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }

            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Asistencias_Buscar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@texto", SqlDbType.NVarChar, 150).Value = texto ?? string.Empty;
                using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    adaptador.Fill(tabla);
            }
            return tabla;
        }

        public void Insertar(Asistencia asistencia)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Asistencias_Insertar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@codigo_estudiante", asistencia.CodigoEstudiante);
                            cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                            cmd.Parameters.AddWithValue("@Id_Nivel", asistencia.IdNivel);
                            cmd.Parameters.AddWithValue("@Id_Materia", asistencia.IdMateria);
                            cmd.Parameters.AddWithValue("@Id_Profesor", asistencia.IdProfesor);
                            cmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Actualizar(Asistencia asistencia)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Asistencias_Actualizar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_asistencia", asistencia.IdAsistencia);
                            cmd.Parameters.AddWithValue("@codigo_estudiante", asistencia.CodigoEstudiante);
                            cmd.Parameters.AddWithValue("@Fecha", asistencia.Fecha);
                            cmd.Parameters.AddWithValue("@Id_Nivel", asistencia.IdNivel);
                            cmd.Parameters.AddWithValue("@Id_Materia", asistencia.IdMateria);
                            cmd.Parameters.AddWithValue("@Id_Profesor", asistencia.IdProfesor);
                            cmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }

        public void Eliminar(int idAsistencia)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Asistencias_Eliminar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@id_asistencia", idAsistencia);
                            cmd.ExecuteNonQuery();
                        }
                        tx.Commit();
                    }
                    catch
                    {
                        tx.Rollback();
                        throw;
                    }
                }
            }
        }
    }
}
