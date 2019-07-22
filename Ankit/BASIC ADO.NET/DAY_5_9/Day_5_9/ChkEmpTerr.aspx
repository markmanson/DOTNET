<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChkEmpTerr.aspx.cs" Inherits="Day_5_9.ChkEmpTerr" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>CheckEmpTerr</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    <asp:Label ID="lblError1" runat="server" Visible="false"></asp:Label>
    
    <asp:GridView ID="gvChk" runat="server" BackColor="White" BorderColor="#E7E7FF" 
        BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
        <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" />
    <Columns>
                    <asp:TemplateField HeaderText="Delete">
                    <HeaderTemplate>
                        <asp:CheckBox ID="chkHeader" runat="server"  AutoPostBack="true" 
                            oncheckedchanged="chkHeader_CheckedChanged"/>
                    </HeaderTemplate>
                        <ItemTemplate>
                            <asp:CheckBox ID="chkItem" runat="server"  AutoPostBack ="true"
                                oncheckedchanged="chkItem_CheckedChanged" />
                          
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                    
                  
                    
                    
                   
                    <asp:BoundField DataField="EmployeeId" HeaderText="id" ReadOnly="false" />
                    <asp:BoundField DataField="FirstName" HeaderText="Name" ReadOnly="false" />
                    <asp:BoundField DataField="LastName" HeaderText="id" ReadOnly="false" Visible="false" />
                    <asp:BoundField DataField="Title" HeaderText="Tittle" ReadOnly="false" />
                    <asp:BoundField DataField="TitleOfCourtesy" HeaderText="Title Of Courtesy" ReadOnly="false"
                        Visible="false" />
                    <asp:BoundField DataField="BirthDate" HeaderText="Birth Date" ReadOnly="false" />
                    <asp:BoundField DataField="HireDate" HeaderText="Hire Date" ReadOnly="false" />
                    <asp:BoundField DataField="Address" HeaderText="Address" ReadOnly="false" />
                    <asp:BoundField DataField="City" HeaderText="City" ReadOnly="false" />
                    <asp:BoundField DataField="Region" HeaderText="Region" ReadOnly="false" />
                    <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" ReadOnly="false" />
                    <asp:BoundField DataField="Country" HeaderText="Country" ReadOnly="false" />
                    <asp:BoundField DataField="HomePhone" HeaderText="HomePhone" ReadOnly="false" />
                    <asp:BoundField DataField="Extension" HeaderText="Extension" ReadOnly="false" />
                    <asp:TemplateField HeaderText="Notes">
                        <ItemTemplate>
                            <asp:TextBox ID="TextBox1" runat="server" Text='<%#Eval("Notes")%>' ReadOnly="true"
                                TextMode="MultiLine"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="ReportsTo" HeaderText="ReportsTo" ReadOnly="false" />
                   
                    <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                            <asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" 
                                DataTextField="territoryDescription"></asp:ListBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                    
                   
                </Columns>
    
        <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
        <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
        <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
        <AlternatingRowStyle BackColor="#F7F7F7" />
    
    </asp:GridView>
    </form>
</body>
</html>
