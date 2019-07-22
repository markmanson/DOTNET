<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCache.aspx.cs" Inherits="ASP_Day9_10.DisplayCache" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DisplayCache</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="left">
        <asp:Button ID="BtnDisplay" runat="server" Text="Display Data From Cache" 
            onclick="BtnDisplay_Click" />
    </div>
    </form>
</body>
</html>
