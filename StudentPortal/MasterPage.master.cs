using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Convert.ToString(Session["fname"]) == "user")
        {
            Panel2.Visible = true;
            Panel1.Visible = false;
            Panel3.Visible = false;
            Stat.Visible = false;
            Lib.Visible = false;
            Can.Visible = false;
            Office.Visible = false;
        }
        else if (Convert.ToString(Session["fname"]) == "admin")
        {
            Panel3.Visible = true;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Office.Visible = false;
            Stat.Visible = false;
            Lib.Visible = false;
            Can.Visible = false;
        }
        else if (Convert.ToString(Session["fname"]) == "Stationary")
        {
            Stat.Visible = true;
            Lib.Visible = false;
            Can.Visible = false;
            Office.Visible = false;
            Panel1.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else if (Convert.ToString(Session["fname"]) == "Stationary")
        {
            Stat.Visible = true;
            Lib.Visible = false;
            Can.Visible = false;
            Panel1.Visible = false;
            Office.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else if (Convert.ToString(Session["fname"]) == "Canteen")
        {
            Stat.Visible = false;
            Lib.Visible = false;
            Can.Visible = true;
            Panel1.Visible = false;
            Office.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else if (Convert.ToString(Session["fname"]) == "Library")
        {
            Stat.Visible = false;
            Lib.Visible = true;
            Can.Visible = false;
            Panel1.Visible = false;
            Office.Visible = false;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else if (Convert.ToString(Session["fname"]) == "Office")
        {
            Stat.Visible = false;
            Lib.Visible = false;
            Can.Visible = false;
            Panel1.Visible = false;
            Office.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
        else
        {
            Stat.Visible = false;
            Lib.Visible = false;
            Can.Visible = false;
            Panel1.Visible = true;
            Panel2.Visible = false;
            Panel3.Visible = false;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session.Abandon();
        Response.Redirect("Pre.aspx");
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        Response.Redirect("CReg.aspx");
    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default2.aspx");
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        Response.Redirect("design.aspx");
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        Response.Redirect("Pre.aspx");
    }
}
