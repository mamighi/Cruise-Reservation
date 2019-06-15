using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CheckReservation : System.Web.UI.Page
{
    List<DataManage.reservation> res;
    protected void Page_Load(object sender, EventArgs e)
    {

        Session["curr"] = "CheckReservation.aspx";
        if (Session["user"] == null)
            Response.Redirect("Login.aspx");
        DataBaseManagment dbm = new DataBaseManagment();
        res = dbm.getreservation();
        if (!IsPostBack)
        {
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("RESERVATION");
            foreach (DataManage.reservation temp in res)
            {
                if (temp.couser.Equals(Session["user"].ToString()))
                {
                    DropDownList1.Items.Add(temp.resId.ToString());
                }
            }
        }
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            foreach (DataManage.reservation temp in res)
            {
                if (temp.resId == int.Parse(DropDownList1.SelectedItem.ToString()))
                {
                    DataBaseManagment dbm = new DataBaseManagment();
                    DataManage.trip tr = dbm.getTripData(temp.tripId);
                    Label3.Text = tr.deplocation;
                    Label4.Text = tr.depdate.ToShortDateString();
                    Label5.Text = tr.depTime.ToString();
                    Label6.Text = tr.arrlocatio;
                    Label7.Text = tr.arrdate.ToShortDateString();
                    Label8.Text = tr.arrTime.ToString();
                    Label9.Text = temp.person.ToString();
                    Label10.Text = temp.status;
                    Label11.Text = temp.cabnum.ToString();
                    Label15.Text = temp.amount.ToString();
                    Label16.Text = temp.status;

                    break;
                }
            }
        }
        catch (Exception ex) { }
    }
}