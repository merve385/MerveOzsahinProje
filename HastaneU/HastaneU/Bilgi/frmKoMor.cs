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
	public partial class frmKoMor : Form
	{
		HastaneUDataContext _db = new HastaneUDataContext();
		Mesajlar _m = new Mesajlar();
		int _komID = -1;

		public bool secim = true;
		bool _edit = false;
		public frmKoMor()
		{
			InitializeComponent();
		}

		private void frmKoMor_Load(object sender, EventArgs e)
		{
			Listele();
		}
		void YeniKaydet()
		{
			try
			{
				tblKoMorbidite kom = new tblKoMorbidite();
				kom.Komorbidite = txtKoMor.Text;
				_db.tblKoMorbidites.InsertOnSubmit(kom);
				_db.SubmitChanges();
				_m.YeniKayit("Kayıt Tamamlandı");
				Temizle();
			}
			catch (Exception e)
			{

				_m.Hata(e);
			}
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
            if (_edit && _komID > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!_edit) YeniKaydet();
            Listele();
		}
		void Listele()
		{
			Liste.Rows.Clear();
			int i = 0;
			var lst = _db.tblKoMorbidites.ToList();
			foreach (var k in lst)
			{
				Liste.Rows.Add();
				Liste.Rows[i].Cells[0].Value = k.ID;
				Liste.Rows[i].Cells[1].Value = k.Komorbidite;
				i++;
			}
			Liste.AllowUserToAddRows = false;
		}
		void Sec()
		{
			try
			{
                _edit = true;
                _komID = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                txtKoMor.Text = Liste.CurrentRow.Cells[1].Value.ToString();
			}
			catch (Exception)
			{
                _edit = false;

                _komID = -1;
			}
		}
		void Temizle()
		{
			txtKoMor.Text = "";
			_edit = false;
            _komID = -1;
			Listele();
		}
		string km1 = "", km2 = "", km3 = "";

		private void Liste_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if (km1 == "")
			{
				km1 = Liste.CurrentRow.Cells[1].Value.ToString();
			}
			else if (km1 != "" && km2 == "")
			{
				km2 = Liste.CurrentRow.Cells[1].Value.ToString();
			}
			else if (km2 != "" && km3 == "")
			{
				km3 = Liste.CurrentRow.Cells[1].Value.ToString();
			}
			kmAktar();
		}

		private void btnKoMorAktar_Click(object sender, EventArgs e)
		{
			Form1.Aktarma2 = txtKmToplam.Text;
			Close();
		}

		private void btnSil_Click(object sender, EventArgs e)
		{
            if (_edit && _komID > 0 && _m.Sil() == DialogResult.Yes)
               
                Sil();

		}

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        void kmAktar()
		{
			txtKmToplam.Text = km1 + "*" + km2 + "*" + km3;
		}
		
		void Sil()
		{
			try
			{
				_db.tblKoMorbidites.DeleteOnSubmit(_db.tblKoMorbidites.First(x => x.ID == _komID));
				_db.SubmitChanges();
				
				Temizle();
			}
			catch (Exception e)
			{

				_m.Hata(e);
			}
		}
        void Guncelle()
        {
            tblKoMorbidite kom = _db.tblKoMorbidites.First(x => x.ID == _komID);
            kom.Komorbidite = txtKoMor.Text;
            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();


        }
	}

}
