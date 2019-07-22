<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Day_3._Default" %>
<%@ Register Assembly="ServerControlLogin" Namespace="ServerControlLogin" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>lOGIN WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <cc1:ServerControlLogin ID="LgnFrm" runat="server" onsubmit="btnSubmit_Click" />   
    </div>
    </form>
</body>
</html>
