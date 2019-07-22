<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY7Excercise._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Grid</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Always">
        <ContentTemplate>
            <div align="left">
                <asp:Panel ID="PanelGrid" runat="server" CssClass="Panel" GroupingText="Employee Details">
                    <asp:Button ID="BtnDisplayGrid" runat="server" Text="Display Grid" OnClick="BtnDisplayGrid_Click" />
                    <asp:Label ID="LblMsg" runat="server" CssClass="span"></asp:Label>
                    <asp:GridView ID="EmployeeGrid" runat="server" AutoGenerateColumns="false" AllowPaging="True"
                        PageSize="5" CssClass="GridView" Font-Bold="true" GridLines="Both" HorizontalAlign="Center"
                        DataKeyNames="EmpName" AllowSorting="True" CaptionAlign="Top" OnPageIndexChanging="EmployeeGrid_PageIndexChanging"
                        OnRowCreated="EmployeeGrid_RowCreated" OnSorting="EmployeeGrid_Sorting">
                        <HeaderStyle CssClass="GridViewHeaderStyle" HorizontalAlign="Center" VerticalAlign="Top"
                            Font-Bold="True" ForeColor="CadetBlue" Font-Underline="false" Wrap="True" />
                        <AlternatingRowStyle Font-Bold="True" CssClass="GridViewAlternaterowstyle" ForeColor="CadetBlue"
                            HorizontalAlign="Left" VerticalAlign="Top" />
                        <RowStyle HorizontalAlign="Left" VerticalAlign="Top" />
                        <Columns>
                            <asp:BoundField HeaderText="EmpName" ControlStyle-Width="180px" ItemStyle-Width="80px"
                                SortExpression="EmpName" DataField="EmpName" />
                            <asp:BoundField HeaderText="Address" ControlStyle-Width="240px" ItemStyle-Width="80px"
                                SortExpression="Address" DataField="Address" />
                            <asp:BoundField HeaderText="Email" ControlStyle-Width="350px" ItemStyle-Width="150px"
                                SortExpression="Email" DataField="Email" />
                            <asp:BoundField HeaderText="Salary" ControlStyle-Width="150px" ItemStyle-Width="100px"
                                SortExpression="Salary" DataField="Salary" />
                        </Columns>
                    </asp:GridView>
                </asp:Panel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
