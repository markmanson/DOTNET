<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day2_4._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>DefaultPage</title>
</head>
<body>
    <form id="form1" runat="server">
    <div >
        <asp:Label ID="LblError" runat="server" ></asp:Label>
        <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
            <asp:GridView ID="gvdEmployeeTerritories" runat="server" AlternatingRowStyle-BackColor="Aqua" AutoGenerateColumns="false"
      HorizontalAlign="Center" BackColor="#DEBA84" BorderColor="#DEBA84" 
            BorderStyle="None" BorderWidth="1px" CellPadding="3" 
    CellSpacing="2"     >
                <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                <Columns>
                    <asp:TemplateField HeaderText="EmployeeID" >
                        <ItemTemplate>
                            <asp:Label ID="lblEmpID" runat="server"  Text='<%# bind("EmployeeID")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="FirstName" >
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server"  Text='<%# bind("FirstName")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
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
                            <asp:Label ID="lblReportsTo" runat="server" Text='<%# bind("ReportsTo")%>' ></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Photo Path"  >
                        <ItemTemplate>
                            <asp:Label ID="lblPhotoPath" runat="server" Text='<%# bind("PhotoPath")%>'></asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </asp:Panel>
    
    </div>
    </form>
</body>
</html>
