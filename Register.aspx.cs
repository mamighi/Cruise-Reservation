using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Register : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (!checkdata())
            return;
        DataManage.user user = new DataManage.user();
        user.username = TextBox3.Text;
        user.password = TextBox4.Text;
        user.fn = TextBox6.Text;
        user.ln = TextBox7.Text;
        user.email = TextBox8.Text;
        user.cn = TextBox9.Text;
        user.uml = "user";
        DataBaseManagment dbm = new DataBaseManagment();
        if(!dbm.addNewUser(user))
        {
            Label3.Text = "Please choose another user name";
            Label3.Visible = true;
            return;
        }
        Session["user"] = user.username;
        Response.Redirect("Default.aspx");
    }
    public bool checkdata()
    {
        if(TextBox3.Text.Length<1 ||TextBox4.Text.Length<1 ||TextBox6.Text.Length<1 ||TextBox7.Text.Length<1 ||TextBox8.Text.Length<1 ||TextBox9.Text.Length<1)
        {
            Label3.Text = "Please fill all field";
            Label3.Visible = true;
            return false;
        }
        if(!TextBox4.Text.Equals(TextBox5.Text))
        {
            Label3.Text = "Passwords Are not macth";
            Label3.Visible = true;
            return false;
        }
        return true;
    }
}