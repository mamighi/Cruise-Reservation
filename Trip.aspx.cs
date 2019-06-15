using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Trip : System.Web.UI.Page
{
    List<DataManage.trip> tr;
    protected void Page_Load(object sender, EventArgs e)
    {
        DataBaseManagment dbm = new DataBaseManagment();
        tr = dbm.getAllTrip();
        if (!IsPostBack)
        {
            
            DropDownList1.Items.Clear();
            DropDownList1.Items.Add("TRIP ID");
            foreach (DataManage.trip temp in tr)
            {
                DropDownList1.Items.Add(temp.id.ToString());
            }
        }
    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            foreach (DataManage.trip temp in tr)
            {
                if (temp.id == int.Parse(DropDownList1.SelectedItem.ToString()))
                {
                    DataBaseManagment dbm = new DataBaseManagment();
                    DataManage.cruise cr = dbm.getCruiseDataByID(temp.cruiseId);
                    Label2.Text = cr.cname;
                    Label3.Text = cr.cabNum.ToString();
                    TextBox2.Text = temp.depdate.ToShortDateString();
                    TextBox1.Text = temp.deplocation;
                    TextBox3.Text = temp.depTime.Hours.ToString();
                    TextBox4.Text = temp.depTime.Minutes.ToString();
                    TextBox5.Text = temp.arrlocatio;
                    TextBox6.Text = temp.arrdate.ToShortDateString();
                    TextBox7.Text = temp.arrTime.Hours.ToString();
                    TextBox8.Text = temp.arrTime.Minutes.ToString();
                    TextBox9.Text = temp.price.ToString();
                    TextBox10.Text = temp.description;
                }
            }
        }
        catch (Exception ex) { }
    }
}