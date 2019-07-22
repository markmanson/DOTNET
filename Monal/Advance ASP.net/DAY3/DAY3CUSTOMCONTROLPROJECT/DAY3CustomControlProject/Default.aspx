<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY3CustomControlProject._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register TagPrefix="cc1" Namespace="ServerControl" Assembly="ServerControl" %>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Control Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
   <%-- <asp:Panel GroupingText="Login Form" runat="server" ID="pnl" CssClass="panel">--%>
        <cc1:ServerControl ID="ServerControl1" runat="server" OnClick="BtnSubmit_Click" />
    <%--</asp:Panel>--%>
    </form>
</body>
</html>
