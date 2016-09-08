using System;
using System.Configuration; //Web.config varten
using System.Data; //ADO.NET:in luokkia varten
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HaeTyontekijat : System.Web.UI.Page
{
    string xmlfile;
    protected void Page_Load(object sender, EventArgs e)
    {
        //luetaan web.config:ista xml tiedoston nimi
        xmlfile = ConfigurationManager.AppSettings["tiedosto"];
        lbMessage.Text = xmlfile;
    }

    protected void btnHae_Click(object sender, EventArgs e)
    {
        //luetaan xml tiedostosta työntekijöitten tiedot ja esitetään ne gridviewssä
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();
        DataView dv = new DataView();
        ds.ReadXml(Server.MapPath(xmlfile));
        dt = ds.Tables[0];
        dv = dt.DefaultView;
        //datan sitominen ui-kontrolliin
        gvData.DataSource = dv;
        gvData.DataBind();
        lbMessage.Text = string.Format("Löytyi {0} työntekijää", dt.Rows.Count);
    }
}