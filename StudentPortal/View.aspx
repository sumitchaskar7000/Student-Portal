<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="View.aspx.cs" Inherits="View" %>

<asp:Content ID="body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
    
        <br />
        <asp:Label ID="Label10" runat="server" Font-Size="X-Large" 
            Font-Underline="True" Text="Student Profile  " CssClass="heading"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Label19" runat="server" Text="Student ID  :-" CssClass="label"></asp:Label>
&nbsp;
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DropDownList1_SelectedIndexChanged" 
            CssClass="label">
            <asp:ListItem>--Select--</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label25" runat="server" Visible="False" CssClass="label"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="153px" Visible="False">
            <asp:Label ID="Label11" runat="server" Text="Name  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:Label ID="Label12" runat="server" Text="Label" CssClass="label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label24" runat="server" Text="Address  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:Label ID="Label20" runat="server" Text="Label" CssClass="label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label13" runat="server" Text="Mobile  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:Label ID="Label14" runat="server" Text="Label" CssClass="label"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label15" runat="server" Text="EMail  :-" CssClass="label"></asp:Label>
            &nbsp;
            <asp:Label ID="Label16" runat="server" Text="Label" CssClass="label"></asp:Label>
            <br />
        </asp:Panel>
        <br />
        <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click" 
            Visible="False">Photo</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton2" runat="server" onclick="LinkButton2_Click" 
            Visible="False">Birth Certificate</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton3" runat="server" onclick="LinkButton3_Click" 
            Visible="False">Cast Certificate</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton4" runat="server" onclick="LinkButton4_Click" 
            Visible="False">SSC Passing </asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton5" runat="server" onclick="LinkButton5_Click" 
            Visible="False">SSC Leaving</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton6" runat="server" onclick="LinkButton6_Click" 
            Visible="False">HSC Passing</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton7" runat="server" onclick="LinkButton7_Click" 
            Visible="False">HSC Leaving</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton8" runat="server" onclick="LinkButton8_Click" 
            Visible="False">Graduate Passing</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton9" runat="server" onclick="LinkButton9_Click" 
            Visible="False">Graduate Leaving </asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton10" runat="server" onclick="LinkButton10_Click" 
            Visible="False">Post-Graduate Passing</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="LinkButton11" runat="server" onclick="LinkButton11_Click" 
            Visible="False">Post-Graduate Leaving </asp:LinkButton>
        <br />
        <br />
    
    </div>
</asp:Content>
