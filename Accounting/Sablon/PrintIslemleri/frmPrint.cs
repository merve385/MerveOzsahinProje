using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.Modal;

namespace Accounting.PrintIslemleri
{
    public partial class frmPrint : Form
    {
        AccountingDBDataContext db = new AccountingDBDataContext();
        public string HangiListe;
        public frmPrint()
        {
            InitializeComponent();
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            switch (HangiListe)
            {
                case "Alis":
                    Alis();
                    break;
            }
        }
        private void Alis()
        {
            AlSat.frmAlis als = Application.OpenForms["frmAlis"] as AlSat.frmAlis;
            pAlis cr = new pAlis();
            var srg = (from s in db.vwAlis
                       where s.PurNo == int.Parse(als.txtAlisNo.Text)
                       select s).ToList();
            PrintYardim ch = new PrintYardim();
            DataTable dt = ch.ConvertTo(srg);
            cr.SetDataSource(dt);
            crvPrint.ReportSource = cr;
        }
    }
}
