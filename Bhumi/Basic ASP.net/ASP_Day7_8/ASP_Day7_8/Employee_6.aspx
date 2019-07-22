<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee_6.aspx.cs" Inherits="ASP_Day7_8.Employee_6" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee_6</title>
</head>
<body>
    <form id="FrmEmployeeDetails" runat="server">
    <div align="center">
    <h2>Employee Details<asp:Label runat="server" ID="LblEmpty" Visible="false">Data Not Available</asp:Label></h2>
        <asp:GridView ID="gvEmployeeDetails" runat="server" AutoGenerateColumns="False" 
            AllowPaging="True" onpageindexchanging="gvEmployeeDetails_PageIndexChanging"  
            PageSize="5" Width="40%" AllowSorting="True" 
            onsorting="gvEmployeeDetails_Sorting" CellPadding="10" ForeColor="#333333" 
            GridLines="None">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField HeaderText="Name" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" SortExpression="Name">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"Name") %>
                    </ItemTemplate>

        <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

        <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="Address" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" SortExpression="Address">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"Address")  %>
                    </ItemTemplate>

            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:TemplateField>            
                <asp:TemplateField HeaderText="Email" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" SortExpression="Email">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"Email") %>
                    </ItemTemplate>

            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Salary" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" SortExpression="Salary">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"Salary")%>                        
                    </ItemTemplate>

            <HeaderStyle HorizontalAlign="Left"></HeaderStyle>

            <ItemStyle HorizontalAlign="Left"></ItemStyle>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>    
    </div>
    </form>
</body>
</html>
