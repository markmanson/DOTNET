<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_Login.aspx.cs" Inherits="ADV_ASP_Day3.Default_Login" %>

<%@ Register Assembly="ServerControl1" Namespace="ServerControl1" TagPrefix="CC" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<style type="text/css">
    .table
    {
        background-color:#FFF0F0;
        margin-top: 100px;
        margin-right: 150px;
        margin-left: 50px;
        border: 2px solid black;        
    }
</style>
    <title>Default_Login</title>
</head>
<body>
    <form id="form1" runat="server" defaultfocus="LoginCotrol1">
    <div align="center">
    <table class="table" cellpadding="3" cellspacing="5">
    <caption><h2>Login Details</h2></caption>
    <tr>
    <td><CC:LoginCotrol ID="LoginCotrol1" runat="server" Font-Size="Large" OnSubmit="Submit_Click" /> </td>
    </tr>
    </table>
          
    </div>
    </form>
</body>
</html>
