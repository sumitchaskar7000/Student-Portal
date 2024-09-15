using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;

public partial class SBal : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select Bal,Email from Stud Where Id='" + Session["id"].ToString() + "'", con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();

        if (dr.HasRows)
        {
            dr.Read();
            TextBox1.Text = dr[0].ToString();
            Label7.Text = dr[1].ToString();
            con.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == "" || TextBox3.Text == "" || TextBox4.Text == "" || TextBox5.Text == "" || TextBox5.Text == "" || TextBox6.Text == "") 
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Please Details');", true);
        }
        else
        {
            int bal = Convert.ToInt32(TextBox1.Text);
            int rs = Convert.ToInt32(TextBox2.Text);
            int dif = bal + rs;
            SqlCommand cmd = new SqlCommand("Update Stud Set Bal='" + dif + "' where Id ='" + Session["id"].ToString() + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Balance Added Successfuly');", true);
            Button1.Visible = true;
            TextBox1.Text = "";
            TextBox1.ReadOnly = false;

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("voramish7018@gmail.com");
            mail.To.Add(Label7.Text);
            mail.Subject = "Balance Update";
            mail.Body = "Your A/C has been credited by " + rs + ". Current balance is " + dif + ".";
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("voramish7018@gmail.com", "allbesst");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
    }
}