<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ADO.NET._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gdvEmployee" runat="server"  HeaderStyle-BackColor=Red BackColor=#DEBA84 
            HorizontalAlign="Center"  AlternatingRowStyle-BackColor=Gainsboro 
            RowStyle-Wrap=true BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" AutoGenerateColumns="false"  >
            <%--<columns>
            <asp:BoundField HeaderText="EmployeeID" DataField="EmployeeID"/>
            <asp:BoundField HeaderText="Last Name" DataField ="LastName"/>
            <asp:BoundField HeaderText="FirstName" DataField ="FirstName"/>
            <asp:BoundField HeaderText="Title" DataField ="Title"/>
            <asp:BoundField HeaderText="TitleOfCourtesy" DataField ="TitleOfCourtesy"/>
            <asp:BoundField HeaderText="BirthDate" DataField ="BirthDate"/>
            <asp:BoundField HeaderText="HireDate" DataField ="HireDate"/>
            <asp:BoundField HeaderText="Address" DataField ="Address"/>
            <asp:BoundField HeaderText="City" DataField ="City"/>
            <asp:BoundField HeaderText="Region" DataField ="Region"/>
            <asp:BoundField HeaderText="PostalCode" DataField ="PostalCode"/>
            <asp:BoundField HeaderText="Country" DataField ="Country"/>
            <asp:BoundField HeaderText="HomePhone" DataField ="HomePhone"/>
            <asp:BoundField HeaderText="Extension" DataField ="Extension"/>
            <asp:BoundField HeaderText="Photo" DataField ="Photo"/>           
            <asp:BoundField HeaderText="ReportsTo" DataField ="ReportsTo"/>
            <asp:BoundField HeaderText="PhotoPath" DataField ="PhotoPath"/>
            </columns>--%>            
                 <Columns>
     <asp:BoundField HeaderText="Employee Id" DataField="EmployeeID"/>           
            <asp:TemplateField HeaderText="FirstName" >
                <ItemTemplate>
                    <asp:Label ID="Label1" runat="server"  Text='<%# bind("FirstName")%>'></asp:Label>
                </ItemTemplate></asp:TemplateField>
 <asp:TemplateField HeaderText="LastName" >
                <ItemTemplate>
                    <asp:Label ID="LblLstName" runat="server" Text='<%# bind("LastName")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>     
        <asp:TemplateField HeaderText="Title" >
                <ItemTemplate>
                    <asp:Label ID="lblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>           
            <asp:TemplateField HeaderText="Birth Date"  >
                <ItemTemplate>
                    <asp:Label ID="lblBirthDate" runat="server" Text='<%# bind("BirthDate")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>            
            <asp:TemplateField HeaderText="Hire Date"  >
                <ItemTemplate>
                    <asp:Label ID="lblHireDate" runat="server" Text='<%# bind("HireDate")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>            
            <asp:TemplateField HeaderText="Address"  >
                <ItemTemplate>
                    <asp:Label ID="lblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>            
            <asp:TemplateField HeaderText="City"  >
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>            
            <asp:TemplateField HeaderText="Region"  >
                <ItemTemplate>
                    <asp:Label ID="lblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>            
            <asp:TemplateField HeaderText="Postal Code"  >
                <ItemTemplate>
                    <asp:Label ID="lblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Country"  >
                <ItemTemplate>
                    <asp:Label ID="lblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Home Phone" >
                <ItemTemplate>
                    <asp:Label ID="lblHomePhone" runat="server" Text='<%# bind("HomePhone")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Extension"  >
                <ItemTemplate>
                    <asp:Label ID="lblExtension" runat="server" Text='<%# bind("Extension")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Photo" >
                <ItemTemplate>
                    <asp:Label ID="lblPhoto" runat="server" Text='<%# bind("Photo")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Notes"  >
                <ItemTemplate>
              <asp:Label ID="lblNotes" runat="server" Text='<%# bind("Notes")%>' ></asp:Label>
                    
                </ItemTemplate>


            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Reports To" >
                <ItemTemplate>
                    
                <%--<asp:TextBox ID= "txtReportTo" runat="server"  ReadOnly= true Text='<%# bind("ReportsTo")%>'></asp:TextBox> 
                </ItemTemplate>--%>
<asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>' ></asp:Label></ItemTemplate>

            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Photo Path"  >
                <ItemTemplate>
                    <asp:Label ID="lblPhotoPath" runat="server" Text='<%# bind("PhotoPath")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            
        </Columns>
            
<RowStyle Wrap="True" BackColor="#FFF7E7" ForeColor="#8C4510"></RowStyle>

            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />

<HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White"></HeaderStyle>

        </asp:GridView>
    
    </div>
    <asp:Label ID="LblError" runat="server" ></asp:Label>
    </form>
</body>
</html>
