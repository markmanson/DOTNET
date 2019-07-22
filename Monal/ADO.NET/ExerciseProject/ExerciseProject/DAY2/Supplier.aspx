<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Supplier.aspx.cs" Inherits="ExerciseProject.DAY2.Supplier" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Supplier Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:GridView ID="GrdSupplier" Font-Bold="true" 
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
     Width="76%" AutoGenerateColumns="false">
     <Columns>
     <asp:BoundField HeaderText="Supplier ID" DataField="SupplierID" Visible="false" />
           
            <asp:TemplateField HeaderText="Company Name" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblCompanyName" runat="server" Text='<%# bind("CompanyName")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>       
        <asp:TemplateField HeaderText="Contact Name" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblContactName" runat="server" Text='<%# bind("ContactName")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>       
        
            <asp:TemplateField HeaderText="Contact Title"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblcontactTitle" runat="server" Text='<%# bind("contactTitle")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
           
                     
            <asp:TemplateField HeaderText="Address"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="City"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Region"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Postal Code"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Country"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Phone"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblPhone" runat="server" Text='<%# bind("Phone")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Fax"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblFax" runat="server" Text='<%# bind("Fax")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Home Page"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblHomePage" runat="server" Text='<%# bind("HomePage")%>'></asp:Label>
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
