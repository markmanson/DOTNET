<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UserControlPage._Default" %>

<%@ Register Src="UserControls.ascx" TagName="UserControls" TagPrefix="uc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>User Control Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="PnlUsercontrol" runat="server" GroupingText="User Control" CssClass="Panel">
            <asp:Label ID="LblCounter" runat="server" Text="Counter" CssClass="lblMsgCounter"></asp:Label>
            <asp:TextBox ID="TxtCounter" runat="server"></asp:TextBox>
            <uc1:UserControls ID="UserControlCounter" runat="server" Getcounter="0" />
        </asp:Panel>
    </div>
    </form>
</body>
</html>
