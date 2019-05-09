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
	public partial class frmDoktor : Form
	{
		HastaneUDataContext _db = new HastaneUDataContext();
		
		Mesajlar _m = new Mesajlar();
		public bool Secim = true;
		bool _edit = false;

		int _doktorID = -1;
		public frmDoktor()
		{
			InitializeComponent();
		}

		private void btnKaydet_Click(object sender, EventArgs e)
		{
            if (_edit && _doktorID > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!_edit) YeniKaydetDr();
        }
		void YeniKaydetDr()
		{
			try
			{

                tblDoktor dkr = new tblDoktor();
				dkr.DAdi = txtDrAd.Text;

				_db.tblDoktors.InsertOnSubmit(dkr);
				_db.SubmitChanges();
				_m.YeniKayit("Kayıt tamamlandı.");
				Temizle();
			}
			catch (Exception e)
			{
				_m.Hata(e);
			}
		}
		void Listele()
		{
			Liste.Rows.Clear();
			int i = 0;
			var lst = _db.tblDoktors.ToList();
			foreach (var k in lst)
			{
				Liste.Rows.Add();
				Liste.Rows[i].Cells[0].Value = k.ID;
				Liste.Rows[i].Cells[1].Value = k.DAdi;
				i++;
			}
			Liste.AllowUserToAddRows = false;
		}

		
		void Sec()
		{
			try
			{
                _edit = true;
				_doktorID = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                txtDrAd.Text = Liste.CurrentRow.Cells[1].Value.ToString(); 
			}
			catch (Exception)
			{
                _edit = false;
				_doktorID = -1;
			}
		}

		private void frmDoktor_Load(object sender, EventArgs e)
		{
			Listele();
		}
		void Temizle()
		{
			txtDrAd.Text = "";
			_edit = false;
			_doktorID = -1;
			Listele();
		}
        string dr1 = "", dr2 = "", dr3 = "";

        private void btnDrAktar_Click(object sender, EventArgs e)
        {
            Form1.Aktarma2 = txtDrToplam.Text;
            Close();
        }

        private void Liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dr1 == "")
            {
                dr1 = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dr1 != "" && dr2 == "")
            {
                dr2 = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            else if (dr2 != "" && dr3 == "")
            {
                dr3 = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            opAktar();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_edit && _doktorID > 0 && _m.Sil() == DialogResult.Yes)
               
                Sil();
           
        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        void opAktar()
        {
            txtDrToplam.Text = dr1 + "*" + dr2 + "*" + dr3;
        }
        void Sil()
        {
            try
            {
                _db.tblDoktors.DeleteOnSubmit(_db.tblDoktors.First(x => x.ID ==_doktorID));
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
            tblDoktor dok = _db.tblDoktors.First(x => x.ID == _doktorID);
            dok.DAdi = txtDrAd.Text;

            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }
    }
    
}
