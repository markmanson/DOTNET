<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Day8_9ExcerobjCultureInfose.LoginPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Login Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="LoginPanel" runat="server" CssClass="panel">
            <asp:Label ID="LblMsg" runat="server" CssClass="lblControl" Font-Bold="true" Visible="false"></asp:Label>
            <table class="Dynamictable">
                <tr>
                    <td align="right" colspan="2">
                        <asp:Button ID="BtnLanguage" runat="server" OnClick="BtnLanguage_Click" Width="75px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center" class="Bodytd">
                        <asp:Label ID="LblHeading" runat="server" CssClass="lblControl" Font-Bold="true"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Bodytd">
                        <asp:Label ID="LblName" runat="server" CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="Bodytd">
                        <asp:TextBox ID="TxtName" runat="server" Width="128px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="Bodytd">
                        <asp:Label ID="LblPwd" runat="server" CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="Bodytd">
                        <asp:TextBox ID="TxtPwd" runat="server" Width="128px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center" class="Bodytd">
                        <asp:Button ID="BtnSubmit" runat="server" Width="70px" OnClick="BtnSubmit_Click" />
                        <asp:Button ID="BtnCancel" runat="server" Width="70px" OnClick="BtnCancel_Click" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
