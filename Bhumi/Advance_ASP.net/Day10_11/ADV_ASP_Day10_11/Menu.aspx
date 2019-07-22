    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="ADV_ASP_Day10_11.Menu" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Menu</title>
</head>
<body>
    <form id="frmMenu" runat="server">
    <div>
        <asp:Xml ID="Menu_XML" runat="server" DocumentSource="~/menu.xml" TransformSource="template.xslt" ></asp:Xml>
    </div>
    </form>
</body>
</html>
