using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakcim.admin
{
    public partial class ilanozellikekle : System.Web.UI.Page
    {
        esqlbaglantisi baglan = new esqlbaglantisi();

        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_ilan.Enabled = false;
            SqlCommand cmd = new SqlCommand(" Select  TOP 1 *from Ilan order by ilanID desc", baglan.baglan());
            SqlDataReader dr= cmd.ExecuteReader();
            ddl_ilan.DataTextField = "ilanBaslik";
            ddl_ilan.DataValueField = "ilanID";
            ddl_ilan.DataSource = dr;
            ddl_ilan.DataBind();

        }

        protected void btn_ekle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdio = new SqlCommand("insert into IcOzellik(kuvet,asansör,sömine,kapici,ilanID) Values('"+cbox_kuvet.Checked+"','"+cbox_asansör.Checked+"','"+cbox_sömine.Checked+"','"+cbox_kapici.Checked+"','"+ddl_ilan.SelectedValue+"')", baglan.baglan());
            cmdio.ExecuteNonQuery();

            SqlCommand cmddo = new SqlCommand("insert into DisOzellik(alarm,park,oyun,yuruyus,ilanID) Values('"+cbox_alarm.Checked+"','"+cbox_park.Checked+"','"+cbox_oyun.Checked+"','"+cbox_yuruyus.Checked+"','"+ddl_ilan.SelectedValue+"')", baglan.baglan());
            cmddo.ExecuteNonQuery();
            Response.Redirect("panel.aspx");
        }
        
    }
}