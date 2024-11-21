using EspacioCorner.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EspacioCorner.Datos
{
    public class DatosAlumnos : DatosConexionDB
    {
        public int AgregarAlumno(string nombreApellido, int dni, string numPersonal, string numPadreTutor, string numMadreTutor, DateTime fechaCumple, bool fichaMedica, EstadoAlumno estadoAlumno)
        {
            string query = "INSERT INTO Alumnos (Nombre_Apellido, DNI, NumPersonal, NumPadre_Tutor, NumMadre_Tutor, FechaCumple, FichaMedica, Estado) VALUES (@NombreApellido, @DNI, @NumPersonal, @NumPadreTutor, @NumMadreTutor, @FechaCumple, @FichaMedica, @Estado); SELECT SCOPE_IDENTITY();";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@NombreApellido", nombreApellido);
            cmd.Parameters.AddWithValue("@DNI", dni);
            cmd.Parameters.AddWithValue("@NumPersonal", numPersonal);
            cmd.Parameters.AddWithValue("@NumPadreTutor", numPadreTutor);
            cmd.Parameters.AddWithValue("@NumMadreTutor", numMadreTutor);
            cmd.Parameters.AddWithValue("@FechaCumple", fechaCumple);
            cmd.Parameters.AddWithValue("@FichaMedica", fichaMedica ? "SI" : "NO");
            cmd.Parameters.AddWithValue("@Estado", estadoAlumno.ToString());

            try
            {
                AbrirConexion();
                int idAlumno = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine("Alumno agregado correctamente. ID: " + idAlumno);
                return idAlumno;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al agregar alumno: " + e.Message);
                throw new Exception("Error al agregar alumno", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }

        public void AgregarAsistencia(int idAlumno, int idDeporte)
        {
            string query = "INSERT INTO Asistencia (Id_Alumno, Id_Deporte, Asist_Parcial) VALUES (@IdAlumno, @IdDeporte, 0)";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@IdAlumno", idAlumno);
            cmd.Parameters.AddWithValue("@IdDeporte", idDeporte);

            try
            {
                AbrirConexion();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Asistencia agregada correctamente.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al agregar asistencia: " + e.Message);
                throw new Exception("Error al agregar asistencia", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }

        public List<Alumno> ObtenerAlumnosPorDeporte(string deporte)
        {
            List<Alumno> alumnos = new List<Alumno>();
            string query = @"
                SELECT a.* 
                FROM Alumnos a
                JOIN Asistencia asis ON a.Id_Alumno = asis.Id_Alumno
                JOIN Deporte d ON asis.Id_Deporte = d.Id_Deporte
                WHERE d.NombreDep = @Deporte";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@Deporte", deporte);

            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Alumno alumno = new Alumno
                    {
                        id_Alumno = reader.GetInt32(0),
                        nombre_Apellido = reader.GetString(1),
                        dNI = reader.GetInt32(2),
                        numPersonal = reader.GetString(3),
                        numPadre_Tutor = reader.GetString(4),
                        numMadre_Tutor = reader.GetString(5),
                        fechaCumple = reader.GetDateTime(6),
                        fichaMedica = reader.GetString(7) == "SI",
                        estado = (EstadoAlumno)Enum.Parse(typeof(EstadoAlumno), reader.GetString(8))
                    };
                    alumnos.Add(alumno);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener alumnos por deporte", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }

            return alumnos;
        }

        public int ObtenerIdDeportePorNombre(string nombreDeporte)
        {
            string query = "SELECT Id_Deporte FROM Deporte WHERE NombreDep = @NombreDep";
            SqlCommand cmd = new SqlCommand(query, conexion);
            cmd.Parameters.AddWithValue("@NombreDep", nombreDeporte);

            try
            {
                AbrirConexion();
                return (int)cmd.ExecuteScalar();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al obtener el ID del deporte: " + e.Message);
                throw new Exception("Error al obtener el ID del deporte", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
