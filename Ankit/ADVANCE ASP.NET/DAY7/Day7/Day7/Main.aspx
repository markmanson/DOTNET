<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Day7.HomePage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>HomePage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label runat="server" ID="lblLogin" Text="You have Login successfully" ForeColor ="Blue" Visible="false"></asp:Label>
    <asp:Button ID="btnOut" Text="SignOut" runat="server" Visible="false" 
            onclick="btnOut_Click" />
    </div>
    </form>
</body>
</html>
