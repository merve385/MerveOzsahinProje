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
    public partial class ilanresimekle : System.Web.UI.Page
    {
        esqlbaglantisi baglan = new esqlbaglantisi();
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_ilan.Enabled = false;
            SqlCommand cmdi = new SqlCommand("Select TOP 1 *from Ilan order by ilanID desc",baglan.baglan());
            SqlDataReader dri = cmdi.ExecuteReader();
            ddl_ilan.DataTextField = "ilanBaslik";
            ddl_ilan.DataValueField = "ilanID";

            ddl_ilan.DataSource = dri;
            ddl_ilan.DataBind();
        }

        protected void ddl_ilan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btn_rEkle_Click(object sender, EventArgs e)
        {
            if(fu_iresim.HasFile)
            {
                fu_iresim.SaveAs(Server.MapPath("//iresim" + fu_iresim.FileName));
                SqlCommand cmde = new SqlCommand("insert into Resim (resimAd,resimResim,ilanID) Values('"+txt_rAd+"','"+fu_iresim.FileName+"','"+ddl_ilan.SelectedValue+"')", baglan.baglan());
                cmde.ExecuteNonQuery();
                Response.Redirect("ilanresimekle.aspx");
            }
            else
            {
                btn_rEkle.Text = "Resim Ekleyiniz";
            }
        }

        protected void btn_bitir_Click(object sender, EventArgs e)
        {
            Response.Redirect("ilanozellikekle.aspx");

        }
    }
}