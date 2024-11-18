using System;
using System.Windows.Forms;

namespace EspacioCorner.Front
{
	public partial class Futbol : Form
    {
		public Futbol()
		{
			InitializeComponent();
		}

		private void Futbol_Load(object sender, EventArgs e)
		{

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
	}
}
