using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

public partial class jep : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnMysql_Click(object sender, EventArgs e)
    {
        try
        {
            //string cs = "server=mysql.labranet.jamk.fi;database=H8404_3;user=H8404;password=dWcKwAt9Ftw25xxB25jP7nb8ZHUdf5rL";
            string cs = System.Configuration.ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
            DataTable dt = JAMK.ICT.Data.DBPlacebo.GetMySql(cs);
            gvCities.DataSource = dt;
            gvCities.DataBind();
        }
        catch (Exception ex)
        {

            lbmsq.Text = ex.Message;
        }
    }
}