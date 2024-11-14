using System;
using System.Data.SqlClient;

namespace EspacioCorner.Datos
{
    public class DatosAsistencia : DatosConexionDB
    {
        public int RegistrarAsistencia(int idAlumno, int idDeporte, bool asistParcial)
        {
            string query = "INSERT INTO Asistencia (Id_Alumno, Id_Deporte, Asist_Parcial) VALUES (@IdAlumno, @IdDeporte, @AsistParcial)";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);
            cmd.Parameters.AddWithValue("@IdDeporte", idDeporte);
            cmd.Parameters.AddWithValue("@AsistParcial", asistParcial);

            try
            {
                AbrirConexion();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al registrar asistencia", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }

        public SqlDataReader ObtenerAsistencias()
        {
            string query = "SELECT A.Nombre_Apellido, D.NombreDep, ASIS.Asist_Parcial FROM Asistencia ASIS JOIN Alumnos A ON ASIS.Id_Alumno = A.Id_Alumno JOIN Deporte D ON ASIS.Id_Deporte = D.Id_Deporte";
            SqlCommand cmd = new SqlCommand(query, conexion);

            try
            {
                AbrirConexion();
                return cmd.ExecuteReader();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener asistencias", e);
            }
        }

        public int ObtenerTotalAsistencias(int idAlumno, int idDeporte)
        {
            string query = "SELECT COUNT(*) FROM Asistencia WHERE Id_Alumno = @IdAlumno AND Id_Deporte = @IdDeporte";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);
            cmd.Parameters.AddWithValue("@IdDeporte", idDeporte);

            try
            {
                AbrirConexion();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener total de asistencias", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }

        public int ObtenerAsistenciasParciales(int idAlumno, int idDeporte)
        {
            string query = "SELECT COUNT(*) FROM Asistencia WHERE Id_Alumno = @IdAlumno AND Id_Deporte = @IdDeporte AND Asist_Parcial = 1";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);
            cmd.Parameters.AddWithValue("@IdDeporte", idDeporte);

            try
            {
                AbrirConexion();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener asistencias parciales", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
