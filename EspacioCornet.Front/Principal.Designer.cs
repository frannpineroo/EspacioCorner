namespace EspacioCorner.Front
{
	partial class Principal
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttArte = new System.Windows.Forms.Button();
			this.buttVolley = new System.Windows.Forms.Button();
			this.buttBasquet = new System.Windows.Forms.Button();
			this.buttFutbol = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Transparent;
			//this.panel1.BackgroundImage = global::EspacioCorner.Front.Properties.Resources.Corner;
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.panel1.Controls.Add(this.buttArte);
			this.panel1.Controls.Add(this.buttVolley);
			this.panel1.Controls.Add(this.buttBasquet);
			this.panel1.Controls.Add(this.buttFutbol);
			this.panel1.Location = new System.Drawing.Point(90, 63);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(459, 334);
			this.panel1.TabIndex = 2;
			// 
			// buttArte
			// 
			this.buttArte.BackColor = System.Drawing.Color.Chocolate;
			this.buttArte.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttArte.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttArte.Location = new System.Drawing.Point(311, 267);
			this.buttArte.Name = "buttArte";
			this.buttArte.Size = new System.Drawing.Size(75, 23);
			this.buttArte.TabIndex = 3;
			this.buttArte.Text = "Arte";
			this.buttArte.UseVisualStyleBackColor = false;
			// 
			// buttVolley
			// 
			this.buttVolley.BackColor = System.Drawing.Color.Chocolate;
			this.buttVolley.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttVolley.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttVolley.Location = new System.Drawing.Point(230, 267);
			this.buttVolley.Name = "buttVolley";
			this.buttVolley.Size = new System.Drawing.Size(75, 23);
			this.buttVolley.TabIndex = 2;
			this.buttVolley.Text = "Volley";
			this.buttVolley.UseVisualStyleBackColor = false;
			// 
			// buttBasquet
			// 
			this.buttBasquet.BackColor = System.Drawing.Color.Chocolate;
			this.buttBasquet.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttBasquet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttBasquet.Location = new System.Drawing.Point(149, 267);
			this.buttBasquet.Name = "buttBasquet";
			this.buttBasquet.Size = new System.Drawing.Size(75, 23);
			this.buttBasquet.TabIndex = 1;
			this.buttBasquet.Text = "Basquet";
			this.buttBasquet.UseVisualStyleBackColor = false;
			// 
			// buttFutbol
			// 
			this.buttFutbol.BackColor = System.Drawing.Color.Chocolate;
			this.buttFutbol.Font = new System.Drawing.Font("Bodoni MT", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttFutbol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.buttFutbol.Location = new System.Drawing.Point(68, 267);
			this.buttFutbol.Name = "buttFutbol";
			this.buttFutbol.Size = new System.Drawing.Size(75, 23);
			this.buttFutbol.TabIndex = 0;
			this.buttFutbol.Text = "Futbol";
			this.buttFutbol.UseVisualStyleBackColor = false;
			this.buttFutbol.Click += new System.EventHandler(this.buttFutbol_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.ClientSize = new System.Drawing.Size(655, 450);
			this.Controls.Add(this.panel1);
			this.Name = "Principal";
			this.Text = "Principal";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button buttArte;
		private System.Windows.Forms.Button buttVolley;
		private System.Windows.Forms.Button buttBasquet;
		private System.Windows.Forms.Button buttFutbol;
		private System.Windows.Forms.Panel panel1;
	}
}