<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_Form.aspx.cs" Inherits="ASP_Day1_2.Default_Form" %>

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
    <title>Default_Form</title>
</head>
<body>
    <form id="FrmDefault_Form" runat="server" defaultfocus="TxtName">
    <div align="center">
    <table width="20%" cellpadding="3" class="table">
    <caption><h3 align="center">Exercise no : 1</h3>    
    </caption>
        <tr>
        <td></td>
        <td></td>
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblName" Text="Name" Width="30px"></asp:Label>
            </td>
            <td>
                &nbsp;&nbsp;<asp:TextBox runat="server" ID="TxtName"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="RfvName" ControlToValidate="TxtName" ErrorMessage="Enter Name" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
            <td>
                &nbsp;
            </td>
            
            <td colspan="2">
                <asp:Label runat="server" ID="LblSessionValue" Text="Session Value" 
                    Width="95px"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtSessionValue" Width="90px"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td></td>
        <td colspan="2">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>                
            </td>
            <td>                
            </td>
            <td>                
            </td>
            <td>
                <asp:Button runat="server" ID="BtnSubmit" Text="Submit" Width="150%" 
                    onclick="BtnSubmit_Click" style="font-weight: 700"/>
            </td>
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>
            <td></td>
            <td>
                <asp:Label runat="server" ID="LblCounter"></asp:Label>
            </td>
            <td>                
            </td>
            <td></td>
            <td></td>
            <td></td>
            <td></td>
            <td>
                <asp:Label runat="server" ID="LblCounter1"></asp:Label>
            </td>
        </tr>
        <tr>
            <td></td>
            <td></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
