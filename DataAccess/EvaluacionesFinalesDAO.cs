using System.Data;
using GestionAcademica.Entities;
using Microsoft.Data.SqlClient;

namespace GestionAcademica.DataAccess
{
    public class EvaluacionesFinalesDAO
    {
        public DataTable ObtenerTodos()
        {
            DataTable tabla = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            using (SqlCommand cmd = new SqlCommand("sp_EvaluacionesFinales_ObtenerTodos", cn))
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
            using (SqlCommand cmd = new SqlCommand("sp_EvaluacionesFinales_Buscar", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@texto", SqlDbType.NVarChar, 150).Value = texto ?? string.Empty;
                using (SqlDataAdapter adaptador = new SqlDataAdapter(cmd))
                    adaptador.Fill(tabla);
            }
            return tabla;
        }

        public void Insertar(EvaluacionFinal evaluacion)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_EvaluacionesFinales_Insertar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@codigo_estudiante", evaluacion.CodigoEstudiante);
                            cmd.Parameters.AddWithValue("@Asistencia", evaluacion.Asistencia);
                            cmd.Parameters.AddWithValue("@Puntos_Asistencia", evaluacion.PuntosAsistencia);
                            cmd.Parameters.AddWithValue("@Participacion", evaluacion.Participacion);
                            cmd.Parameters.AddWithValue("@Pruebas", evaluacion.Pruebas);
                            cmd.Parameters.AddWithValue("@id_materia", evaluacion.IdMateria);
                            cmd.Parameters.AddWithValue("@id_profesor", evaluacion.IdProfesor);
                            cmd.Parameters.AddWithValue("@nota_final", evaluacion.NotaFinal);
                            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = evaluacion.IdEstado;
                            cmd.Parameters.AddWithValue("@fecha_evaluacion", evaluacion.FechaEvaluacion);
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

        public void Actualizar(EvaluacionFinal evaluacion)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_EvaluacionesFinales_Actualizar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Evaluacion", evaluacion.IdEvaluacion);
                            cmd.Parameters.AddWithValue("@codigo_estudiante", evaluacion.CodigoEstudiante);
                            cmd.Parameters.AddWithValue("@Asistencia", evaluacion.Asistencia);
                            cmd.Parameters.AddWithValue("@Puntos_Asistencia", evaluacion.PuntosAsistencia);
                            cmd.Parameters.AddWithValue("@Participacion", evaluacion.Participacion);
                            cmd.Parameters.AddWithValue("@Pruebas", evaluacion.Pruebas);
                            cmd.Parameters.AddWithValue("@id_materia", evaluacion.IdMateria);
                            cmd.Parameters.AddWithValue("@id_profesor", evaluacion.IdProfesor);
                            cmd.Parameters.AddWithValue("@nota_final", evaluacion.NotaFinal);
                            cmd.Parameters.Add("@estado", SqlDbType.Int).Value = evaluacion.IdEstado;
                            cmd.Parameters.AddWithValue("@fecha_evaluacion", evaluacion.FechaEvaluacion);
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

        public void Eliminar(int idEvaluacion)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                using (SqlTransaction tx = cn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand cmd = new SqlCommand("sp_EvaluacionesFinales_Eliminar", cn, tx))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@Id_Evaluacion", idEvaluacion);
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
