<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_2_4._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblMsg" runat="server"  Visible="False"></asp:Label>
       <asp:GridView ID="gvEmp" HorizontalAlign="Center" runat="server" AutoGenerateColumns="False">
        <PagerStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle"
       BackColor="#F7F7DE"></PagerStyle>
    <HeaderStyle ForeColor="White" Font-Bold="True" 
       BackColor="#6B696B"></HeaderStyle>
       
    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
      <Columns>
      <asp:TemplateField HeaderText="EmployeeID"><ItemTemplate>
          <asp:Label ID="LblEmployeeID" runat="server" Text='<%# 
Bind("EmployeeID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="TitleOfCourtesy"><ItemTemplate>
          <asp:Label ID="LblTitleOfCourtesy" runat="server" Text='<%# 
Bind("TitleOfCourtesy") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
       
          <asp:TemplateField HeaderText="FirstName"><ItemTemplate>
          <asp:Label ID="LblFirstName" runat="server" Text='<%# 
Bind("FirstName") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="LastName"><ItemTemplate>
          <asp:Label ID="LblLastName" runat="server" Text='<%# 
Bind("LastName") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="Title"><ItemTemplate>
          <asp:Label ID="LblTitle" runat="server" Text='<%# 
Bind("Title") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="BirthDate"><ItemTemplate>
          <asp:Label ID="LblBirthDate" runat="server" Text='<%# 
Bind("BirthDate") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="HireDate"><ItemTemplate>
          <asp:Label ID="LblHireDate" runat="server" Text='<%# 
Bind("HireDate") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address"><ItemTemplate>
          <asp:Label ID="LblAddress" runat="server" Text='<%# 
Bind("Address") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="City"><ItemTemplate>
          <asp:Label ID="LblCity" runat="server" Text='<%# 
Bind("City") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Region"><ItemTemplate>
          <asp:Label ID="LblRegion" runat="server" Text='<%# 
Bind("Region") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
      
    </Columns>
      
        </asp:GridView>
       
     
    </div>
    </form>
</body>
</html>
