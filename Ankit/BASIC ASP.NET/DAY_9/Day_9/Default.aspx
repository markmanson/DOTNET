<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_9._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Login</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:Table runat ="server" HorizontalAlign="Center" BorderStyle="Inset" BorderColor="Coral" BorderWidth="2">
        <asp:TableHeaderRow >
            <asp:TableHeaderCell HorizontalAlign="Center" ColumnSpan="2">
                <asp:Label ID="lblHead" runat="server" Text="Login Details"></asp:Label>
            </asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblName" Text="Name" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFName" runat="server" Text="*" SetFocusOnError="true" ErrorMessage="Enter the Name" Display="Dynamic" ControlToValidate="txtName"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Label ID="lblPass" Text="Password" runat="server"></asp:Label>
            </asp:TableCell>
            <asp:TableCell>
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RFPass" runat="server" SetFocusOnError="true" ErrorMessage="Enter The Password" Text="*" Display="Dynamic" ControlToValidate="txtPass"></asp:RequiredFieldValidator>
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" onclick="btnSubmit_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableFooterRow>
            <asp:TableCell ColumnSpan="2" HorizontalAlign="Center">
                  <asp:ValidationSummary ID="Val"
                    HeaderText="Please Enter details in Field..."
                    DisplayMode="BulletList"
                    EnableClientScript="true" 
                    runat="server"/>
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>                

    
    
    </div>
    </form>
</body>
</html>
