using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using JAMK.IT;
using System.Data;

public partial class vk5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            loadCities();
        }

    }

    protected void btnGetTrains_Click(object sender, EventArgs e)
    {
        try
        {
            //Hae JSON
            string shortCode = ddCity.SelectedValue;
            string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/live-trains?station="+shortCode+ "&arrived_trains=0&arriving_trains=0&departed_trains=0&departing_trains=50");
            List<Train> trains = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Train>>(json);
            string ret = "<h2>Lähtevät junat</h2><ul>";
            foreach (var train in trains)
            {
                ret += "<li>" + train.trainNumber + " " + train.cancelled + " " + train.departureDate +"</li>";
            }
            ret += "</ul>";
            ltResult.Text = ret;
           /* DataTable dt = new DataTable();
            DataRow dr = null;
            dt.Columns.Add(new DataColumn("Junan numero", typeof(string)));
            dt.Columns.Add(new DataColumn("Peruutettu", typeof(Boolean)));
            dt.Columns.Add(new DataColumn("Päivämäärä", typeof(string)));
            foreach (var train in trains)
            {
                dr["Junan numero"] = train.trainNumber;
                dr["Peruutettu"] = train.cancelled;
                dr["Päivämäärä"] = train.departureDate;
                dt.Rows.Add(dr);
            }
            gvTrains.DataSource = dt;
            gvTrains.DataBind();*/

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
    protected void loadCities()
    {
        try
        {
            //Hae JSON
            string json = GetJsonFrom("http://rata.digitraffic.fi/api/v1/metadata/stations");
            List<City> cities = Newtonsoft.Json.JsonConvert.DeserializeObject<List<City>>(json);
            foreach (var city in cities)
            {
                if (city.passengerTraffic == true && city.type == "STATION")
                {
                    ddCity.Items.Add(new ListItem(city.stationName, city.stationShortCode));
                }
            }
            
        }
        catch (Exception ex)
        {

            ltResult.Text = ex.Message;
        }
    }

}