<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Details_Ex2.aspx.cs" Inherits="ADV_ASP_Day1_2.Frame_Ex2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title>Frame_Ex2</title>
    <style type="text/css">
        #HeaderFrame
        {
            width: 1000px;
        }        
        #RightFrame
        {
            height: 600px;
            width: 840px;            
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td><iframe id="HeaderFrame" runat="server" src="Frame1.aspx">            
        </iframe></td>
    </tr>
    </table>
    <table>
    <tr>
    <td>
        <br />
        <asp:Button ID="BtnEmployee" runat="server" Text="Get Employee Details" 
            onclick="BtnEmployee_Click" />
        <br />
        <br />
        <br />
        <asp:Button ID="BtnDepartment" runat="server" Text="Get Department Details" 
            onclick="BtnDepartment_Click" />      
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </td>
    
    <td>                                                                                                                                         
    <iframe id="RightFrame" runat="server"></iframe>
    </td>
    </tr>
    </table>   
            
    </div>
    </form>
</body>
</html>
