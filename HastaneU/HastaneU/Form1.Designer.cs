namespace HastaneU
{
    partial class Form1
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
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnHastaGiris = new System.Windows.Forms.Button();
			this.btnRapor = new System.Windows.Forms.Button();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Peru;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 74);
			this.panel1.TabIndex = 0;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.Tan;
			this.panel2.Controls.Add(this.btnRapor);
			this.panel2.Controls.Add(this.btnHastaGiris);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel2.Location = new System.Drawing.Point(0, 74);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(113, 376);
			this.panel2.TabIndex = 1;
			// 
			// btnHastaGiris
			// 
			this.btnHastaGiris.Location = new System.Drawing.Point(23, 20);
			this.btnHastaGiris.Name = "btnHastaGiris";
			this.btnHastaGiris.Size = new System.Drawing.Size(75, 23);
			this.btnHastaGiris.TabIndex = 0;
			this.btnHastaGiris.Text = "Hasta Giriş";
			this.btnHastaGiris.UseVisualStyleBackColor = true;
			this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
			// 
			// btnRapor
			// 
			this.btnRapor.Location = new System.Drawing.Point(23, 49);
			this.btnRapor.Name = "btnRapor";
			this.btnRapor.Size = new System.Drawing.Size(75, 23);
			this.btnRapor.TabIndex = 1;
			this.btnRapor.Text = "Rapor";
			this.btnRapor.UseVisualStyleBackColor = true;
			this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.IsMdiContainer = true;
			this.Name = "Form1";
			this.Text = "Form1";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnHastaGiris;
		private System.Windows.Forms.Button btnRapor;
	}
}

