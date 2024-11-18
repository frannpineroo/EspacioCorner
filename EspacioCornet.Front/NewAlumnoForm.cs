using System;
using System.Windows.Forms;
using EspacioCorner.Entidades;

namespace EspacioCornet.Front
{
	public partial class NewAlumnoForm : Form
	{
		public Alumnos NuevoAlumno { get; private set; }
		public NewAlumnoForm()
		{
			InitializeComponent();
		}

		private void lblNombreAlum_Click(object sender, EventArgs e)
		{

		}

		private void buttAniadirAlum_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtDNIAlum.Text))
			{
				MessageBox.Show("Por favor, ingrese datos válidos.");
				return;
			}
		}
	}
}
