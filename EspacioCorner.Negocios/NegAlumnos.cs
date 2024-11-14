using System;
using EspacioCorner.Datos;

namespace EspacioCorner.Negocios
{
    public class NegAlumnos
    {
        private DatosAlumnos datosAlumnos = new DatosAlumnos();

        public int AgregarAlumno(string nombreApellido, string numPadreTutor, string numMadreTutor, DateTime fechaCumple)
        {
            if (!ValidarFechaCumple(fechaCumple))
            {
                throw new Exception("La fecha de cumpleaños no es válida.");
            }

            try
            {
                return datosAlumnos.AgregarAlumno(nombreApellido, numPadreTutor, numMadreTutor, fechaCumple);
            }
            catch (Exception e)
            {
                throw new Exception("Error en la capa de negocios al agregar alumno", e);
            }
        }

        private bool ValidarFechaCumple(DateTime fechaCumple)
        {
            string fechaString = fechaCumple.ToString("dd/MM/yyyy");
            string[] partes = fechaString.Split('/');
            int dia = int.Parse(partes[0]);
            int mes = int.Parse(partes[1]);
            int año = int.Parse(partes[2]);

            if (dia < 1 || dia > 31)
            {
                return false;
            }

            if (mes < 1 || mes > 12)
            {
                return false;
            }

            int añoActual = DateTime.Now.Year;
            if (año > añoActual - 18)
            {
                return false;
            }

            return true;
        }
    }
}


