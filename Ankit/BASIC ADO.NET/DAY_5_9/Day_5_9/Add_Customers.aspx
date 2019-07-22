<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Customers.aspx.cs" Inherits="Day_5_9.Add_Customers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Add Customers</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblError" runat="server"></asp:Label>
    </div>
    <asp:Button ID="AddDetails" runat="server" Text="AddNew" 
        onclick="AddDetails_Click" />
    <asp:GridView ID="gvCustomer" runat="server" AutoGenerateColumns="false" DataKeyNames="CustomerID">
    <Columns>
    <asp:TemplateField HeaderText="Edit">
    <ItemTemplate>
    <asp:LinkButton ID ="lnkEdit" runat="server" Text="Edit" onclick="lnkEdit_Click" ></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Delete">
    <ItemTemplate>
    <asp:LinkButton ID ="lnkDelete" runat="server" Text="Delete" 
            onclick="lnkDelete_Click" ></asp:LinkButton>
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="CustomerID">
    <ItemTemplate>
    <asp:Label ID="lblCustomerID" runat="server" Text='<%# bind("CustomerID")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="CompanyName">
    <ItemTemplate>
    <asp:Label ID="lblCompanyName" runat="server" Text='<%# bind("CompanyName")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="ContactName">
    <ItemTemplate>
    <asp:Label ID="lblContactName" runat="server" Text='<%# bind("ContactName")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Address">
    <ItemTemplate>
    <asp:Label ID="lblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="City">
    <ItemTemplate>
    <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Region">
    <ItemTemplate>
    <asp:Label ID="lblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="PostalCode">
    <ItemTemplate>
    <asp:Label ID="lblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Country">
    <ItemTemplate>
    <asp:Label ID="lblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Phone">
    <ItemTemplate>
    <asp:Label ID="lblPhone" runat="server" Text='<%# bind("Phone")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    <asp:TemplateField HeaderText="Fax">
    <ItemTemplate>
    <asp:Label ID="lblFax" runat="server" Text='<%# bind("Fax")%>'></asp:Label>    
    </ItemTemplate>
    </asp:TemplateField>
    </Columns>
    </asp:GridView>
    
    </form>
</body>
</html>
