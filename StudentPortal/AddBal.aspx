<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddBal.aspx.cs" Inherits="AddBal" %>

<asp:Content ID="Body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" Text="Add Balance"
            CssClass="heading"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Student ID  :-" CssClass="label"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="txt"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" CssClass="button"
            Height="32px" />
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="270px" Visible="false">
            <br />
            <asp:Label ID="Label3" runat="server" Text="Name  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox2" runat="server" CssClass="txt"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Balance  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox3" runat="server" CssClass="txt"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label5" runat="server" Text="Rs  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox4" runat="server" CssClass="txt"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Visible="False" CssClass="label"></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" CssClass="button" />
            <br />
            <br />
        </asp:Panel>
    </div>
</asp:Content>
