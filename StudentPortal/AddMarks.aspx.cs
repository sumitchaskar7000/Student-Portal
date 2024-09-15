using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.IO;

public partial class AddMarks : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT Id FROM Stud ";
        SqlDataAdapter da = new SqlDataAdapter(s, con);
        DataSet ds = new DataSet();
        da.Fill(ds);
        int rows = ds.Tables[0].Rows.Count;
        if (Label19.Text == "")
        {
            if (rows != 0)
            {
                for (int i = 0; i < rows; i++)
                {
                    DropDownList3.Items.Add(ds.Tables[0].Rows[i][0].ToString());
                }
                Label19.Text = "done";
            }
        }
    }
    
    protected void Button1_Click(object sender, EventArgs e)
    {
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Marks Entered Successfully');", true);
    }

    public void other()
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT Photo FROM Doc where Id='"+DropDownList3.Text+"' And Photo IS NULL";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            TextBox14.Text = "Not Submited ";
            FileUpload1.Visible = true;
            Button12.Visible = true;
        }
        else
        {
            FileUpload1.Visible = false;
            TextBox14.Text = "Submited ";
            Button12.Visible = false;
        }
        con.Close();

        con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        s = "SELECT Birth FROM Doc where Id='" + DropDownList3.Text + "' And Birth IS NULL";
        cmd = new SqlCommand(s, con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload2.Visible = true;
            TextBox5.Text = "Not Submited ";
            Button2.Visible = true;
        }
        else
        {
            FileUpload2.Visible = false;
            TextBox5.Text = "Submited ";
            Button2.Visible = false;
        }
        con.Close();


        con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        s = "SELECT Cast FROM Doc where Id='" + DropDownList3.Text + "' And Cast IS NULL";
        cmd = new SqlCommand(s, con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload3.Visible = true;
            TextBox6.Text = "Not Submited ";
            Button3.Visible = true;
        }
        else
        {
            FileUpload3.Visible = false;
            TextBox6.Text = "Submited ";
            Button3.Visible = false;
        }
        con.Close();
    }

    public void ssc()
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT SSCPass FROM Doc where Id='" + DropDownList3.Text + "' And SSCPass IS NULL";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload4.Visible = true;
            TextBox1.Text = "Not Submited ";
            Button4.Visible = true;
        }
        else
        {
            FileUpload4.Visible = false;
            TextBox1.Text = "Submited ";
            Button4.Visible = false;
        }
        con.Close();

        con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        s = "SELECT SSCLeav FROM Doc where Id='" + DropDownList3.Text + "' And SSCLeav IS NULL";
        cmd = new SqlCommand(s, con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload5.Visible = true;
            TextBox2.Text = "Not Submited ";
            Button5.Visible = true;
        }
        else
        {
            FileUpload5.Visible = false;
            TextBox2.Text = "Submited ";
            Button5.Visible = false;
        }
        con.Close();
    }
    public void hsc()
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT HSCPass FROM Doc where Id='" + DropDownList3.Text + "' And HSCPass IS NULL";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload6.Visible = true;
            TextBox7.Text = "Not Submited ";
            Button6.Visible = true;
        }
        else
        {
            FileUpload6.Visible = false;
            TextBox7.Text = "Submited ";
            Button6.Visible = false;
        }
        con.Close();

        con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        s = "SELECT HSCLeav FROM Doc where Id='" + DropDownList3.Text + "' And HSCLeav IS NULL";
        cmd = new SqlCommand(s, con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload7.Visible = true;
            TextBox8.Text = "Not Submited ";
            Button7.Visible = true;
        }
        else
        {
            FileUpload7.Visible = false;
            TextBox8.Text = "Submited ";
            Button7.Visible = false;
        }
        con.Close();
    }
    public void gra()
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT GradPass FROM Doc where Id='" + DropDownList3.Text + "' And GradPass IS NULL";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload8.Visible = true;
            TextBox13.Text = "Not Submited ";
            Button8.Visible = true;
        }
        else
        {
            FileUpload8.Visible = false;
            TextBox13.Text = "Submited ";
            Button8.Visible = false;
        }
        con.Close();

        con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        s = "SELECT GradLeav FROM Doc where Id='" + DropDownList3.Text + "' And GradLeav IS NULL";
        cmd = new SqlCommand(s, con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload9.Visible = true;
            TextBox10.Text = "Not Submited ";
            Button9.Visible = true;
        }
        else
        {
            FileUpload9.Visible = false;
            TextBox10.Text = "Submited ";
            Button9.Visible = false;
        }
        con.Close();
    }
    public void post()
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "SELECT PostPass FROM Doc where Id='" + DropDownList3.Text + "' And PostPass IS NULL";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload10.Visible = true;
            TextBox11.Text = "Not Submited ";
            Button10.Visible = true;
        }
        else
        {
            FileUpload10.Visible = false;
            TextBox11.Text = "Submited ";
            Button10.Visible = false;
        }
        con.Close();

        con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        s = "SELECT PostLeav FROM Doc where Id='" + DropDownList3.Text + "' And PostLeav IS NULL";
        cmd = new SqlCommand(s, con);
        con.Open();
        dr = cmd.ExecuteReader();
        if (dr.HasRows)
        {
            FileUpload11.Visible = true;
            TextBox12.Text = "Not Submited ";
            Button11.Visible = true;
        }
        else
        {
            FileUpload11.Visible = false;
            TextBox12.Text = "Submited ";
            Button11.Visible = false;
        }
        con.Close();
    }

    protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        string s = "Select Quali from Stud Where Id='" + DropDownList3.Text + "'";
        SqlCommand cmd = new SqlCommand(s, con);
        con.Open();
        SqlDataReader r = cmd.ExecuteReader();

        r.Read();

        if (r[0].ToString() == "SSC")
        {
            other();
            ssc();
            Panel4.Visible = true;
            Panel5.Visible = false;
            Panel6.Visible = false;
            Panel7.Visible = false;
        }
        else if (r[0].ToString() == "HSC")
        {
            other();
            ssc();
            hsc();
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel6.Visible = false;
            Panel7.Visible = false;
        }
        else if (r[0].ToString() == "Graduate")
        {
            other();
            ssc();
            hsc();
            gra();
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel6.Visible = true;
            Panel7.Visible = false;
        }
        else if (r[0].ToString() == "Post Graduate")
        {
            other();
            ssc();
            hsc();
            gra();
            post();
            Panel4.Visible = true;
            Panel5.Visible = true;
            Panel6.Visible = true;
            Panel7.Visible = true;
        }
    }
    public static void databaseFilePut(string varFilePath, string name, string id)
    {
        byte[] file;
        using (var stream = new FileStream(varFilePath, FileMode.Open, FileAccess.Read))
        {
            using (var reader = new BinaryReader(stream))
            {
                file = reader.ReadBytes((int)stream.Length);
            }
        }
        SqlConnection varConnection = new SqlConnection(@"Data Source=DESKTOP-RK97SPH;Initial Catalog=StudentData;Integrated Security=True");
        varConnection.Open();
        using (var sqlWrite = new SqlCommand("Update Doc Set " + name + "=@File where Id='" + id + "'", varConnection))
        {
            sqlWrite.Parameters.Add("@File", SqlDbType.VarBinary, file.Length).Value = file;
            sqlWrite.ExecuteNonQuery();
        }
        varConnection.Close();
    }
    protected void Button12_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
            FileUpload1.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "Photo", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button12.Visible = false;
            FileUpload1.Visible = false;
            TextBox14.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        if (FileUpload2.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload2.PostedFile.FileName);
            FileUpload2.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "Birth", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button2.Visible = false;
            FileUpload2.Visible = false;
            TextBox5.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        if (FileUpload3.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload3.PostedFile.FileName);
            FileUpload3.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "Cast", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button3.Visible = false;
            FileUpload3.Visible = false;
            TextBox6.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }

    }
    protected void Button4_Click(object sender, EventArgs e)
    {
        if (FileUpload4.HasFile == true)
        {
        string fileName = System.IO.Path.GetFileName(FileUpload4.PostedFile.FileName);
        FileUpload4.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
        string name = Server.MapPath("~/Uploads/" + fileName);
        databaseFilePut(name, "SSCPass", DropDownList3.Text);
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
        Button4.Visible = false;
        FileUpload4.Visible = false;
        TextBox1.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        if (FileUpload5.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload5.PostedFile.FileName);
            FileUpload5.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "SSCLeav", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button5.Visible = false;
            FileUpload5.Visible = false;
            TextBox2.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button6_Click(object sender, EventArgs e)
    {
        if (FileUpload6.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload6.PostedFile.FileName);
            FileUpload6.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "HSCPass", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button6.Visible = false;
            FileUpload6.Visible = false;
            TextBox7.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button7_Click(object sender, EventArgs e)
    {
        if (FileUpload7.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload7.PostedFile.FileName);
            FileUpload7.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "HSCLeav", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button7.Visible = false;
            FileUpload7.Visible = false;
            TextBox8.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button8_Click(object sender, EventArgs e)
    {
        if (FileUpload8.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload8.PostedFile.FileName);
            FileUpload8.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "GrandPass", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button8.Visible = false;
            FileUpload8.Visible = false;
            TextBox13.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button9_Click(object sender, EventArgs e)
    {
        if (FileUpload9.HasFile == true)
        {
            string fileName = System.IO.Path.GetFileName(FileUpload9.PostedFile.FileName);
            FileUpload9.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
            string name = Server.MapPath("~/Uploads/" + fileName);
            databaseFilePut(name, "Birth", DropDownList3.Text);
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
            Button9.Visible = false;
            FileUpload9.Visible = false;
            TextBox10.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button10_Click(object sender, EventArgs e)
    {
        if (FileUpload10.HasFile == true)
        {
        string fileName = System.IO.Path.GetFileName(FileUpload10.PostedFile.FileName);
        FileUpload10.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
        string name = Server.MapPath("~/Uploads/" + fileName);
        databaseFilePut(name, "Birth", DropDownList3.Text);
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
        Button10.Visible = false;
        FileUpload10.Visible = false;
        TextBox11.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
    protected void Button11_Click(object sender, EventArgs e)
    {
        if (FileUpload11.HasFile == true)
        {
        string fileName = System.IO.Path.GetFileName(FileUpload11.PostedFile.FileName);
        FileUpload11.PostedFile.SaveAs(Server.MapPath("~/Uploads/" + fileName));
        string name = Server.MapPath("~/Uploads/" + fileName);
        databaseFilePut(name, "Birth", DropDownList3.Text);
        Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Document Uploaded Successfully');", true);
        Button11.Visible = false;
        FileUpload11.Visible = false;
        TextBox12.Text = "Submited";
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(GetType(), "msgbox", "alert('Add Document');", true);
        }
    }
}