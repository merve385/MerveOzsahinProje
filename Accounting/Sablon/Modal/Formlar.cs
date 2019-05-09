using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.Modal
{
    class Formlar
    {
        #region InformationEntry

        public int Category(bool secim=false)
        {
            Bilgi.frmCategoryEntry frm = new Bilgi.frmCategoryEntry();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return frmAnaSayfa.Aktarma;
        }
        public void Shippers()
        {
            Bilgi.frmShippers frm = new Bilgi.frmShippers();
            frm.ShowDialog();
        }

        public int KulGiris(bool secim=false)
        {
            Bilgi.frmEmployee frm = new Bilgi.frmEmployee();
            if (secim)
            {
                frm.Secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.ShowDialog();
            }
            return frmAnaSayfa.Aktarma;
        }

        public void FirmaGiris()
        {
            Bilgi.frmCompany frm = new Bilgi.frmCompany();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public int FirmaList(bool secim=false)
        {
            Bilgi.frmCompanyList frm = new Bilgi.frmCompanyList();
            if(secim)
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
            return frmAnaSayfa.Aktarma;
        }
        public void UrunGiris()
        {
            Bilgi.frmProduct frm = new Bilgi.frmProduct();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public int UrunList(bool secim = false)
        {
            Bilgi.frmProductList frm = new Bilgi.frmProductList();
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
            return frmAnaSayfa.Aktarma;
        }
        #endregion
        #region SalesProcess
        public void Alis()
        {
            AlSat.frmAlis frm = new AlSat.frmAlis();
            frm.MdiParent = Form.ActiveForm;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        public int AlisList(bool secim = false)
        {
            AlSat.frmAlisList frm = new AlSat.frmAlisList();
            if (secim)
            {
                frm.secim = true;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = Form.ActiveForm;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            return frmAnaSayfa.Aktarma;
        }

        #endregion

        #region StockProcess

        #endregion
    }
}
