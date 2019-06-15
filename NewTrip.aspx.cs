using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class NewTrip : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsCallback)
            loadCruises();
    }
    public void loadCruises()
    {
        
        DataBaseManagment dbm = new DataBaseManagment();
        if (!IsPostBack)
        {
            DropDownList1.Items.Clear();
            List<int> cruiseId = dbm.getAllCruiseId();
            DropDownList1.Items.Add("0");
            foreach (int Id in cruiseId)
                DropDownList1.Items.Add(Id.ToString());
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Calendar1.Visible = true;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        Calendar2.Visible = true;

    }
    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        TextBox2.Text = Calendar1.SelectedDate.Date.ToString();
        Calendar1.Visible = false;

    }
    protected void Calendar2_SelectionChanged(object sender, EventArgs e)
    {
        TextBox6.Text = Calendar2.SelectedDate.Date.ToString();
        Calendar2.Visible = false;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (!checkData())
            return;
        DataManage.trip trip = new DataManage.trip();
        trip.cruiseId = Int32.Parse(DropDownList1.SelectedItem.ToString());
        trip.deplocation = TextBox1.Text;
        trip.depdate = Calendar1.SelectedDate;
        TimeSpan tm = new TimeSpan(Int32.Parse(TextBox3.Text), Int32.Parse(TextBox4.Text), 0);
        trip.depTime = tm;
        trip.arrlocatio = TextBox5.Text;
        trip.arrdate = Calendar2.SelectedDate;
        TimeSpan am = new TimeSpan(Int32.Parse(TextBox7.Text), Int32.Parse(TextBox8.Text), 0);
        trip.arrTime = am;
        trip.price = float.Parse(TextBox9.Text);
        trip.description = TextBox10.Text;

        DataBaseManagment dbm = new DataBaseManagment();
        dbm.addNewTrip(trip);
        Response.Redirect("AdminHome.aspx");
    }
    public bool checkData()
    {
        if(TextBox1.Text.Length<1 || TextBox2.Text.Length<1 ||TextBox3.Text.Length<1 ||TextBox4.Text.Length<1 ||TextBox5.Text.Length<1 ||TextBox6.Text.Length<1 ||TextBox7.Text.Length<1 ||TextBox8.Text.Length<1 ||TextBox9.Text.Length<1)
        {
            Label4.Text = "Please Insert All Information";
            Label4.Visible = true;
            return false;
        }
        return true;
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int cruiseID = Int32.Parse(DropDownList1.SelectedItem.ToString());
        DataBaseManagment dbm = new DataBaseManagment();
        DataManage.cruise cruise= dbm.getCruiseDataByID(cruiseID);
        Label2.Text = cruise.cname;
        Label3.Text = cruise.cabNum.ToString();
    }
}