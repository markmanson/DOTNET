<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Frame2.aspx.cs" Inherits="ADV_ASP_Day1_2.Frame2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <br />
    <br />
        <asp:Button ID="BtnEmployee" runat="server" Text="Get Employee Details" 
            onclick="BtnEmployee_Click" /><br /><br />
        <asp:Button ID="BtnDepartment" runat="server" Text="Get Department Details" 
            onclick="BtnDepartment_Click" />
    </div>
    </form>
</body>
</html>
