using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.IO;


public partial class Marks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        check("Photo", LinkButton1);
        check("Birth", LinkButton2);
        check("Cast", LinkButton3);
        check("SSCPass", LinkButton4);
        check("SSCLeav", LinkButton5);
        check("HSCPass", LinkButton6);
        check("HSCLeav", LinkButton7);
        check("GradPass", LinkButton8);
        check("GradLeav", LinkButton9);
        check("PostPass", LinkButton10);
        check("PostLeav", LinkButton11);
    }

    public void check(string name, Control c)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT " + name + " FROM Doc where Id='" + Session["id"].ToString() + "' And " + name + " IS NULL";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            c.Visible = false;
        }
        else
        {
            c.Visible = true;
        }
        con.Close();
    }

    public void databaseFileRead(string name, string varPathToNewLocation)
    {
        SqlConnection varConnection = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        varConnection.Open();
        using (var sqlQuery = new SqlCommand("SELECT " + name + " FROM Doc where Id='" + Session["id"].ToString() + "'", varConnection))
        {
            using (var sqlQueryResult = sqlQuery.ExecuteReader())
                if (sqlQueryResult != null)
                {
                    sqlQueryResult.Read();
                    var blob = new Byte[(sqlQueryResult.GetBytes(0, 0, null, 0, int.MaxValue))];
                    sqlQueryResult.GetBytes(0, 0, blob, 0, blob.Length);
                    using (var fs = new FileStream(varPathToNewLocation, FileMode.Create, FileAccess.Write))
                        fs.Write(blob, 0, blob.Length);
                }
        }
        varConnection.Close();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\photo.pdf");
        databaseFileRead("Photo", path);
        Session["path"] = path;
       // Response.Write(string.Format("<script>window.open('{0}','_blank');</script>", "WebForm3.aspx"));
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);

    }
    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\Birth.pdf");
        databaseFileRead("Birth",path);
        Session["path"] = @"E:\priyalvartak\Birth.pdf";
        //Response.Write(string.Format("<script>window.open('{0}','_blank');</script>", "WebForm3.aspx"));
       ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton3_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\Cast.pdf");
        databaseFileRead("Cast", path);
        Session["path"] = path;
       // Response.Write(string.Format("<script>window.open('{0}','_blank');</script>", "WebForm3.aspx"));
       ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton4_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\ssc.pdf");
        databaseFileRead("SSCPass", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton5_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\SSCLeav.pdf");
        databaseFileRead("SSCLeav", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton6_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\HSCPass.pdf");
        databaseFileRead("HSCPass", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton7_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\HSCLeav.pdf");
        databaseFileRead("HSCLeav", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton8_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\GradPass.pdf");
        databaseFileRead("GradPass", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton9_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\GradLeav.pdf");
        databaseFileRead("GradLeav", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton10_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\PostPass.pdf");
        databaseFileRead("PostPass", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
    protected void LinkButton11_Click(object sender, EventArgs e)
    {
        string path = Server.MapPath("~\\Uploads\\PostLeav.pdf.pdf");
        databaseFileRead("PostPass", path);
        Session["path"] = path;
        ClientScript.RegisterStartupScript(this.Page.GetType(), "", "window.open('WebForm3.aspx','Graph','height=500,width=840');", true);
    }
}