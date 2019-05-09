using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneU.Modal;

namespace HastaneU.Bilgi
{
	public partial class frmAra : Form
	{
		HastaneUDataContext _db = new HastaneUDataContext();
		Formlar _f = new Formlar();
		Mesajlar _m = new Mesajlar();
		public bool Secim = true;
		public frmAra()
		{
			InitializeComponent();
		}

		private void frmAra_Load(object sender, EventArgs e)
		{
            Combo();
		}
		void Combo()
		{
			var lst = (from s in _db.PatoVerilers select new { s.PatVeriler }).Distinct();
			foreach(var k in lst)
			{
				cbPatoloj.Items.Add(k.PatVeriler);
			}
		}
		void Listele()
		{
			Liste.Rows.Clear();
			if (txtTMin.Text == "")
			{
				txtTMin.Text = "0";
			}
			if (txtTMax.Text == "")
			{
				txtTMax.Text = "999999";
			}
			if (txtKMin.Text == "")
			{
				txtKMin.Text = "0";
			}
			if (txtKMax.Text=="")
			{
				txtKMax.Text = "999999";
			}
			int i = 0;
			int tumormin = int.Parse(txtTMin.Text);
			int tumormax = int.Parse(txtTMax.Text);
			int kanamamin = int.Parse(txtKMin.Text);
			int kanamamax = int.Parse(txtKMax.Text);
			var lst = (from s in _db.tblDemogs where s.Boyut <= tumormax && s.Boyut >= tumormin select s.HastaID).ToList();
			foreach(var k in lst)
			{
				var lst2 = (from a in _db.tblOperatifs where a.HastaID == k && a.Kanama <= kanamamax && a.Kanama >= kanamamin select a.HastaID).ToList();
				foreach (var t in lst2)
				{
					var lst3 = (from b in _db.tblPatolojis where b.HastaID == t && b.Patoloji == cbPatoloj.Text select b.HastaID).ToList();
					foreach(var y in lst3)
					{
						var lstele = (from c in _db.tblOperatifs where c.HastaID == y && c.PksAciklama == cbpks.Text select c.HastaID).ToList();
						foreach(var z in lstele)
						{
							Liste.Rows.Add();
							Liste.Rows[i].Cells[0].Value = _db.tblHastas.First(x => x.ID == z).ID;
							Liste.Rows[i].Cells[1].Value = _db.tblHastas.First(x => x.ID == z).Protokol;
							Liste.Rows[i].Cells[2].Value = _db.tblHastas.First(x => x.ID == z).HAdi;							
							Liste.Rows[i].Cells[3].Value = _db.tblOperatifs.First(x => x.HastaID == z).Kanama;
							Liste.Rows[i].Cells[4].Value = _db.tblPatolojis.First(x => x.HastaID == z).Patoloji;
							Liste.Rows[i].Cells[5].Value = _db.tblOperatifs.First(x => x.HastaID == z).PksAciklama;
							i++;

						}
					}

				}
			}
		}

		private void txtTMin_Click(object sender, EventArgs e)
		{
			txtTMin.Text = "";
		}

		private void txtTMax_Click(object sender, EventArgs e)
		{
			txtTMax.Text = "";
		}

		private void txtKMin_Click(object sender, EventArgs e)
		{
			txtKMin.Text = "";
		}

		private void txtKMax_Click(object sender, EventArgs e)
		{
			txtKMax.Text = "";
		}

		private void txtTMin_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && ! char.IsControl(e.KeyChar);
		}

		private void txtTMax_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtKMin_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void txtKMax_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
		}

		private void btnRapor_Click(object sender, EventArgs e)
		{
			Listele();
		}
	}
}
