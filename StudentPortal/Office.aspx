<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Office.aspx.cs" Inherits="Office" %>

<asp:Content ID="Body" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>

    <br />
    &nbsp;&nbsp;
    <asp:Label ID="Label4" runat="server" Font-Size="X-Large" Font-Underline="True" 
        Text="Office  Login" CssClass="heading"></asp:Label>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <table width="30%">
            <tr>
                <td width="50%" align="right">
                    <asp:Label ID="Lable1" runat="server" Text="ID  :-" CssClass="label"></asp:Label>
                </td>
                <td width="50%">
                    <asp:TextBox ID="id" runat="server" Width="70%" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="50%" align="right">
                    <asp:Label ID="Label3" runat="server" Text="Password :-" CssClass="label"></asp:Label>
                </td>
                <td width="50%">
                    <asp:TextBox ID="pass" runat="server" Width="70%" TextMode="Password" 
                        CssClass="txt"></asp:TextBox>
                </td>
            </tr>
        </table>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Login" 
        onclick="Button1_Click" CssClass="button" Width="125px" />
    &nbsp;
    &nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" 
        Text="Cancel" Width="114px" CssClass="button" />
    <br />
    <br />
    <br />

</div>
</asp:Content>