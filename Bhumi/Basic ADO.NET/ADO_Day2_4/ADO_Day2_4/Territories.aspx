<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Territories.aspx.cs" Inherits="ADO_Day2_4.Territories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">    
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:GridView ID="gvTerritories" runat="server" AllowPaging="True" 
            BackColor="White" BorderColor="#CCCCCC" 
            BorderStyle="None" Caption='<h3>Information on Territories</h3>' CaptionAlign="Top" 
            onpageindexchanging="GridView1_PageIndexChanging" BorderWidth="1px" 
            CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="325px" 
            AutoGenerateColumns="False" AllowSorting="True" 
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
            <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F7F7F7" />
            <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
            <SortedDescendingCellStyle BackColor="#E5E5E5" />
            <SortedDescendingHeaderStyle BackColor="#242121" />
            <Columns>
                <asp:TemplateField HeaderText="TerritoryID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"TerritoryID") %>
                    </ItemTemplate>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="Description" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"TerritoryDescription") %>
                    </ItemTemplate>
                </asp:TemplateField>            
                <asp:TemplateField HeaderText="Region ID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"RegionID") %>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>    
    </div>
    </form>
</body>
</html>
