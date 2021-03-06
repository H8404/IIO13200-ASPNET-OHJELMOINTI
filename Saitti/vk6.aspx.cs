﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

public partial class vk6 : System.Web.UI.Page
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
            XmlDocument doc = new XmlDocument();
            doc = myDataSource.GetXmlDocument();
            string artist;
            string title;
            string isbn;
            string price;
            XmlNodeList nodes = doc.SelectNodes("/Records/genre/record");
            foreach (XmlNode n in nodes)
            {
                artist = n.Attributes["Artist"].Value;
                title = n.Attributes["Title"].Value;
                isbn = n.Attributes["ISBN"].Value;
                price = n.Attributes["Price"].Value;
                myDiv.InnerHtml += "<h2>" + artist + ": " + title + "</h2>";
                myDiv.InnerHtml += "<img src='Images/" + isbn + ".jpg' style='height:150px'/><br>";
                myDiv.InnerHtml += "<span>ISBN:</span><a href='vk6tiedot.aspx?isbn="+isbn+"' >" + isbn + "</a><br>";
                myDiv.InnerHtml += "<span>Hinta:"+price+"</span>";
            }
        }
        catch (Exception ex)
        {

            myDiv.InnerHtml = ex.Message;
        }
    }
}