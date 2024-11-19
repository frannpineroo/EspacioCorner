using EspacioCorner.Negocios;
using System;
using System.Windows.Forms;

namespace EspacioCorner.Front
{
	public partial class Basquet : Form
    {
        public Basquet()
        {
            InitializeComponent();
        }

		private void Basquet_Load(object sender, EventArgs e)
		{
			dgvAlumBasquet.DataSource = null;
			dgvAlumBasquet.DataSource = DatosEscuela.AlumnosBasquet;
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
