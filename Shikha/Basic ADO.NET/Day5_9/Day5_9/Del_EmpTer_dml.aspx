<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Del_EmpTer_dml.aspx.cs" Inherits="Day5_9.Del_EmpTer_dml" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Delete Empterritories</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="LblMsgET" runat="server"  Visible="False"></asp:Label>
     <asp:LinkButton ID="LbtnAdd" runat="server"  CommandName="export"  
            Text='Add information' onclick="LbtnAdd_Click" ></asp:LinkButton>
        <asp:GridView ID="gvEmpTer" HorizontalAlign="Center" DataKeyNames="EmployeeID" runat="server" 
            AutoGenerateColumns="False" onrowdatabound="gvEmpTer_RowDataBound"
             >
        <PagerStyle ForeColor="Black" HorizontalAlign="Center" VerticalAlign="Middle"
       BackColor="#F7F7DE"></PagerStyle>
    <HeaderStyle ForeColor="White" Font-Bold="True" 
       BackColor="#6B696B"></HeaderStyle>
       
    <AlternatingRowStyle BackColor="White"></AlternatingRowStyle>
      <Columns>
       <asp:TemplateField HeaderText="CheckAll">
<HeaderTemplate>
<asp:CheckBox ID="chkSelectAll" runat="server" 
              AutoPostBack="true" oncheckedchanged="chkSelectAll_CheckedChanged"/>
              
</HeaderTemplate>
<ItemTemplate>
<asp:CheckBox ID="chkSelect" runat="server" 
              AutoPostBack="true" OnCheckedChanged="chkSelect_CheckedChanged"/>
             
</ItemTemplate>
</asp:TemplateField>
           <asp:TemplateField HeaderText="EDIT">
            <ItemTemplate>
                <asp:LinkButton ID="LbtnEDIT"  runat="server" OnClick="LbtnEDIT_Click" CommandName="export"  Text='EDIT'>
                
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
          <asp:TextBox ID="txtNotes" TextMode="MultiLine" runat="server" Text='<%# 
Bind("Notes") %>'>>
        </asp:TextBox>
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
        <script type="text/javascript" language="javascript">
function DeleteConfirmation()
{
if (confirm("Are you sure,you want to delete selected records ?")==true)
            
   return true;
else
   return false;
}
</script>
        <asp:Button ID="btnDelete" OnClientClick="return DeleteConfirmation();" 
            runat="server" Text="Delete" onclick="btnDelete_Click" />
        
          <asp:Label ID="lblDelete" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>
    <%--DataKeyNames="EmployeeID"--%>
  <%--  onrowdatabound="gvEmpTer_RowDataBound"--%>
    </form>
</body>
</html>
