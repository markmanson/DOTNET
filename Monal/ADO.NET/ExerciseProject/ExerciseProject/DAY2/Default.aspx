<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExerciseProject.DAY2.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
     <title>DAY2-2(TypedDataset Employee)</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    <asp:GridView ID="GrdEmployee" Font-Bold="true" 
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
     Width="100%" AutoGenerateColumns="false">
     <Columns>
     <asp:BoundField HeaderText="Employee Id" DataField="EmployeeID" Visible="false" />
           
            <asp:TemplateField HeaderText="Name" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblName" runat="server" Text='<%# bind("Name")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>       
        
            <asp:TemplateField HeaderText="Title"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Birth Date"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblBirthDate" runat="server" Text='<%# bind("BirthDate")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Hire Date"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblHireDate" runat="server" Text='<%# bind("HireDate")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Address"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="City"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Region"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Postal Code"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Country"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Home Phone"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblHomePhone" runat="server" Text='<%# bind("HomePhone")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Extension"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblExtension" runat="server" Text='<%# bind("Extension")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
          <%--  <asp:TemplateField HeaderText="Photo"  ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblPhoto" runat="server" Text='<%# bind("Photo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            --%>
            <asp:TemplateField HeaderText="Notes"  ControlStyle-Width="190">
                <ItemTemplate>
                    <asp:Label ID="lblNotes" runat="server" Text='<%# bind("Notes")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Reports To"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Photo Path"  ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblPhotoPath" runat="server" Text='<%# bind("PhotoPath")%>'></asp:Label>
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
