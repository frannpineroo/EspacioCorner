namespace EspacioCorner.Front
{
	partial class FormPrincipal
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.buttFutbol = new System.Windows.Forms.Button();
			this.buttBasquet = new System.Windows.Forms.Button();
			this.buttVolley = new System.Windows.Forms.Button();
			this.buttArte = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.panel1.Controls.Add(this.buttArte);
			this.panel1.Controls.Add(this.buttVolley);
			this.panel1.Controls.Add(this.buttBasquet);
			this.panel1.Controls.Add(this.buttFutbol);
			this.panel1.Location = new System.Drawing.Point(225, 103);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(341, 202);
			this.panel1.TabIndex = 0;
			// 
			// buttFutbol
			// 
			this.buttFutbol.Location = new System.Drawing.Point(133, 44);
			this.buttFutbol.Name = "buttFutbol";
			this.buttFutbol.Size = new System.Drawing.Size(75, 23);
			this.buttFutbol.TabIndex = 0;
			this.buttFutbol.Text = "Futbol";
			this.buttFutbol.UseVisualStyleBackColor = true;
			// 
			// buttBasquet
			// 
			this.buttBasquet.Location = new System.Drawing.Point(133, 73);
			this.buttBasquet.Name = "buttBasquet";
			this.buttBasquet.Size = new System.Drawing.Size(75, 23);
			this.buttBasquet.TabIndex = 1;
			this.buttBasquet.Text = "Básquet";
			this.buttBasquet.UseVisualStyleBackColor = true;
			// 
			// buttVolley
			// 
			this.buttVolley.Location = new System.Drawing.Point(133, 102);
			this.buttVolley.Name = "buttVolley";
			this.buttVolley.Size = new System.Drawing.Size(75, 23);
			this.buttVolley.TabIndex = 2;
			this.buttVolley.Text = "Volley";
			this.buttVolley.UseVisualStyleBackColor = true;
			// 
			// buttArte
			// 
			this.buttArte.Location = new System.Drawing.Point(133, 131);
			this.buttArte.Name = "buttArte";
			this.buttArte.Size = new System.Drawing.Size(75, 23);
			this.buttArte.TabIndex = 3;
			this.buttArte.Text = "Arte";
			this.buttArte.UseVisualStyleBackColor = true;
			// 
			// FormPrincipal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel1);
			this.Name = "FormPrincipal";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button buttArte;
		private System.Windows.Forms.Button buttVolley;
		private System.Windows.Forms.Button buttBasquet;
		private System.Windows.Forms.Button buttFutbol;
	}
}

