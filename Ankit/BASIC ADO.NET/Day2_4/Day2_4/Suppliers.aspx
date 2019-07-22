<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Suppliers.aspx.cs" Inherits="Day2_4.Suppliers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Supplier</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:Label ID="lblError" runat="server" Visible="false"></asp:Label>
    <div>
    
    </div>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
    <asp:GridView ID="gvSuppliers" runat="server" HorizontalAlign="Center" AlternatingRowStyle-BackColor="BlanchedAlmond"
        BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" CellSpacing="2" AutoGenerateColumns="false" 
        >
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <Columns>
        <asp:TemplateField HeaderText="SupplierID">
        <ItemTemplate>
        <asp:Label ID="SuppID" runat="server" Text='<%# bind("SuppID")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="CompanyName">
        <ItemTemplate>
        <asp:Label ID="CmpnyNme" runat="server" Text='<%# bind("CmpnyNme")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ContactName">
        <ItemTemplate>
        <asp:Label ID="CntctNme" runat="server" Text='<%# bind("ContctNme")%>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="ContactTitle">
        <ItemTemplate>
        <asp:Label ID="CntctTitl" runat="server" Text='<%# bind("CntctTitle")%>'></asp:Label>
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
    </asp:Panel>
    </form>
</body>
</html>
