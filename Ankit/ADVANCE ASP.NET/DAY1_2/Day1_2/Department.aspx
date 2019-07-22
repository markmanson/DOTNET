<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department.aspx.cs" Inherits="Day1_2.Department" %>
<%@ Register Src="~/WebUserControlGrid.ascx" TagName="btn" TagPrefix="BTN" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Department</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Button ID="btnGetDepart" runat="server" Text="Show Department Detail" onclick="btnGetDepart_Click" />
            <asp:PlaceHolder ID="Place" runat="server"></asp:PlaceHolder>
    </div>
    </form>
</body>
</html>
