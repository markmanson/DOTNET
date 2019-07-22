<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Territories.aspx.cs" Inherits="ExerciseProject.DAY2.Territories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DAY2-1(Territories Page)</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GrdTerritories"  Font-Bold="true" 
            BorderStyle="Solid"
            AlternatingRowStyle-Font-Bold="true"
            HeaderStyle-BackColor="ActiveCaptionText" 
            AlternatingRowStyle-BorderStyle="Solid" 
            AlternatingRowStyle-ForeColor="CadetBlue" 
            HeaderStyle-Font-Bold="true" 
            HeaderStyle-Font-Size="Larger" 
            HeaderStyle-ForeColor="CadetBlue" 
            AlternatingRowStyle-Font-Names="Times New Roman, Times, serif"
            AlternatingRowStyle-BackColor="ActiveCaptionText"  
            GridLines="Both" 
            BackColor="Azure"     
            runat="server" 
            Width="45%" AutoGenerateColumns="false">
            <Columns>
            
            <asp:TemplateField HeaderText="Territory ID"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblTerritoryID" runat="server" Text='<%# bind("TerritoryID")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            <asp:TemplateField HeaderText="Territory Description" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblDesc" runat="server" Text='<%# bind("TerritoryDescription")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>   
            <asp:TemplateField HeaderText="Region ID" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblRegionID" runat="server" Text='<%# bind("RegionID")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>   
           </Columns>

<HeaderStyle BackColor="ActiveCaptionText" Font-Bold="True" Font-Size="Larger" ForeColor="CadetBlue"></HeaderStyle>

<AlternatingRowStyle BackColor="ActiveCaptionText" BorderStyle="Solid" Font-Bold="True" Font-Names="Times New Roman,Times,serif" ForeColor="CadetBlue"></AlternatingRowStyle>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
