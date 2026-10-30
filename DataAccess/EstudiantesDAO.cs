using System.Data;
using GestionAcademica.Entities;
using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public class EstudiantesDAO
    {
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Estudiantes_ObtenerTodos", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                    tabla.Load(lector);
            }

            return tabla;
        }

        public DataTable Buscar(string texto)
        {
            DataTable tabla = new DataTable();
            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_Estudiantes_Buscar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@texto", SqlDbType.NVarChar, 150).Value = texto ?? string.Empty;
                cn.Open();
                using (SqlDataReader lector = cmd.ExecuteReader())
                    tabla.Load(lector);
            }
            return tabla;
        }

        public void Insertar(Estudiante estudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Estudiantes_Insertar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@codigo_estudiante", estudiante.CodigoEstudiante);
                            cmd.Parameters.AddWithValue("@Alumno", estudiante.Alumno);
                            cmd.Parameters.AddWithValue("@id_estado", estudiante.IdEstado);
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

        public void Actualizar(Estudiante estudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Estudiantes_Actualizar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@codigo_estudiante", estudiante.CodigoEstudiante);
                            cmd.Parameters.AddWithValue("@Alumno", estudiante.Alumno);
                            cmd.Parameters.AddWithValue("@id_estado", estudiante.IdEstado);
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

        public void Eliminar(string codigoEstudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_Estudiantes_Eliminar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@codigo_estudiante", codigoEstudiante);
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

        
        public void EliminarConHistorial(string codigoEstudiante)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        
                        EjecutarEliminacion(cn, tx, "DELETE FROM dbo.Evaluaciones_Finales WHERE codigo_estudiante = @codigo", codigoEstudiante);
                        EjecutarEliminacion(cn, tx, "DELETE FROM dbo.Asistencias_Sesiones WHERE codigo_estudiante = @codigo", codigoEstudiante);

                      
                        using (SqlCommand cmd = new SqlCommand("sp_Estudiantes_Eliminar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@codigo_estudiante", codigoEstudiante);
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

        private static void EjecutarEliminacion(SqlConnection cn, SqlTransaction tx, string sql, string codigoEstudiante)
        {
            using (SqlCommand cmd = new SqlCommand(sql, cn, tx))
            {
                cmd.Parameters.AddWithValue("@codigo", codigoEstudiante);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
