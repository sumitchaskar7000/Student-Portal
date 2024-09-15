using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

public partial class New_Transaction : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        SqlCommand cmd = new SqlCommand("Select Bal,Email from Stud where Id='"+TextBox1.Text+"'",con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            dr.Read();
            TextBox3.Text = dr[0].ToString();
            Label5.Text = dr[1].ToString();
            con.Close();
            Panel4.Visible = true;
            Button1.Visible = false;
            TextBox1.ReadOnly = true;
        }
        else
        {
            con.Close();
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Invalid Student Id');", true);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Panel4.Visible = false;
        Button1.Visible = true;
        TextBox1.Text = "";
        TextBox1.ReadOnly = false;
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (TextBox2.Text == "")
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Please Enter Rs.');", true);
        }
        else
        {
            int bal = Convert.ToInt32(TextBox3.Text);
            int rs = Convert.ToInt32(TextBox2.Text);
            int dif = bal - rs;

            if (rs > bal)
            {
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Insufficient Balance');", true);
            }
            else
            {
                string id = "";
                string com = "select top 1 TId From Trans ORDER BY TId Desc";
                con.Open();
                SqlCommand cmd = new SqlCommand(com, con);
                object count = cmd.ExecuteScalar();
                if (count != null)
                {
                    int i = Convert.ToInt32(count);
                    i++;
                    id = i.ToString();
                }
                else
                {
                    id = "20001";
                }
                con.Close();

                cmd = new SqlCommand("Update Stud Set Bal='" + dif + "' where Id ='"+TextBox1.Text+"'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                cmd = new SqlCommand("insert into Trans (TId,UserId,To_Type,Rs,Note) values ('" + id + "','" + TextBox1.Text + "','" + Session["fname"].ToString() + "','"+TextBox2.Text+"','"+TextBox4.Text+"') ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Payment Successfull');", true);
                string finalpassword = "Your A/C has been debited by Rs." + rs + ". Your current balance is " + dif + ".";
                MailMessage msg = new MailMessage();
                string senderemail = "priyal.2011@gmail.com";
                msg.From = new MailAddress(senderemail);
                string mypass = "priyalvartak2011";
                msg.To.Add(Label5.Text);
                msg.Subject = "Balance Update";
                msg.Body = finalpassword;
                SmtpClient sc = new SmtpClient("smtp.gmail.com");
                sc.Port = 587;
                sc.Credentials = new NetworkCredential(senderemail, mypass);
                sc.EnableSsl = true;
                sc.Send(msg);
                Panel4.Visible = false;
                Button1.Visible = true;
                TextBox1.Text = "";
                TextBox1.ReadOnly = false;   
            }
        }
    }
}