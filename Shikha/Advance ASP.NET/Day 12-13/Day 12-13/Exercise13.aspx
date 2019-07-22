<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise13.aspx.cs" Inherits="Day_12_13._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>ExportData WebPage</title>
</head>
<body>
    <form id="form1" runat="server" 
    style="background-color: #CC99FF; border-style: solid; border-color: #008080">
    <div>
    <table><tr><td>
        <asp:GridView ID="gvEmp" runat="server">
        </asp:GridView>
    </td></tr>
    <tr><td></td></tr>
    </table>
    </div>
    <div>
        <asp:Button ID="btnExport" runat="server" Text="Export To Excel" 
            onclick="btnExport_Click" Width="118px" BackColor="#006666" 
            BorderColor="#003300" Font-Bold="True" Font-Italic="True" Font-Size="Small" 
            Height="40px" style="margin-left: 50px" />
    &nbsp;&nbsp;
        <br />
    </div>
    </form>
</body>
</html>
