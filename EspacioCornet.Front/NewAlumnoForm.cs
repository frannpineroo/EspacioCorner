using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EspacioCorner.Entidades;
using EspacioCorner.Front;
using EspacioCorner.Negocios;

namespace EspacioCorner.Front
{
    public partial class NewAlumnoForm : Form
    {
        private string deporte;
        private NegAlumnos negAlumnos = new NegAlumnos();

        public NewAlumnoForm(string deporteSeleccionado = null)
        {
            InitializeComponent();
            deporte = deporteSeleccionado;

            cmbEstAlumno.DataSource = Enum.GetValues(typeof(EstadoAlumno));
            clbDeportes.Items.AddRange(new string[] { "Fútbol", "Básquet", "Volley", "Arte" });

            if (!string.IsNullOrEmpty(deporteSeleccionado))
            {
                for (int i = 0; i < clbDeportes.Items.Count; i++)
                {
                    if (clbDeportes.Items[i].ToString() == deporteSeleccionado)
                    {
                        clbDeportes.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void lblNombreAlum_Click(object sender, EventArgs e) { }

        private void clbDeportes_SelectedIndexChanged(object sender, EventArgs e) { }

        private void NewAlumnoForm_Load(object sender, EventArgs e) { }

        private void cmbEstAlumno_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbEstAlumno.DataSource = Enum.GetValues(typeof(EstadoAlumno));
        }

        private void buttAniadirAlum_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreAl.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            if (!int.TryParse(txtDNIAlum.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número entero.");
                return;
            }

            if (clbDeportes.CheckedItems.Count == 0)
            {
                MessageBox.Show("Debe seleccionar al menos un deporte.");
                return;
            }

            DateTime fechaCumple = calFechaNac.SelectionStart;
            if (fechaCumple == null || fechaCumple == DateTime.MinValue)
            {
                MessageBox.Show("Debe seleccionar una fecha de nacimiento.");
                return;
            }

            string validacionFecha = negAlumnos.ValidarFechaCumple(fechaCumple);
            if (!string.IsNullOrEmpty(validacionFecha))
            {
                MessageBox.Show(validacionFecha);
            }

            Alumno nuevoAlumno = new Alumno
            {
                nombre_Apellido = txtNombreAl.Text,
                dNI = dni,
                numPersonal = txtNumAlum.Text,
                numPadre_Tutor = txtNumP.Text,
                numMadre_Tutor = txtNumM.Text,
                fichaMedica = cboxFichaMed.Checked,
                estado = (EstadoAlumno)cmbEstAlumno.SelectedItem,
                fechaCumple = fechaCumple
            };

            // Obtener los Ids de los deportes seleccionados
            List<int> deportesSeleccionados = new List<int>();
            foreach (string deporte in clbDeportes.CheckedItems)
            {
                int idDeporte = negAlumnos.ObtenerIdDeportePorNombre(deporte);
                deportesSeleccionados.Add(idDeporte);
            }

            var resultado = negAlumnos.AgregarAlumno(nuevoAlumno.nombre_Apellido, nuevoAlumno.dNI, nuevoAlumno.numPersonal, nuevoAlumno.numPadre_Tutor, nuevoAlumno.numMadre_Tutor, nuevoAlumno.fechaCumple, nuevoAlumno.fichaMedica, nuevoAlumno.estado, deportesSeleccionados);

            if (resultado.Item1 > 0)
            {
                MessageBox.Show("Alumno agregado exitosamente.");
            }
            else
            {
                MessageBox.Show("Error al agregar el alumno.");
            }

            Principal formPrincipal = new Principal();
            formPrincipal.Show();

            this.Close();
        }

        private void buttCancelar_Click(object sender, EventArgs e)
        {
            using (Principal principalForm = new Principal())
            {
                this.Hide();
                principalForm.ShowDialog();
            }
        }
    }
}

//private void cmbEstAlumno_SelectedIndexChanged(object sender, EventArgs e)
//{
//	cmbEstAlumno.DataSource = Enum.GetValues(typeof(EstadoAlumno));
//}

//private void buttCancelar_Click(object sender, EventArgs e)
//{
//	using (Principal principalForm = new Principal())
//	{
//		this.Hide();
//		principalForm.ShowDialog();
//	}
//}
