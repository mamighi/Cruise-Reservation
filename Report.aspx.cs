using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Report : System.Web.UI.Page
{
    string av, time;
    protected void Page_Load(object sender, EventArgs e)
    {
        getReportType();
        generatReport();
    }
    public void getReportType()
    {
        if (RadioButton1.Checked)
            av = "ALL";
        else if (RadioButton2.Checked)
            av = "AV";
        else
            av = "SO";
        if (RadioButton4.Checked)
            time = "ALL";
        else if (RadioButton5.Checked)
            time = "PA";
        else
            time = "FU";
    }
    public void generatReport()
    {
        try
        {
            DataBaseManagment dbm = new DataBaseManagment();
            List<DataManage.trip> trip = dbm.getAllTrip();
            foreach (DataManage.trip temp in trip)
            {
                DateTime now = DateTime.Now;
                if (av.Equals("AV"))
                {
                    if (temp.econ == 0 && temp.prem == 0 && temp.lux == 0)
                    {
                        trip.Remove(temp);
                        break;
                    }
                }
                else if (av.Equals("SO"))
                {
                    if (temp.econ != 0 || temp.prem != 0 || temp.lux != 0)
                    {
                        trip.Remove(temp);
                        break;
                    }
                }

                if (time.Equals("PA"))
                {
                    if (now > temp.depdate)
                        trip.Remove(temp);
                }
                else if (time.Equals("FU"))
                {
                    if (now < temp.depdate)
                        trip.Remove(temp);
                }
            }
            for (int i = 0; i < trip.Count; i++)
            {
                TableRow tr = new TableRow();
                if (i % 2 != 0)
                    tr.BackColor = System.Drawing.Color.Silver;
                else
                    tr.BackColor = System.Drawing.Color.White;
                TableCell tid = new TableCell();
                tid.Text = trip[i].id.ToString();
                tid.HorizontalAlign = HorizontalAlign.Center;

                TableCell dep = new TableCell();
                dep.Text = trip[i].deplocation.ToString();
                dep.HorizontalAlign = HorizontalAlign.Center;

                TableCell dept = new TableCell();
                dept.Text = trip[i].depdate.ToShortDateString();
                dept.HorizontalAlign = HorizontalAlign.Center;

                TableCell arrt = new TableCell();
                arrt.Text = trip[i].arrdate.ToShortDateString();
                arrt.HorizontalAlign = HorizontalAlign.Center;


                TableCell pr = new TableCell();
                pr.Text = trip[i].price.ToString();
                pr.HorizontalAlign = HorizontalAlign.Center;

                TableCell eco = new TableCell();
                eco.Text = trip[i].econ.ToString();
                eco.HorizontalAlign = HorizontalAlign.Center;

                TableCell prem = new TableCell();
                prem.Text = trip[i].prem.ToString();
                prem.HorizontalAlign = HorizontalAlign.Center;

                TableCell lux = new TableCell();
                lux.Text = trip[i].lux.ToString();
                lux.HorizontalAlign = HorizontalAlign.Center;

                tr.Cells.Add(tid);
                tr.Cells.Add(dep);
                tr.Cells.Add(dept);
                tr.Cells.Add(arrt);
                tr.Cells.Add(pr);
                tr.Cells.Add(eco);
                tr.Cells.Add(prem);
                tr.Cells.Add(lux);
                Table1.Rows.Add(tr);

            }
        }
        catch (Exception ex) { }
    }
    protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton3_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton4_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton5_CheckedChanged(object sender, EventArgs e)
    {

    }
    protected void RadioButton6_CheckedChanged(object sender, EventArgs e)
    {

    }
}