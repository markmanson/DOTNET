<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Excercise7.aspx.cs" Inherits="DAY5EXercise.Excercise7" %>

<%--<%@ OutputCache Duration="15" VaryByControl="DdlEmployee" Location="Any" %>--%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Store value In Cache</title>
    <link href="Stylesheet.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="MainPnl" runat="server" GroupingText="Select Employee Name For View Employee Detail"
            CssClass="panel">
            <table id="DdlTable" class="Dynamictable">
                <tr>
                    <td class="Bodytd" colspan="2">
                        <asp:Label ID="LblMsg" runat="server" CssClass="lblControl" Text="Select Employee Name:"></asp:Label>
                        <asp:DropDownList ID="DdlEmployee" runat="server" Height="27px" DataTextField="EmpName"
                            DataValueField="EmpName" Width="98px">
                        </asp:DropDownList>
                        <asp:Button ID="BtnDisplay" runat="server" Text="Details" OnClick="BtnDisplay_Click"
                            Width="54px" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Panel ID="PanelGrid" runat="server" Visible="false" GroupingText="Employee Detail"
                            CssClass="panel">
                            <asp:GridView ID="EmployeeGrid" runat="server" AutoGenerateColumns="false" CssClass="GridView"
                                Font-Bold="true" GridLines="Both" HorizontalAlign="Center" CaptionAlign="Top">
                                <HeaderStyle CssClass="GridViewHeaderStyle" HorizontalAlign="Center" VerticalAlign="Top"
                                    Font-Bold="True" ForeColor="CadetBlue" Font-Underline="false" Wrap="True" />
                                <AlternatingRowStyle Font-Bold="True" CssClass="GridViewAlternaterowstyle" ForeColor="CadetBlue"
                                    HorizontalAlign="Left" VerticalAlign="Top" />
                                <RowStyle HorizontalAlign="Left" VerticalAlign="Top" />
                                <Columns>
                                    <asp:BoundField HeaderText="Name" ControlStyle-Width="180px" ItemStyle-Width="80px"
                                        DataField="EmpName"></asp:BoundField>
                                    <asp:BoundField HeaderText="Address" ControlStyle-Width="240px" ItemStyle-Width="80px"
                                        DataField="Address"></asp:BoundField>
                                    <asp:BoundField HeaderText="Email" ControlStyle-Width="350px" ItemStyle-Width="150px"
                                        DataField="Email"></asp:BoundField>
                                    <asp:BoundField HeaderText="Salary" ControlStyle-Width="150px" ItemStyle-Width="100px"
                                        DataField="Salary"></asp:BoundField>
                                </Columns>
                            </asp:GridView>
                        </asp:Panel>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
