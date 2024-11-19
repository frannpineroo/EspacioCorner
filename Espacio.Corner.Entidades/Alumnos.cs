using System;

namespace EspacioCorner.Entidades
{
		public enum EstadoAlumno
		{
			Activo,
			Inactivo
		}

	public class Alumno
	{
		#region atributos
		private int Id_Alumno { get; set; }
		private string Nombre_Apellido { get; set; }
		private int DNI { get; set; }
		private string NumPersonal { get; set; }
		private string NumPadre_Tutor { get; set; }
		private string NumMadre_Tutor { get; set; }
		private DateTime FechaCumple { get; set; }
		private bool FichaMedica { get; set; } // True para "SI", False para "NO"
		private EstadoAlumno EstadoAlumno { get; set; }
		#endregion

		#region Constructor
		public Alumno()
		{
			Id_Alumno = 0;
			Nombre_Apellido = string.Empty;
			DNI = 0;
			NumPersonal = string.Empty;
			NumPadre_Tutor = string.Empty;
			NumMadre_Tutor = string.Empty;
			FechaCumple = DateTime.MinValue;
			FichaMedica = false;
			EstadoAlumno = EstadoAlumno.Activo;
		}

		public Alumno(int id_Alumno, string nombre_Apellido, int dni, string numPersonal, string numPadre_Tutor, string numMadre_Tutor, DateTime fechaCumple, bool fichaMedica, EstadoAlumno estado)
		{
			Id_Alumno = id_Alumno;
			Nombre_Apellido = nombre_Apellido;
			DNI = dni;
			NumPersonal = numPersonal;
			NumPadre_Tutor = numPadre_Tutor;
			NumMadre_Tutor = numMadre_Tutor;
			FechaCumple = fechaCumple;
			FichaMedica = fichaMedica;
			EstadoAlumno = estado;
		}
		#endregion

		#region propiedades/encapsulamiento
		public int id_Alumno
		{
			get { return Id_Alumno; }
			set { Id_Alumno = value; }
		}
		public string nombre_Apellido
		{
			get { return Nombre_Apellido; }
			set { Nombre_Apellido = value; }
		}
		public int dNI
		{
			get { return DNI; }
			set { DNI = value; }
		}
		public string numPersonal
		{
			get { return NumPersonal; }
			set { NumPersonal = value; }
		}
		public string numPadre_Tutor
		{
			get { return NumPadre_Tutor; }
			set { NumPadre_Tutor = value; }
		}
		public string numMadre_Tutor
		{
			get { return NumMadre_Tutor; }
			set { NumMadre_Tutor = value; }
		}
		public DateTime fechaCumple
		{
			get { return FechaCumple; }
			set { FechaCumple = value; }
		}
		public bool fichaMedica
		{
			get { return FichaMedica; }
			set { FichaMedica = value; }
		}
		public EstadoAlumno estado
		{
			get { return EstadoAlumno; }
			set { EstadoAlumno = value; }
		}
		#endregion
	}
}
