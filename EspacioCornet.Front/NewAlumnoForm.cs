using System;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using EspacioCorner.Entidades;
using EspacioCorner.Negocios;

namespace EspacioCornet.Front
{
	public partial class NewAlumnoForm : Form
	{
		private string deporte;
		public NewAlumnoForm(string deporteSeleccionado = null)
		{
			InitializeComponent();
			deporte = deporteSeleccionado;
			// Cargar opciones del estado desde la enumeración
			cmbEstAlumno.DataSource = Enum.GetValues(typeof(EstadoAlumno));
			// Preseleccionar el deporte recibido
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

		private void lblNombreAlum_Click(object sender, EventArgs e)
		{

		}

		private void buttAniadirAlum_Click(object sender, EventArgs e)
		{
			// Validar entrada
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

			Alumno nuevoAlumno = new Alumno
			{
				nombre_Apellido = txtNombreAl.Text,
				dNI = dni,
				numPersonal = txtNumP.Text,
				numPadre_Tutor = txtNumP.Text,
				numMadre_Tutor = txtNumM.Text,
				fichaMedica = cboxFichaMed.Checked,
				estado = (EstadoAlumno)cmbEstAlumno.SelectedItem
			};

			// Agregar el alumno a los deportes seleccionados
			foreach (var deporte in clbDeportes.CheckedItems)
			{
				switch (deporte.ToString())
				{
					case "Fútbol":
						if (!DatosEscuela.AlumnosFutbol.Any(a => a.dNI == dni))
							DatosEscuela.AlumnosFutbol.Add(nuevoAlumno);
						break;
					case "Básquet":
						if (!DatosEscuela.AlumnosBasquet.Any(a => a.dNI == dni))
							DatosEscuela.AlumnosBasquet.Add(nuevoAlumno);
						break;
					case "Volley":
						if (!DatosEscuela.AlumnosVolley.Any(a => a.dNI == dni))
							DatosEscuela.AlumnosVolley.Add(nuevoAlumno);
						break;
					case "Arte":
						if (!DatosEscuela.AlumnosArte.Any(a => a.dNI == dni))
							DatosEscuela.AlumnosArte.Add(nuevoAlumno);
						break;
				}

				MessageBox.Show("Alumno agregado exitosamente.");
				this.Close();
			}
		}
		private void clbDeportes_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void NewAlumnoForm_Load(object sender, EventArgs e)
		{
			
		}

		private void cmbEstAlumno_SelectedIndexChanged(object sender, EventArgs e)
		{
			cmbEstAlumno.DataSource = Enum.GetValues(typeof(EstadoAlumno));
		}
	}
}
