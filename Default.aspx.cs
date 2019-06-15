using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["curr"] = "Default.aspx";
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Reservation.aspx");
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("CheckReservation.aspx");
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        Response.Redirect("Aboutus.aspx");

    }
}