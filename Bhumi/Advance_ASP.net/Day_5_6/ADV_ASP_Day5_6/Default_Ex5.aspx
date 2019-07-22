<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default_Ex5.aspx.cs" Inherits="ADV_ASP_Day5_6.Default_Ex5" %>
<%@ OutputCache Duration="30" VaryByParam="None" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Default_Ex5</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
        <td>
            <asp:Label ID="LblServerDate" runat="server" 
                Text="Current time (Server-side code):" style="font-weight: 700" 
                ForeColor="#3366FF"></asp:Label>
            <% Response.Write(DateTime.Now.ToString()); %>
            <br />
            <asp:Label ID="LblClientDate" runat="server" 
                Text="Current time (Client-side code):" style="font-weight: 700" 
                ForeColor="#3366FF"></asp:Label> 
            <script type="text/javascript">
            document.write(Date());</script>           
         </td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
