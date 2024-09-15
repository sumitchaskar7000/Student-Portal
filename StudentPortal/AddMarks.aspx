<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    CodeFile="AddMarks.aspx.cs" Inherits="AddMarks" %>

<asp:Content ID="body" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    <div>
        <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Font-Underline="True" Text="Add Documents"
            CssClass="heading"></asp:Label>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Student Id  :-" CssClass="label"></asp:Label>
        &nbsp;
        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" Width="124px"
            OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged" CssClass="txt">
        </asp:DropDownList>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label19" runat="server" Visible="False" CssClass="label"></asp:Label>
        <br />
        <br />
        <asp:Panel ID="Panel4" runat="server" Height="250px" Visible="False">
            <table width="60%">
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label18" runat="server" Text="Photo  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox14" runat="server" ReadOnly="True" Width="100%" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Add" Width="60%"
                            CssClass="button" Height="37px" ValidationGroup="1" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                        <asp:RegularExpressionValidator ID="ValidateEx" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload1" ValidationGroup="1" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                      
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label10" runat="server" Text="Birth Certificate  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox5" runat="server" ReadOnly="True" Width="100%" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button2" runat="server" ValidationGroup="2" Text="Add" OnClick="Button2_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload2" runat="server" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload2" ValidationGroup="2" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label11" runat="server" Text="Cast Certificate  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox6" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button3" runat="server" ValidationGroup="3" Text="Add" OnClick="Button3_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload3" runat="server" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload3" ValidationGroup="3" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label5" runat="server" Text="SSC Passing  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox1" runat="server" Width="100%" ReadOnly="True" Height="22px"
                            CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button4" runat="server" ValidationGroup="4" Text="Add" OnClick="Button4_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload4" runat="server" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload4" ValidationGroup="4" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label6" runat="server" Text="SSC Leaving  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox2" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button5" runat="server" ValidationGroup="5" Text="Add" OnClick="Button5_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload5" runat="server" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload5" ValidationGroup="5" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel5" runat="server" Height="120px" Visible="False">
            <table width="60%">
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label12" runat="server" Text="HSC Passing  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox7" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button6" runat="server" ValidationGroup="6" Text="Add" OnClick="Button6_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload6" runat="server" />
                      <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload6" ValidationGroup="6" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label13" runat="server" Text="HSC Leaving  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox8" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button7" runat="server" ValidationGroup="7" Text="Add" OnClick="Button7_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload7" runat="server" />
                     <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload7" ValidationGroup="7" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel6" runat="server" Height="130px" Visible="False">
            <table width="60%">
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label14" runat="server" Text="Graduation Passing  :-" CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox13" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button8" runat="server" Text="Add" OnClick="Button8_Click" ValidationGroup="8"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload8" runat="server" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator7" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload8" ValidationGroup="8" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label15" runat="server" Text="Graduation Leaving  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox10" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button9" runat="server" ValidationGroup="9" Text="Add" OnClick="Button9_Click"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload9" runat="server" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator8" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload9" ValidationGroup="9" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        <asp:Panel ID="Panel7" runat="server" Height="130px" Visible="False">
            <table width="60%">
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label16" runat="server" Text="Post-Graduation Passing  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox11" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button10" runat="server" Text="Add" OnClick="Button10_Click" ValidationGroup="10"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload10" runat="server" />
                       <asp:RegularExpressionValidator ID="RegularExpressionValidator9" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload10" ValidationGroup="10" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td align="left" width="35%">
                        <asp:Label ID="Label17" runat="server" Text="Post-Graduation Leaving  :- " CssClass="label"></asp:Label>
                    </td>
                    <td width="15%">
                        <asp:TextBox ID="TextBox12" runat="server" Width="100%" ReadOnly="True" CssClass="txt"></asp:TextBox>
                    </td>
                    <td style="width: 20%" align="right">
                        <asp:Button ID="Button11" runat="server" Text="Add" OnClick="Button11_Click" ValidationGroup="11"
                            CssClass="button" Height="37px" Width="60%" />
                    </td>
                    <td style="width: 30%">
                        <asp:FileUpload ID="FileUpload11" runat="server" />
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator10" runat="server"   ValidationExpression="^.*\.(pdf|PDF)$" ControlToValidate="FileUpload11" ValidationGroup="11" ErrorMessage=".pdf only" ForeColor="Red" ></asp:RegularExpressionValidator>
                    </td>
                </tr>
            </table>
        </asp:Panel>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server"
            OnClick="Button1_Click" Text="Submit" ValidationGroup="19" CssClass="button" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
