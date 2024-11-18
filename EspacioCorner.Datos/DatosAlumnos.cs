using EspacioCorner.Entidades;
using System;
using System.Data.SqlClient;

namespace EspacioCorner.Datos
{
	public class DatosAlumnos : DatosConexionDB
	{
		public int AgregarAlumno(string nombreApellido, int dni, string numPersonal, string numPadreTutor, string numMadreTutor, DateTime fechaCumple, bool fichaMedica, EstadoAlumno estado)
		{
			string query = "INSERT INTO Alumnos (Nombre_Apellido, DNI, NumPersonal, NumPadre_Tutor, NumMadre_Tutor, FechaCumple, FichaMedica, Estado) VALUES (@NombreApellido, @DNI, @NumPersonal, @NumPadreTutor, @NumMadreTutor, @FechaCumple, @FichaMedica, @Estado)";
			SqlCommand cmd = new SqlCommand(query, conexion);

			cmd.Parameters.AddWithValue("@NombreApellido", nombreApellido);
			cmd.Parameters.AddWithValue("@DNI", dni);
			cmd.Parameters.AddWithValue("@NumPersonal", numPersonal);
			cmd.Parameters.AddWithValue("@NumPadreTutor", numPadreTutor);
			cmd.Parameters.AddWithValue("@NumMadreTutor", numMadreTutor);
			cmd.Parameters.AddWithValue("@FechaCumple", fechaCumple);
			cmd.Parameters.AddWithValue("@FichaMedica", fichaMedica ? "SI" : "NO");
			cmd.Parameters.AddWithValue("@Estado", estado.ToString());

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
