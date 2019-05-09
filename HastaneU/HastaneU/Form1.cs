using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneU
{
    public partial class Form1 : Form
    {
        Modal.HastaneUDataContext _db = new Modal.HastaneUDataContext();
        Modal.Formlar _f = new Modal.Formlar();
		public static string Aktarma2="";

        public static int Aktarma = -1;


        public Form1()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            _f.HastaGiris();
        }

		private void btnRapor_Click(object sender, EventArgs e)
		{
			_f.RaporList();
		}
	}
}
