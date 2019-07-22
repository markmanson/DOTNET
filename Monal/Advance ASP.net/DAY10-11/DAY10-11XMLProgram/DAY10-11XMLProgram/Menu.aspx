<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="DAY10_11XMLProgram.Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu Page</title>
    <link rel="Stylesheet" type="text/css" href="Stylesheet.css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="LblValue" Text="SELECT MENU" Font-Bold="true" Font-Underline="true"
            CssClass="lblControl"></asp:Label>
        <asp:Xml ID="Xml1" runat="server" DocumentSource="~/XMLMenuFile.xml" TransformSource="~/XSLTFile1.xslt"></asp:Xml>
    </div>
    </form>
</body>
</html>
