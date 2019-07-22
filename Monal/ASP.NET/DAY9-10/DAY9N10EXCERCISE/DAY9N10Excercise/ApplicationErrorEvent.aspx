<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ApplicationErrorEvent.aspx.cs"
    Inherits="DAY9N10Excercise.ApplicationErrorEvent" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error Occured in Application</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblFileContents" runat="server" CssClass="lblMsg"></asp:Label>
    </div>
    </form>
</body>
</html>
