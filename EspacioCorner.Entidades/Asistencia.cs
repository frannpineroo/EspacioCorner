namespace EspacioCorner.Entidades
{
	public class Asistencia
	{
		public int IdAsistencia { get; set; }
		public int IdAlumno { get; set; }
		public int IdProfe { get; set; }
		public DateTime FechaAsistencia { get; set; }
		public bool Asistio { get; set; }
	}
}
