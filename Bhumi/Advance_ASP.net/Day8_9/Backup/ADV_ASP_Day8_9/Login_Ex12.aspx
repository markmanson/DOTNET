<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login_Ex12.aspx.cs" Inherits="ADV_ASP_Day8_9.Login_Ex12" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>Login_Ex12</title>
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
    <form id="FrmLogin_Ex12" runat="server" defaultfocus="TxtLoginID">
    <div align="center">
        <table width="90px" cellpadding="3" class="table">
            <caption>
                <h2 align="center">
                    <asp:Label ID="LblHeader" runat="server" Text="Login"></asp:Label></h2>    
    </caption>
        <tr>
        <td></td>
        <td colspan="3" align="right">
                <asp:Label ID="LblInvalid" runat="server" Text="*Invalid Login ID or Password" ForeColor="Red" Visible="false"></asp:Label>                
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnLanguage" runat="server" Text="日本語" 
                        onclick="BtnLanguage_Click" CausesValidation="false" 
                    style="font-weight: 700" Width="100px" /></td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblLoginID" Text="Login ID" 
                    style="font-weight: 700" Width="90px"></asp:Label>
            </td>                        
            <td>
                <font color="red">*</font><asp:TextBox runat="server" ID="TxtLoginID" Width="150px"></asp:TextBox>                            
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="RfvName" 
                    ControlToValidate="TxtLoginID" ErrorMessage="Enter LoginID" ForeColor="Red" 
                    Width="200px"></asp:RequiredFieldValidator>
            </td>
            </tr>
        <tr>
            <td>
            &nbsp;
            </td>
            <td>
                <asp:Label runat="server" ID="LblPassword" Text="Password" 
                    style="font-weight: 700" Width="90px"></asp:Label>
            </td>                        
            <td>
                <font color="red">*</font><asp:TextBox runat="server" ID="TxtPassword" 
                        Width="150px" TextMode="Password"></asp:TextBox>                            
            </td>
            <td>
                <asp:RequiredFieldValidator runat="server" ID="RfvPassword" 
                    ControlToValidate="TxtPassword" ErrorMessage="Enter Password" ForeColor="Red" 
                    Width="170px"></asp:RequiredFieldValidator>
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
                <asp:Button ID="BtnCancel" runat="server" Text="Cancel" 
                    style="font-weight: 700" Width="100px" CausesValidation="False" 
                    onclick="BtnCancel_Click"/>
                <br />
                <br />
            </td>
        </tr>                
    </table>    
    
    </div>
    </form>
</body>
</html>
