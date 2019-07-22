<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="DAY5Exercise.Information" %>

<%@ PreviousPageType VirtualPath="~/Default.aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Stylesheet.css" type="text/css" rel="Stylesheet" />
    <title>Information Page</title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div align="Center">
        <asp:Panel ID="PanelRegister" Direction="LeftToRight" GroupingText="Welcome User"
            runat="server" CssClass="Panel" Height="160px">
            <table id="tbl" runat="server">
                <tr>
                    <td align="left">
                        <asp:Label ID="LblName" runat="server" CssClass="lblMsg" Font-Bold="true"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblMFValue" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblEmailId" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblDOB" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblPwd" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblFax" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblMarried" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="left">
                        <asp:Label ID="LblLanguage" runat="server" CssClass="lblMsg" Font-Bold="True"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
