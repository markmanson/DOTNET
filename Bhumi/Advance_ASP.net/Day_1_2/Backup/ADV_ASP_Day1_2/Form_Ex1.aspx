<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form_Ex1.aspx.cs" Inherits="ADV_ASP_Day1_2.Form_Ex1" %>
<%@ Register TagPrefix="My" TagName="UserButtonControl" Src="~/UserControl1.ascx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
    .table
    {
        background-color:#E6E6FA;
        margin-top: 100px;
        margin-bottom: 100px;
        margin-right: 150px;
        margin-left: 50px;
        border: 2px ridge black;        
    }    
</style>
    <title>Form_Ex1</title>
</head>
<body>
    <form id="FrmForm_Ex1" runat="server">
    <div align="center">
    <table width="25%" cellpadding="3" class="table">
    <caption><h2 align="center">Exercise no : 1</h2> 
    <tr><td></td></tr>
       <tr>
       <td></td>
        <td>
            <asp:Label ID="LblCounter" runat="server" Text="Counter"></asp:Label>
        </td>
        <td>
            <asp:TextBox ID="TxtCounter" runat="server" Width="60px" ReadOnly="true"></asp:TextBox>
        </td>
        <td>
            <My:UserButtonControl runat="server" ID="UserControl"></My:UserButtonControl>
        </td>
        
        <td></td>
       </tr>
       <tr><td></td></tr>
    </caption>
    </table>
    </div>
    </form>
</body>
</html>
