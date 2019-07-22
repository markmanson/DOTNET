<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cache_Drop_Down.aspx.cs" Inherits="Day5.Cache_Drop_Down" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>CacheDropDownList</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>    
    <asp:Table runat="server" HorizontalAlign ="Center" ><asp:TableRow><asp:TableCell>
            <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
            </asp:TableCell></asp:TableRow>
            <asp:TableRow><asp:TableCell HorizontalAlign="Center">
            <asp:Button ID="btnShow" Text="ShowCache" runat="server" onclick="btnShow_Click" />
    </asp:TableCell></asp:TableRow></asp:Table>
    </div>
    </form>        

</body>
</html>
