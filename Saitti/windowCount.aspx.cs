using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class windowCount : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnCount_Click(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtWidth.Text) && !string.IsNullOrWhiteSpace(txtHeight.Text) && !string.IsNullOrWhiteSpace(txtFrame.Text))
        {
            double parsedValue;
            if (double.TryParse(txtWidth.Text, out parsedValue) && double.TryParse(txtHeight.Text, out parsedValue) && double.TryParse(txtFrame.Text, out parsedValue))
            {
                double width = Convert.ToDouble(txtWidth.Text);
                double height = Convert.ToDouble(txtHeight.Text);
                lbArea.Text = "Ikkunan pinta-ala :" + CountArea(width, height).ToString() + " m^2";
                lbPerimeter.Text = "Karmipuun piiri: " + CountPerimeter(width, height).ToString() + " m";
                lbFinalPrice.Text = "Tarjoushinta (Ilman ALV): " + CountPrice(CountArea(width, height), CountPerimeter(width, height)).ToString() + " €";
                lbMessage.Text = "";
            }
            else
            {
                lbMessage.Text = "Kentissä saa olla vain numeroita";
            }
        }
        else
        {
            lbMessage.Text = "Täytä tyhjät kentät ensin!";
        }
    }

    private double CountArea(double w, double h)
    {
        double mmArea = w * h;
        double area = mmArea * 0.000001;
        return area;
    }

    private double CountPerimeter(double w, double h)
    {
        double mmPerimeter = (2 * w) + (2 * h);
        double perimeter = mmPerimeter * 0.001;
        return perimeter;
    }

    private double CountPrice(double a, double r)
    {
        double squarePrice = 45;
        double cover = 0.3;
        double workPrice = 150;
        double aluminum = 100;
        double finalPrice = (1 + cover) * ((a * squarePrice) + (r * aluminum) + workPrice);
        return finalPrice;
    }
}