<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Choice.aspx.cs" Inherits="ASP_Day6.Choice" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Choice</title>
    <style type="text/css">
    .table1
    {
        background-color:#A9A9A9;
        margin-top: 100px;
        margin-bottom: 100px;
        margin-left: 50px;
        border: 2px solid black;
    }
    .td1
    {
        border: 2px solid black;
        background-color:White;
    }        
    </style>
</head>
<body>
    <form id="FrmChoice" runat="server" defaultfocus="BtnSubmit">
    <div align="center">
    <table width="15%" cellpadding="1" class="table1">
    <caption><h3 align="center">Exercise no : 5</h3></caption>    
    <tr>  
    <td></td>         
        <td> 
            <asp:Label runat="server" ID="LblHeader" Text="Select Multiple Options" ></asp:Label>    
        </td>
        <td></td>        
        </tr>
        <tr>
        <td></td>
            <td class="td1">
                <asp:CheckBoxList runat="server" ID="CblItems">
                <asp:ListItem Text=".NET Framework" Value="0"></asp:ListItem>
                <asp:ListItem Text="ASP.NET" Value="1"></asp:ListItem>
                <asp:ListItem Text="VB.NET" Value="2"></asp:ListItem>
                <asp:ListItem Text="C-Sharp.NET" Value="3"></asp:ListItem>
                <asp:ListItem Text="AJAX" Value="4"></asp:ListItem>                
                </asp:CheckBoxList>                
            </td>
            <td></td>
            </tr>
        <tr>
        <td></td>        
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button 
                    runat="server" ID="BtnSubmit" Text="Submit" Width="130px" 
                    style="font-weight: 700" BackColor="Beige" onclick="BtnSubmit_Click"/>
            </td>
            <td></td>        
        </tr>                    
        </table>
    </div>
    </form>
</body>
</html>
