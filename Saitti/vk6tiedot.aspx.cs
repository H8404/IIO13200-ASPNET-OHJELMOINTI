using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class vk6tiedot : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        
        string url = @"App_Data/LevykauppaX.xml";
        myDataSource.DataFile = url;
        GetMusic();
    }

    private void GetMusic()
    {
        try
        {
            string isbnFromURL = Request.QueryString["isbn"];
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            string artist;
            string title;
            string price;
            string song;
            XmlNodeList nodes = doc.SelectNodes("/Records/genre/record[@ISBN='"+isbnFromURL+"']");
            foreach (XmlNode n in nodes)
            {
                artist = n.Attributes["Artist"].Value;
                title = n.Attributes["Title"].Value;
                price = n.Attributes["Price"].Value;
                myDiv.InnerHtml += "<h2>" + artist + ": " + title + "</h2>";
                myDiv.InnerHtml += "<img src='Images/" + isbnFromURL + ".jpg' style='height:150px'/></br>";
                myDiv.InnerHtml += "<span>ISBN: " + isbnFromURL + "</span><br>";
                myDiv.InnerHtml += "<span>Hinta:" + price + "</span></br>";
            }
            XmlNodeList songs = doc.SelectNodes("/Records/genre/record[@ISBN='" + isbnFromURL + "']/song");
            foreach (XmlNode s in songs)
            {
                song = s.Attributes["name"].Value;
                myDiv.InnerHtml += "<span>"+song+"</span></br>";
            }
        }
        catch (Exception ex)
        {

            myDiv.InnerHtml = ex.Message;
        }
    }
}