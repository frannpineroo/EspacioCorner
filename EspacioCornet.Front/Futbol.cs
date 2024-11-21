using EspacioCorner.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EspacioCorner.Front
{
    public partial class Futbol : Form
    {
        private NegAlumnos negAlumnos = new NegAlumnos();

        public Futbol()
        {
            InitializeComponent();
        }

        private void Futbol_Load(object sender, EventArgs e)
        {
            try
            {
                var alumnos = negAlumnos.ObtenerAlumnosPorDeporte("Fútbol");
                var alumnosConEdad = alumnos.Select(alumno => new
                {
                    alumno.fichaMedica,
                    alumno.nombre_Apellido,
                    alumno.dNI,
                    Edad = CalcularEdad(alumno.fechaCumple),
                    alumno.fechaCumple,
                    alumno.numPersonal,
                    alumno.numMadre_Tutor,
                    alumno.numPadre_Tutor,
                    alumno.estado,
                    alumno.id_Alumno
                }).ToList();

                dgvAlumFutbol.DataSource = alumnosConEdad;
                dgvAlumFutbol.Columns["Id_Alumno"].Visible = false; 
                dgvAlumFutbol.Columns["Edad"].HeaderText = "Edad"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar alumnos: " + ex.Message);
            }
        }

        private int CalcularEdad(DateTime fechaCumple)
        {
            int edad = DateTime.Now.Year - fechaCumple.Year;
            if (DateTime.Now.DayOfYear < fechaCumple.DayOfYear)
                edad--;
            return edad;
        }

        private void buttFutToPrin_Click(object sender, EventArgs e)
        {
            using (Principal principalForm = new Principal())
            {
                this.Hide();
                principalForm.ShowDialog();
            }
        }

        private void buttNewFutbol_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
