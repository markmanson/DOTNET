<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day7_8._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Employee</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblNodata" runat="server" Visible="false"></asp:Label>
        <asp:GridView ID="gvEmp" runat="server" HorizontalAlign="Center"
            AutoGenerateColumns="False" AllowPaging="True" PageSize="5" 
            onpageindexchanging="gvEmp_PageIndexChanging" AllowSorting="True" 
             onsorted="gvEmp_Sorted" Height="300px" Width="500px" 
            BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
            CellPadding="2" ForeColor="Black" GridLines="None">      
        <Columns>
        <asp:TemplateField  SortExpression="Ename">
                        <HeaderTemplate >
                            <asp:LinkButton ID="lnkName"  runat="server" Text="Name" onclick="gvEmp_Sorted" CommandArgument="Ename"></asp:LinkButton>
                        </HeaderTemplate>
                        <ItemTemplate >
                            <asp:Label ID="lblName" runat="server"   Text='<%# bind("Ename")%>'></asp:Label>
                        </ItemTemplate>
        </asp:TemplateField>
       <asp:TemplateField SortExpression="Address" >
                        <HeaderTemplate>
                                <asp:LinkButton ID="lnkAdd" runat="server" Text="Address" onclick="gvEmp_Sorted" CommandArgument="Address"></asp:LinkButton>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblAddress" runat="server"  Text='<%# bind("Address")%>'></asp:Label>
                        </ItemTemplate>
       </asp:TemplateField >
        <asp:TemplateField SortExpression="Email">
                        <HeaderTemplate>
                            <asp:LinkButton ID="lnkEmail" Text="Email" runat="server" onclick="gvEmp_Sorted" CommandArgument="Email"></asp:LinkButton>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblEmail" runat="server"  Text='<%# bind("Email")%>'></asp:Label>
                        </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField SortExpression="Salary" >
                        <HeaderTemplate>
                            <asp:LinkButton ID="lnkSalary" Text="Salary" runat="server" onclick="gvEmp_Sorted" CommandArgument="Salary"></asp:LinkButton>
                        </HeaderTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblSalary" runat="server"  Text='<%# bind("Salary")%>'></asp:Label>
                        </ItemTemplate>
        </asp:TemplateField>
        </Columns>
            <FooterStyle BackColor="Tan" />
            <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
                HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
            <HeaderStyle BackColor="Tan" Font-Bold="True" />
            <AlternatingRowStyle BackColor="PaleGoldenrod" />
        </asp:GridView>
    </div>
    </form>
</body>
</html>
