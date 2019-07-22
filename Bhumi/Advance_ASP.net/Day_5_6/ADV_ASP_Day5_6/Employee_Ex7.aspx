<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee_Ex7.aspx.cs" Inherits="ADV_ASP_Day5_6.Employee_Ex7" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee_Ex7</title>
    <style type="text/css">
    .table
    {       
        border-style:solid;        
    }
    </style>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="DdlEmployee">
    <div align="center">
    <table class="table">
    <caption><h2>Employee Details</h2></caption>
    <tr><td></td></tr>
    <tr><td></td></tr>
    <tr>
    <td></td>
    <td></td>
        <td>
            <asp:DropDownList ID="DdlEmployee" runat="server" Height="25px" Width="100px" 
                AppendDataBoundItems="True">
                <asp:ListItem Value="0">---SELECT---</asp:ListItem>
            </asp:DropDownList>
                   &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                   <asp:Button ID="BtnDetails" runat="server" Text="Details" 
                style="font-weight: 700" Width="100px" onclick="BtnDetails_Click" />&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />            
        </td>
        <td>
        </td>
        <td>
        </td>
    </tr>
    </table>
    </div>
    </form></body>
</html>
