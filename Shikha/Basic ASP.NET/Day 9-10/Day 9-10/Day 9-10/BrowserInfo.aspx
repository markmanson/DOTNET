﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BrowserInfo.aspx.cs" Inherits="Day_9_10.BrowserInfo" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>
    Browser Info WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblMsg" runat="server" Text="This Page sends the cache object to DisplayCache page!! Expiry time is 15 sec.."></asp:Label>
        <asp:TextBox ID="txtFile" runat="server" TextMode="MultiLine" ></asp:TextBox>
    <br />
        <asp:Button ID="btnClick" runat="server" Text="Display" 
            onclick="btnClick_Click" />
            
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnUpdate" runat="server" Text="Updtae" 
            onclick="btnUpdate_Click" />
            
    </div>
    
    </form>
</body>
</html>
