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


namespace Accounting.AlSat
{
    public partial class frmAlisList : Form
    {
        AccountingDBDataContext _db = new AccountingDBDataContext();
        public bool secim ;
        public int alId = -1;
        int _secimId = -1;


        public frmAlisList()
        {
            InitializeComponent();
        }

        private void frmAlisList_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblPurchasings
                      select new {
                         p= s.PurNo,n=s.tblCompany.Name,d=s.Date//,id=s.ID
                      }).Distinct().OrderByDescending(x=>x.d).OrderBy(y=>y.n);
            foreach (var k in lst)
            {
                Liste.Rows.Add();
               // Liste.Rows[i].Cells[0].Value = k.id;//alış noyu tekrarlatmamak için ıd kısmını kapattık üstekini de kaldırdık.
                Liste.Rows[i].Cells[0].Value = k.p;
                Liste.Rows[i].Cells[1].Value = k.n;
                Liste.Rows[i].Cells[2].Value = k.d;
                i++;

            }
            Liste.AllowUserToAddRows = false;
            Liste.ReadOnly = true;
        }
        void Sec()
        {
            try
            {
                alId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                alId = -1;
            }
        }
        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && alId > 0)
            {
                frmAnaSayfa.Aktarma = alId;
                Close();
            }
        }
    }
}
