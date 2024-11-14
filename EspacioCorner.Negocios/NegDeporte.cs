using System;
using System.Collections.Generic;
using EspacioCorner.Datos;

namespace EspacioCorner.Negocios
{
    public class NegDeporte
    {
        private DatosDeporte datosDeporte = new DatosDeporte();

        public int AgregarDeporte(string nombreDep)
        {
            try
            {
                return datosDeporte.AgregarDeporte(nombreDep);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al agregar deporte", e);
            }
        }

        public List<string> ObtenerDeportes()
        {
            try
            {
                return datosDeporte.ObtenerDeportes();
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al obtener deportes", e);
            }
        }
    }
}
