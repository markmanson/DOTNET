<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="Day5_9.Customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Customer Dml WebPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:LinkButton ID="LbtnAdd" runat="server" CommandName="export"  
            Text='Add information' onclick="LbtnAdd_Click" ></asp:LinkButton>
      <asp:GridView ID="gvCustomerDml" HorizontalAlign="Center"  DataKeyNames="CustomerID" 
            runat="server" AutoGenerateColumns="False">
        <PagerStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle"
       BackColor="#F7F7DE"></PagerStyle>
    <HeaderStyle ForeColor="White" Font-Bold="True" 
       BackColor="#6B696B"></HeaderStyle>
       
    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
      <Columns>
         <asp:TemplateField HeaderText="DELETE">
            <ItemTemplate>
                <asp:LinkButton ID="LbtnDELETE" runat="server"  CommandName="export" OnClick="LbtnDELETE_Click" Text='DELETE'>
                
            </asp:LinkButton>
            
            </ItemTemplate>
        </asp:TemplateField>
           <asp:TemplateField HeaderText="EDIT">
            <ItemTemplate>
                <asp:LinkButton ID="LbtnEDIT" runat="server" CommandName="export" OnClick="LbtnEDIT_Click" Text='EDIT'>
                
            </asp:LinkButton>
            
            </ItemTemplate>
        </asp:TemplateField>
      <asp:TemplateField HeaderText="CustomerID"><ItemTemplate>
          <asp:Label ID="LblCustomerID" runat="server" Text='<%# 
Bind("CustomerID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="CompanyName"><ItemTemplate>
          <asp:Label ID="LblCompanyName" runat="server" Text='<%# 
Bind("CompanyName") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="ContactName"><ItemTemplate>
          <asp:Label ID="LblContactName" runat="server" Text='<%# 
Bind("ContactName") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="ContactTitle"><ItemTemplate>
          <asp:Label ID="LblContactTitle" runat="server" Text='<%# 
Bind("ContactTitle") %>'></asp:Label>
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
         <asp:TemplateField HeaderText="Country"><ItemTemplate>
          <asp:Label ID="LblCountry" runat="server" Text='<%# 
Bind("Country") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
      
       <asp:TemplateField HeaderText="Phone"><ItemTemplate>
          <asp:Label ID="LblPhone" runat="server" Text='<%# 
Bind("Phone") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
      
       <asp:TemplateField HeaderText="Fax"><ItemTemplate>
          <asp:Label ID="LblFax" runat="server" Text='<%# 
Bind("Fax") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
    
    </Columns>
      
        </asp:GridView>
        <asp:Label ID="lblDelete" runat="server" Text="Label" Visible="false"></asp:Label>
            
    </div>
    
    </form>
</body>
</html>
