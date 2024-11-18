using System;
using System.Windows.Forms;

namespace EspacioCorner.Front
{
	public partial class Arte : Form
    {
        public Arte()
        {
            InitializeComponent();
        }

		private void Arte_Load(object sender, EventArgs e)
		{

		}

		private void buttArtToPrin_Click(object sender, EventArgs e)
		{
			using (Principal principalForm = new Principal())
			{
				this.Hide();
				principalForm.ShowDialog();
			}
			
		}
	}
}
