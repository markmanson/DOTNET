<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Main.aspx.cs" Inherits="Day_7.Main" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Main WebPage</title>
</head>
<body onpageshow="if (event.persisted) noBack();"  style="background-image: url('Images/texture_leaves_by_kuschelirmel_stock (1).jpg')">
    <form id="form1" runat="server" 
    style="background-image: url('Images/Texture_by_umerr2000.jpg')">
    <div>
    <table align="center" style="height: 348px; width: 101%;">
    <tr>
    <td> 
        <asp:Label ID="lblUser" runat="server" Font-Bold="True" Font-Italic="True" 
            Font-Size="XX-Large" ForeColor="#000099" ></asp:Label></td></tr>
        <tr><td >
            <asp:Label ID="lblOut" runat="server" Text="LogOut" Font-Bold="True" 
                Font-Italic="True" ForeColor="#003366" Font-Size="XX-Large"></asp:Label>
           <asp:LinkButton ID="lnkBtnLog" PostBackUrl="~/LoginAuthentication.aspx" 
                Text="LogOut" runat="server" onclick="lnkBtnLog_Click"  
                 > <img src="Images/home_icon_small (1).png" /> </asp:LinkButton>
            </td></tr>
    <tr>
        <td align="middle">
            
            
            <%--<asp:hyperlink id="hlLogin" runat="server" 
            navigateurl="default.aspx">Log back in.</asp:hyperlink>--%>
        </td>
    </tr>
</table>
    </div>
     <script type = "text/javascript">
  window.history.forward();
    function noBack() { window.history.forward(); }
       </script> 
    </form>
</body>
</html>
