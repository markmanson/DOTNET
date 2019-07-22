<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise08_PageError.aspx.cs" Inherits="Day_9_10.Exercise08_PageError" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Exercise08 WebPage</title>
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
     <%-- <asp:Button ID="btnError" runat="server" Text="ErrorButton" 
          onclick="btnError_Click" Height="36px" />--%>
  </td></tr>
  <tr><td>
  </td><td>
     <%-- <asp:Label ID="lblMsg" runat="server" Text="Not Error Occur" Visible="false"></asp:Label>--%>
      
  </td>
  </tr><tr><td></td><td><asp:Label ID="lblErr" runat="server" Text="Error Occured" Visible="false"></asp:Label></td></tr>
 
  
    
    </table>
    </div>
    </form>
</body>
</html>
