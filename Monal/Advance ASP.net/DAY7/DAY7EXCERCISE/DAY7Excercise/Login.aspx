<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DAY7Excercise.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="LblPanel" runat="server" Font-Size="18px">
            <asp:Label ID="LblHeading" runat="server" Text="Forms Authentication Example" Font-Bold="true"
                Font-Size="18px"></asp:Label>
            <hr />
        </asp:Panel>
        <asp:Panel ID="LoginPanel" runat="server" GroupingText="Login Form" CssClass="panel">
        <asp:Label ID="LblMsg" runat="server" Visible="false" CssClass="lblControl" Font-Bold="true"></asp:Label>
            <table class="Dynamictable">
                <tr>
                    <td class="Bodytd">
                        <asp:Label ID="LblName" runat="server" Text="UserName:"  CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="Bodytd">
                        <asp:TextBox ID="TxtName" runat="server" Width="128px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="Bodytd">
                        <asp:Label ID="LblPwd" runat="server" Text="Password :" CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="Bodytd">
                        <asp:TextBox ID="TxtPwd" runat="server" Width="128px" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                  <tr>
                    <td colspan="2" align="center" class="Bodytd">
                        <asp:Button ID="BtnSignOn" runat="server" Text="Sign On" 
                            onclick="BtnSignOn_Click" />
                    </td>                   
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
