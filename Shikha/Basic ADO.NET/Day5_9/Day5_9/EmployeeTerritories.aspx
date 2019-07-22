<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTerritories.aspx.cs" Inherits="Day5_9.EmployeeTerritories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee Territories Dml</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="LblMsgET" runat="server"  Visible="False"></asp:Label>
     <asp:LinkButton ID="LbtnAdd" runat="server" OnClick="LbtnAdd_Click" CommandName="export"  
            Text='Add information' ></asp:LinkButton>
        <asp:GridView ID="gvEmpTer" HorizontalAlign="Center" runat="server" DataKeyNames="EmployeeID"
            AutoGenerateColumns="False" 
            onrowdatabound="gvEmpTer_RowDataBound" >
        <PagerStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle"
       BackColor="#F7F7DE"></PagerStyle>
    <HeaderStyle ForeColor="White" Font-Bold="True" 
       BackColor="#6B696B"></HeaderStyle>
       
    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
      <Columns>
        <asp:TemplateField HeaderText="DELETE">
            <ItemTemplate>
                <asp:LinkButton ID="LbtnDELETE" OnClick="LbtnDELETE_Click" runat="server"  CommandName="export"  Text='DELETE'>
                
            </asp:LinkButton>
            
            </ItemTemplate>
        </asp:TemplateField>
           <asp:TemplateField HeaderText="EDIT">
            <ItemTemplate>
                <asp:LinkButton ID="LbtnEDIT" OnClick="LbtnEDIT_Click" runat="server" CommandName="export"   Text='EDIT'>
                
            </asp:LinkButton>
            
            </ItemTemplate>
        </asp:TemplateField>
      <asp:TemplateField HeaderText="EmployeeID"><ItemTemplate>
          <asp:Label ID="LblEmployeeID" runat="server" Text='<%# 
Bind("EmployeeID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
       <%-- <asp:TemplateField HeaderText="TerritoryID"><ItemTemplate>
          <asp:Label ID="LblTerritoryID" runat="server" Text='<%# 
Bind("TerritoryID") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>--%>
        <asp:TemplateField HeaderText="TitleOfCourtesy"><ItemTemplate>
          <asp:Label ID="LblTitleOfCourtesy" runat="server" Text='<%# 
Bind("TitleOfCourtesy") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
       
          <asp:TemplateField HeaderText="EmployeeName">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%# Eval("FirstName") + " " + Eval("LastName") %>'>
                            
                        </asp:Label>                        
                    </ItemTemplate>
                </asp:TemplateField>
         <asp:TemplateField HeaderText="Title"><ItemTemplate>
          <asp:Label ID="LblTitle" runat="server" Text='<%# 
Bind("Title") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
         <asp:TemplateField HeaderText="BirthDate"><ItemTemplate>
          <asp:Label ID="LblBirthDate" runat="server" Text='<%# 
Bind("BirthDate") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="HireDate"><ItemTemplate>
          <asp:Label ID="LblHireDate" runat="server" Text='<%# 
Bind("HireDate") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Address"><ItemTemplate>
          <asp:Label ID="LblAddress" runat="server" Text='<%# 
Bind("Address") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="City"><ItemTemplate>
          <asp:Label ID="LblCity" runat="server" Text='<%# 
Bind("City") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Region"><ItemTemplate>
          <asp:Label ID="LblRegion" runat="server" Text='<%# 
Bind("Region") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="PostalCode"><ItemTemplate>
          <asp:Label ID="LblPostalCode" runat="server" Text='<%# 
Bind("PostalCode") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Country"><ItemTemplate>
          <asp:Label ID="LblCountry" runat="server" Text='<%# 
Bind("Country") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="HomePhone"><ItemTemplate>
          <asp:Label ID="LblHomePhone" runat="server" Text='<%# 
Bind("HomePhone") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
          <asp:TemplateField HeaderText="Extension"><ItemTemplate>
          <asp:Label ID="LblExtension" runat="server" Text='<%# 
Bind("Extension") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
                  <asp:TemplateField HeaderText="Photo"><ItemTemplate>
          <asp:Label ID="LblPhoto" runat="server" Text='<%# 
Bind("Photo") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
                  <asp:TemplateField HeaderText="Notes"><ItemTemplate>
         <%-- <asp:Label ID="LblNotes" runat="server" Text='<%# 
Bind("Notes") %>'></asp:Label>--%>
                      <asp:TextBox ID="txtNotes" TextMode="MultiLine" Text='<%# 
Bind("Notes") %>' runat="server"></asp:TextBox>
        </ItemTemplate>
        </asp:TemplateField>
                  <asp:TemplateField HeaderText="ReportsTo"><ItemTemplate>
          <asp:Label ID="LblReportsTo" runat="server" Text='<%# 
Bind("ReportsTo") %>'></asp:Label>
        </ItemTemplate>
        </asp:TemplateField>
            <asp:TemplateField HeaderText="TerritoryDescription">  
            <ItemTemplate>
        <asp:ListBox ID="LstTerritoryDescription" SelectionMode="Multiple" DataTextField="territoryDescription" runat="server"></asp:ListBox>
        </ItemTemplate> 
              </asp:TemplateField>   
                
         </Columns>
        
        </asp:GridView>
          <asp:Label ID="lblDelete" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>
