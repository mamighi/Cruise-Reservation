using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Cruies : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        loadCruiseID();
    }
    public void loadCruiseID()
    {
        DataBaseManagment dbm = new DataBaseManagment();
        List<int> id = dbm.getAllCruiseId();
        if (!IsPostBack)
        {
            DropDownList2.Items.Clear();
            DropDownList2.Items.Add("CRUISE ID");
            foreach (int tid in id)
            {
                DropDownList2.Items.Add(tid.ToString());
            }
        }
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            DataBaseManagment dbm = new DataBaseManagment();
            DataManage.cruise cr = dbm.getCruiseDataByID(int.Parse(DropDownList2.SelectedItem.ToString()));
            TextBox2.Text = cr.cname;
            TextBox3.Text = cr.cabNum.ToString();
            TextBox17.Text = cr.agent;
            TextBox16.Text = cr.des;
            if (cr.econ != 0)
            {
                CheckBox1.Checked = true;
                TextBox4.Text = cr.econcab.ToString();
                TextBox5.Text = cr.econrate.ToString();
                TextBox6.Text = cr.econcap.ToString();
                TextBox7.Text = cr.econdes;
            }
            if (cr.perm != 0)
            {
                CheckBox2.Checked = true;
                TextBox8.Text = cr.permcab.ToString();
                TextBox9.Text = cr.permdes.ToString();
                TextBox10.Text = cr.permcap.ToString();
                TextBox11.Text = cr.permdes;
            }
            if (cr.lux != 0)
            {
                CheckBox3.Checked = true;
                TextBox12.Text = cr.luxcab.ToString();
                TextBox13.Text = cr.lucrate.ToString();
                TextBox14.Text = cr.luxcap.ToString();
                TextBox15.Text = cr.luxdes;
            }
        }
        catch (Exception ex) { }
    }

}