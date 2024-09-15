<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Change_Pass.aspx.cs" Inherits="Change_Pass" %>

<asp:Content ID="Body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>

    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" 
        Text="Change Password" CssClass="heading"></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="User Id  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" CssClass="txt"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Old Password  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="New Password  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Confirm Password  :-" 
        CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" TextMode="Password" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Change" 
        CssClass="button" />
    <br />
    <br />

</div>
</asp:Content>