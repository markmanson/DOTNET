<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supplierss.aspx.cs" Inherits="Day_2_4.Supplierss" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Supplier</title>
</head>
<body>
    <form id="form1" runat="server">
     <asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>
    <div>
     
    <asp:GridView ID="gvSuppliers" runat="server" HorizontalAlign="Center" AlternatingRowStyle-BackColor="Olive"
        BackColor="#5F9EA0" BorderColor="#DEBA84"  AutoGenerateColumns="false" >
        
        <PagerStyle ForeColor="#5F9EA0" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#5F9EA0" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#5F9EA0" Font-Bold="True" ForeColor="White" />
        <Columns>
        <asp:TemplateField HeaderText="SupplierID">
        <ItemTemplate>
        <asp:Label ID="lblSuppID" runat="server" Text='<%# bind("SuppID")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CompanyName">
        <ItemTemplate>
        <asp:Label ID="lblCmpnyNme" runat="server" Text='<%# bind("CmpnyNme")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ContactName">
        <ItemTemplate>
        <asp:Label ID="lblCntctNme" runat="server" Text='<%# bind("ContctNme")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ContactTitle">
        <ItemTemplate>
        <asp:Label ID="lblCntctTitl" runat="server" Text='<%# bind("CntctTitle")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address">
        <ItemTemplate>
        <asp:Label ID="lblAdd" runat="server" Text='<%# bind("Address")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="City">
        <ItemTemplate>
        <asp:Label ID="lblCty" runat="server" Text='<%# bind("City")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Region">
        <ItemTemplate>
        <asp:Label ID="lblRgn" runat="server" Text='<%# bind("Region")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="PostalCode">
        <ItemTemplate>
        <asp:Label ID="lblRgn" runat="server" Text='<%# bind("PstlCd")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Country">
        <ItemTemplate>
        <asp:Label ID="lblCntry" runat="server" Text='<%# bind("Cntry")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Phone">
        <ItemTemplate>
        <asp:Label ID="lblPhn" runat="server" Text='<%# bind("Phn")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Fax">
        <ItemTemplate>
        <asp:Label ID="lblFax" runat="server" Text='<%# bind("Fx")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="HomePage">
        <ItemTemplate>
        <asp:Label ID="lblHmPg" runat="server" Text='<%# bind("HmPg")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
    </asp:GridView>
    
    
    </div>
    </form>
</body>
</html>
