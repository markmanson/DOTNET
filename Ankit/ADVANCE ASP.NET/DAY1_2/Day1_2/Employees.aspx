<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employees.aspx.cs" Inherits="Day1_2.Employees" %>
<%@ Register Src="~/WebUserControlGrid.ascx" TagName="btn" TagPrefix="BTN" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employees</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnGetEmployees" Text="Show Employee Detail" runat="server" onclick="btnGetEmployees_Click" />
            <asp:PlaceHolder ID="Place" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
