using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace emlakcim
{
    public class esqlbaglantisi
    {
        public SqlConnection baglan()
        {
            
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-PLPCTU0\SQLEXPRES; Initial Catalog=emlakcimDB; Integrated Security=true;");
            baglanti.Open();
         
            SqlConnection.ClearAllPools();
            SqlConnection.ClearPool(baglanti);
            return (baglanti);
        }
    }
}