﻿<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Library.aspx.cs" Inherits="Library" %>

<asp:Content ID="Body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
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
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" Text="Login" onclick="Button1_Click" 
            style="margin-top: 0px;" CssClass="button" Width="137px" />
    &nbsp;
        <asp:Button ID="Button2" runat="server" onclick="Button2_Click" Text="Cancel" 
            CssClass="button" Width="129px" /><br /><br />
    </div>
</asp:Content>
 