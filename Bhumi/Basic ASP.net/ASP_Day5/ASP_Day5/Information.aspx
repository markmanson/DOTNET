<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="ASP_Day5.Information" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
    .table1
    {
        background-color:#A9A9A9;
        margin-top: 100px;
        margin-bottom: 100px;
        margin-left: 50px;
        border: 2px solid black;
    }            
</style>

    <title>Information</title>
</head>
<body>
    <form id="FrmInformation" runat="server">
    <div align="center">
    <table width="25%" cellpadding="1" class="table1">        
    <caption><h3 align="center">Exercise no : 4</h3></caption>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblName" Text="Name"></asp:Label>                
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtName" Enabled="False"></asp:TextBox>                
            </td>                        
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblSex" Text="Sex"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtSex" MaxLength="1" Enabled="False"></asp:TextBox>                
            </td>                        
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblEmail" Text="Email Id"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtEmail" Enabled="False"></asp:TextBox>                
            </td>                        
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblDOB" Text="DOB"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtDOB" MaxLength="10" Enabled="False"></asp:TextBox>
            </td>            
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblFaxNo" Text="Fax No."></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtFaxNo" MaxLength="13" Enabled="False"></asp:TextBox>                
            </td>                        
        </tr>
        <tr>
            <td>
                <asp:Label runat="server" ID="LblMarried" Text="Married"></asp:Label>
            </td>
            <td>
                 <asp:TextBox runat="server" ID="TxtMarried" Enabled="False"></asp:TextBox>           
            </td>                        
        </tr>
        <tr>
            <td>
                    <asp:Label runat="server" ID="LblLanguage" Text="Languages Known"></asp:Label>
            </td>
            <td>
                 <asp:TextBox runat="server" ID="TxtLanguage" Enabled="False" 
                     TextMode="MultiLine"></asp:TextBox>           
            </td>                        
        </tr>
        </table>    
    </div>
    </form>
</body>
</html>
