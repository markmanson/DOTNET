﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="JapaniesWelcm.aspx.cs" Inherits="Day_8_9.JapaniesWelcm" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>JapaniesWelcm WebPage</title>
    <style type="text/css">
        .style1
        {
            height: 192px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table style="border-style:solid; border-color: #800080; background-color: #C0C0C0; width: 645px; height: 143px;">
    <tr><td align="center" class="style1">
      <asp:Label ID="lblWlcm" runat="server" Text="Unikaihatsuへようこそ , " 
            Font-Bold="True" Font-Italic="True" ForeColor="#660033" 
            Font-Size="X-Large"></asp:Label>
  </td></tr></table>
    
    
   <%-- <asp:Label ID="lblWlcm" runat="server" Text="Unikaihatsuへようこそ , "></asp:Label>--%>
    </div>
    </form>
</body>
</html>
