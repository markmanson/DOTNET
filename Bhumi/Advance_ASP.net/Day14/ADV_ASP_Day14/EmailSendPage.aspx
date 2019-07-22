<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmailSendPage.aspx.cs" Inherits="ADV_ASP_Day14.EmailSendPage" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit.HTMLEditor" tagprefix="cc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>EmailSendPage</title>
<style type="text/css">
        .auto-style1 {
            color: black;
            font-weight: bold;            
            background-color: #F6F6F6;
            font-family:Segoe Script;
        } 
        .auto-style2 {
            background-color: #F6F6F6;
        }
        .send
        {
            margin-left:440px;                        
        }
        
    .style1
    {
        width: 635px;
    }
        
    </style>
</head>
<body style="background-image: url('../Images/background-websites.jpg'); background-repeat:no-repeat">
    <form id="FrmEmailSendPage" runat="server">
        <div>
            <asp:Label ID="LblSendMailAlert" runat="server" Visible="false" Text="Mail sent..." ForeColor="White" Font-Size="Larger"></asp:Label>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        <br />
        <br />
        <br />
            <table style="border-style: solid; border-color: inherit; border-width: 1px; background-color: #F6F6F6;" align="center">
                <tr>
                    <td colspan="2" align="center" class="auto-style1">
                        <asp:Image ID="ImgMail" runat="server" ImageUrl="~/Images/mail.jpg" 
                            Height="92px" Width="762px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;From:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="TxtFrom" runat="server" Width="450px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RfvFrom" runat="server" ErrorMessage="*" ControlToValidate="TxtFrom" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RgxvFrom" runat="server" 
                            ErrorMessage="*Invalid Input" ForeColor="Red" ControlToValidate="TxtFrom" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;To:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="TxtTo" runat="server" Width="450px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RfvTo" runat="server" ErrorMessage="*" ControlToValidate="TxtTo" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RgxvTo" runat="server" 
                            ErrorMessage="*Invalid Input" ForeColor="Red" ControlToValidate="TxtTo" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;Cc:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="TxtCc" runat="server" Width="450px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RgxvCc" runat="server" 
                            ErrorMessage="*Invalid Input" ForeColor="Red" ControlToValidate="TxtCc" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;Bcc:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="TxtBcc" runat="server" Width="450px"></asp:TextBox>
                        <asp:RegularExpressionValidator ID="RgxvBcc" runat="server" 
                            ErrorMessage="*Invalid Input" ForeColor="Red" ControlToValidate="TxtBcc" 
                            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;Subject:
                    </td>
                    <td class="style1">
                        <asp:TextBox ID="TxtSubject" runat="server" Width="450px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;Attach a file: &nbsp;
                    </td>
                    <td class="style1">
                        <asp:FileUpload ID="fileUpload1" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td valign="top" class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp; 
                        <br />
&nbsp;&nbsp;&nbsp;Message:
                    </td>
                    <td class="style1">
                        <br />
                        <cc1:Editor ID="TxtBody" runat="server" Width="600px" />
                    </td>
                    <td>
                    </td>
                </tr>
                
                <tr>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="style1">
                        <asp:Button ID="BtnClear" Text="Clear" runat="server" Style="height: 26px; font-weight: 700;" 
                            Width="80px" CausesValidation="False" onclick="BtnClear_Click" 
                            BackColor="#AECEFF" BorderStyle="Solid" BorderWidth="1px" />

                        <asp:Button CssClass="send" ID="btnSubmit" Text="Send" runat="server" 
                           Style="height: 26px; font-weight: 700;" Width="80px" 
                            onclick="btnSubmit_Click" BackColor="#AECEFF" BorderStyle="Outset" 
                            BorderWidth="1px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body></html>
