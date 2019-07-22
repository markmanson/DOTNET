<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY9N10Excercise._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>File Read And Exception</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="Panel1" runat="server" CssClass="Panel">
            <asp:Button ID="BtnError" runat="server" Text="ErrorButton" OnClick="BtnError_Click" />
            <br />
            <asp:Label ID="LblFileContents" runat="server" CssClass="lblMsg"></asp:Label>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
