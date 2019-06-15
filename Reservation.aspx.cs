using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reservation : System.Web.UI.Page
{
    List<DataManage.cruise> cr;
    List<DataManage.trip> tr;
    DataManage.trip selected;
    DataManage.reservation res;
    protected void Page_Load(object sender, EventArgs e)
    {
        resdiv.Visible = false;
        Session["curr"] = "Reservation.aspx";
        DataBaseManagment dbm = new DataBaseManagment();
        cr = dbm.getAllCruise();
        tr = dbm.getAllTrip();
        if (IsPostBack)
            sel();
        if (!IsPostBack)
            fillDepLoc();
    }
    public void fillDepLoc()
    {
        DropDownList1.Items.Clear();
        DropDownList1.Items.Add("FROM");
        foreach(DataManage.trip trip in tr)
        {
            DropDownList1.Items.Add(trip.deplocation);
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DropDownList2.Items.Clear();
        DropDownList2.Items.Add("DESTINATION");
        foreach (DataManage.trip trip in tr)
        {
            if(trip.deplocation.Equals(DropDownList1.SelectedItem.ToString()))
            DropDownList2.Items.Add(trip.arrlocatio);
        }
    }
    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        ListBox1.Items.Clear();
        foreach (DataManage.trip trip in tr)
        {
            if (trip.deplocation.Equals(DropDownList1.SelectedItem.ToString()) && trip.arrlocatio.Equals(DropDownList2.SelectedItem.ToString()))
            {
                DateTime da = new DateTime(trip.depdate.Year, trip.depdate.Month, trip.depdate.Day, trip.depTime.Hours, trip.depTime.Minutes, 0);
                ListBox1.Items.Add(da.ToString());
            }
        }
    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
        DateTime dep = DateTime.Parse(ListBox1.SelectedItem.ToString());
        foreach(DataManage.trip trip in tr)
        {
            if(trip.deplocation.Equals(DropDownList1.SelectedItem.ToString()) && trip.arrlocatio.Equals(DropDownList2.SelectedItem.ToString()) && trip.depdate.Year==dep.Year && trip.depdate.Month==dep.Month && trip.depdate.Day==dep.Day && trip.depTime.Hours==dep.Hour && trip.depTime.Minutes==dep.Minute)
            {
                selected = trip;
                break;
            }
        }
        if (selected.econ == 0)
            RadioButton1.Enabled = false;
        if (selected.prem == 0)
            RadioButton2.Enabled = false;
        if (selected.lux == 0)
            RadioButton3.Enabled = false;

    }
    public void sel()
    {
        try
        {
            DateTime dep = DateTime.Parse(ListBox1.SelectedItem.ToString());
            foreach (DataManage.trip trip in tr)
            {
                if (trip.deplocation.Equals(DropDownList1.SelectedItem.ToString()) && trip.arrlocatio.Equals(DropDownList2.SelectedItem.ToString()) && trip.depdate.Year == dep.Year && trip.depdate.Month == dep.Month && trip.depdate.Day == dep.Day && trip.depTime.Hours == dep.Hour && trip.depTime.Minutes == dep.Minute)
                {
                    selected = trip;
                    break;
                }
            }
            if (selected.econ == 0)
                RadioButton1.Enabled = false;
            if (selected.prem == 0)
                RadioButton2.Enabled = false;
            if (selected.lux == 0)
                RadioButton3.Enabled = false;
        }
        catch (Exception ex) { }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {
        loadInfo("econ");

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {
        loadInfo("prem");
    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {
        loadInfo("lux");
    }
    public void loadInfo(string type)
    {

    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        resdiv.Visible = true;
    
        if (TextBox3.Text.Length < 1)
        {
            Label3.Text = "Please insert the person number";
            Label3.Visible = true;
            return;
        }
        if(selected==null)
        {
            Label3.Text = "Please select all data";
            Label3.Visible = true;
            return;
        }
        if(!RadioButton1.Checked && !RadioButton2.Checked && !RadioButton3.Checked)
        {
            Label3.Text = "Please select cabin type";
            Label3.Visible = true;
            return;
        }
        int person = Int32.Parse(TextBox3.Text);
        DataManage.cruise selectedCr=null;
        foreach(DataManage.cruise cruise in cr)
        {
            if(cruise.id==selected.cruiseId)
            {
                selectedCr = cruise;
            }
        }

        int cabcap;
        int avcab;
        int cabpr;
        string des;
        if (RadioButton1.Checked)
        {
            des = selectedCr.econdes;
            cabpr=selectedCr.econrate;
            avcab=selected.econ;
            cabcap=selectedCr.econcap;
            Label2.Text = "ECONOMIC";
        }
        else if (RadioButton2.Checked)
        {

            des = selectedCr.permdes;
            cabpr=selectedCr.permrate;
            avcab=selected.prem;
            cabcap=selectedCr.permcap;
            Label2.Text = "PREMIUM";
        }
        else
        {
            des = selectedCr.luxdes;
            cabpr=selectedCr.lucrate;
            avcab=selected.lux;
            cabcap=selectedCr.luxcap;
            Label2.Text = "LUXURY";
        }

        float cabneed = person / cabcap;
        if ((cabneed*10) % 10 != 0)
        {
            cabneed = cabneed - ((cabneed % 10) / 10) + 1;
        }
        if (RadioButton1.Checked)
        {
            if (cabneed > selected.econ)
            {
                Label9.Text = "There is not enough available cabins";
                Label9.Visible = true;
            }
        }
        else if (RadioButton2.Checked)
        {
            if (cabneed > selected.prem)
            {
                Label9.Text = "There is not enough available cabins";
                Label9.Visible = true;
            }
        }
        else
        {
            if (cabneed > selected.lux)
            {
                Label9.Text = "There is not enough available cabins";
                Label9.Visible = true;
            }
        }

  


        Label11.Text = selected.arrdate.ToShortDateString();
        Label10.Text = selected.arrTime.ToString();
        Label4.Text = cabneed.ToString() + " Cabins";
        Label5.Text = (selected.price*cabpr).ToString();
        Label6.Text = cabcap.ToString();
        Label7.Text = des;

        float total = cabpr * cabneed*selected.price;
        Label8.Text = total.ToString();

        res = new DataManage.reservation();
        res.tripId = selected.id;
        res.status = "RESERVED";
        res.person = person;
        try
        {
            res.couser = Session["user"].ToString();
            Button5.Visible = true;
        }
        catch(Exception ex)
        {
            Label9.Text = "You have to sign in for reservation";
            Label9.Visible = true;
        }
        res.cabnum = int.Parse(cabneed.ToString());
        res.cabintype = Label2.Text;
        res.amount = total;
        if (Session["user"] != null && Label9.Text != "There is not enough available cabins")
            Button5.Visible = true;

    }
    public void ress()
    {
        int person = Int32.Parse(TextBox3.Text);
        DataManage.cruise selectedCr = null;
        foreach (DataManage.cruise cruise in cr)
        {
            if (cruise.id == selected.cruiseId)
            {
                selectedCr = cruise;
            }
        }

        int cabcap;
        int avcab;
        int cabpr;
        string des;
        if (RadioButton1.Checked)
        {
            des = selectedCr.econdes;
            cabpr = selectedCr.econrate;
            avcab = selected.econ;
            cabcap = selectedCr.econcap;
            Label2.Text = "ECONOMIC";
        }
        else if (RadioButton2.Checked)
        {

            des = selectedCr.permdes;
            cabpr = selectedCr.permrate;
            avcab = selected.prem;
            cabcap = selectedCr.permcap;
            Label2.Text = "PREMIUM";
        }
        else
        {
            des = selectedCr.luxdes;
            cabpr = selectedCr.lucrate;
            avcab = selected.lux;
            cabcap = selectedCr.luxcap;
            Label2.Text = "LUXURY";
        }

        float cabneed = person / cabcap;
        if ((cabneed * 10) % 10 != 0)
        {
            cabneed = cabneed - ((cabneed % 10) / 10) + 1;
        }
        if (RadioButton1.Checked)
        {
            if (cabneed > selected.econ)
            {
                Label9.Text = "There is not enough available cabins";
                Label9.Visible = true;
            }
        }
        else if (RadioButton2.Checked)
        {
            if (cabneed > selected.prem)
            {
                Label9.Text = "There is not enough available cabins";
                Label9.Visible = true;
            }
        }
        else
        {
            if (cabneed > selected.lux)
            {
                Label9.Text = "There is not enough available cabins";
                Label9.Visible = true;
            }
        }




        Label11.Text = selected.arrdate.ToShortDateString();
        Label10.Text = selected.arrTime.ToString();
        Label4.Text = cabneed.ToString() + " Cabins";
        Label5.Text = (selected.price * cabpr).ToString();
        Label6.Text = cabcap.ToString();
        Label7.Text = des;

        float total = cabpr * cabneed * selected.price;
        Label8.Text = total.ToString();

        res = new DataManage.reservation();
        res.tripId = selected.id;
        res.status = "RESERVED";
        res.person = person;
        res.couser = Session["user"].ToString();
        res.cabnum = int.Parse(cabneed.ToString());
        res.cabintype = Label2.Text;
        res.amount = total;
        if (Session["user"] != null && Label9.Text != "There is not enough available cabins")
            Button5.Visible = true;
    }
    protected void Button5_Click(object sender, EventArgs e)
    {
        ress();
        DataBaseManagment dbm = new DataBaseManagment();
        dbm.newreservation(res);
        string type=string.Empty;
        int newVal = int.MinValue;

        if(res.cabintype.Equals("ECONOMIC"))
        {
            newVal = selected.econ - res.cabnum;
            type="econav";
        }
        else if (res.cabintype.Equals("PREMIUM"))
        {
            newVal = selected.prem - res.cabnum;
            type="premav";
        }
        else
        {
            newVal = selected.lux - res.cabnum;
            type="luxav";
        }
        dbm.updateavailablecabin(res.tripId,type, newVal);
        Response.Redirect("CheckReservation.aspx");
    }
}