using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakcim
{
    public partial class _default : System.Web.UI.Page
    {
        esqlbaglantisi baglan = new esqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlCommand cmdslider = new SqlCommand("Select *from Ilan",baglan.baglan());
            SqlDataReader drslider = cmdslider.ExecuteReader();

            dl_slider.DataSource = drslider;
            dl_slider.DataBind();
        }
    }
}