using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddNewCruise : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox11.Enabled = false;
            TextBox12.Enabled = false;
            TextBox13.Enabled = false;
            TextBox14.Enabled = false;
            TextBox15.Enabled = false;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (!checkData())
            return;
        DataBaseManagment dbm = new DataBaseManagment();
        DataManage.cruise cruise = new DataManage.cruise();
        cruise.ccode = TextBox1.Text;
        cruise.cname = TextBox2.Text;
        cruise.cabNum = Int32.Parse(TextBox3.Text);
        cruise.des = TextBox4.Text;

        cruise.econ = (CheckBox1.Checked) ? 1 : 0;
        try
        {
            cruise.econcab = Int32.Parse(TextBox4.Text);
            cruise.econcap = Int32.Parse(TextBox6.Text);
            cruise.econrate = Int32.Parse(TextBox5.Text);
            cruise.econdes = TextBox7.Text;
        }
        catch(Exception ex)
        {
            cruise.econcab = 0;
            cruise.econcap = 0;
            cruise.econrate = 0;
            cruise.econdes = TextBox7.Text;
        }

        cruise.perm = (CheckBox2.Checked) ? 1 : 0;
        try
        {
            cruise.permcab = Int32.Parse(TextBox8.Text);
            cruise.permcap = Int32.Parse(TextBox10.Text);
            cruise.permrate = Int32.Parse(TextBox9.Text);
            cruise.permdes = TextBox11.Text;
        }
        catch(Exception ex)
        {
            cruise.permcab = 0;
            cruise.permcap = 0;
            cruise.permrate = 0;
            cruise.permdes = TextBox11.Text;
        }
        cruise.lux = (CheckBox3.Checked) ? 1 : 0;
        try
        {

            cruise.luxcab = Int32.Parse(TextBox12.Text);
            cruise.luxcap = Int32.Parse(TextBox14.Text);
            cruise.lucrate = Int32.Parse(TextBox13.Text);
            cruise.luxdes = TextBox15.Text;
        }
        catch(Exception ex)
        {
            cruise.luxcab = 0;
            cruise.luxcap = 0;
            cruise.lucrate = 0;
            cruise.luxdes = TextBox15.Text;
        }

        dbm.addNewCruise(cruise);
        Response.Redirect("AdminHome.aspx");
    }
    protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
        if(!CheckBox1.Checked)
        {
            TextBox4.Enabled = false;
            TextBox5.Enabled = false;
            TextBox6.Enabled = false;
            TextBox7.Enabled = false;
        }
        else
        {
            TextBox4.Enabled = true;
            TextBox5.Enabled = true;
            TextBox6.Enabled = true;
            TextBox7.Enabled = true;
        }
    }
    protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
    {
        if(!CheckBox2.Checked)
        {
            TextBox8.Enabled = false;
            TextBox9.Enabled = false;
            TextBox10.Enabled = false;
            TextBox11.Enabled = false;
        }
        else
        {
            TextBox8.Enabled = true;
            TextBox9.Enabled = true;
            TextBox10.Enabled = true;
            TextBox11.Enabled = true;
        }
    }
    protected void CheckBox3_CheckedChanged(object sender, EventArgs e)
    {
        if (!CheckBox3.Checked)
        {
            TextBox12.Enabled = false;
            TextBox13.Enabled = false;
            TextBox14.Enabled = false;
            TextBox15.Enabled = false;
        }
        else
        {
            TextBox12.Enabled = true;
            TextBox13.Enabled = true;
            TextBox14.Enabled = true;
            TextBox15.Enabled = true;
        }
    }
    public bool checkData()
    {
        if(TextBox1.Text.Length<1 || TextBox2.Text.Length<1 || TextBox3.Text.Length<1)
        {
            Label5.Text = "Please Insert All Cruise Data";
            Label5.Visible = true;
            return false;
        }
        if(CheckBox2.Checked)
        {
            if (TextBox8.Text.Length < 1 || TextBox9.Text.Length < 1 || TextBox10.Text.Length < 1 || TextBox11.Text.Length < 1)
            {
                Label5.Text = "Please Insert All Perimum Data";
                Label5.Visible = true;
                return false;
            }
        }
        if (CheckBox3.Checked)
        {
            if (TextBox12.Text.Length < 1 || TextBox13.Text.Length < 1 || TextBox14.Text.Length < 1 || TextBox15.Text.Length < 1)
            {
                Label5.Text = "Please Insert All Luxury Data";
                Label5.Visible = true;
                return false;
            }
        }
        if (CheckBox1.Checked)
        {
            if (TextBox4.Text.Length < 1 || TextBox5.Text.Length < 1 || TextBox6.Text.Length < 1 || TextBox7.Text.Length < 1)
            {
                Label5.Text = "Please Insert All Economic Data";
                Label5.Visible = true;
                return false;
            }
        }
        if(!CheckBox1.Checked && !CheckBox2.Checked && !CheckBox3.Checked)
        {
            Label5.Text = "Please Select At Least On Cabin Type";
            Label5.Visible = true;
            return false;
        }
        return true;

    }
}