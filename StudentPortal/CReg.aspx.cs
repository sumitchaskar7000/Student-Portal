using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class CReg : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        
    protected void Page_Load(object sender, EventArgs e)
    {
       string com = "select top 1 Id From Stud ORDER BY Id Desc;";
        con.Open();
        SqlCommand cmd = new SqlCommand(com, con);
        object count = cmd.ExecuteScalar();
        if (count != null)
        {
            int i = Convert.ToInt32(count);
            i++;
            TextBox1.Text = i.ToString();
        }
        else
        {
            TextBox1.Text = "20540";
        }
        con.Close();
    }

    public string check()
    { 
        if(TextBox1.Text=="")
        {
            return "User ID";
        }
        else if (TextBox2.Text == "")
        {
            return "Name";
        }
        else if (TextBox3.Text == "")
        {
            return "Address";
        }
        else if (TextBox4.Text == "")
        {
            return "Mobile No";
        }
        else if (TextBox5.Text == "")
        {
            return "Email";
        }
        return "OK";
    }

    public string checkID()
    {
        SqlConnection con = new SqlConnection();
        con.ConnectionString = "Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True";
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * from Stud where ID='"+TextBox1.Text+"'", con);
        SqlDataReader dr;
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            con.Close();
            return "wrong";
        }
        else
        {
            con.Close();
            return "OK";
        }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (check() == "OK")
        {
            if (checkID() == "OK")
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Stud(Id,Name,Addr,Mob,EMail,Quali,Pass) values (@Id,@Name,@Addr,@Mob,@EMail,@Quali,@Pass);", con);
                cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                cmd.Parameters.AddWithValue("@Name", TextBox2.Text);
                cmd.Parameters.AddWithValue("@Addr", TextBox3.Text);
                cmd.Parameters.AddWithValue("@Mob", TextBox4.Text);
                cmd.Parameters.AddWithValue("@EMail", TextBox5.Text);
                cmd.Parameters.AddWithValue("@Quali", DropDownList1.Text);
                cmd.Parameters.AddWithValue("@Pass", TextBox4.Text);
                cmd.ExecuteReader();
                con.Close();

                con.Open();
                cmd = new SqlCommand("insert into Doc(Id) values (@Id);", con);
                cmd.Parameters.AddWithValue("@Id", TextBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('User Registered ');", true);
                TextBox1.Text = "";
                TextBox2.Text = "";
                TextBox3.Text = "";
                TextBox4.Text = "";
                TextBox5.Text = "";
                Button3.Visible = true;
            }
            else
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert(' Please Check Your ID, This ID is already Registered ');", true);
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Please Enter " + check() + "');", true);
        }
    }
}