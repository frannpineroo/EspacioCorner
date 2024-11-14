using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioCorner.Entidades
{
    public class Asistencia
    {
        #region atributos
        private int Id_Asistencia { get; set; }
        private int Id_Alumno { get; set; }
        private int Id_Deporte { get; set; }
        private bool Asist_Parcial { get; set; }
        #endregion

        #region Constructor
        public Asistencia() 
        {
            Id_Asistencia = 0; 
            Id_Alumno = 0; 
            Id_Deporte = 0; 
            Asist_Parcial = false; 
        }
        public Asistencia(int id_Asistencia, int id_Alumno, int id_Deporte, bool asist_Parcial)
        {
            Id_Asistencia = id_Asistencia; 
            Id_Alumno = id_Alumno; 
            Id_Deporte = id_Deporte; 
            Asist_Parcial = asist_Parcial;
        }
        #endregion

            #region propiedades/encapsulamiento
        public int id_Asistencia
        {
            get { return Id_Asistencia; }
            set { Id_Asistencia = value; }
        }
        public int id_Alumno
        {
            get { return Id_Alumno; }
            set { Id_Alumno = value; }
        }
        public int id_Deporte
        {
            get { return Id_Deporte; }
            set { Id_Deporte = value; }
        }
        public bool asist_Parcial
        {
            get { return Asist_Parcial; }
            set { Asist_Parcial = value; }
        }
        #endregion
    }
}
