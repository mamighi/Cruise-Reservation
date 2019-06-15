using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserMasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] != null)
        {
            login.Visible = false;
            Label3.Visible = true;
            Button3.Visible = true;
            Label3.Text = "Welcome " + Session["user"];
        }
        else
        {
            login.Visible = true;
            Label3.Visible = false;
            Button3.Visible = false;
        }


    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string userName = TextBox1.Text;
        string password = TextBox2.Text;
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
        else
            Response.Redirect("Login.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Logout.aspx");
    }
}
