<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginAuthentication.aspx.cs" Inherits="Day_7._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login WebPage</title>
    
    <style type="text/css">
        .style1
        {
        }
        #loginbox
        {
            width: 386px;
            height: 122px;
        }
        .style2
        {
            width: 482px;
        }
        .style3
        {
            width: 133px;
        }
    </style>
</head>
<body onload="fnLoad();" >
    <form id="form1" runat="server">
    <div>
    <table align="center"
            
            
            style=" border: thin solid #800000; height: 231px;  font-size:large; font-weight: normal; font-style: normal; color: #000080; width: 72%; background-color: #C0C0C0;">
    <tr>
        <td align="middle" class="style2">
            <table id="loginbox" class="itemstyle">
                <tr>
                    <td id="login" align="middle" colspan="3" 
                        style="font-size: xx-large; text-decoration: underline;">Form 
                        Authentiacation, Login</td>
                </tr>
               
                <tr>
                    <td class="style1">Username:</td>
                    <td class="style3">
                        <asp:textbox id="txtUsername" tabindex="4" runat="server" 
                    columns="12" Width="96px" ></asp:textbox>
                       </td>
                    <td valign="center" align="middle" rowspan="2"> <asp:RequiredFieldValidator ID="rfvUser" ControlToValidate="txtUsername" runat="server" Display="None" SetFocusOnError="true" ErrorMessage="Please enter user name">
                        </asp:RequiredFieldValidator>
                        &nbsp;</td>
                <tr>
                    <td class="style1">Password:</td>
                    <td class="style3"><asp:textbox id="txtPassword" runat="server" columns="12" 
                    textmode="Password" Width="94px"></asp:textbox></td> <asp:RequiredFieldValidator ID="rfvPass" ControlToValidate="txtPassword" runat="server" Display="None" ErrorMessage="Please enter Password" SetFocusOnError="true">
                        </asp:RequiredFieldValidator>
                </tr>
                <tr>
                    <td class="style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnSignon" runat="server" Height="33px" Text="SignON" 
                            Width="137px" onclick="btnSignon_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;</td>
                    <td colspan="2">&nbsp;</td>
                </tr>
                <tr><td class="style1" colspan="3"> 
                    <asp:Label ID="lblError" Visible="False" runat="server" ForeColor="Red" ></asp:Label></td></tr>
            </table>
        </td> 
    </tr>
</table>
<asp:ValidationSummary ID="ValidationSummary1" ShowMessageBox="false" ShowSummary="true" runat="server" />
    </div>
    </form>
    <script type = "text/javascript">
  
  function fnLoad()
        {
            document.getElementById('txtUsername').focus();

        }
       </script> 
</body>
</html>
