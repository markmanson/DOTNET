<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error8.aspx.cs" Inherits="ASP_Day9_10.Error8" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error8</title>
</head>
<body>
    <form id="FrmError8" runat="server">
    <div>               
    <asp:Button runat="server" Text="Read File" ID="BtnRead" Width="200px" 
            onclick="BtnRead_Click" Height="40px"/>
            <br /><br />
    <asp:Button runat="server" Text="Error Messages" ID="BtnError" Width="200px" 
            onclick="BtnError_Click"/>
    </div>
    </form>
</body>
</html>
