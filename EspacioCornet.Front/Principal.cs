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
			Futbol futbolForm = new Futbol();
			futbolForm.Show();
		}

		private void pictureBox1_Click(object sender, System.EventArgs e)
		{

		}

		private void buttArte_Click(object sender, System.EventArgs e)
		{
			Arte arteForm = new Arte();
			arteForm.Show();	
		}

		private void buttBasquet_Click(object sender, System.EventArgs e)
		{
			Basquet basquetForm = new Basquet();
			basquetForm.Show();
		}

		private void buttVolley_Click(object sender, System.EventArgs e)
		{
			Volley volleyForm = new Volley();
			volleyForm.Show();
		}
	}
}
