using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class MyProf : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "Select * from Stud Where Id='"+Session["id"].ToString()+"'";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader r = cmd.ExecuteReader();
        r.Read();
        Label12.Text=r[1].ToString();
        Label20.Text = r[2].ToString();
        Label14.Text=r[3].ToString();
        Label16.Text=r[4].ToString();
        string max=r[5].ToString();
        Label22.Text = r[0].ToString();
        con.Close();
        
    }
}