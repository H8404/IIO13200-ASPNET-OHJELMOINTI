using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class H3 : System.Web.UI.Page
{
    public string SecretMessage
    {
        get { return SecretMessage; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        //Alustetaan kontrollit jne
        if (!IsPostBack)
        {
            ddlMessages.Items.Add("JEEEEEEE");
            ddlMessages.Items.Add("HFJJGH");
            ddlMessages.Items.Add("Voi juku");
        }
        
    }

    protected void btnQuery_Click(object sender, EventArgs e)
    {
        Response.Redirect("H3Target.aspx?User=Hanna&Message=" + txtMessage.Text);
    }

    protected void btnSession_Click(object sender, EventArgs e)
    {
        Session["Message"] = txtMessage.Text;
        Response.Redirect("H3Target.aspx");
    }

    protected void btnCookie_Click(object sender, EventArgs e)
    {
        HttpCookie cookie = new HttpCookie("Message", txtMessage.Text);
        cookie.Expires = DateTime.Now.AddMinutes(15);
        Response.Cookies.Add(cookie);
    }

    protected void btnPublicProperty_Click(object sender, EventArgs e)
    {
        Server.Transfer("H3Target.aspx");
    }

    protected void ddlMessages_SelectedIndexChanged(object sender, EventArgs e)
    {
        txtMessage.Text = ddlMessages.SelectedItem.ToString();
    }
}