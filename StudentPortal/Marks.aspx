<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Marks.aspx.cs" Inherits="Marks" %>

<asp:Content ID="body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
    
        <br />
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" 
            Text="Documents"></asp:Label>
        <br />
        <br />
        <br />
            <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Photo</asp:LinkButton>
            <br __designer:mapid="a9" />
            <br __designer:mapid="aa" />
            <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click">Birth Certificate</asp:LinkButton>
            <br __designer:mapid="ac" />
            <br __designer:mapid="ad" />
            <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click">Cast Certificate</asp:LinkButton>
        <br />
        <br />
    
    </div>
    <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click">SSC Passing </asp:LinkButton>
    <br __designer:mapid="b0" />
    <br __designer:mapid="b1" />
    <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click">SSC Leaving</asp:LinkButton>
    <br />
    <br />
    <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click">HSC Passing</asp:LinkButton>
    <br __designer:mapid="b4" />
    <br __designer:mapid="b5" />
    <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click">HSC Leaving</asp:LinkButton>
<br />
    <br />
    <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click">Graduate Passing</asp:LinkButton>
    <br __designer:mapid="b8" />
    <br __designer:mapid="b9" />
    <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click">Graduate Leaving </asp:LinkButton>
    <br __designer:mapid="bb" />
    <br />
    <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click">Post-Graduate Passing</asp:LinkButton>
    <br __designer:mapid="bd" />
    <br __designer:mapid="be" />
    <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click">Post-Graduate Leaving </asp:LinkButton>
<br />
<br />
<br />
</asp:Content>
