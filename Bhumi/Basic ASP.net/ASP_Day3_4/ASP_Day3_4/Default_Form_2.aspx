<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_Form_2.aspx.cs" Inherits="ASP_Day3_4.Default_Form_2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
    .table
    {
        background-color:#A9A9A9;
        margin-top: 100px;
        margin-bottom: 100px;
        margin-right: 150px;
        margin-left: 50px;
        border: 2px solid black;
    }    
</style>
     <title>Default_Form_2</title>
</head>
<body>
    <form id="FrmDefault_Form2" runat="server" defaultfocus="TxtItem">
    <div align="center">
    <table width="25%" cellpadding="3" class="table">
    <caption><h3 align="center">Exercise no : 2</h3></caption>
        <tr>
        <td></td>
        <td></td>
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtItem" Width="150px"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator runat="server" ID="RgxvItems" ControlToValidate="TxtItem" ValidationExpression="^\S+[a-z A-Z 0-9]+$" ErrorMessage="InValid Input" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>
            <td>
                <asp:Button runat="server" ID="BtnAddlist" Text="ADD LIST" BackColor="Beige" 
                    onclick="BtnAddlist_Click" style="font-weight: 700"/>
            </td>
            <td>
                &nbsp;
            </td>
            
            <td>
                
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td>
                
            </td>
            <td>
                
            </td>
        </tr>
        <tr>
            <td>                
            </td>
            <td>
            <asp:ListBox runat="server" ID="LstItem1" Width="150px" SelectionMode="Multiple" Height="100px"></asp:ListBox>                
            </td>
            <td>                
            </td>
            <td>
                <asp:Button runat="server" ID="BtnLeftToRight" Text=">" BackColor="Beige" 
                    onclick="BtnLeftToRight_Click" style="font-weight: 700"/>
                <br />
                <br />
                <asp:Button runat="server" ID="BtnRightToLeft" Text="<" BackColor="Beige" 
                    onclick="BtnRightToLeft_Click" style="font-weight: 700"/>
            </td>            
            <td>
                <asp:ListBox runat="server" ID="LstItem2" Width="150px" SelectionMode="Multiple" Height="100px"></asp:ListBox>                            
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td></td>
        </tr>        
        <tr>
            <td></td>
            <td>
                <asp:Button runat="server" ID="BtnRemove" Text="Remove Items" BackColor="Beige" 
                    onclick="BtnRemove_Click" style="font-weight: 700" Width="150px"/>
            </td>
            <td>                
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>                
            </td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label ID="LblInsert" runat="server" Text="Data Inserted" ForeColor="Green" Visible="false"></asp:Label>
            </td>
        </tr>
    </table>
    </div>
    
    </form>
</body>
</html>
