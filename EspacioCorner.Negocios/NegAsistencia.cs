using System;
using System.Data.SqlClient;
using EspacioCorner.Datos;

namespace EspacioCorner.Negocios
{
    public class NegAsistencia
    {
        private DatosAsistencia datosAsistencia = new DatosAsistencia();

        public int RegistrarAsistencia(int idAlumno, int idDeporte, bool asistParcial)
        {
            try
            {
                return datosAsistencia.RegistrarAsistencia(idAlumno, idDeporte, asistParcial);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al registrar asistencia", e);
            }
        }

        public SqlDataReader ObtenerAsistencias()
        {
            try
            {
                return datosAsistencia.ObtenerAsistencias();
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al obtener asistencias", e);
            }
        }

        public double CalcularPorcentajeAsistencia(int idAlumno, int idDeporte)
        {
            try
            {
                int total = datosAsistencia.ObtenerTotalAsistencias(idAlumno, idDeporte);
                int asistio = datosAsistencia.ObtenerAsistenciasParciales(idAlumno, idDeporte);

                if (total == 0) return 0;

                return (double)asistio / total * 100;
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al calcular porcentaje de asistencia", e);
            }
        }
    }
}
