using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        string userName = TextBox3.Text;
        string password = TextBox4.Text;
        DataBaseManagment dbm = new DataBaseManagment();
        string retVal = dbm.Login(userName, password);
        if (!retVal.Equals("wrong"))
        {
            Session["user"] = userName;

            if (retVal.TrimEnd().Equals("admin"))
            {
                Response.Redirect("AdminHome.aspx");
            }
            else
                Response.Redirect(Session["curr"].ToString().TrimEnd());
        }
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
}