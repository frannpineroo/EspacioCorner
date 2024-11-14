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

        public double CalcularPorcentajeAsistencia(int idAlumno, int idDeporte)
        {
            string queryTotal = "SELECT COUNT(*) FROM Asistencia WHERE Id_Alumno = @IdAlumno AND Id_Deporte = @IdDeporte";
            string queryAsistio = "SELECT COUNT(*) FROM Asistencia WHERE Id_Alumno = @IdAlumno AND Id_Deporte = @IdDeporte AND Asist_Parcial = 1";

            SqlCommand cmdTotal = new SqlCommand(queryTotal, conexion);
            SqlCommand cmdAsistio = new SqlCommand(queryAsistio, conexion);

            cmdTotal.Parameters.AddWithValue("@IdAlumno", idAlumno);
            cmdTotal.Parameters.AddWithValue("@IdDeporte", idDeporte);
            cmdAsistio.Parameters.AddWithValue("@IdAlumno", idAlumno);
            cmdAsistio.Parameters.AddWithValue("@IdDeporte", idDeporte);

            try
            {
                AbrirConexion();
                int total = (int)cmdTotal.ExecuteScalar();
                int asistio = (int)cmdAsistio.ExecuteScalar();

                if (total == 0) return 0;

                return (double)asistio / total * 100;
            }
            catch (Exception e)
            {
                throw new Exception("Error al calcular porcentaje de asistencia", e);
            }
            finally
            {
                CerrarConexion();
                cmdTotal.Dispose();
                cmdAsistio.Dispose();
            }
        }
    }
}
