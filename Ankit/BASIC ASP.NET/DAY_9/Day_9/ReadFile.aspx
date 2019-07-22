<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReadFile.aspx.cs" Inherits="Day_9.ReadFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Read File</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server" HorizontalAlign="Center" BackColor="AntiqueWhite" BorderColor="Black" BorderWidth="2" Width="400">
    <asp:TableHeaderRow><asp:TableHeaderCell >
            <asp:Label ID="lblHeader" Text="Contents of file" runat="server"></asp:Label>
    </asp:TableHeaderCell></asp:TableHeaderRow>
    <asp:TableRow><asp:TableCell HorizontalAlign="Center">
            <asp:TextBox ID="txtBoxContents" runat="server" Width="350"></asp:TextBox>
    </asp:TableCell></asp:TableRow>
    <asp:TableFooterRow><asp:TableCell HorizontalAlign="Center">
            <asp:Button ID="btnError" Text="ErrorButton" runat="server" Width="200" onclick="btnError_Click"/>
    </asp:TableCell></asp:TableFooterRow>
    <asp:TableRow><asp:TableCell HorizontalAlign="Center">
                    <asp:Label ID="lblError" Visible="false" runat="server"></asp:Label>
    </asp:TableCell></asp:TableRow>
    </asp:Table>        

    </div>
    </form>
</body>
</html>
