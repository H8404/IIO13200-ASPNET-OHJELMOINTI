using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using JAMK.IT;
using Newtonsoft;

public partial class demoJson : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGet_Click(object sender, EventArgs e)
    {
        try
        {
            //Hae JSON
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP.txt");
            ltResult.Text = json;
        }
        catch (Exception ex)
        {

            ltResult.Text = ex.Message;
        }

    }
    protected string GetJsonFrom(string url)
    {
        using (WebClient wc = new WebClient())
        {
            var json = wc.DownloadString(url);
            return json;
        }
    }

    protected void btnObject_Click(object sender, EventArgs e)
    {
        try
        {
            //Hae JSON
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTestP.txt");
            Person p = Newtonsoft.Json.JsonConvert.DeserializeObject<Person>(json);
            ltResult.Text = string.Format("Löytyi henkilö {0} syntynyt {1}",p.Name,p.Birthday);
        }
        catch (Exception ex)
        {

            ltResult.Text = ex.Message;
        }

    }

    protected void btnObjectlist_Click(object sender, EventArgs e)
    {
        try
        {
            //Hae JSON
            string json = GetJsonFrom("http://student.labranet.jamk.fi/~salesa/mat/JsonTest");
            List<Politic> hallitus = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Politic>>(json);
            string ret = "<h2>Suomen hallitus</h2><ul>";
            foreach (var ministeri in hallitus)
            {
                ret += "<li>" + ministeri.Name + " " + ministeri.Party + "</li>";
            }
            ret += "</ul>";
            ltResult.Text = ret;
        }
        catch (Exception ex)
        {

            ltResult.Text = ex.Message;
        }
    }
}