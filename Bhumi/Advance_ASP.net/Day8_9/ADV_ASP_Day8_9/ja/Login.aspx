<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ADV_ASP_Day8_9.ja.Login" %>

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
        width: 110px;
    }
        .style4
    {
        background-color: #F0F0F5;
        margin-top: 100px;
        margin-right: 150px;
        margin-left: 50px;
        border: 2px double black;
        width: 448px;
    }
    .style5
    {
        width: 10px;
    }
    .style7
    {
        width: 160px;
    }
    .style8
    {
        width: 110px;
    }
    .style9
    {
        height: 4px;
        width: 10px;
    }
    .style10
    {
        height: 4px;
        width: 180px;
    }
    .style11
    {
        width: 140px;
    }
    .style12
    {
        height: 4px;
        width: 112px;
    }
        </style>
</head>
<body>
    <form id="FrmLogin" runat="server" defaultfocus="TxtLoginID">
    <div align="center">
        <table width="80px" cellpadding="3" class="style4">
                <caption>
                <h2 align="center">ログイン</h2>    
    </caption>
        <tr>
        <td class="style5"></td>
        <td colspan="3" align="left">
                <asp:Label ID="LblInvalid" runat="server" 
                Text="*無効なログインIDまたはパスワード" ForeColor="Red" Visible="False"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="style5">
                &nbsp;</td>
            <td class="style11">
                &nbsp;</td>                        
            <td class="style7">
                &nbsp;</td>
            <td class="style8">
                &nbsp;</td>            
        </tr>
        <tr>
            <td class="style5">
            &nbsp;
            </td>
            <td class="style11">
                <asp:Label runat="server" ID="LblLoginID" Text="ログインID"  ForeColor="Blue" 
                    style="font-weight: 700" Width="80px"></asp:Label>
            </td>                        
            <td class="style7">
                <font color="red" size="3px">*</font><asp:TextBox runat="server" ID="TxtLoginID" Width="180px"></asp:TextBox>                                            
            </td>
            <td class="style8">
                <asp:RequiredFieldValidator runat="server" ID="RfvName" 
                    ControlToValidate="TxtLoginID" ErrorMessage="ログインIDを入力してください" ForeColor="Red" 
                    Width="198px"></asp:RequiredFieldValidator>
            </td>            
        </tr>
        <tr>
            <td class="style9">
            </td>
            <td class="style12">
                &nbsp;</td>                        
            <td class="style10">
            </td>
            <td class="style1">
            </td>            
        </tr>
        <tr>
            <td class="style5">
            &nbsp;
            </td>
            <td class="style11">
                <asp:Label runat="server" ID="LblPassword" Text="パスワード"  ForeColor="Blue" 
                    style="font-weight: 700"></asp:Label>
            </td>                        
            <td class="style7">
                <font color="red" size="3px">*</font><asp:TextBox runat="server" ID="TxtPassword" Width="180px" TextMode="Password"></asp:TextBox>                            
            </td>
            <td class="style8">
                <asp:RequiredFieldValidator runat="server" ID="RfvPassword" 
                    ControlToValidate="TxtPassword" ErrorMessage="パスワードを入力します" ForeColor="Red" 
                    Width="195px"></asp:RequiredFieldValidator>
            </td>            
        </tr>        
        <tr>
            <td colspan="4" align="left">
                &nbsp;</td>
        </tr>                
        <tr>
            <td colspan="4" align="Left">                
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                
                <asp:Button runat="server" ID="BtnSubmit" Text="サブミト"
                    style="font-weight: 700" Width="100px" onclick="BtnSubmit_Click"/>
                &nbsp;&nbsp;&nbsp;
                <asp:Button runat="server" ID="BtnCancel" Text="キャンセル"
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
