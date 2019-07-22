<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BrowserInfo.aspx.cs" Inherits="Day_9.BrowserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>BrowserInfo</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblMsg" runat="server" Text="This Page sends the cache object to DisplayCache page!! Expiry time is 15 sec.."></asp:Label>
    </div>
    </form>
</body>
</html>
