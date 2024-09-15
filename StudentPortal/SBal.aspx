<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="SBal.aspx.cs" Inherits="SBal" %>

<asp:Content ID="Body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>

    <br />
    <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" 
        Text="Add Balance" CssClass="heading"></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Balance  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" CssClass="txt"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Amount  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox2" runat="server" CssClass="txt"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Credit Card No  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox3" runat="server" MaxLength="16" CssClass="txt"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    &nbsp;
    <asp:Label ID="Label5" runat="server" Text="CVV No  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox4" runat="server" MaxLength="3" CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" Text="Expiry Date  :-" CssClass="label"></asp:Label>
&nbsp;
    <asp:TextBox ID="TextBox5" runat="server" Width="56px" MaxLength="2" CssClass="txt"></asp:TextBox>
&nbsp;<asp:TextBox ID="TextBox6" runat="server" Width="54px" MaxLength="2" 
            CssClass="txt"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
            CssClass="button" />
    <br />
        <br />
        <asp:Label ID="Label7" runat="server" Visible="False" CssClass="label"></asp:Label>
    <br />

</div>
</asp:Content>