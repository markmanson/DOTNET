<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DisplayCache.aspx.cs" Inherits="Day_9_10.DisplayCache" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Display WebPage</title>
</head>
<body>
     <form id="form1" runat="server">
    <div >
    <asp:Table ID="Table1" runat="server" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2">
    <asp:TableHeaderRow><asp:TableCell>
            <asp:Label ID="lblCache" runat="server" Font-Size="Larger"></asp:Label>
    </asp:TableCell></asp:TableHeaderRow>
    <asp:TableRow> <asp:TableCell><asp:Label ID="lblFile" runat="server" Text="" Font-Bold="True" Font-Italic="True" 
            ForeColor="Navy" ></asp:Label>  </asp:TableCell></asp:TableRow>
          <asp:TableRow> <asp:TableCell>  <asp:Label ID="lblDate" runat="server" Text="" Font-Bold="True" Font-Italic="True" 
            ForeColor="Violet"></asp:Label></asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell>
            <asp:Button ID="btnCache" Text="Cache" runat="server" onclick="btnCache_Click" />
    </asp:TableCell></asp:TableRow>
    </asp:Table>            

    </div>
    </form>
</body>
</html>
