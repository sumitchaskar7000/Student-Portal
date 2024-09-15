<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master"
    CodeFile="New_Transaction.aspx.cs" Inherits="New_Transaction" %>

<asp:Content ID="Body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" Text="New Transaction"
            CssClass="heading"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Student ID :-" CssClass="label"></asp:Label>
        &nbsp;
        <asp:TextBox ID="TextBox1" runat="server" CssClass="txt"></asp:TextBox>
        &nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Search" CssClass="button"
            Height="32px" Width="89px" />
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="300px" Visible="False">
            <br />
            <asp:Label ID="Label4" runat="server" Text="Balance  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="True" CssClass="txt"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            &nbsp;<asp:Label ID="Label3" runat="server" Text="Rs  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox2" runat="server" CssClass="txt"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Visible="False" CssClass="label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label6" runat="server" Text="Note  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:TextBox ID="TextBox4" runat="server" Height="39px" TextMode="MultiLine" Width="148px"
                CssClass="txt"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Pay" Width="88px"
                CssClass="button" Height="37px" />
            &nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" Width="90px"
                CssClass="button" Height="37px" />
        </asp:Panel>
        <br />
    </div>
</asp:Content>
