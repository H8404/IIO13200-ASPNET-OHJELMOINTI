using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class H3Target : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        string msg = "";
        //VE1 Query String
        msg += "<h3>QueryString</h3>";
        msg += "URLissa välitetty viesti: " + Request.QueryString["Message"];
        msg += "<br/>";
        //RequestQueryString on kokoelma joka voidan loopitta
        foreach (string key in Request.QueryString)
        {
            msg += "URLista löytyy avain: " + key + " ja sen arvo on " + Request.QueryString[key] + "<br/>";
        }
        //VE2 SESSION
        msg += "<h3>Session</h3>";
        msg += "Sessionista haettu viesti: " + Session["Message"];
        //tulos näkyviin HTML:ään

        //VE3 KEKSIT
        msg += "<h3>KEKSIT</h3>";
        foreach (string kex in Request.Cookies)
        {
            if(kex == "Message")
            {
                msg += "Keksissä lukee " + Request.Cookies[kex].Value;
            }
        }
        //VE4 Luetaan edellisen sivun property
        msg += "<h3>Propertyn lukeminen</h3>";
        var previouspage = PreviousPage;
        if(previouspage != null)
        {
            msg += "Ed.sivun property on "; //+ previouspage.SecretMessage;
        }

        myText.InnerHtml = msg;
    }
}