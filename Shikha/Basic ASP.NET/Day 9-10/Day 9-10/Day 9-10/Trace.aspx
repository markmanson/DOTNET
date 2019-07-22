<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trace.aspx.cs" Inherits="Day_9_10.Trace" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Trace WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblFile" runat="server" Text=""></asp:Label>
        <asp:LinkButton ID="lbtnView" runat="server">View Trace Log</asp:LinkButton>
    </div>
    </form>
</body>
</html>
