<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Territories.aspx.cs" Inherits="Day_2_4.Territories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Territories WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="LblMsgT" runat="server"  Visible="False"></asp:Label>
    <asp:GridView ID="gvS" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False">
      <PagerStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle"
       BackColor="#F7F7DE"></PagerStyle>
    <HeaderStyle ForeColor="White" Font-Bold="True" 
       BackColor="#6B696B"></HeaderStyle>
       
    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
      <Columns>
      <asp:TemplateField HeaderText="TerritoryID"><ItemTemplate>
          <asp:Label ID="LblTerritoryID" runat="server" Text='<%# 
Bind("TerritoryID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TerritoryDescription"><ItemTemplate>
          <asp:Label ID="LblTerritoryDescription" runat="server" Text='<%# 
Bind("TerritoryDescription") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="RegionID"><ItemTemplate>
          <asp:Label ID="LblRegionID" runat="server" Text='<%# 
Bind("RegionID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
       </Columns>
        </asp:GridView>
       
    </div>
    </form>
</body>
</html>
