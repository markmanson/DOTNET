<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise1.aspx.cs" Inherits="Day1_2._Default" ClassName="WebUserControl1" %>
<%@ Register Src="~/WebUserControlButton.ascx" TagName="btn" TagPrefix="BTN" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Exercise 1</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table runat="server" HorizontalAlign="Center">
    <asp:TableRow><asp:TableCell>
        <asp:TextBox ID="txtValue" runat="server" ReadOnly="true"></asp:TextBox>
    </asp:TableCell></asp:TableRow>    
    <asp:TableRow><asp:TableCell>
        <BTN:btn runat="server"  />
    </asp:TableCell></asp:TableRow>
    </asp:Table>    
    </div>
    </form>
</body>
</html>
