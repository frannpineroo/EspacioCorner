using System;
using System.Data.SqlClient;

namespace EspacioCorner.Datos
{
    public class DatosAlumnos : DatosConexionDB
    {
        public int AgregarAlumno(string nombreApellido, string numPadreTutor, string numMadreTutor, DateTime fechaCumple)
        {
            string query = "INSERT INTO Alumnos (Nombre_Apellido, NumPadre_Tutor, NumMadre_Tutor, FechaCumple) VALUES (@NombreApellido, @NumPadreTutor, @NumMadreTutor, @FechaCumple)";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@NombreApellido", nombreApellido);
            cmd.Parameters.AddWithValue("@NumPadreTutor", numPadreTutor);
            cmd.Parameters.AddWithValue("@NumMadreTutor", numMadreTutor);
            cmd.Parameters.AddWithValue("@FechaCumple", fechaCumple);

            try
            {
                AbrirConexion();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al agregar alumno", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
