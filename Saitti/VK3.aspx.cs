using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VK3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Populate_MonthList();
            Populate_YearList();
        }
    }

    protected void Populate_MonthList()
    {
        var dtf = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
        for (int i = 1; i <= 12; i++)
            drpCalMonth.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));
        drpCalMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
    }


    protected void Populate_YearList()
    {
        for (int intYear = DateTime.Now.Year - 60; intYear <= DateTime.Now.Year; intYear++)
        {
            drpCalYear.Items.Add(intYear.ToString());
        }
        drpCalYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
    }

    protected void cdBirthday_SelectionChanged(object sender, EventArgs e)
    {
        lbToday.Text = "Tänään on: " + cdBirthday.TodaysDate.ToShortDateString();
        lbBirthday.Text = "Syntymäpäiväsi on: " + cdBirthday.SelectedDate.ToShortDateString();
        DateTime startDay = cdBirthday.SelectedDate;
        DateTime endDay = cdBirthday.TodaysDate;
        lbFinal.Text = "Valitun päivän ja tämän päivän erotus on: " + (endDay - startDay).TotalDays;
    }

    protected void Set_Calendar(object Sender, EventArgs e)
    {
        int year = int.Parse(drpCalYear.SelectedValue);
        int month = int.Parse(drpCalMonth.SelectedValue);
        cdBirthday.VisibleDate = new DateTime(year, month, 1);
    }
}