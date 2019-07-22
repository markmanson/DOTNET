<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JapaniesLan.aspx.cs" Inherits="Day_8_9.JapaniesLan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>JapaniesLogin WebPage</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
            height: 218px;
        }
        .style2
        {            height: 40px;
        }
        .style4
        {
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
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="style1" 
            style="background-color: #CC99FF; border-style: solid; border-color: #008080">
            <tr>
                <td class="style2" align="center" colspan="3">
                    &nbsp;<asp:Label ID="lblLogin" runat="server" Text="ログイン" Font-Bold="True" 
                        Font-Italic="True" Font-Size="X-Large" ForeColor="#660066"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style5">
                    &nbsp;</td>
                <td class="style4">
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
                <td class="style4">
                    <asp:Label ID="lblPassword" runat="server" Text="パスワド"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Height="25px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="rfvPass" ControlToValidate="txtPassword" runat="server" Display="None" ErrorMessage="Please enter Password" SetFocusOnError="true">
                        </asp:RequiredFieldValidator> </td>
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
                <td class="style6">
                    </td>
                <td class="style7">
                    <asp:Button ID="btnSumita" runat="server" Height="33px" Text="サベミト" 
                        Width="70px" onclick="btnSumita_Click" />
                </td>
                <td class="style7">
                    <asp:Button ID="btnCancela" runat="server" Height="32px" Text="ケンセル" 
                        Width="68px" onclick="btnCancela_Click"  CausesValidation="false"  />
                </td>
            </tr>
            <tr>
                <td class="style8">
                    </td>
                <td class="style9" colspan="2">
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" ></asp:Label>
                </td>
            </tr>
            
        </table>
      <asp:ValidationSummary ID="ValidationSummary1" HeaderText="Fix following Errors...." ShowMessageBox="false" ShowSummary="true" runat="server" />
    </div>
    </form>
</body>
</html>
