using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace emlakcim.admin
{
    public partial class ilandetayekle : System.Web.UI.Page
    {
        esqlbaglantisi baglan = new esqlbaglantisi() ;
        protected void Page_Load(object sender, EventArgs e)
        {
            ddl_ilan.Enabled = false;
            SqlCommand cmdi = new SqlCommand("Select  TOP 1 *from Ilan order by ilanID desc",baglan.baglan());
            SqlDataReader dri = cmdi.ExecuteReader();

            ddl_ilan.DataTextField = "ilanBaslik";
            ddl_ilan.DataValueField = "ilanID";
            ddl_ilan.DataSource = dri;
            ddl_ilan.DataBind();

        }

        protected void btn_dtyEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmdde = new SqlCommand("insert into ilanDetay (idOdaSayisi,idBinaninYasi,idBinaKat,idBinaKacinciKat,idIsitma,idEsyalimi,ilanID) Values ('"+txt_odasayisi.Text+"','"+txt_binayasi.Text+"','"+txt_binakat.Text+"','"+txt_kacincikat.Text+"','"+txt_isitma.Text+"','"+cbox_esya.Checked+"','"+ddl_ilan.SelectedValue+"')",baglan.baglan());
            cmdde.ExecuteNonQuery();
            Response.Redirect("ilanresimekle.aspx");
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}