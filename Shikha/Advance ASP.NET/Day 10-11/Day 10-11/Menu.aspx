<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Day_10_11._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Menu WebPage</title>
     
      <link rel="stylesheet" type="text/css" href="StylesheetXML.css"/>
    
</head>
<body >
    <form id="form1" runat="server" style="top: auto">
    <div style="background-image: url('Images/Texture_by_umerr2000.jpg'); background-repeat: repeat; height: 68px;">
        <b><asp:Label ID="Label3" runat="server" Text="Have a Good Day..."></asp:Label></b></div>
    <table style="top: auto"><tr><td class="style1"><a>
        <asp:Label ID="Label1" runat="server" Text="Welcome..."></asp:Label>
   </a> </td></tr>
    <tr><td class="style1"><a>
        <asp:Label ID="Label2" runat="server" Text="Please Select cources.."></asp:Label></a></td></tr>
        <tr><td class="style2">
      <asp:Xml ID="Xml1"  DocumentSource="~/XMLMenu.xml" TransformSource="~/XSLTMenu.xslt" runat="server"></asp:Xml>
 </td></tr></table>
    </form>
</body>
</html>
