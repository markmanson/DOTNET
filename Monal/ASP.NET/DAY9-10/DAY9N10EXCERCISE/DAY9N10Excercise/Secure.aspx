<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Secure.aspx.cs" Inherits="DAY9N10Excercise.Secure" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Secure Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
        <asp:Panel ID="PnlSecure" runat="server"  CssClass="Panel">
            <asp:Label ID="LblSecure" runat="server" CssClass="lblMsg"></asp:Label>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
