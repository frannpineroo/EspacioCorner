using System;
using System.Data.SqlClient;

namespace EspacioCorner.Datos
{
    public class DatosDeporte : DatosConexionDB
    {
        public int AgregarDeporte(string nombreDep)
        {
            string query = "INSERT INTO Deporte (NombreDep) VALUES (@NombreDep)";
            SqlCommand cmd = new SqlCommand(query, conexion);

            cmd.Parameters.AddWithValue("@NombreDep", nombreDep);

            try
            {
                AbrirConexion();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception("Error al agregar deporte", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
