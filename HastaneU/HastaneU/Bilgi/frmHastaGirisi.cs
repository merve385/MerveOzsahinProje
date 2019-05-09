using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HastaneU.Modal;

namespace HastaneU.Bilgi
{
    public partial class frmHastaGirisi : Form
    {
        HastaneUDataContext _db = new HastaneUDataContext();
        Formlar _f = new Formlar();
        Mesajlar _m = new Mesajlar();
        Numaralar _n = new Numaralar();
        bool edit = false;
        int _hastaID = -1;
        int _demoID = -1;
        int _ooID= -1;
        int _pooID = -1;
        int _pattoID = -1;
        int _takipID = -1;
        public bool Secim = false;
        public frmHastaGirisi()
        {
            InitializeComponent();
        }

        private void frmHastaGirisi_Load(object sender, EventArgs e)
        {
            Combo();
            Temizle();
        }
        void Combo()
        {
            var lst = (from s in _db.PatoVerilers select new { s.PatVeriler }).Distinct();
            foreach (var k in lst)
            {
                cbPatoloji.Items.Add(k.PatVeriler);
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            var btnoturu = new Button();
            btnoturu.Size = new Size(25, txtOpTuruHasta.ClientSize.Height + 2);
            btnoturu.Location = new Point(txtOpTuruHasta.ClientSize.Width - btnoturu.Width, -1);
            btnoturu.Cursor = Cursors.Default;
            //btnfno.Image=Resources.arrow_1176;
            txtOpTuruHasta.Controls.Add(btnoturu);
            SendMessage(txtOpTuruHasta.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnoturu.Width << 16));
            btnoturu.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            var btndr = new Button();
            btndr.Size = new Size(25, txtDr.ClientSize.Height + 2);
            btndr.Location = new Point(txtDr.ClientSize.Width - btndr.Width, -1);
            btndr.Cursor = Cursors.Default;
            //btnfno.Image=Resources.arrow_1176;
            txtDr.Controls.Add(btndr);
            SendMessage(txtDr.Handle, 0xd3, (IntPtr)2, (IntPtr)(btndr.Width << 16));
            btndr.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);

            var btnhasta = new Button();
            btnhasta.Size = new Size(25, txtHastaNo.ClientSize.Height + 2);
            btnhasta.Location = new Point(txtHastaNo.ClientSize.Width - btnhasta.Width, -1);
            btnhasta.Cursor = Cursors.Default;
            //btnfno.Image=Resources.arrow_1176;
            txtHastaNo.Controls.Add(btnhasta);
            SendMessage(txtHastaNo.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnhasta.Width << 16));
            btnhasta.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

            base.OnLoad(e);

            var btnkomor = new Button();
            btnkomor.Size = new Size(25, txtKoMor.ClientSize.Height + 2);
            btnkomor.Location = new Point(txtKoMor.ClientSize.Width - btnkomor.Width, -1);
            btnkomor.Cursor = Cursors.Default;
            //btnfno.Image=Resources.arrow_1176;
            txtKoMor.Controls.Add(btnkomor);
            SendMessage(txtKoMor.Handle, 0xd3, (IntPtr)2, (IntPtr)(btnkomor.Width << 16));
            btnkomor.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
            base.OnLoad(e);


            btnoturu.Click += btnoturu_Click;
            btndr.Click += btndr_Click;
            btnhasta.Click += btnhasta_Click;
            btnkomor.Click += btnkmor_Click;


        }
        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void btnoturu_Click(object sender, EventArgs e)
        {
            string deneme = _f.OPTuruList(true);
            txtOpTuruHasta.Text = deneme;
            Form1.Aktarma2 = "";
        }
        private void btndr_Click(object sender, EventArgs e)
        {           
            string deneme = _f.DrList(true);
            txtDr.Text = deneme;
            Form1.Aktarma2 = "";
        }
        private void btnhasta_Click(object sender, EventArgs e)
        {
            int id = _f.HastaList(true);
            if (id > 0)
            {
                HastaAc(id);
            }
            Form1.Aktarma = -1;
        }
        private void btnkmor_Click(object sender, EventArgs e)
        {
            string deneme = _f.KoMorList(true);
            txtKoMor.Text = deneme;
            Form1.Aktarma2 = "";
        }


        void Ac(int id)
        {
            try
            {
                edit = true;
                _hastaID = id;
                tblHasta has = _db.tblHastas.First(x => x.ID == _hastaID);               
                txtHastaNo.Text = has.HastaNo.ToString();
            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }
        void Temizle()
        {            
            foreach (TabPage item in tabControl1.TabPages)
            {
                foreach(Control ct in item.Controls)
                {
                    if(ct is TextBox)
                    {
                        ct.Text = "";
                    }
                    if(ct is ComboBox)
                    {
                        ((ComboBox)ct).SelectedIndex = -1;
                    }
                }

            }
           
            txtHastaNo.Text = _n.HastaNo();
        }
        void YeniKaydet()
        {
            try
            {
                tblHasta has = new tblHasta();
                has.HAdi = txtAdi.Text;
                has.HSoyadi = txtSoyadi.Text;
                has.Protokol = txtProtokol.Text;
                has.OpTarihi = DateTime.Parse(dtOpTarihi.Text);
                has.OpTuru = txtOpTuruHasta.Text;
                has.Takip = txtTakip.Text != "" ? int.Parse(txtTakip.Text) : -1;
                has.Anah = cbAnah.Text != "" ? int.Parse(cbAnah.Text) : -1;
                has.HastaNo = txtHastaNo.Text != "" ? int.Parse(txtHastaNo.Text) : -1;


                _db.tblHastas.InsertOnSubmit(has);
                _db.SubmitChanges();

                HastaneUDataContext _gb = new HastaneUDataContext();

                tblDemog demo = new tblDemog();
                demo.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : 1;
                demo.Boy = txtBoy.Text != "" ? decimal.Parse(txtBoy.Text) : -1;
                demo.Kilo = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : -1;
                demo.BMI = txtBMI.Text != "" ? int.Parse(txtBMI.Text) : -1;
                demo.Asa = cbAsa.Text != "" ? int.Parse(cbAsa.Text) : -1;
                demo.Dr = txtDr.Text;
                demo.Cins = cbCins.Text;
                demo.Taraf = cbTaraf.Text;
                demo.Lokalizasyon = txtLokal.Text;
                demo.Boyut =int.Parse(txtBoyut.Text);               
                demo.KoMor = txtKoMor.Text;
                demo.HastaID = has.ID;                

                _gb.tblDemogs.InsertOnSubmit(demo);
                _gb.SubmitChanges();
              
                tblOperatif op = new tblOperatif();
                op.PksAciklama = cbPksAciklama.Text;
                op.Sik = cbSik.Text;
                op.CoOperasyon = txtCoOperasyon.Text;
                op.Iskemi = txtiskemi.Text != "" ? int.Parse(txtiskemi.Text) : -1;
                op.PortSayisi = txtPortSayisi.Text != "" ? int.Parse(txtPortSayisi.Text) : -1;
                op.YardimYnt = txtYardimYnt.Text;
                op.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                op.Dren = cbDiren.Text;
                op.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                op.Piyes = cbPiyes.Text;
                op.HastaID = has.ID;             
                
                _gb.tblOperatifs.InsertOnSubmit(op);
                _gb.SubmitChanges();            

                tblPosOperatif posop = new tblPosOperatif();
                posop.PerErKomp = cbPeropveErkenKomp.Text;
                posop.Dren = cbDiren.Text;

                posop.PostAnaliz = txtPostopAnaliz.Text;
                posop.Sonda = cbSonda.Text;
                posop.HospSuresi = cbHospSuresi.Text != "" ? int.Parse(cbHospSuresi.Text) : -1;
                posop.PreopKreatin = txtPreopKreatin.Text != "" ? decimal.Parse(txtPreopKreatin.Text) : 1;
                posop.PostopKreatin = txtPostoKreatin.Text != "" ? decimal.Parse(txtPostoKreatin.Text) : 1;
                posop.PreopHtc = txtPreopHct.Text != "" ? decimal.Parse(txtPreopHct.Text) : -1;
                posop.PostopHtc = txtPostopHct.Text != "" ? decimal.Parse(txtPostopHct.Text) : -1;
                posop.PreopHb = txtPreophb.Text != "" ? decimal.Parse(txtPreophb.Text) : -1;
                posop.PostopHb = txtPostopHb.Text != "" ? decimal.Parse(txtPostopHb.Text) : 1;
                posop.Takip = txtTakipPos.Text;
                posop.Tel = txtTel.Text;
                posop.PostopGec = txtGecKomp.Text;
                posop.KompClavien = cbCompClavien.Text;
                posop.HastaID = has.ID;               
                
                _gb.tblPosOperatifs.InsertOnSubmit(posop);
                _gb.SubmitChanges();
               
                tblPatoloji pat = new tblPatoloji();
                pat.Patoloji = cbPatoloji.Text;
                pat.AltGrup = txtAltGrup.Text;
                pat.FurhmanGrade = cbFurhmanGrade.Text;
                pat.PatoEvre = cbPatolojikEvre.Text;
                pat.CerrahiSinir = cbCerrahiSinir.Text;
                pat.HastaID = has.ID;              


                _gb.tblPatolojis.InsertOnSubmit(pat);
                _gb.SubmitChanges();               


                tblTakipVerileri tkp = new tblTakipVerileri();
                tkp.PUcLokal = cb3AyLNuks.Text;
                tkp.PUcKreatin = txtP3Kreatin.Text != "" ? decimal.Parse(txtP3Kreatin.Text) : -1;

                tkp.PAltiLokal = cbP6AyLNuks.Text;
                tkp.PAltiKreatin = txtP6Kreatin.Text != "" ? decimal.Parse(txtP6Kreatin.Text) : -1;

                tkp.POnikiKreatin = txtP12Kreatin.Text != "" ? decimal.Parse(txtP12Kreatin.Text) : -1;
                tkp.POnikiLokal = cbP12AyLNuks.Text;                               
                tkp.HastaID = has.ID;               

                _gb.tblTakipVerileris.InsertOnSubmit(tkp);                
                _gb.SubmitChanges();
                HastaneUDataContext _nb = new HastaneUDataContext();
                _m.YeniKayit("Kayıt başarıyla gerçekleşti.");
                Temizle();

            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        void HastaAc(int id )
        {
            try
            {
                edit = true;
                _hastaID = id;

                _demoID = id;
                _ooID = id;
                _pooID = id;
                _pattoID = id;
                _takipID = id;

                tblHasta has = _db.tblHastas.First(x => x.ID == _hastaID);
                txtAdi.Text = has.HAdi;
                txtSoyadi.Text = has.HSoyadi;
                txtProtokol.Text = has.Protokol;
                (dtOpTarihi.Text) = has.OpTarihi.ToString();
                txtOpTuruHasta.Text = has.OpTuru;
                txtTakip.Text = (has.Takip).ToString();
                cbAnah.Text = has.Anah.ToString();

                tblDemog demo = _db.tblDemogs.First(x => x.HastaID == _demoID);
                txtYas.Text = demo.Yas.ToString();
                txtBoy.Text = demo.Boy.ToString();
                txtKilo.Text = demo.Kilo.ToString();
                txtBMI.Text = demo.BMI.ToString();
                cbAsa.Text = demo.Asa.ToString();
                txtDr.Text = demo.Dr;
                cbCins.Text = demo.Cins;
                cbTaraf.Text = demo.Taraf;
                txtLokal.Text = demo.Lokalizasyon;
                txtBoyut.Text = demo.Boyut.ToString();
                txtKoMor.Text = demo.KoMor;

                tblOperatif op = _db.tblOperatifs.First(x => x.HastaID == _ooID);
                cbPksAciklama.Text = op.PksAciklama;
                cbSik.Text = op.Sik;
                txtCoOperasyon.Text = op.CoOperasyon;
                txtiskemi.Text = op.Iskemi.ToString();
                txtPortSayisi.Text = op.PortSayisi.ToString();
                txtYardimYnt.Text = op.YardimYnt;
                txtSure.Text = op.Sure.ToString();
                cbDiren.Text = op.Dren;
                txtKanama.Text = op.Kanama.ToString();
                cbPiyes.Text = op.Piyes;

                tblPosOperatif posop = _db.tblPosOperatifs.First(x => x.HastaID == _pooID);

                cbPeropveErkenKomp.Text = posop.PerErKomp;
                cbDiren.Text = posop.Dren;
                txtPostopAnaliz.Text = posop.PostAnaliz;
                cbSonda.Text = posop.Sonda;
                cbHospSuresi.Text = posop.HospSuresi.ToString();
                txtPreopKreatin.Text = posop.PreopKreatin.ToString();
                txtPreopHct.Text = posop.PreopHtc.ToString();
                txtPostopHct.Text = posop.PostopHtc.ToString();
                txtPreophb.Text = posop.PreopHb.ToString();
                txtPostopHb.Text = posop.PostopHb.ToString();
                txtTakipPos.Text = posop.Takip;
                txtTel.Text = posop.Tel;
                txtGecKomp.Text = posop.PostopGec;
                cbCompClavien.Text = posop.KompClavien;

                tblPatoloji pat = _db.tblPatolojis.First(x => x.HastaID == _pattoID);

                cbPatoloji.Text = pat.Patoloji;
                txtAltGrup.Text = pat.AltGrup;
                cbFurhmanGrade.Text = pat.FurhmanGrade;
                cbPatolojikEvre.Text = pat.PatoEvre;
                cbCerrahiSinir.Text = pat.CerrahiSinir;

                tblTakipVerileri tkp = _db.tblTakipVerileris.First(x => x.HastaID == _takipID);

                cb3AyLNuks.Text = tkp.PUcLokal;
                txtP3Kreatin.Text = tkp.PUcKreatin.ToString();

                cbP6AyLNuks.Text = tkp.PAltiLokal;
                txtP6Kreatin.Text = tkp.PAltiKreatin.ToString();

                cbP12AyLNuks.Text = tkp.POnikiLokal;
                txtP12Kreatin.Text = tkp.POnikiKreatin.ToString();
            }
            catch (Exception e)
            {

                _m.Hata(e);
            }            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && _hastaID > 0 && _m.Guncelle() == DialogResult.Yes) Guncelle();
            else if (!edit) YeniKaydet();
        }
        void Guncelle()
        {
            try
            {
                tblHasta has = _db.tblHastas.First(x => x.ID == _hastaID);
                has.HAdi = txtAdi.Text;
                has.HSoyadi = txtSoyadi.Text;
                has.Protokol = txtProtokol.Text;
                has.OpTarihi = DateTime.Parse(dtOpTarihi.Text);
                has.OpTuru = txtOpTuruHasta.Text;
                has.Takip = txtTakip.Text != "" ? int.Parse(txtTakip.Text) : -1;
                has.Anah = cbAnah.Text != "" ? int.Parse(cbAnah.Text) : -1;
                has.HastaNo = txtHastaNo.Text != "" ? int.Parse(txtHastaNo.Text) : -1; ;
                _db.SubmitChanges();


                HastaneUDataContext _gb = new HastaneUDataContext();

                tblDemog demo = new tblDemog();
                demo.Yas = txtYas.Text != "" ? int.Parse(txtYas.Text) : 1;
                demo.Boy = txtBoy.Text != "" ? decimal.Parse(txtBoy.Text) : -1;
                demo.Kilo = txtKilo.Text != "" ? decimal.Parse(txtKilo.Text) : -1;
                demo.BMI = txtBMI.Text != "" ? int.Parse(txtBMI.Text) : -1;
                demo.Asa = cbAsa.Text != "" ? int.Parse(cbAsa.Text) : -1;
                demo.Dr = txtDr.Text;
                demo.Cins = cbCins.Text;
                demo.Taraf = cbTaraf.Text;
                demo.Lokalizasyon = txtLokal.Text;
                demo.Boy = txtBoyut.Text != "" ? int.Parse(txtBoyut.Text) : 1;
                demo.KoMor = txtKoMor.Text;
                demo.HastaID = has.ID;
                _gb.SubmitChanges();

                tblOperatif op = new tblOperatif();

                op.PksAciklama = cbPksAciklama.Text;
                op.Sik = cbSik.Text;
                op.CoOperasyon = txtCoOperasyon.Text;
                op.Iskemi = txtiskemi.Text != "" ? int.Parse(txtiskemi.Text) : -1;
                op.PortSayisi = txtPortSayisi.Text != "" ? int.Parse(txtPortSayisi.Text) : -1;
                op.YardimYnt = txtYardimYnt.Text;
                op.Sure = txtSure.Text != "" ? int.Parse(txtSure.Text) : -1;
                op.Dren = cbDiren.Text;
                op.Kanama = txtKanama.Text != "" ? int.Parse(txtKanama.Text) : -1;
                op.Piyes = cbPiyes.Text;
                op.HastaID = has.ID;
                _gb.SubmitChanges();

                tblPosOperatif posop = new tblPosOperatif();

                posop.PerErKomp = cbPeropveErkenKomp.Text;
                posop.Dren = cbDiren.Text;
                posop.PostAnaliz = txtPostopAnaliz.Text;
                posop.Sonda = cbSonda.Text;
                posop.HospSuresi = cbHospSuresi.Text != "" ? int.Parse(cbHospSuresi.Text) : -1;
                posop.PreopKreatin = txtPreopKreatin.Text != "" ? decimal.Parse(txtPreopKreatin.Text) : 1;
                posop.PostopKreatin = txtPostoKreatin.Text != "" ? decimal.Parse(txtPostoKreatin.Text) : 1;
                posop.PreopHtc = txtPreopHct.Text != "" ? decimal.Parse(txtPreopHct.Text) : -1;
                posop.PostopHtc = txtPostopHct.Text != "" ? decimal.Parse(txtPostopHct.Text) : -1;
                posop.PreopHb = txtPreophb.Text != "" ? decimal.Parse(txtPreophb.Text) : -1;
                posop.PostopHb = txtPostopHb.Text != "" ? decimal.Parse(txtPostopHb.Text) : 1;
                posop.Takip = txtTakipPos.Text;
                posop.Tel = txtTel.Text;
                posop.PostopGec = txtGecKomp.Text;
                posop.KompClavien = cbCompClavien.Text;
                posop.HastaID = has.ID;
                _gb.SubmitChanges();

                tblPatoloji pat = new tblPatoloji();

                pat.Patoloji = cbPatoloji.Text;
                pat.AltGrup = txtAltGrup.Text;
                pat.FurhmanGrade = cbFurhmanGrade.Text;
                pat.PatoEvre = cbPatolojikEvre.Text;
                pat.CerrahiSinir = cbCerrahiSinir.Text;
                pat.HastaID = has.ID;
                _gb.SubmitChanges();

                tblTakipVerileri tkp = new tblTakipVerileri();

                tkp.PUcLokal = cb3AyLNuks.Text;
                tkp.PUcKreatin = txtP3Kreatin.Text != "" ? decimal.Parse(txtP3Kreatin.Text) : -1;

                tkp.PAltiLokal = cbP6AyLNuks.Text;
                tkp.PAltiKreatin = txtP6Kreatin.Text != "" ? decimal.Parse(txtP6Kreatin.Text) : -1;

                tkp.POnikiKreatin = txtP12Kreatin.Text != "" ? decimal.Parse(txtP12Kreatin.Text) : -1;
                tkp.POnikiLokal = cbP12AyLNuks.Text;
                tkp.HastaID = has.ID;
                _gb.SubmitChanges();


                _m.Guncelle(true);
                Temizle();

            }
            catch (Exception e)
            {
                _m.Hata(e);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPatoloji_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       


    }
}
