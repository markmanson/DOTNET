<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="Day_8_9.Welcome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Welcome WebPage</title>
    <style type="text/css">
        .style1
        {
            height: 112px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center" 
            
            style="border-color: #0000FF; border-style: solid; background-color: #008080; width: 611px; height: 164px;"><tr><td align="center" class="style1">
        <asp:Label ID="lblWlcm" runat="server" Font-Bold="True" Font-Italic="True" Font-Size="X-Large" ForeColor="#660066"></asp:Label>
   </td></tr></table> </div>
    </form>
</body>
</html>
