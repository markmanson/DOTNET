<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ADV_ASP_Day8_9.Login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
<style type="text/css">
    .table
    {
        background-color:#F0F0F5;
        margin-top: 100px;       
        margin-right: 150px;
        margin-left: 50px;
        border: 2px double black;        
    }        
        .style1
    {
            height: 4px;
    }
        </style>
</head>
<body>
    <form id="FrmLogin" runat="server" defaultfocus="TxtLoginID">
    <div align="center">
        <table width="40px" cellpadding="3" class="table">
            <caption>
                <h2 align="center">Login Details</h2>    
    </caption>
        <tr>
        <td></td>
        <td colspan="3" align="left">
                <asp:Label ID="LblInvalid" runat="server" 
                Text="*Invalid Login ID Or Password" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>                        
            <td>
                &nbsp;</td>
            <td>
                &nbsp;</td>            
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblLoginID" Text="Login ID"  ForeColor="Blue" 
                    style="font-weight: 700"></asp:Label><font color="red">*</font>
            </td>                        
            <td>
                <asp:TextBox runat="server" ID="TxtLoginID" Width="180px"></asp:TextBox>                                            
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="RfvName" 
                    ControlToValidate="TxtLoginID" ErrorMessage="Enter Login ID" ForeColor="Red" 
                    Width="110px"></asp:RequiredFieldValidator>
            </td>            
        </tr>
        <tr>
            <td class="style1">
            </td>
            <td class="style1">
            </td>                        
            <td class="style1">
            </td>
            <td class="style1">
            </td>            
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblPassword" Text="Password"  ForeColor="Blue" 
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
        </tr>        
        <tr>
            <td colspan="4" align="left">
                &nbsp;</td>
        </tr>                
        <tr>
            <td colspan="4" align="center">                
                <asp:Button runat="server" ID="BtnSubmit" Text="Submit"
                    style="font-weight: 700" Width="100px" onclick="BtnSubmit_Click"/>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" ID="BtnCancel" Text="Cancel"
                    style="font-weight: 700" Width="100px" onclick="BtnCancel_Click" CausesValidation="false"/>
                    <br />
                    <br />                    
            </td>
        </tr>                
    </table>        
    </div>
    </form>
</body>
</html>
