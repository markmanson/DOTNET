﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Error9.aspx.cs" Inherits="ASP_Day9_10.Error9"%>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error9</title>
</head>
<body>
    <form id="FrmError9" runat="server">
    <div>        
        <asp:Label ID="LblError" runat="server" style="font-weight: 700" 
            ForeColor="Red"></asp:Label>  <br />      
    <asp:Button runat="server" Text="Read File" ID="BtnRead" Width="200px" Height="40px" 
            onclick="BtnRead_Click"/>
            <br />
            <br />
    <asp:Button runat="server" Text="Error Messages" ID="BtnError" Width="200px" 
            onclick="BtnError_Click"/>
    </div>
    </form>
</body>
</html>
