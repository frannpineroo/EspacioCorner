using EspacioCorner.Entidades;

namespace EspacioCorner.Negocio
{
	class CalcAsistencia
    {
		public double CalcularPorcentajeAsistencia(int idAlumno, List<Asistencia> asistencias)
		{
			int totalAsistencias = asistencias.Count(a => a.IdAlumno == idAlumno);
			int clasesAsistidas = asistencias.Count(a => a.IdAlumno == idAlumno && a.Asistio);

			return (double)clasesAsistidas / totalAsistencias * 100;
		}
	}
}
