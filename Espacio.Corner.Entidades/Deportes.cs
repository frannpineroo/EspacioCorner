using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EspacioCorner.Entidades
{
    public class Deporte
    {
        #region atributos
        private int Id_Deporte { get; set; }
        private string NombreDep { get; set; }
        #endregion

        #region Constructor
        public Deporte() 
        { 
            Id_Deporte = 0; 
            NombreDep = string.Empty; 
        }
        public Deporte(int id_Deporte, string nombreDep)
        {
            Id_Deporte = id_Deporte; 
            NombreDep = nombreDep;
        }
        #endregion

            #region propiedades/encapsulamiento
        public int id_Deporte
        {
            get { return Id_Deporte; }
            set { Id_Deporte = value; }
        }
        public string nombreDep
        {
            get { return NombreDep; }
            set { NombreDep = value; }
        }
        #endregion
    }
}
