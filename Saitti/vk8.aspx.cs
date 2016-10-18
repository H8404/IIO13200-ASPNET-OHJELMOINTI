using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class vk8 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            GetCities();
        }
    }

    protected void GetCities()
    {
        try
        {
            string url = @"http://www.finnkino.fi/xml/TheatreAreas/";
            myDataSource.DataFile = url;
            string name;
            string id;
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            XmlNodeList nodes = doc.SelectNodes("/TheatreAreas/TheatreArea");
            foreach (XmlNode n in nodes)
            {
                name = n["Name"].InnerText;
                id = n["ID"].InnerText;
                lbCity.Items.Add(new ListItem(name,id));
            }
        }
        catch (Exception ex)
        {
            lbMsg.Text = ex.Message;
        }
    }

    protected void GetMovies()
    {
        string url = @"http://www.finnkino.fi/xml/Schedule/?area=1015&dt=18.10.2016";
        myDataSource.DataFile = url;
    }

    protected void lbCity_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            picsdiv.InnerHtml = "";
            string picURL;
            string id = lbCity.SelectedValue;
            string day = DateTime.Now.ToShortDateString();
            string url = @"http://www.finnkino.fi/xml/Schedule/?area=" + id + "&dt=" + day;
            myDataSource.DataFile = url;
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            XmlNodeList nodes = doc.SelectNodes("/Schedule/Shows/Show/Images");
            foreach (XmlNode n in nodes)
            {
                picURL = n["EventLargeImagePortrait"].InnerText;
                picsdiv.InnerHtml += "<img src='" + picURL + "' alt='leffa' />";
            }
        }
        catch (Exception ex)
        {
            lbMsg.Text = ex.Message;
        }
    }


}