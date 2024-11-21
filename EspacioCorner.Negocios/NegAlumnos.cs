using System;
using System.Collections.Generic;
using EspacioCorner.Datos;
using EspacioCorner.Entidades;

namespace EspacioCorner.Negocios
{
    public class NegAlumnos
    {
        private DatosAlumnos datosAlumnos = new DatosAlumnos();

        public (int, string) AgregarAlumno(string nombreApellido, int dni, string numPersonal, string numPadreTutor, string numMadreTutor, DateTime fechaCumple, bool fichaMedica, EstadoAlumno estado, List<int> deportes)
        {
            string advertencia = ValidarFechaCumple(fechaCumple);

            try
            {
                int idAlumno = datosAlumnos.AgregarAlumno(nombreApellido, dni, numPersonal, numPadreTutor, numMadreTutor, fechaCumple, fichaMedica, estado);

                // Agregar registros en Asistencia para los deportes seleccionados
                foreach (int idDeporte in deportes)
                {
                    datosAlumnos.AgregarAsistencia(idAlumno, idDeporte);
                }

                return (idAlumno, advertencia);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la capa de negocios al agregar alumno: " + e.Message);
                throw new Exception("Error en la capa de negocios al agregar alumno", e);
            }
        }

        public string ValidarFechaCumple(DateTime fechaCumple)
        {
            if (fechaCumple > DateTime.Now)
            {
                return "La fecha de cumpleaños no puede ser superior a la fecha actual.";
            }

            int edad = DateTime.Now.Year - fechaCumple.Year;
            if (fechaCumple.Date > DateTime.Now.AddYears(-edad)) edad--;

            if (edad > 18)
            {
                return "Advertencia: El alumno tiene más de 18 años.";
            }

            return string.Empty;
        }

        public List<Alumno> ObtenerAlumnosPorDeporte(string deporte)
        {
            try
            {
                return datosAlumnos.ObtenerAlumnosPorDeporte(deporte);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al obtener alumnos por deporte", e);
            }
        }

        public int ObtenerIdDeportePorNombre(string nombreDeporte)
        {
            return datosAlumnos.ObtenerIdDeportePorNombre(nombreDeporte);
        }
    }
}
