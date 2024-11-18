using System.Windows.Forms;

namespace EspacioCorner.Front
{
	public partial class Principal : Form
    {
		public Principal()
        {
            InitializeComponent();
        }

		private void buttFutbol_Click(object sender, System.EventArgs e)
		{
			using (Futbol futbolForm = new Futbol())
			{
				this.Hide();
				futbolForm.ShowDialog();
			}
			
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{

		}

		private void buttArte_Click(object sender, System.EventArgs e)
		{
			using (Arte arteForm = new Arte())
			{
				this.Hide();
				arteForm.ShowDialog();
			}
				
		}

		private void buttBasquet_Click(object sender, System.EventArgs e)
		{
			using (Basquet basquetForm = new Basquet())
			{
				this.Hide();
				basquetForm.ShowDialog();
			}
			
		}

		private void buttVolley_Click(object sender, System.EventArgs e)
		{
			using (Volley volleyForm = new Volley())
			{
				this.Hide();
				volleyForm.ShowDialog();
			}
			
		}
	}
}
