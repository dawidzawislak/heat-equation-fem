namespace RRiR
{
	partial class Form1
	{
		/// <summary>
		/// Wymagana zmienna projektanta.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Wyczyść wszystkie używane zasoby.
		/// </summary>
		/// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Kod generowany przez Projektanta formularzy systemu Windows

		/// <summary>
		/// Metoda wymagana do obsługi projektanta — nie należy modyfikować
		/// jej zawartości w edytorze kodu.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.descLbl = new System.Windows.Forms.Label();
			this.plot = new ScottPlot.FormsPlot();
			this.heaberLbl = new System.Windows.Forms.Label();
			this.equationImg = new System.Windows.Forms.PictureBox();
			this.desc2Lbl = new System.Windows.Forms.Label();
			this.nTBox = new System.Windows.Forms.TextBox();
			this.cumputeBtn = new System.Windows.Forms.Button();
			this.clearPlotBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.equationImg)).BeginInit();
			this.SuspendLayout();
			// 
			// descLbl
			// 
			this.descLbl.AutoSize = true;
			this.descLbl.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.descLbl.Location = new System.Drawing.Point(25, 57);
			this.descLbl.Name = "descLbl";
			this.descLbl.Size = new System.Drawing.Size(331, 15);
			this.descLbl.TabIndex = 0;
			this.descLbl.Text = "Compute u(x) function with FEM and Gelerkin algorithms";
			// 
			// plot
			// 
			this.plot.Location = new System.Drawing.Point(368, 20);
			this.plot.Name = "plot";
			this.plot.Size = new System.Drawing.Size(420, 375);
			this.plot.TabIndex = 1;
			// 
			// heaberLbl
			// 
			this.heaberLbl.AutoSize = true;
			this.heaberLbl.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.heaberLbl.Location = new System.Drawing.Point(66, 9);
			this.heaberLbl.Name = "heaberLbl";
			this.heaberLbl.Size = new System.Drawing.Size(238, 39);
			this.heaberLbl.TabIndex = 2;
			this.heaberLbl.Text = "Heat equation";
			// 
			// equationImg
			// 
			this.equationImg.Image = ((System.Drawing.Image)(resources.GetObject("equationImg.Image")));
			this.equationImg.InitialImage = ((System.Drawing.Image)(resources.GetObject("equationImg.InitialImage")));
			this.equationImg.Location = new System.Drawing.Point(73, 91);
			this.equationImg.Name = "equationImg";
			this.equationImg.Size = new System.Drawing.Size(253, 252);
			this.equationImg.TabIndex = 3;
			this.equationImg.TabStop = false;
			// 
			// desc2Lbl
			// 
			this.desc2Lbl.AutoSize = true;
			this.desc2Lbl.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.desc2Lbl.Location = new System.Drawing.Point(25, 362);
			this.desc2Lbl.Name = "desc2Lbl";
			this.desc2Lbl.Size = new System.Drawing.Size(147, 16);
			this.desc2Lbl.TabIndex = 4;
			this.desc2Lbl.Text = "Elements number (N):";
			// 
			// nTBox
			// 
			this.nTBox.Location = new System.Drawing.Point(178, 361);
			this.nTBox.Name = "nTBox";
			this.nTBox.Size = new System.Drawing.Size(100, 20);
			this.nTBox.TabIndex = 5;
			// 
			// cumputeBtn
			// 
			this.cumputeBtn.Location = new System.Drawing.Point(287, 359);
			this.cumputeBtn.Name = "cumputeBtn";
			this.cumputeBtn.Size = new System.Drawing.Size(75, 23);
			this.cumputeBtn.TabIndex = 6;
			this.cumputeBtn.Text = "Compute";
			this.cumputeBtn.UseVisualStyleBackColor = true;
			this.cumputeBtn.Click += new System.EventHandler(this.cumputeBtn_Click);
			// 
			// clearPlotBtn
			// 
			this.clearPlotBtn.Location = new System.Drawing.Point(695, 9);
			this.clearPlotBtn.Name = "clearPlotBtn";
			this.clearPlotBtn.Size = new System.Drawing.Size(78, 23);
			this.clearPlotBtn.TabIndex = 7;
			this.clearPlotBtn.Text = "Clear plot";
			this.clearPlotBtn.UseVisualStyleBackColor = true;
			this.clearPlotBtn.Click += new System.EventHandler(this.clearPlotBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 393);
			this.Controls.Add(this.clearPlotBtn);
			this.Controls.Add(this.cumputeBtn);
			this.Controls.Add(this.nTBox);
			this.Controls.Add(this.desc2Lbl);
			this.Controls.Add(this.equationImg);
			this.Controls.Add(this.heaberLbl);
			this.Controls.Add(this.plot);
			this.Controls.Add(this.descLbl);
			this.Name = "Form1";
			this.Text = "Heat equation FEM";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.equationImg)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label descLbl;
		private ScottPlot.FormsPlot plot;
		private System.Windows.Forms.Label heaberLbl;
		private System.Windows.Forms.PictureBox equationImg;
		private System.Windows.Forms.Label desc2Lbl;
		private System.Windows.Forms.TextBox nTBox;
		private System.Windows.Forms.Button cumputeBtn;
		private System.Windows.Forms.Button clearPlotBtn;
	}
}

