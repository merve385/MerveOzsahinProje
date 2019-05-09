namespace HastaneU.Bilgi
{
    partial class frmAra
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Liste = new System.Windows.Forms.DataGridView();
            this.HasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KanamaMik = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRapor = new System.Windows.Forms.Button();
            this.cbpks = new System.Windows.Forms.ComboBox();
            this.cbPatoloj = new System.Windows.Forms.ComboBox();
            this.txtKMax = new System.Windows.Forms.TextBox();
            this.txtKMin = new System.Windows.Forms.TextBox();
            this.txtTMax = new System.Windows.Forms.TextBox();
            this.txtTMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.SizeWE;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Liste);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRapor);
            this.splitContainer1.Panel2.Controls.Add(this.cbpks);
            this.splitContainer1.Panel2.Controls.Add(this.cbPatoloj);
            this.splitContainer1.Panel2.Controls.Add(this.txtKMax);
            this.splitContainer1.Panel2.Controls.Add(this.txtKMin);
            this.splitContainer1.Panel2.Controls.Add(this.txtTMax);
            this.splitContainer1.Panel2.Controls.Add(this.txtTMin);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 0;
            // 
            // Liste
            // 
            this.Liste.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Liste.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.HasID,
            this.ProNo,
            this.HAdi,
            this.KanamaMik,
            this.Pato,
            this.Pks});
            this.Liste.Cursor = System.Windows.Forms.Cursors.Default;
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(590, 446);
            this.Liste.TabIndex = 0;
            // 
            // HasID
            // 
            this.HasID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HasID.HeaderText = "Hasta ID";
            this.HasID.Name = "HasID";
            this.HasID.Width = 69;
            // 
            // ProNo
            // 
            this.ProNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProNo.HeaderText = "Protokol No";
            this.ProNo.Name = "ProNo";
            // 
            // HAdi
            // 
            this.HAdi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HAdi.HeaderText = "Hasta Adı";
            this.HAdi.Name = "HAdi";
            // 
            // KanamaMik
            // 
            this.KanamaMik.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KanamaMik.HeaderText = "Kanama Miktarı";
            this.KanamaMik.Name = "KanamaMik";
            // 
            // Pato
            // 
            this.Pato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pato.HeaderText = "Patoloji";
            this.Pato.Name = "Pato";
            // 
            // Pks
            // 
            this.Pks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pks.HeaderText = "PKS";
            this.Pks.Name = "Pks";
            // 
            // btnRapor
            // 
            this.btnRapor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRapor.Location = new System.Drawing.Point(0, 413);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(198, 33);
            this.btnRapor.TabIndex = 4;
            this.btnRapor.Text = "Raporla";
            this.btnRapor.UseVisualStyleBackColor = true;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // cbpks
            // 
            this.cbpks.FormattingEnabled = true;
            this.cbpks.Items.AddRange(new object[] {
            "EVET",
            "HAYIR"});
            this.cbpks.Location = new System.Drawing.Point(6, 313);
            this.cbpks.Name = "cbpks";
            this.cbpks.Size = new System.Drawing.Size(121, 21);
            this.cbpks.TabIndex = 3;
            // 
            // cbPatoloj
            // 
            this.cbPatoloj.FormattingEnabled = true;
            this.cbPatoloj.Location = new System.Drawing.Point(6, 252);
            this.cbPatoloj.Name = "cbPatoloj";
            this.cbPatoloj.Size = new System.Drawing.Size(121, 21);
            this.cbPatoloj.TabIndex = 3;
            // 
            // txtKMax
            // 
            this.txtKMax.Location = new System.Drawing.Point(41, 186);
            this.txtKMax.Name = "txtKMax";
            this.txtKMax.Size = new System.Drawing.Size(100, 20);
            this.txtKMax.TabIndex = 1;
            this.txtKMax.Click += new System.EventHandler(this.txtKMax_Click);
            this.txtKMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKMax_KeyPress);
            // 
            // txtKMin
            // 
            this.txtKMin.Location = new System.Drawing.Point(41, 152);
            this.txtKMin.Name = "txtKMin";
            this.txtKMin.Size = new System.Drawing.Size(100, 20);
            this.txtKMin.TabIndex = 1;
            this.txtKMin.Click += new System.EventHandler(this.txtKMin_Click);
            this.txtKMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKMin_KeyPress);
            // 
            // txtTMax
            // 
            this.txtTMax.Location = new System.Drawing.Point(41, 84);
            this.txtTMax.Name = "txtTMax";
            this.txtTMax.Size = new System.Drawing.Size(100, 20);
            this.txtTMax.TabIndex = 1;
            this.txtTMax.Click += new System.EventHandler(this.txtTMax_Click);
            this.txtTMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTMax_KeyPress);
            // 
            // txtTMin
            // 
            this.txtTMin.Location = new System.Drawing.Point(41, 50);
            this.txtTMin.Name = "txtTMin";
            this.txtTMin.Size = new System.Drawing.Size(100, 20);
            this.txtTMin.TabIndex = 1;
            this.txtTMin.Click += new System.EventHandler(this.txtTMin_Click);
            this.txtTMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTMin_KeyPress);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(3, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(3, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Min";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(3, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Max";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(3, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Min";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(17, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kanama Miktari";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(17, 287);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 0;
            this.label8.Text = "PKS";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 226);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 23);
            this.label7.TabIndex = 0;
            this.label7.Text = "Patoloji";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tümor Boyutu";
            // 
            // frmAra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmAra";
            this.Text = "frmAra";
            this.Load += new System.EventHandler(this.frmAra_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView Liste;
        private System.Windows.Forms.DataGridViewTextBoxColumn HasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn HAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn KanamaMik;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pks;
        private System.Windows.Forms.ComboBox cbpks;
        private System.Windows.Forms.ComboBox cbPatoloj;
        private System.Windows.Forms.TextBox txtKMax;
        private System.Windows.Forms.TextBox txtKMin;
        private System.Windows.Forms.TextBox txtTMax;
        private System.Windows.Forms.TextBox txtTMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnRapor;
	}
}