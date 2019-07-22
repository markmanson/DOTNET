<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Department_Details.aspx.cs" Inherits="ADV_ASP_Day1_2.Department_Details" %>
<%@ Register TagPrefix="My" TagName="UserTableControl" Src="~/TestControl1.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Department_Details</title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="BtnDeptmnt">
    <div>
    <asp:Button ID="BtnDeptmnt" runat="server" Text="Show Department Details" 
            onclick="BtnDeptmnt_Click" />
        <br />
        <br />
        <br />
        <My:UserTableControl runat="server" ID="UserControl" Visible="false"></My:UserTableControl>
    </div>
    </form>
</body>
</html>
