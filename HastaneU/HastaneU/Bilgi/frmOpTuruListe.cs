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
    public partial class frmOpTuruListe : Form
    {
        HastaneUDataContext _db = new HastaneUDataContext();
        Mesajlar _m = new Mesajlar();
        Formlar _f = new Formlar();
        public bool Secim = true;
        bool _edit = false;

        int _opId = -1;

        public frmOpTuruListe()
        {
            InitializeComponent();
        }

        private void frmOpTuruListe_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_edit && _opId > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!_edit) YeniKaydetOpTuru();
        }

        void Temizle()
        {
            txtOpTuruL.Text = "";
            _edit = false;
            _opId = -1;
            Listele();
        }

        void YeniKaydetOpTuru()
        {
            try
            {
                tblOpTuru opt = new tblOpTuru();
                opt.OpTuru = txtOpTuruL.Text;

                _db.tblOpTurus.InsertOnSubmit(opt);
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
            var lst = _db.tblOpTurus.ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.OpTuru;
                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
               

        void Sec()
        {

            try
            {
                _edit = true;
                _opId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
                txtOpTuruL.Text = Liste.CurrentRow.Cells[1].Value.ToString();

            }
            catch (Exception)
            {
                _edit = false;
                _opId = -1;
            }
        }

        void Sil()
        {
            try
            {
                _db.tblOpTurus.DeleteOnSubmit(_db.tblOpTurus.First(x => x.ID == _opId));
                _db.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                _m.Hata(e);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (_edit && _opId > 0 && _m.Sil() == DialogResult.Yes)
              
                Sil();
        }
        string op1 = "", op2 = "", op3 = "";

        private void btnAktar_Click(object sender, EventArgs e)
        {
            
            Form1.Aktarma2 = txtOpToplam.Text;
            Close();

        }

        private void Liste_Click(object sender, EventArgs e)
        {
            Sec();
        }

        private void Liste_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (op1 == "")
            {
                op1 = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            else if (op1 != "" && op2 == "")
            {
                op2 = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            else if (op2 != "" && op3 == "")
            {
                op3 = Liste.CurrentRow.Cells[1].Value.ToString();
            }
            opAktar();
        }
        void opAktar()
        {
            txtOpToplam.Text = op1 + "*" + op2 + "*" + op3;
        }
        void Guncelle()
        {
            tblOpTuru opt = _db.tblOpTurus.First(x => x.ID == _opId);
            opt.OpTuru = txtOpTuruL.Text;

            _db.SubmitChanges();
            _m.Guncelle(true);
            Temizle();
        }
    }


       



}
