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
    public partial class frmHastaNo : Form
    {
        HastaneUDataContext _db = new HastaneUDataContext();
        Mesajlar _m = new Mesajlar();
        Formlar _f = new Formlar();
        public bool Secim = true;
        bool _edit = false;

        int _secimId = -1;

        public frmHastaNo()
        {
            InitializeComponent();
        }

        private void frmHastaNo_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
            Liste.Rows.Clear();
            int i = 0;
            var lst = (from s in _db.tblHastas
                       where s.Protokol.Contains(txtHastaBul.Text)
                       select s).OrderBy(x => x.Protokol).ToList();
            foreach (var k in lst)
            {
                Liste.Rows.Add();
                Liste.Rows[i].Cells[0].Value = k.ID;
                Liste.Rows[i].Cells[1].Value = k.Protokol;
                Liste.Rows[i].Cells[2].Value = k.HAdi;

                i++;
            }
            Liste.AllowUserToAddRows = false;
        }
        void Sec()
        {
            try
            {
                _secimId = int.Parse(Liste.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception)
            {
                _secimId = -1;
            }
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (Secim && _secimId > 0)
            {
                Form1.Aktarma = _secimId;
                Close();
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
