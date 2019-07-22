<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ToPics.aspx.cs" Inherits="Day_6.ToPics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ToPics WebPage</title>
 <link rel="stylesheet" type="text/css" href="Stylesheet1.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center"><tr><td align="center">
        <asp:Label ID="lblMessage" runat="server" Text="Selected Topics are:" Font-Bold="True" Font-Italic="True" ForeColor="#006699"></asp:Label>
        
     <asp:Panel ID="pnlTopic" runat="server" HorizontalAlign="Center"> </asp:Panel> 
      </td> </tr>   
    </table>
    </div>
    </form>
</body>
</html>
