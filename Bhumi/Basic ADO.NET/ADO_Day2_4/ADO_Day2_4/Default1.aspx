<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default1.aspx.cs" Inherits="ADO_Day2_4.Default1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:GridView ID="gvEmployees" runat="server" AutoGenerateColumns="False" 
            CellPadding="4" ForeColor="#333333" Caption='<h3>Employee Details</h3>' 
            GridLines="None" Width="80%">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
        <Columns>
                <asp:TemplateField HeaderText="EmployeeID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>
                    </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>            
                <asp:TemplateField HeaderText="Firstname" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                    <asp:HyperLink runat="server" NavigateUrl='<%#"Emp_Territory1.aspx?ID=" + DataBinder.Eval (Container.DataItem,"EmployeeID") %>'>
                    <%#DataBinder.Eval(Container.DataItem, "FirstName")%>
                    </asp:HyperLink>
                    </ItemTemplate>

                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Salutation" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem, "TitleOfCourtesy")%>
                    </ItemTemplate>

                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="BirthDate" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderStyle-Width="16%" ItemStyle-Width="16%">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem, "BirthDate")%>
                    </ItemTemplate>

                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="Address" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left" HeaderStyle-Width="14%" ItemStyle-Width="14%">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"Address") %>
                    </ItemTemplate>

                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>            
                <asp:TemplateField HeaderText="City" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"City") %>
                    </ItemTemplate>

                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Country" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"Country") %>
                    </ItemTemplate>

                    <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="ContactNo" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem, "HomePhone")%>
                    </ItemTemplate>

                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
            </Columns>
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
       </asp:GridView>
    
    </div>
    </form>
</body>
</html>
