using EspacioCorner.Negocios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EspacioCorner.Front
{
    public partial class Basquet : Form
    {
        private NegAlumnos negAlumnos = new NegAlumnos();

        public Basquet()
        {
            InitializeComponent();
        }

        private void Basquet_Load(object sender, EventArgs e)
        {
            try
            {
                var alumnos = negAlumnos.ObtenerAlumnosPorDeporte("Básquet");
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

                dgvAlumBasquet.DataSource = alumnosConEdad;
                dgvAlumBasquet.Columns["Id_Alumno"].Visible = false; 
                dgvAlumBasquet.Columns["Edad"].HeaderText = "Edad"; 
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

        private void buttBasToPrin_Click(object sender, EventArgs e)
        {
            using (Principal principalForm = new Principal())
            {
                this.Hide();
                principalForm.ShowDialog();
            }
        }
    }
}
