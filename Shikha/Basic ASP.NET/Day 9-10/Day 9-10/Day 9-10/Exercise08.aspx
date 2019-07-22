<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise08.aspx.cs" Inherits="Day_9_10._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>File WebPage</title>
  <link rel="stylesheet" type="text/css" href="Style.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
    <tr><td>
        <asp:Label ID="lblContent" runat="server" Text=" Content Of File"  Font-Bold="True"  ></asp:Label>
        :-</td><td> </td><td><asp:Label ID="lblFile" runat="server" Font-Name="Verdana"></asp:Label></td>
    <td>
    </td>  </tr>
  <tr><td></td>
  <td>
      <%--<asp:Button ID="btnError" runat="server" Text="ErrorButton" 
          onclick="btnError_Click" Height="36px" />--%>
  </td></tr>
  <tr><td>
  </td><td>
     <%-- <asp:Label ID="lblFile" runat="server" Text="Not Error Occur" Visible="false"></asp:Label>--%>
      
  </td>
  </tr><tr><td></td><td><asp:Label ID="lblErr" runat="server" Text="Error Occured" Visible="false"></asp:Label></td></tr>
  
    
    </table>
    </div>
    </form>
</body>
</html>
