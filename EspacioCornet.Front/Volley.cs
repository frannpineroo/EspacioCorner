using EspacioCorner.Negocios;
using System;
using System.Windows.Forms;

namespace EspacioCorner.Front
{
	public partial class Volley : Form
    {
        public Volley()
        {
            InitializeComponent();
        }
		private void Volley_Load(object sender, EventArgs e)
		{
			dgvAlumVolley.DataSource = null;
			dgvAlumVolley.DataSource = DatosEscuela.AlumnosVolley;
		}
		private void buttVolToPrin_Click(object sender, EventArgs e)
		{
			using (Principal principalForm = new Principal())
			{
				this.Hide();
				principalForm.ShowDialog();
			}
			
		}
	}
}
