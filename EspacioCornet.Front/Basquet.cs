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

		}

		private void buttBasToPrin_Click(object sender, EventArgs e)
		{
			Principal principalForm = new Principal();
			principalForm.Show();
		}
	}
}
