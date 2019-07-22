<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_Login.aspx.cs" Inherits="ASP_Day9_10.Default_Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default_Login</title>
    <style type="text/css">
    .table
    {
        background-color:#E6E6FA;
        margin-top: 100px;       
        margin-right: 150px;
        margin-left: 50px;
        border: 2px dashed black;        
    }        
        </style>
</head>
<body>
    <form id="FrmDefault_Login" runat="server" defaultfocus="TxtUserName">
    <div align="center">
    <table width="90px" cellpadding="3" class="table">
    <caption><h2 align="center">Login Details</h2>    
    </caption>
        <tr>
        <td></td>
        <td colspan="3" align="left">
            &nbsp;</td>
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblUserName" Text="UserName" 
                    style="font-weight: 700"></asp:Label><font color="red">*</font>
            </td>                        
            <td>
                <asp:TextBox runat="server" ID="TxtUserName" Width="180px"></asp:TextBox>                            
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="RfvName" 
                    ControlToValidate="TxtUserName" ErrorMessage="Enter UserName" ForeColor="Red" 
                    Width="110px"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblPassword" Text="Password" 
                    style="font-weight: 700"></asp:Label><font color="red">*</font>
            </td>                        
            <td>
                <asp:TextBox runat="server" ID="TxtPassword" Width="180px" TextMode="Password"></asp:TextBox>                            
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="RfvPassword" 
                    ControlToValidate="TxtPassword" ErrorMessage="Enter Password" ForeColor="Red" 
                    Width="100px"></asp:RequiredFieldValidator>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>        
        <tr>
            <td colspan="4" align="left">
                <asp:Label ID="LblInvalid" runat="server" Text="*Invalid UserName or Password" ForeColor="Red" Visible="false"></asp:Label>                
            </td>
        </tr>                
        <tr>
            <td colspan="4" align="center">                
                <asp:Button runat="server" ID="BtnSubmit" Text="Submit"
                    onclick="BtnSubmit_Click" style="font-weight: 700" Width="100px"/>
            </td>
        </tr>                
    </table>    
    
    </div>
    </form>
</body>
</html>
