using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioCorner.Entidades
{
    public class Alumnos
    {
        #region atributos 
        private int Id_Alumno { get; set; }
        private string Nombre_Apellido { get; set; } 
        private string NumPadre_Tutor { get; set; } 
        private string NumMadre_Tutor { get; set; } 
        private DateTime FechaCumple { get; set; }
        #endregion
        #region Constructor 
        public Alumnos()
        {
            Id_Alumno = 0;
            Nombre_Apellido = string.Empty;
            NumPadre_Tutor = string.Empty;
            NumMadre_Tutor = string.Empty;
            FechaCumple = DateTime.MinValue;
        }
        public Alumnos(int id_Alumno, string nombre_Apellido, string numPadre_Tutor, string numMadre_Tutor, DateTime fechaCumple) 
        { 
            Id_Alumno = id_Alumno; 
            Nombre_Apellido = nombre_Apellido; 
            NumPadre_Tutor = numPadre_Tutor; 
            NumMadre_Tutor = numMadre_Tutor; 
            FechaCumple = fechaCumple;
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
        #endregion 
    }
}
