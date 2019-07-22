<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Territories.aspx.cs" Inherits="Day2_4.Territories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Territories</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
       
        <asp:Label ID="lblError" runat="server" ></asp:Label>
    
       <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
 <asp:GridView ID="gdvTerritories" runat="server"  AutoGenerateColumns="False" 
            HorizontalAlign="Center" AlternatingRowStyle-BackColor="Gainsboro "
            RowStyle-Wrap="true" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" BackColor="#DEBA84">
<RowStyle Wrap="True" BackColor="#FFF7E7" ForeColor="#8C4510"></RowStyle>
    <columns>
    
            <%--<asp:BoundField HeaderText="TerritoryID" DataField="TerritoryID"/>
            <asp:BoundField HeaderText="TerritoryDescription" DataField ="TerritoryDescription"/>
            <asp:BoundField HeaderText="RegionID" DataField ="RegionID"/>--%>
            <asp:TemplateField HeaderText="TerritoryID">
                <ItemTemplate>
                    <asp:Label ID="LblTerritoryID" runat="server" Text='<%# bind("TerritoryID")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TerritoryDescription">
                <ItemTemplate>
                    <asp:Label ID="TerritoryDescription" runat="server" Text='<%# bind("TerritoryDescription")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="RegionID">
                <ItemTemplate>
                    <asp:Label ID="RegionID" runat="server" Text='<%# bind("RegionID")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>

    </columns>
     <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
     <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
     <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
     <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
    </asp:GridView>
    </asp:Panel>
    </div>
    </form>
</body>
</html>
