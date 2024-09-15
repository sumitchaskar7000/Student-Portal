<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <br />
        <table>
            <tr>
                <td>
                    <asp:ImageButton ID="ImageButton1" runat="server" Height="146px" ImageUrl="~/images/admin.png"
                        Width="147px" OnClick="ImageButton1_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton6" runat="server" Height="146px" ImageUrl="~/images/Office.png"
                        Width="147px" OnClick="ImageButton6_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton2" runat="server" Height="146px" ImageUrl="~/images/lib.png"
                        Width="147px" OnClick="ImageButton2_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton3" runat="server" Height="146px" ImageUrl="~/images/Canteen.bmp"
                        Width="176px" OnClick="ImageButton3_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton4" runat="server" Height="150px" ImageUrl="~/images/stationeryae.png"
                        Width="168px" OnClick="ImageButton4_Click" />
                </td>
                <td>
                    <asp:ImageButton ID="ImageButton5" runat="server" Height="146px" ImageUrl="~/images/student.png"
                        Width="147px" OnClick="ImageButton5_Click" />
                </td>
            </tr>
        </table>
        <br />
        <br />
    </div>
</asp:Content>
