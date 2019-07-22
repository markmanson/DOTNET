<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_Form3.aspx.cs" Inherits="ASP_Day3_4.Default_Form3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
    .table1
    {
        background-color:#A9A9A9;
        margin-top: 100px;
        margin-right: 150px;
        margin-left: 50px;
        border: 2px solid black;
    }
    .table2
    {
        background-color:White;
        margin-right: 150px;
        margin-left: 50px;
        border-color:Black;
    }
    .style1
    {
        width: 58px;
    }
</style>

    <title>Default_Form3</title>
</head>
<body>
    <form id="FrmDefault_Form3" runat="server" defaultfocus="TxtItem">
    <div align="center">
        <table class="table1" width="39%">
        <caption><h3 align="center">Exercise no : 3</h3></caption>    
        <tr><td></td></tr>        
        <tr><td></td></tr>
            <tr>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
                        runat="server" ID="TxtItem" Width="200px"></asp:TextBox>                        
                        <asp:RegularExpressionValidator runat="server" ID="RgxvItems" ControlToValidate="TxtItem" ValidationExpression="^[a-zA-Z0-9]*,[a-zA-Z0-9, ]+$" ErrorMessage="InValid Input" ForeColor="Red"></asp:RegularExpressionValidator>
                </td> 
                <td>
                    <asp:Button runat="server" ID="BtnCreateDropDownlist" 
                        Text="Create DropDownlist" BackColor="Beige" 
                        style="font-weight: 700"/>                    
                </td>                
          </tr>                    
                <tr>
                <td>
                    <asp:Table CssClass="table2" width="70%" runat="server" ID="TblDynamic"></asp:Table>                                        
                    </td>                    
                </tr>
                <tr><td></td></tr>
                <tr><td></td></tr>        
                </table>
    </div>
    </form>
</body>
</html>
