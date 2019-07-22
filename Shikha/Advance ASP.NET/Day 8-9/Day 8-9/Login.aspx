<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Day_8_9.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login WebPage</title>
    <style type="text/css">
        .style1
        {
            width: 90%;
            height: 218px;
        }
        .style2
        {            height: 40px;
        }
        .style5
        {
            width: 157px;
        }
        .style6
        {
            width: 157px;
            height: 36px;
        }
        .style7
        {
            height: 36px;
        }
        .style8
        {
            width: 157px;
            height: 43px;
        }
        .style9
        {
            height: 43px;
        }
        .style10
        {
        }
        .style11
        {
            width: 154px;
            height: 36px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      <table align="center" class="style1" 
            style="border-style: solid; border-color: #800000; background-color: #C0C0C0">
            <tr>
                <td class="style2" align="center" >
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                </td><td class="style10" align="right">
                    <asp:Label ID="lblLogin" runat="server" Text="ログイン"></asp:Label>
                </td><td align="right">
                    <asp:Button ID="btnChange" runat="server" Height="39px" 
                         Width="110px" onclick="btnChange_Click" CausesValidation="false" />
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style10">
                    <asp:Label ID="lblLoginID" runat="server" Text="ログインID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtLoginID" runat="server" Height="25px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvUser" ControlToValidate="txtLoginID" runat="server" Display="None" SetFocusOnError="true" ErrorMessage="Please enter user name">
                        </asp:RequiredFieldValidator> </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style10">
                    <asp:Label ID="lblPassword" runat="server" Text="パスワド"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" Height="25px" TextMode= "Password" ></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPass" ControlToValidate="txtPassword" runat="server" Display="None" ErrorMessage="Please enter Password" SetFocusOnError="true">
                        </asp:RequiredFieldValidator> </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style10">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style6">
                    </td>
                <td class="style11">
                    <asp:Button ID="btnSumita" runat="server" Height="33px" Text="サベミト" 
                        Width="70px" onclick="btnSumita_Click"  />
                </td>
                <td class="style7">
                    <asp:Button ID="btnCancela" runat="server" Height="32px" Text="ケンセル" 
                        Width="68px" onclick="btnCancela_Click" CausesValidation="false" />
                </td>
            </tr>
            <tr>
                <td class="style8">
                    </td>
                <td class="style9" colspan="2">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
           <tr><td>
          
           </td><td class="style10" colspan="2">      <asp:ValidationSummary ID="ValidationSummary2"
    HeaderText="Please fix the Errors..."
    EnableClientScript="true" 
    runat="server"/></td></tr> 
        </table>
       
    </div>
    
    </form>
</body>
</html>
