<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topics.aspx.cs" Inherits="Day_6.Topics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Topics</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lbl" runat="server"></asp:Label>
    </div>
    <asp:PlaceHolder EnableViewState="True" ID="PlaceHolder" runat="server" Visible="True">
      </asp:PlaceHolder>
    </form>
</body>
</html>
