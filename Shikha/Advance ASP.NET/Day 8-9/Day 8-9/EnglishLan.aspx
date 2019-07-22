<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EnglishLan.aspx.cs" Inherits="Day_8_9.EnglishLan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EnglishLogin WebPage</title>
    <style type="text/css">
        .style1
        {
            width: 89%;
        }
        .style2
        {            height: 39px;
        }
        .style4
        {
            width: 138px;
        }
        .style5
        {
            width: 157px;
        }
        .style6
        {
            width: 157px;
            height: 43px;
        }
        .style7
        {
            height: 43px;
        }
        .style8
        {
            height: 43px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <table class="style1" align="center" 
            style="background-color: #C0C0C0; border-style: solid; border-color: #008080">
            <tr>
                <td class="style2" align="center" colspan="3">
                    &nbsp;<asp:Label ID="Label1" runat="server" Text="Login" Font-Bold="True" 
                        Font-Italic="True" Font-Size="X-Large"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblLoginID" runat="server" Text="LoginID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLoginID" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvUser" ControlToValidate="txtLoginID" runat="server" Display="None" SetFocusOnError="true" ErrorMessage="Please enter user name">
                        </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode= "Password" ></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvPass" ControlToValidate="txtPassword" runat="server" Display="None" ErrorMessage="Please enter Password" SetFocusOnError="true">
                        </asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
                    <asp:Button ID="btnSubmit" runat="server" Height="33px" Text="Submit" 
                        Width="70px" onclick="btnSubmit_Click" />
                </td>
                <td>
                    <asp:Button ID="btnCancel" runat="server" Height="32px" Text="Cancel" 
                        Width="68px" onclick="btnCancel_Click"  CausesValidation="false"  />
                </td>
            </tr>
            <tr>
                <td class="style6">
                    </td>
                <td class="style7" colspan="2">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Fix following Errors...." ShowMessageBox="false" ShowSummary="true" runat="server" />
    </form>
</body>
</html>
