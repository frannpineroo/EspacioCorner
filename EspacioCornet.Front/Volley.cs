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
