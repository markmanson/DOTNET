<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="day_5.Information" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Information WebPage</title>
    <link rel="stylesheet" type="text/css" href="Stylesheet1.css">
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table align="center">
    <tr><th align="center">User Information
    </th>
    </tr>
    <tr><td>Name</td>
    <td>
        <asp:Label ID="lblName" runat="server" Text=""></asp:Label>
        <br /></td></tr>
       <tr><td> Sex</td><td>
        <asp:Label ID="lblsex" runat="server" Text=""></asp:Label>
        <br /> </td> </tr>
        <tr><td>
        Email</td><td>
        <asp:Label ID="lblEmail" runat="server" Text=""></asp:Label>
        <br /></td></tr>
        <tr><td>DateOfBirth</td><td>
        <asp:Label ID="lblDob" runat="server" Text=""></asp:Label>
        <br /></td></tr>
         <tr><td>Password</td><td>
        <asp:Label ID="lblPassword" runat="server" Text=""></asp:Label>
        <br /></td></tr>
         <tr><td>Married</td><td>
        <asp:Label ID="lblMerrird" runat="server" Text=""></asp:Label>
        <br /></td></tr>
          <tr><td>Language</td><td>
        <asp:Label ID="lblLanguage" runat="server" Text=""></asp:Label>
        </td></tr>
        </table>
    </div>
    </form>
</body>
</html>
