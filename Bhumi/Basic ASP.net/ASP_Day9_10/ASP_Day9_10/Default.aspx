<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ASP_Day9_10.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
    .table
    {
        background-color:#E6E6FA;       
        margin-left: 20px;
        border: 2px dashed black; 
        font-size:larger;       
    }     
</style>   
    <title>Default</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="left">
    <table class="table" width="40%" cellpadding="4">
    <tr>
        <td>
            View Data From Cache:
        </td>
        <td>
            <asp:Button ID="BtnRedirect" runat="server" Text="View Data" PostBackUrl="~/DisplayCache.aspx" />
        </td>
    </tr>
    <tr>
        <td>
            Store Browser Details In Cache:
        </td>
        <td>
            <asp:Button ID="Btnstore" runat="server" Text="Store Data in Cache" 
            onclick="Btnstore_Click" />
        </td>
    </tr>
    <tr>
        <td>
            Remove Data From Cache after 15 Seconds:
        </td>
        <td>
            <asp:Button ID="BtnExpire" runat="server" Text="Expire Cache Data" 
            onclick="BtnExpire_Click" />
        </td>
    </tr>
    <tr>
        <td>
            Insert Date In Cache:
        </td>
        <td>
            <asp:Button ID="BtnDate" runat="server" Text="Add Current Date" 
            onclick="BtnDate_Click" />
        </td>
    </tr>
    <tr>
        <td>
            Update Date Field In Cache:
        </td>
        <td>
            <asp:Button ID="BrtnUpdateDate" runat="server" Text="Update Date" 
            onclick="BrtnUpdateDate_Click" />
        </td>
    </tr>
    <tr>
        <td>
            Remove Data From Cache Using File Updation:
        </td>
        <td>
            <asp:Button ID="BtnFileDepend" runat="server" Text="File Dependency" 
            onclick="BtnFileDepend_Click" />
        </td>
    </tr>

    </table>
        
        
        
        <br />
        <br />
        
        <br />
        <br />
        
        <br />
        <br />
        
    </div>
    </form>
</body>
</html>
