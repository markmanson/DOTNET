<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmployeeTerritories.aspx.cs" Inherits="ADO_Day2_4.EmployeeTerritories" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    
        <asp:GridView ID="gvEmployeeTerritory" runat="server" AllowPaging="True" Width="20%" 
            AutoGenerateColumns="False" 
            onpageindexchanging="GridView1_PageIndexChanging" CaptionAlign="Top"
            Caption='<h3><table border="1" width="100%" cellpadding="0" cellspacing="0" bgcolor="yellow"><tr><td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Employees Territories</td></tr></table></h3>'>
        <Columns>
                <asp:TemplateField HeaderText="EmployeeID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem,"EmployeeID") %>
                    </ItemTemplate>

                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>           
                <asp:TemplateField HeaderText="TerritoryID" HeaderStyle-HorizontalAlign="Left" ItemStyle-HorizontalAlign="Left">
                    <ItemTemplate>
                        <%#DataBinder.Eval(Container.DataItem, "TerritoryID")%>
                    </ItemTemplate>
                
                <HeaderStyle HorizontalAlign="Left"></HeaderStyle>
                </asp:TemplateField>
           </Columns>
        </asp:GridView>    
    </div>
    </form>
</body>
</html>
