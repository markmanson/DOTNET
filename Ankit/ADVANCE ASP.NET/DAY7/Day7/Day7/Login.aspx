<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Day7._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2" BackColor="Honeydew" Width="500px">
    <asp:TableHeaderRow ><asp:TableHeaderCell HorizontalAlign="Center" ColumnSpan="2">
        <asp:Label ID="lblHeader" Text="Form Authentication , Login" runat="server" Font-Bold="true" Font-Size="Larger"></asp:Label>
    </asp:TableHeaderCell></asp:TableHeaderRow>
    <asp:TableRow><asp:TableCell>
        <asp:Label ID="lblUser" runat="server" Text="User Name" Width="250px" ></asp:Label>
    </asp:TableCell>
    <asp:TableCell>
    <asp:TextBox ID="txtUser" runat="server" Width="250px"></asp:TextBox>
    </asp:TableCell>
    </asp:TableRow>
    <asp:TableRow><asp:TableCell>
        <asp:Label ID="lblPass" runat="server" Text="Password" Width="250px"></asp:Label>
    </asp:TableCell><asp:TableCell>
        <asp:TextBox ID="txtPass" runat="server" Width="250px" TextMode="Password"></asp:TextBox>
    </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell HorizontalAlign="Center" ColumnSpan="2">
        <asp:Button ID="btnSignIn" Text="SignOn" runat="server" onclick="btnSignIn_Click" Width="250px" />
    </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell HorizontalAlign ="Center" ColumnSpan="2">
        <asp:Label ID="lblError" Visible="false" runat="server" ForeColor="Red"></asp:Label>
    </asp:TableCell></asp:TableRow>
    </asp:Table>        
    </div>
    </form>
</body>
</html>
