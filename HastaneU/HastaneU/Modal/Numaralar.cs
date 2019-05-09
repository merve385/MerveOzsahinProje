using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HastaneU.Modal;

namespace HastaneU.Modal
{
    class Numaralar
    {
        HastaneUDataContext _db = new HastaneUDataContext();
        public string HastaNo()
        {
            try
            {
                int numara = (from s in _db.tblHastas
                               orderby s.ID descending
                               select s).First().HastaNo.Value;
                numara++;
                string num = numara.ToString().PadLeft(7, '0');
                return num;
            }
            catch (Exception)
            {
                return "0000001";
            }
        }
    }
}
