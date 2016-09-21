using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class VK2Lotto : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRandNumbers_Click(object sender, EventArgs e)
    {
        int rows;
        if (Int32.TryParse(txtRows.Text, out rows) && rows > 0)
        {
            if (ddType.SelectedValue == "lotto")
            {
                var lotteryNumbers = new JAMK.ICT.BL.BLLottery().randomLottery();
                var result = string.Join(" ", lotteryNumbers.Select(x => x.ToString()).ToArray());
                lbRandNumbers.Text = result;
            }
            else
            {
                var lotteryNumbers = new JAMK.ICT.BL.BLLottery().randomVikingLottery();
                var result = string.Join(" ", lotteryNumbers.Select(x => x.ToString()).ToArray());
                lbRandNumbers.Text = result;
            }
        }
        else
        {
            lbRandNumbers.Text = "Rivi kenttä saa sisältää vain positiivisia numeroita";
        }
    }
}