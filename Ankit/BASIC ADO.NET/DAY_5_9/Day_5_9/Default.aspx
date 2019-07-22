<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_5_9._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Default</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <asp:Label ID="LblError" runat="server" Visible="false"></asp:Label>
    <asp:Button ID="btnAdd" runat="server" Text="Add details" onclick="btnAdd_Click" />
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
        <asp:GridView ID="gvEditEmployees" runat="server" 
            AlternatingRowStyle-BackColor="Aqua" AutoGenerateColumns="False" 
            BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" 
            CellPadding="3" CellSpacing="2" DataKeyNames="EmployeeID" 
            HorizontalAlign="Center" RowStyle-Wrap="true">
            <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" Wrap="True" />
            <Columns>
                <asp:TemplateField HeaderText="Edit">
                    <ItemTemplate>
                        <%--<asp:Label ID="lblEdit" runat="server"  Text='<%# bind("EmployeeID")%>'></asp:Label>--%>
                        <asp:LinkButton ID="LnkEdit" runat="server" onclick="LnkEdit_Click" Text="Edit"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Delete">
                    <ItemTemplate>
                        <%--<asp:Label ID="lblEdit" runat="server"  Text='<%# bind("EmployeeID")%>'></asp:Label>--%>
                        <asp:LinkButton ID="LnkDelete" runat="server" onclick="LnkDelete_Click" 
                            Text="Delete"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="EmployeeID">
                    <ItemTemplate>
                        <asp:Label ID="lblID" runat="server" Text='<%# bind("EmployeeID")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Name">
                    <ItemTemplate>
                        <%--  <asp:Label ID="lblFirstName" runat="server"  Text='<%# bind("FirstName")%>'></asp:Label>--%>
                        <%--<asp:HyperLink ID="HlnkName" runat="server" Visible="true" NavigateUrl="~/EmpTerr.aspx"  Text='<%# bind("Name")%>' >EmpTerr.aspx</asp:HyperLink>--%>
                        <asp:Label ID="lblName" runat="server" Text='<%# bind("Name")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="LastName" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblLastName" runat="server" Text='<%# bind("LastName")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="FirstName" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblFirstName" runat="server" Text='<%# bind("FirstName")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Title">
                    <ItemTemplate>
                        <asp:Label ID="lblTitle" runat="server" Text='<%# bind("Title")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="TitleOfCourtesy" Visible="false">
                    <ItemTemplate>
                        <asp:Label ID="lblTitleOfCourtesy" runat="server" 
                            Text='<%# bind("TitleOfCourtesy")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Birth Date">
                    <ItemTemplate>
                        <asp:Label ID="lblBirthDate" runat="server" Text='<%# bind("BirthDate")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Hire Date">
                    <ItemTemplate>
                        <asp:Label ID="lblHireDate" runat="server" Text='<%# bind("HireDate")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Address">
                    <ItemTemplate>
                        <asp:Label ID="lblAddress" runat="server" Text='<%# bind("Address")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="lblCity" runat="server" Text='<%# bind("City")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Region">
                    <ItemTemplate>
                        <asp:Label ID="lblRegion" runat="server" Text='<%# bind("Region")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Postal Code">
                    <ItemTemplate>
                        <asp:Label ID="lblPostalCode" runat="server" Text='<%# bind("PostalCode")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country">
                    <ItemTemplate>
                        <asp:Label ID="lblCountry" runat="server" Text='<%# bind("Country")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Home Phone">
                    <ItemTemplate>
                        <asp:Label ID="lblHomePhone" runat="server" Text='<%# bind("HomePhone")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Extension">
                    <ItemTemplate>
                        <asp:Label ID="lblExtension" runat="server" Text='<%# bind("Extension")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Notes">
                    <ItemTemplate>
                        <asp:TextBox ID="lblNotes" runat="server" ReadOnly="true" 
                            Text='<%# bind("Notes")%>' TextMode="MultiLine"></asp:TextBox>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Reports To">
                    <ItemTemplate>
                        <%--<asp:TextBox ID= "txtReportTo" runat="server"  ReadOnly= true Text='<%# bind("ReportsTo")%>'></asp:TextBox> 
                </ItemTemplate>--%>
                        <asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
            <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
            <AlternatingRowStyle BackColor="Aqua" />
        </asp:GridView>
    
    </asp:Panel>
    </div>
    </form>
</body>
</html>
