<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="SearchApplication._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Searching Page</title>
    <link href="Stylesheet.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
    <div align="left">
        <asp:Panel runat="server" ID="PnlTableSearch" GroupingText="Search Criteria" CssClass="Panel">
            <table class="table" align="left">
                <tr>
                    <td class="td" align="justify" colspan="2">
                        <asp:Label ID="Lblsearch" runat="server" Text="Search Information" CssClass="lblMsg"
                            Width="196px"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblName" runat="server" Text="FirstName : " CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtFirstName" runat="server" Width="128px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblLastName" runat="server" Text="Last Name : " CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtLastName" runat="server" Width="128px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblAge" runat="server" CssClass="lblControl" Text="Age : "></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtAge" runat="server" Width="128px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblSex" runat="server" Text="Sex : " CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="td">
                        <fieldset id="FieldsetSex" title="Sex" runat="server" style="height: 12px">
                            <asp:RadioButtonList ID="RdbtnSex" runat="server" CssClass="lblControl" RepeatDirection="Horizontal"
                                Height="10px" RepeatLayout="Flow">
                                <asp:ListItem>Male</asp:ListItem>
                                <asp:ListItem>Female</asp:ListItem>
                            </asp:RadioButtonList>
                        </fieldset>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblEducation" runat="server" CssClass="lblControl" Text="Education: "></asp:Label>
                    </td>
                    <td class="td">
                        <asp:DropDownList ID="DdlEducation" runat="server" Width="128px">
                            <asp:ListItem Selected="True">------Select----------</asp:ListItem>
                            <asp:ListItem>B.Com</asp:ListItem>
                            <asp:ListItem>B.B.A</asp:ListItem>
                            <asp:ListItem>B.SC.IT</asp:ListItem>
                            <asp:ListItem>M.SC.IT</asp:ListItem>
                            <asp:ListItem>B.C.A</asp:ListItem>
                            <asp:ListItem>B.E.</asp:ListItem>
                            <asp:ListItem>M.B.A</asp:ListItem>
                            <asp:ListItem>M.B.B.S</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblExpernce" runat="server" CssClass="lblControl" Text="Experience:"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:DropDownList ID="DdlExperience" runat="server" Width="128px">
                            <asp:ListItem Selected="True" Value="SelectExperience">SelectExperience</asp:ListItem>
                            <asp:ListItem>1</asp:ListItem>
                            <asp:ListItem>2</asp:ListItem>
                            <asp:ListItem>3</asp:ListItem>
                            <asp:ListItem>4</asp:ListItem>
                            <asp:ListItem>5</asp:ListItem>
                            <asp:ListItem>6</asp:ListItem>
                            <asp:ListItem>7</asp:ListItem>
                            <asp:ListItem>8</asp:ListItem>
                            <asp:ListItem>9</asp:ListItem>
                            <asp:ListItem>10</asp:ListItem>
                            <asp:ListItem>11</asp:ListItem>
                            <asp:ListItem>12</asp:ListItem>
                            <asp:ListItem>13</asp:ListItem>
                            <asp:ListItem>14</asp:ListItem>
                            <asp:ListItem>15</asp:ListItem>
                            <asp:ListItem>16</asp:ListItem>
                            <asp:ListItem>17</asp:ListItem>
                            <asp:ListItem>18</asp:ListItem>
                            <asp:ListItem>19</asp:ListItem>
                            <asp:ListItem>20</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="td" align="left">
                        <asp:Label ID="LblSalary" runat="server" Text="Salary : " CssClass="lblControl"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:DropDownList ID="DdlSalary" runat="server" Width="128px">
                            <asp:ListItem Selected="True" Value="----Select----">----Select----</asp:ListItem>
                            <asp:ListItem Value="1000-5000">1000-5000</asp:ListItem>
                            <asp:ListItem Value="5000-10000">5000-10000</asp:ListItem>
                            <asp:ListItem Value="10000-30000">10000-30000</asp:ListItem>
                            <asp:ListItem Value="30000-50000">30000-50000</asp:ListItem>
                            <asp:ListItem Value="50000-90000">50000-90000</asp:ListItem>
                            <asp:ListItem Value="90000-120000">90000-120000</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="td" colspan="2">
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        &nbsp;
                    </td>
                    <td class="td" align="justify">
                        <asp:Button ID="BtnSearch" runat="server" Text="Search" Width="63px" OnClick="BtnSearch_Click" />
                        <asp:Button ID="BtnReset" runat="server" Text="Reset" Width="65px" OnClick="BtnReset_Click" />
                    </td>
                </tr>
            </table>
            <asp:Panel ID="PnlGrid" runat="server" Visible="false" ScrollBars="Vertical" GroupingText="Employee Information"
                CssClass="PanelGrid">
                <asp:Label ID="LblNoRecord" runat="server" CssClass="lblMsg" Visible="false"></asp:Label>
                <asp:GridView ID="EmployeeGrid" runat="server" AutoGenerateColumns="false" CssClass="GridView"
                    Font-Bold="true" GridLines="Both" HorizontalAlign="Center" CaptionAlign="Top">
                    <HeaderStyle CssClass="GridViewHeaderStyle" HorizontalAlign="Center" VerticalAlign="Top"
                        Font-Bold="True" ForeColor="CadetBlue" Font-Underline="false" Wrap="True" />
                    <AlternatingRowStyle Font-Bold="True" CssClass="GridViewAlternaterowstyle" ForeColor="CadetBlue"
                        HorizontalAlign="Left" VerticalAlign="Top" />
                    <RowStyle HorizontalAlign="Left" VerticalAlign="Top" />
                    <Columns>
                        <asp:BoundField HeaderText="First Name" ControlStyle-Width="200px" DataField="FirstName" />
                        <asp:BoundField HeaderText="Last Name" ControlStyle-Width="200px" DataField="LastName" />
                        <asp:BoundField HeaderText="Age" ControlStyle-Width="50px" DataField="age" />
                        <asp:BoundField HeaderText="Sex" ControlStyle-Width="100px" DataField="Sex" />
                        <asp:BoundField HeaderText="Education" ControlStyle-Width="150px" DataField="Education" />
                        <asp:BoundField HeaderText="Experience" ControlStyle-Width="150px" DataField="Experience" />
                        <asp:BoundField HeaderText="Salary" ControlStyle-Width="200px" DataField="Salary" />
                    </Columns>
                </asp:GridView>
            </asp:Panel>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
