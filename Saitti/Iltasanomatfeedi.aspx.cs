using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class Iltasanomatfeedi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetFeeds_Click(object sender, EventArgs e)
    {
        //asetetaan rss feedi xmldatasourcen lähteeksi
        string url = @"http://www.iltasanomat.fi/rss/tuoreimmat.xml";
        myDataSource.DataFile = url;
        GetFeeds();
    }

    protected void btnGetYle_Click(object sender, EventArgs e)
    {
        //asetetaan rss feedi xmldatasourcen lähteeksi
        string url = @"http://feeds.yle.fi/uutiset/v1/majorHeadlines/YLE_UUTISET.rss";
        myDataSource.DataFile = url;
        GetFeeds();
    }

    private void GetFeeds()
    {
        try
        {
            //käytetään XmlDocument luokkaa
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            //aluksi haetaan kanavan tietoja
            XmlNode node1 = doc.SelectSingleNode("/rss/channel");
            string title = node1["title"].InnerText;
            myDiv.InnerHtml = string.Format("<h1>{0} {1}</h1>", title, DateTime.Now.ToString());
            //Kaikki item elementit ja looppi niihin
            XmlNodeList nodes = doc.SelectNodes("/rss/channel/item");
            string cat;
            string link;
            string piclink;
            foreach (XmlNode n in nodes)
            {
                if (n["enclosure"] != null)
                {
                    piclink = n["enclosure"].GetAttribute("url");

                }else
                {
                    piclink = "http://student.labranet.jamk.fi/~salesa/pic/nope.png";
                }
                myDiv.InnerHtml += string.Format("<img src='{0}' style='height:50px'>", piclink);
                cat = n["category"].InnerText;
                title = n["title"].InnerText;
                link = n["link"].InnerText;
                myDiv.InnerHtml += string.Format("{0} <a href='{1}'>{2}</a><br>", cat, link, title);
            }
        }
        catch (Exception ex )
        {

            myDiv.InnerHtml = ex.Message;
        }
    }

  
}