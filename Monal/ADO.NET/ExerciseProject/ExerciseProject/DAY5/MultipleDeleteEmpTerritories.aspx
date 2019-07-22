<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultipleDeleteEmpTerritories.aspx.cs" Inherits="ExerciseProject.Day5.MultipleDeleteEmpTerritories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>DAY5-6-7(EmployeeTerritories Page)</title>
    <style type="text/css">
        .span
        {
            azimuth:center;
           color:#FF0000;
           font-size:larger;
            margin-top:auto;
           margin-left:auto;
           margin-right:auto;
           
          
        }
        
    </style>
    <script language="javascript" type="text/javascript">
    function DeleteConfirmation()
    {
        if (confirm("Are you sure,you want to delete selected records ?")==true)
           return true;
        else
           return false;
}

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="LblErrorMessage" runat="server" Text="Label" CssClass="span" 
            Visible="False"></asp:Label>
    
    <asp:LinkButton Visible="true" ID="LnkAddNewUser" runat="server" onclick="LnkAddNewUser_Click" 
                       >New User?</asp:LinkButton>
    </div>
    <asp:GridView ID="GrdEmpTerritories" BorderStyle="Solid"  Font-Bold="True"
            AlternatingRowStyle-Font-Bold="true"
            HeaderStyle-BackColor="ActiveCaptionText" 
            AlternatingRowStyle-BorderStyle="Solid" 
            AlternatingRowStyle-ForeColor="CadetBlue" 
            HeaderStyle-Font-Bold="true" 
            HeaderStyle-Font-Size="Larger" 
            HeaderStyle-ForeColor="CadetBlue" 
            AlternatingRowStyle-Font-Names="Times New Roman, Times, serif"
            AlternatingRowStyle-BackColor="ActiveCaptionText" 
            BackColor="Azure"     
            runat="server" 
            Width="22%" AutoGenerateColumns="False" DataKeyNames="EmployeeID"
         onrowediting="GrdEmpTerritories_RowEditing" 
        onrowdatabound="GrdEmpTerritories_RowDataBound" 
          >
           
            <Columns>
       
          <%--  <asp:TemplateField HeaderText="Photo">
                <ItemTemplate>
                    <asp:Label ID="lblPhoto" runat="server" Text='<%# bind("Photo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="ChkChildValue" runat="server"  oncheckedchanged="ChildCheckChanged"  AutoPostBack="true"  />
                    </ItemTemplate>
                    <HeaderTemplate>
                        <asp:CheckBox ID="ChkHeader" runat="server" 
                            oncheckedchanged="HeaderCheckChanged"  AutoPostBack="true" />
                    </HeaderTemplate>
                </asp:TemplateField>
       
            <asp:TemplateField HeaderText="Employee ID" Visible="false">
                <ItemTemplate>
                    <asp:Label ID="LblEmpId" runat="server" Visible="false" Text='<%# bind("EmployeeID")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
           <asp:TemplateField HeaderText="Name" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="LblName" runat="server" Text='<%# bind("Name")%>'></asp:Label>
                </ItemTemplate>
            <ControlStyle Width="5px"></ControlStyle>


            </asp:TemplateField>    
        
            <asp:TemplateField HeaderText="Title" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Birth Date" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblBirthDate" runat="server" Text='<%# bind("BirthDate")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hire Date" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblHireDate" runat="server" Text='<%# bind("HireDate")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="City" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Region" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Postal Code" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Home Phone" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblHomePhone" runat="server" Text='<%# bind("HomePhone")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Extension" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblExtension" runat="server" Text='<%# bind("Extension")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Notes" ControlStyle-Width="140">
                <ItemTemplate>
                    <asp:Label ID="lblNotes" runat="server" Text='<%# bind("Notes")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Reports To" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
            <asp:TemplateField HeaderText="Photo Path" ControlStyle-Width="5">
                <ItemTemplate>
                    <asp:Label ID="lblPhotoPath" runat="server" Text='<%# bind("PhotoPath")%>'></asp:Label>
                </ItemTemplate>


            </asp:TemplateField>
           <asp:TemplateField HeaderText="Territory Description"  ControlStyle-Width="100">
                <ItemTemplate>
                <asp:ListBox ID="LstTerritoryDescription"   runat="server" SelectionMode="Multiple" DataTextField="TerritoryDescription" ></asp:ListBox>
                    <%-- <asp:Label ID="lblTerritoryDescription" runat="server" Text='<%# bind("TerritoryDescription")%>'></asp:Label>--%>
                </ItemTemplate>

            </asp:TemplateField>
            
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <asp:LinkButton ID="LnkEdit" runat="server" onclick="LnkEdit_Click">Edit</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <asp:LinkButton ID="LnkDelete" runat="server" OnClientClick='return confirm("Are you sure you want to delete this entry?");' onclick="LnkDelete_Click">Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            
           </Columns>

<HeaderStyle BackColor="ActiveCaptionText" Font-Bold="True" Font-Size="Larger" ForeColor="CadetBlue"></HeaderStyle>

<AlternatingRowStyle BackColor="ActiveCaptionText" BorderStyle="Solid" Font-Bold="True" Font-Names="Times New Roman,Times,serif" ForeColor="CadetBlue"></AlternatingRowStyle>
          </asp:GridView>
    <asp:Button ID="BtnSelectAllCheckBox" runat="server" Text="Multiple Delete" 
        OnClientClick="return DeleteConfirmation();" 
        onclick="BtnSelectAllCheckBox_Click" />
    </form>
</body>
</html>
