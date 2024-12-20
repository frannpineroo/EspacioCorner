﻿using System;
using System.Collections.Generic;
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

        public List<string> ObtenerDeportes()
        {
            string query = "SELECT NombreDep FROM Deporte";
            SqlCommand cmd = new SqlCommand(query, conexion);
            List<string> deportes = new List<string>();

            try
            {
                AbrirConexion();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    deportes.Add(reader["NombreDep"].ToString());
                }
                return deportes;
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener deportes", e);
            }
            finally
            {
                CerrarConexion();
                cmd.Dispose();
            }
        }
    }
}
