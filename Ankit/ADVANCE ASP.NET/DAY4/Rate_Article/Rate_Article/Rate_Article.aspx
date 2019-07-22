<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Rate_Article.aspx.cs" Inherits="Rate_Article._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="ServerControl_RateArticle" Namespace="ServerControl_RateArticle" TagPrefix="Rate" %>
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Rate_Article</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Table HorizontalAlign ="Center" runat="server" BackColor="Coral">
    <asp:TableRow ID="TableRow1" runat="server"><asp:TableCell HorizontalAlign="Center">
        <asp:Label ID="lblArtical" runat="server" Font-Bold="true" Width="150px"></asp:Label>
    </asp:TableCell></asp:TableRow>
    <asp:TableRow ID="TableRow2" runat="server"><asp:TableCell>
    <asp:Label ID="lblTip" Text="Rate This Artical" runat="server" Font-Bold="true"></asp:Label>
    </asp:TableCell></asp:TableRow>
    <asp:TableRow ID="TableRow3" runat="server"><asp:TableCell>
        <Rate:ServerControl1 ID="Rate" runat="server" OnClick ="btnVote_Click" OnSelectedIndexChanged="RblGrade_SelectedIndexChanged"  />
    </asp:TableCell></asp:TableRow></asp:Table>
    </div>
    </form>
</body>
</html>
