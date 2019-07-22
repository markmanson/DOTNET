<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topics.aspx.cs" Inherits="ASP_Day6.Topics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Topics</title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Table runat="server" ID="TblDynamic" BorderStyle="Dotted" CellPadding="10">
    <asp:TableRow TableSection="TableHeader" BackColor="Pink">
            <asp:TableCell Text="Selected Topics Are:" Font-Size="X-Large"/>
        </asp:TableRow>
    </asp:Table>    
    </div>
    </form>
</body>
</html>
