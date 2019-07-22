<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main_Page.aspx.cs" Inherits="ADV_ASP_Day7.Main_Page" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main_Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 40px">
    <h1> WelCome To Home Page :
    <asp:Label runat="server" ID="LblUser" ForeColor="Blue"></asp:Label></h1>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button runat="server" ID="BtnLogOut" Text="LogOut" Font-Size="Large"
            onclick="BtnLogOut_Click" Width="150px" Height="40px" />
    </div>
    </form>
</body>
</html>
