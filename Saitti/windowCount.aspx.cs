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
        double width = Convert.ToDouble(txtWidth.Text);
        double height = Convert.ToDouble(txtHeight.Text);
        txtArea.Text = CountArea(width, height).ToString();
        txtPerimeter.Text = CountPerimeter(width, height).ToString();
    }

    private double CountArea(double w, double h)
    {
        double area = w * h;
        return area;
    }

    private double CountPerimeter(double w, double h)
    {
        double perimeter = (2 * w) + (2 * h);
        return perimeter;
    }

    private void CountPrice(double w, double h)
    {
        double squarePrice = 45;
        double cover = 0.3;
        double workPrice = 150;

    }
}