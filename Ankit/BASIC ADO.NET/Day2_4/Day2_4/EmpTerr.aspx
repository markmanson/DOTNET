<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpTerr.aspx.cs" Inherits="Day2_4.EmpTerr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EmployeeTerritories</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
    <asp:GridView ID="gvEmpTerr" runat="server" BackColor="#DEBA84" HorizontalAlign="Center" AutoGenerateColumns=false
        AlternatingRowStyle-BackColor=BurlyWood BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" 
        CellSpacing="2">
        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
        <Columns>
        <asp:TemplateField HeaderText="EmployeeID"  >
                <ItemTemplate>
                    <asp:Label ID="lblEmployeeID" runat="server" Text='<%# bind("EmployeeID")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TerritoryID"  >
                <ItemTemplate>
                    <asp:Label ID="lblTerritoryID" runat="server" Text='<%# bind("TerritoryID")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                </Columns>

        
    </asp:GridView>
    </asp:Panel>
    </form>
</body>
</html>
