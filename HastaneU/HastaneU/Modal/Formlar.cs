using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneU.Modal
{
    class Formlar
    {
		public bool Secim = false;
	
		public void HastaGiris()
        {
            Bilgi.frmHastaGirisi frm = new Bilgi.frmHastaGirisi();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
		public string OPTuruList(bool secim = false)
		{
			Bilgi.frmOpTuruListe frm = new Bilgi.frmOpTuruListe();
			if (secim)
			{
				
				frm.ShowDialog();
			}
			else
			{
				
				frm.ShowDialog();
			}
			return Form1.Aktarma2;
		}
		public string DrList(bool secim = false)
		{
			Bilgi.frmDoktor frm = new Bilgi.frmDoktor();
			if (secim)
			{
			  
				frm.ShowDialog();
			}
			else
			{
				
				frm.ShowDialog();
			}
			return Form1.Aktarma2;
		}
		public string KoMorList(bool secim = false)
		{
			Bilgi.frmKoMor frm = new Bilgi.frmKoMor();
			if (secim)
			{
				frm.ShowDialog();

			}
			else
			{
				frm.ShowDialog();
			}
			return Form1.Aktarma2;
		}
        public int HastaList(bool secim = false)
        {
            Bilgi.frmHastaNo frm = new Bilgi.frmHastaNo();
            if (secim)
            {
               	frm.Secim = true;				
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.ShowDialog();
            }
            return Form1.Aktarma;
        }
		public int RaporList(bool secim = false)
		{
			Bilgi.frmAra frm = new Bilgi.frmAra();
			if (secim)
			{
				frm.Secim = true;
				frm.ShowDialog();
			}
			else
			{
				frm.MdiParent = Form.ActiveForm;
				frm.WindowState = FormWindowState.Maximized;
				frm.Show();
				
			}
			return Form1.Aktarma;
		}
	}
}
