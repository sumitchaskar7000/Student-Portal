<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="CReg.aspx.cs" Inherits="CReg" %>

<asp:Content ID="body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <table width="50%">
            <tr>
                <td width="70%" align="center">
                    <asp:Label ID="Label2" runat="server" Text="User ID  :-" CssClass="label"></asp:Label>
                </td>
                <td width="30%" align="left">
                    <asp:TextBox ID="TextBox1" runat="server" ReadOnly="True" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="70%" align="center">
                    <asp:Label ID="Label3" runat="server" Text="Name  :-" CssClass="label"></asp:Label>
                </td>
                <td width="30%" align="left">
                    <asp:TextBox ID="TextBox2" pattern="[a-zA-Z]*$" title="Enter Name" runat="server" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="70%" align="center">
                    <asp:Label ID="Label4" Style="padding-bottom: 5px;" runat="server" Text="Address  :-"
                        CssClass="label"></asp:Label>
                </td>
                <td width="30%" align="left">
                    <asp:TextBox ID="TextBox3" required runat="server" Height="41px" TextMode="MultiLine" Width="293px"
                        CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="70%" align="center">
                    <asp:Label ID="Label5" runat="server" Text="Mobile No  :-" CssClass="label"></asp:Label>
                </td>
                <td width="30%" align="left">
                    <asp:TextBox ID="TextBox4" pattern="^[7-9]\d{9}$" title="Enter Contact No." runat="server" CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="70%" align="center">
                    <asp:Label ID="Label6" runat="server" Text="Email  :-" CssClass="label"></asp:Label>
                </td>
                <td width="30%" align="left">
                    <asp:TextBox ID="TextBox5"  runat="server" patteren="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" title="Enter Email Id." CssClass="txt"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td width="70%" align="center">
                    <asp:Label ID="Label7" runat="server" Text="Max Qualification  :-" CssClass="label"></asp:Label>
                </td>
                <td width="30%" align="left">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="txt">
                        <asp:ListItem>SSC</asp:ListItem>
                        <asp:ListItem>HSC</asp:ListItem>
                        <asp:ListItem>Graduate</asp:ListItem>
                        <asp:ListItem>Post Graduate</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="3" align="center">
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Submit" CssClass="button" />
                    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Add Documents"
                        Visible="False" CssClass="button" />
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
