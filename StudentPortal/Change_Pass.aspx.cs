using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Change_Pass : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select ID from login where Type='" + Session["fname"].ToString() + "'",con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        dr.Read();
        TextBox1.Text = dr[0].ToString();
        con.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string pass = "";
        if (TextBox3.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Please Enter new Password');", true);
        }
        else
        {
            if (TextBox3.Text == TextBox4.Text)
            {
                SqlCommand cmd = new SqlCommand("Select Pass from login where Type='" + Session["fname"].ToString() + "'",con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dr.Read();
                pass = dr[0].ToString();
                con.Close();
                if (pass == TextBox2.Text)
                {
                    cmd = new SqlCommand("Update login set Pass='"+TextBox3.Text+"' where ID='"+TextBox1.Text+"'",con);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Password Updated');", true);
                    con.Close();
                }
                else
                {
                    Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Old Password not Matched !!!');", true);

                }
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('New Password not Matched');", true);
            }
        }
    }
}