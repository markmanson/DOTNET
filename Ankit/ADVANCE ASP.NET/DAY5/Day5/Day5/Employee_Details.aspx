<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee_Details.aspx.cs" Inherits="Day5.Employee_Details" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee Details</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table HorizontalAlign="Center" runat="server" BackColor="Coral" Width ="200px"><asp:TableRow><asp:TableCell Width="100px">
        <asp:DropDownList ID="ddlEmpName" runat="server" BackColor="ControlLight" Width="100px">
        </asp:DropDownList>
    </asp:TableCell>
    <asp:TableCell>
            <asp:Button ID="btnDetails" Text="Details" runat="server" onclick="btnDetails_Click" BackColor="ControlLight" Width="100px" />
    </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red"></asp:Label>
    </asp:TableCell></asp:TableRow>
    <asp:TableRow><asp:TableCell HorizontalAlign="Center" ColumnSpan="2" >
        <asp:GridView ID="gdvEmployee" runat="server" Visible="false" BackColor="Honeydew">
        </asp:GridView>
    </asp:TableCell></asp:TableRow>
    </asp:Table>
    </div>        
    </form>
</body>
</html>
