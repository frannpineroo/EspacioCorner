﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
			Principal principalForm = new Principal();
			principalForm.Show();
		}
	}
}
