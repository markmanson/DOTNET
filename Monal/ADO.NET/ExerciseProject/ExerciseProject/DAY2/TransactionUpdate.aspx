<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransactionUpdate.aspx.cs" Inherits="ExerciseProject.DAY2.TransactionUpdate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Transaction Update</title>
      
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:GridView ID="GrdEmployee" Font-Bold="True" 
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
     BackColor="Azure"     
     runat="server" 
     Width="100%" AutoGenerateColumns="False" DataKeyNames="EmployeeID" 
            ShowFooter="True" onrowediting="GrdEmployee_RowEditing" >
     
        <Columns>
       
            <asp:TemplateField HeaderText="Employee ID" Visible="false" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblEmpId" runat="server" Visible="false" Text='<%# bind("EmployeeID")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
           <asp:TemplateField HeaderText="Name" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblName" runat="server" Text='<%# bind("Name")%>'></asp:Label>
                </ItemTemplate>
                <%--<FooterTemplate>
                <asp:LinkButton EnableTheming="true" ID="LnkAddNewUser" runat="server" 
                        CommandName="NewUser"' onclick="LnkAddNewUser_Click">New User?</asp:LinkButton>
            </FooterTemplate>--%>

<ControlStyle Width="5px"></ControlStyle>

            </asp:TemplateField>    
        
            <asp:TemplateField HeaderText="Title" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
           
            <asp:TemplateField HeaderText="Birth Date" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblBirthDate" runat="server" Text='<%# bind("BirthDate")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Hire Date" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblHireDate" runat="server" Text='<%# bind("HireDate")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Address" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="City" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Region" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="PostalCode" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Country" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Home Phone" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblHomePhone" runat="server" Text='<%# bind("HomePhone")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Extension" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblExtension" runat="server" Text='<%# bind("Extension")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
         <%--   <asp:TemplateField HeaderText="Photo">
                <ItemTemplate>
                    <asp:Label ID="lblPhoto" runat="server" Text='<%# bind("Photo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>--%>
            <asp:TemplateField HeaderText="Notes" ControlStyle-Width="100">
                <ItemTemplate>
                    <asp:Label ID="LblNotes" runat="server" Text='<%# bind("Notes")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Reports To" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Photo Path" ControlStyle-Width="5%">
                <ItemTemplate>
                    <asp:Label ID="LblPhotoPath" runat="server" Text='<%# bind("PhotoPath")%>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Edit">
                <ItemTemplate>
                    <asp:LinkButton ID="LnkEdit" runat="server" CommandName="Edit" 
                        onclick="LnkEdit_Click" >Edit</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
           <%-- <asp:TemplateField HeaderText="Delete">
                <ItemTemplate>
                    <asp:LinkButton ID="LnkDelete" runat="server" CommandName="Delete" 
                       onclick="LnkDelete_Click" OnClientClick='return confirm("Are you sure you want to delete this entry?");'>Delete</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>--%>
                     
       </Columns>
    
       
<HeaderStyle BackColor="ActiveCaptionText" Font-Bold="True" Font-Size="Larger" ForeColor="CadetBlue"></HeaderStyle>

<AlternatingRowStyle BackColor="ActiveCaptionText" BorderStyle="Solid" Font-Bold="True" Font-Names="Times New Roman,Times,serif" ForeColor="CadetBlue"></AlternatingRowStyle>
     
    </asp:GridView>
    </div>
    </form>
</body>
</html>
