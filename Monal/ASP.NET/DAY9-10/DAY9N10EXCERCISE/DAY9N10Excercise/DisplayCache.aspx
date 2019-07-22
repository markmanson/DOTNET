<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCache.aspx.cs" Inherits="DAY9N10Excercise.DisplayCache" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Display Cache Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
            <asp:Label ID="lblCacheMsg" runat="server" CssClass="lblMsg"></asp:Label>
            <br />
             <asp:Label ID="LblDate" runat="server" CssClass="lblMsg"></asp:Label>
            <br />
            <asp:Button ID="BtnAddCache" runat="server" Text="Update Date" Height="26px" OnClick="BtnAddCache_Click"
                Width="83px" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
