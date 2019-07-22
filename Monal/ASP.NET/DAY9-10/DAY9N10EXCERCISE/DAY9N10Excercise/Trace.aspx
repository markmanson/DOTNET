<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Trace.aspx.cs" Inherits="DAY9N10Excercise.Trace" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Trace Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <asp:Panel ID="Panel1" runat="server" Height="100%" Width="100%" Font-Size="12px">
            <asp:Label ID="LblFileContents" runat="server" CssClass="lblMsg"></asp:Label>
            <a href="" style="font-size=12px"></a>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
