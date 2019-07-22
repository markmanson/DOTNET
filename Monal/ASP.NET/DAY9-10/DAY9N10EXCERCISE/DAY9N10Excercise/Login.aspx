<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DAY9N10Excercise.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <div align="center">
                <asp:Label ID="LblWelcome" runat="server" CssClass="lblMsg"></asp:Label>
                <asp:Panel ID="PnlLogin" runat="server" GroupingText="Login Page" CssClass="Panel">
                    <table id="TblLogin" class="table" align="center">
                        <tr>
                            <td class="td">
                                <asp:Label ID="LblUserId" runat="server" CssClass="lblControl" Font-Bold="true" Text="User ID :"></asp:Label>
                            </td>
                            <td class="td">
                                <asp:TextBox ID="TxtUserId" runat="server" Font-Size="12px" Width="131px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="td">
                                <asp:Label ID="LblPwd" runat="server" CssClass="lblControl" Font-Bold="true" Text="Password:"></asp:Label>
                            </td>
                            <td class="td">
                                <asp:TextBox ID="TxtPwd" runat="server" Font-Size="12px" TextMode="Password" Width="131px"></asp:TextBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="td" align="right" colspan="1">
                            </td>
                            <td class="td" align="left" colspan="1">
                                <asp:Button ID="BtnSubmit" runat="server" Text="Submit" Width="49px" OnClick="BtnSubmit_Click" />
                                <asp:Button ID="BtnReset" runat="server" OnClick="BtnReset_Click" Text="Reset" Width="49px" />
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
