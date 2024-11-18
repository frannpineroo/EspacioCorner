using System;
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
				return (resultado, advertencia);
			}
			catch (Exception e)
			{
				throw new Exception("Error en la capa de negocios al agregar alumno", e);
			}
		}

		private string ValidarFechaCumple(DateTime fechaCumple)
		{
			// Validar que la fecha no sea superior a la fecha actual
			if (fechaCumple > DateTime.Now)
			{
				throw new Exception("La fecha de cumpleaños no puede ser superior a la fecha actual.");
			}

			// Validar formato dd/MM/yyyy
			string fechaString = fechaCumple.ToString("dd/MM/yyyy");
			string[] partes = fechaString.Split('/');
			int dia = int.Parse(partes[0]);
			int mes = int.Parse(partes[1]);
			int año = int.Parse(partes[2]);

			// Validar día
			if (dia < 1 || dia > 31)
			{
				throw new Exception("El día de la fecha de cumpleaños no es válido.");
			}

			// Validar mes
			if (mes < 1 || mes > 12)
			{
				throw new Exception("El mes de la fecha de cumpleaños no es válido.");
			}

			// Validar año (máximo 18 años desde el año actual)
			int añoActual = DateTime.Now.Year;
			if (año > añoActual - 18)
			{
				return "Advertencia: El alumno tiene más de 18 años.";
			}

			return string.Empty;
		}
	}
}
