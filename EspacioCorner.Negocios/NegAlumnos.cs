using System;
using System.Collections.Generic;
using EspacioCorner.Datos;
using EspacioCorner.Entidades;

namespace EspacioCorner.Negocios
{
    public class NegAlumnos
    {
        private DatosAlumnos datosAlumnos = new DatosAlumnos();

        public (int, string) AgregarAlumno(string nombreApellido, int dni, string numPersonal, string numPadreTutor, string numMadreTutor, DateTime fechaCumple, bool fichaMedica, EstadoAlumno estado)
        {
            string advertencia = ValidarFechaCumple(fechaCumple);

            try
            {
                int resultado = datosAlumnos.AgregarAlumno(nombreApellido, dni, numPersonal, numPadreTutor, numMadreTutor, fechaCumple, fichaMedica, estado);
                Console.WriteLine("Resultado de la inserción: " + resultado);
                return (resultado, advertencia);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la capa de negocios al agregar alumno: " + e.Message);
                throw new Exception("Error en la capa de negocios al agregar alumno", e);
            }
        }

        public string ValidarFechaCumple(DateTime fechaCumple)
        {
            // Validar que la fecha no sea superior a la fecha actual
            if (fechaCumple > DateTime.Now)
            {
                return "La fecha de cumpleaños no puede ser superior a la fecha actual.";
            }

            // Calcular la edad exacta
            int edad = DateTime.Now.Year - fechaCumple.Year;
            if (fechaCumple.Date > DateTime.Now.AddYears(-edad)) edad--;

            // Validar la edad
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
    }
}
