<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RepeaterNDatalist.aspx.cs"
    Inherits="DAY7Excercise.RepeaterNDatalist" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Repeater And DataList</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional">
            <ContentTemplate>
                <asp:Panel runat="server" ID="PanelRepeaterDataGrid" CssClass="Panel1" GroupingText="Repeater And Datalist Control">
                    <asp:Label ID="LblSortOrder" runat="server" CssClass="lblControl" Text="SortBy:"></asp:Label>
                    <asp:DropDownList ID="DdlSort" runat="server" Font-Bold="True" Font-Names="Times New Roman"
                        Font-Size="12px" Height="22px" Width="88px">
                        <asp:ListItem Value="EmpName">Name</asp:ListItem>
                        <asp:ListItem>Address</asp:ListItem>
                        <asp:ListItem Value="Email">EmailId</asp:ListItem>
                        <asp:ListItem>Salary</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Button ID="BtnDisplayRecord" runat="server" Height="23px" Text="Display Records"
                        Width="111px" OnClick="BtnDisplayRecord_Click" />
                    <asp:Label ID="LblMsg" runat="server" CssClass="lblMsg" Visible="False"></asp:Label>
                    <asp:Button ID="BtnFirst" runat="server" Text="First" 
                        onclick="BtnFirst_Click" />
                    <asp:Button ID="BtnNext" runat="server" Text="&gt;&gt;" Height="23px" OnClick="BtnNext_Click" />
                    <asp:Label ID="LblPageNo" runat="server" CssClass="lblMsg"></asp:Label>
                    <asp:Button ID="BtnPrevious" runat="server" Height="25px" OnClick="BtnPrevious_Click"
                        Text="&lt;&lt;" />
                    <asp:Button ID="BtnLast" runat="server" Text="Last" onclick="BtnLast_Click" />
                    <table class="table" id="TblRepeater" runat="server" align="center">
                        <tr>
                            <td class="td" align="center" valign="top">
                                <asp:Label ID="LblRepeater" runat="server" CssClass="lblControl" Text="Repeater Control"></asp:Label>
                                <table class="table" align="center">
                                    <%-- <tr>
                                        <td>--%>
                                    <asp:Repeater ID="EmployeeRepeater" Visible="False" runat="server">
                                        <HeaderTemplate>
                                            <tr class="GridViewAlternaterowstyle">
                                                <td class="tdRepeaterAlterNHeader">
                                                    <b>Name</b>
                                                </td>
                                                <td class="tdRepeaterAlterNHeader">
                                                    <b>Address</b>
                                                </td>
                                                <td class="tdRepeaterAlterNHeader">
                                                    <b>EmailId</b>
                                                </td>
                                                <td class="tdRepeaterAlterNHeader">
                                                    <b>Salary</b>
                                                </td>
                                                </b>
                                            </tr>
                                        </HeaderTemplate>
                                        <ItemTemplate>
                                            <tr>
                                                <td class="tdRepeaterItem">
                                                    <%#DataBinder.Eval(Container, "DataItem.EmpName")%>
                                                </td>
                                                <td class="tdRepeaterItem">
                                                    <%#DataBinder.Eval(Container, "DataItem.Address")%>
                                                </td>
                                                <td class="tdRepeaterItem">
                                                    <%#DataBinder.Eval(Container, "DataItem.Email")%>
                                                </td>
                                                <td class="tdRepeaterItem">
                                                    <%#DataBinder.Eval(Container, "DataItem.Salary")%>
                                                </td>
                                            </tr>
                                        </ItemTemplate>
                                        <AlternatingItemTemplate>
                                            <tr class="GridViewAlternaterowstyle">
                                                <td class="tdRepeaterAlterNHeader">
                                                    <%#DataBinder.Eval(Container, "DataItem.EmpName")%>
                                                </td>
                                                <td class="tdRepeaterAlterNHeader">
                                                    <%#DataBinder.Eval(Container, "DataItem.Address")%>
                                                </td>
                                                <td class="tdRepeaterAlterNHeader">
                                                    <%#DataBinder.Eval(Container, "DataItem.Email")%>
                                                </td>
                                                <td class="tdRepeaterAlterNHeader">
                                                    <%#DataBinder.Eval(Container, "DataItem.Salary")%>
                                                </td>
                                            </tr>
                                        </AlternatingItemTemplate>
                                    </asp:Repeater>
                                    <%--  </td>
                                    </tr>--%>
                                </table>
                            </td>
                            <td class="td" align="center" valign="middle">
                                <table class="table" align="center">
                                    <tr>
                                        <td>
                                            <asp:Label ID="LblDatalist" runat="server" CssClass="lblControl" Text="DataList Control"></asp:Label>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <asp:DataList ID="EmployeeDataList" runat="server" Font-Bold="False" HorizontalAlign="Center"
                                                CaptionAlign="Top" CssClass="GridView" Visible="False" BorderColor="Black">
                                                <HeaderTemplate>
                                                    <tr class="GridViewHeaderStyle">
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <b>Name</b>
                                                        </td>
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <b>Address</b>
                                                        </td>
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <b>EmailId</b>
                                                        </td>
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <b>Salary</b>
                                                        </td>
                                                        </b>
                                                    </tr>
                                                </HeaderTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td class="tdDatalistItem">
                                                            <%#DataBinder.Eval(Container, "DataItem.EmpName")%>
                                                        </td>
                                                        <td class="tdDatalistItem">
                                                            <%#DataBinder.Eval(Container, "DataItem.Address")%>
                                                        </td>
                                                        <td class="tdDatalistItem">
                                                            <%#DataBinder.Eval(Container, "DataItem.Email")%>
                                                        </td>
                                                        <td class="tdDatalistItem">
                                                            <%#DataBinder.Eval(Container, "DataItem.Salary")%>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                                <AlternatingItemTemplate>
                                                    <tr class="GridViewAlternaterowstyle">
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <%#DataBinder.Eval(Container, "DataItem.EmpName")%>
                                                        </td>
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <%#DataBinder.Eval(Container, "DataItem.Address")%>
                                                        </td>
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <%#DataBinder.Eval(Container, "DataItem.Email")%>
                                                        </td>
                                                        <td class="tdRepeaterAlterNHeader">
                                                            <%#DataBinder.Eval(Container, "DataItem.Salary")%>
                                                        </td>
                                                    </tr>
                                                </AlternatingItemTemplate>
                                            </asp:DataList>
                                        </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
