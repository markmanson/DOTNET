<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Information.aspx.cs" Inherits="Day_5.Information" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Information</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:table ID="Table1" runat="server" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2px" BackColor="BlanchedAlmond">
    <asp:TableHeaderRow runat="server" >
    <asp:TableHeaderCell ColumnSpan="2">
                <asp:Label ID="lblHeader" runat="server" Text="User Information" ></asp:Label>
    </asp:TableHeaderCell>
    </asp:TableHeaderRow>
    
    <asp:TableRow ID="TableRow1" runat="server">
    <asp:TableCell>
        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblNme" runat="server"></asp:Label>
             </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow2" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblSex" runat="server" Text="Sex"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblSx" runat="server" ></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow3" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>        
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblMail" runat="server"></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow4" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblDB" runat="server" ></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow5" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblPsWrd" runat="server" ></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow6" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblFax" runat="server" Text="Fax"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblFx" runat="server"></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow7" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblMarried" runat="server" Text="Married"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblMrrid" runat="server" ></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow ID="TableRow8" runat="server">
     <asp:TableCell>
        <asp:Label ID="lblLang" runat="server" Text="Language Known"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:Label ID="lblLng" runat="server" ></asp:Label>
    </asp:TableCell>
    </asp:TableRow>
    
    <asp:TableRow ID="TableRow9" runat="server">
    <asp:TableCell HorizontalAlign="Center">             
    </asp:TableCell>
    </asp:TableRow>
    </asp:table>
    </form>
</body>
</html>
