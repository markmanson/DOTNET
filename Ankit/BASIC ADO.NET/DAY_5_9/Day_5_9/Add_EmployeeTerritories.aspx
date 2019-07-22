<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_EmployeeTerritories.aspx.cs" Inherits="Day_5_9.Add_EmployeeTerritories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Add_EmployeeTerritories</title>
</head>
<body>
    <form id="form1" runat="server">
    <div><asp:Button ID="BtnAddTerr" Text="Add" runat="server"  OnClick="BtnAddTerr_Click"  />
        <asp:Label ID="lblError" runat="server" Visible="false" ></asp:Label>
    <asp:GridView ID="gvEmpTerr" runat="server" AutoGenerateColumns="False" 
        BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" 
        CellPadding="3" GridLines="Vertical" DataKeyNames="EmployeeID" 
            onrowdatabound="gvEmpTerr_RowDataBound" 
            onselectedindexchanged="gvEmpTerr_SelectedIndexChanged" 
            onrowdeleting="gvEmpTerr_RowDeleting">
    
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
    
    <Columns>
            <asp:TemplateField HeaderText="Edit" >
            <ItemTemplate><asp:LinkButton ID="lnkEdit" Text="Edit" runat="server" onclick="lnkEdit_Click" ></asp:LinkButton>
            </ItemTemplate>
            </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Delete">
            <ItemTemplate><asp:LinkButton ID="lnkDelete" Text="Delete" CausesValidation="False" CommandName="Delete" runat="server" 
              OnClientClick="return confirm('Are you want to delete this Employee Details ?');" ></asp:LinkButton>
                    
                    
            </ItemTemplate>
            </asp:TemplateField>
    
            <asp:TemplateField HeaderText="EmployeeID">
            <ItemTemplate><asp:Label ID="lblEmpID" runat="server" Text='<%# bind("EmployeeID")%>'></asp:Label>
            </ItemTemplate>
            </asp:TemplateField> 
                      
            <asp:TemplateField HeaderText="Name" >
            <ItemTemplate>
                   <%--  <asp:Label ID="lblFirstName" runat="server"  Text='<%# bind("FirstName")%>'></asp:Label>--%>
                    <%--<asp:HyperLink ID="HlnkName" runat="server" Visible="true" NavigateUrl="~/EmpTerr.aspx"  Text='<%# bind("Name")%>' >EmpTerr.aspx</asp:HyperLink>--%>
                  <asp:Label runat="server" ID="Name" Text='<%# bind("Name")%>'>LinkButton</asp:Label>
                </ItemTemplate>
                </asp:TemplateField>

            <asp:TemplateField HeaderText="LastName" Visible ="false"  >
                <ItemTemplate>
                    <asp:Label ID="lblLastName" runat="server" Text='<%# bind("LastName")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField> 
            <asp:TemplateField HeaderText="FirstName" Visible="false"   >
                <ItemTemplate>
                    <asp:Label ID="lblFirstName" runat="server" Text='<%# bind("FirstName")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField> 
            <asp:TemplateField HeaderText="Title"  >
                <ItemTemplate>
                    <asp:Label ID="lblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                </ItemTemplate>

            </asp:TemplateField>  
            <asp:TemplateField HeaderText="TitleOfCourtesy" Visible="false"  >
                <ItemTemplate>
                    <asp:Label ID="lblTitleOfCourtesy" runat="server" Text='<%# bind("TitleOfCourtesy")%>'></asp:Label>
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
            <asp:TemplateField HeaderText="Photo" Visible="false" >
                <ItemTemplate>
                    <asp:Label ID="lblPhoto" runat="server" Text='<%# bind("Photo")%>'></asp:Label>
                </ItemTemplate>
                </asp:TemplateField>
            
            <asp:TemplateField HeaderText="Notes"  >
                <ItemTemplate>
              <asp:TextBox ID="lblNotes" runat="server" ReadOnly="true" Text='<%# bind("Notes")%>' ></asp:TextBox>                    
                </ItemTemplate>
            </asp:TemplateField>
                        
            <asp:TemplateField HeaderText="Reports To" >
                <ItemTemplate>                 
               <asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>' ></asp:Label></ItemTemplate>
            </asp:TemplateField>  
                    
            <asp:TemplateField HeaderText="Description">
            <ItemTemplate>
            <asp:ListBox ID = "lstDec" DataTextField="TerritoryDescription" runat="server"  SelectionMode="Multiple"  >
            
                       <%-- <asp:ListItem  Text='<%# bind("TerritoryDescription")%>'></asp:ListItem>--%>
                        
            <%--<asp:ListItem Text="Atlanta"></asp:ListItem> --%>
            
                       
            <%--<asp:ListItem Text="Austin"></asp:ListItem>
            <asp:ListItem Text="Beachwood"></asp:ListItem>
            <asp:ListItem Text="Bedford"></asp:ListItem>
            <asp:ListItem Text="Bellevue"></asp:ListItem>
            <asp:ListItem Text="Bentonville"></asp:ListItem>
            <asp:ListItem Text="Bloomfield Hills"></asp:ListItem>
            <asp:ListItem Text="Boston"></asp:ListItem> 
            <asp:ListItem Text="Braintree"></asp:ListItem>
            <asp:ListItem Text="Cambridge"></asp:ListItem>  
            <asp:ListItem Text="Campbell"></asp:ListItem>  
            <asp:ListItem Text="Cary"></asp:ListItem> 
            <asp:ListItem Text="Chicago"></asp:ListItem>
            <asp:ListItem Text="Colorado Springs"></asp:ListItem>
            <asp:ListItem Text="Columbia"></asp:ListItem>
            <asp:ListItem Text="Dallas"></asp:ListItem>
            <asp:ListItem Text="Denver"></asp:ListItem> 
            <asp:ListItem Text="Edison"></asp:ListItem>
            <asp:ListItem Text="Fairport"></asp:ListItem> 
            <asp:ListItem Text="Findlay"></asp:ListItem> 
            <asp:ListItem Text="Georgetow"></asp:ListItem> 
            <asp:ListItem Text="Greensboro"></asp:ListItem>
            <asp:ListItem Text="Hoffman Estates"></asp:ListItem>
            <asp:ListItem Text="Hollis"></asp:ListItem>
            <asp:ListItem Text="Louisville"></asp:ListItem>
            <asp:ListItem Text="Mellvile"></asp:ListItem>
            <asp:ListItem Text="Menlo Park"></asp:ListItem>
            <asp:ListItem Text="Minneapolis"></asp:ListItem>
            <asp:ListItem Text="Morristown"></asp:ListItem>
            <asp:ListItem Text="New York"></asp:ListItem>
            <asp:ListItem Text="Neward"></asp:ListItem>
            <asp:ListItem Text="Orlando"></asp:ListItem>
            <asp:ListItem Text="Philadelphia"></asp:ListItem>
            <asp:ListItem Text="Phoenix"></asp:ListItem>
            <asp:ListItem Text="Portsmouth"></asp:ListItem>
            <asp:ListItem Text="Providence"></asp:ListItem>
            <asp:ListItem Text="Racine"></asp:ListItem>
            <asp:ListItem Text="Redmond"></asp:ListItem>
            <asp:ListItem Text="Rockville"></asp:ListItem>
            <asp:ListItem Text="Roseville"></asp:ListItem>
            <asp:ListItem Text="San Francisco"></asp:ListItem>
            <asp:ListItem Text="Santa Clara"></asp:ListItem>
            <asp:ListItem Text="Santa Cruz"></asp:ListItem>
            <asp:ListItem Text="Santa Monica"></asp:ListItem>
            <asp:ListItem Text="Savannah"></asp:ListItem>
            <asp:ListItem Text="Scottsdale"></asp:ListItem>
            <asp:ListItem Text="Seattle"></asp:ListItem>
            <asp:ListItem Text="Southfield"></asp:ListItem>
            <asp:ListItem Text="Tampa"></asp:ListItem>
            <asp:ListItem Text="Troy"></asp:ListItem>
            <asp:ListItem Text="Westboro"></asp:ListItem>
            <asp:ListItem Text="Wilton"></asp:ListItem>--%>
           
            </asp:ListBox>
            </ItemTemplate>
            </asp:TemplateField>
    </Columns>
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <AlternatingRowStyle BackColor="#DCDCDC" />
    </asp:GridView>
    </div>
    
    </form>
</body>
</html>
