<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY3Exercise._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>ListBox</title>
    <link rel="Stylesheet" href="Stylesheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
        <ContentTemplate>
            <div align="center">
                <asp:Panel ID="Panel1" runat="server" CssClass="Panel" GroupingText="Create ListBox And Add/Remove Items">
                    <table class="table">
                        <tr>
                            <td>
                                <asp:TextBox ID="TxtAddList" runat="server" Width="126px"></asp:TextBox>
                            </td>
                            <td class="td">
                                &nbsp;
                            </td>
                            <td class="td1">
                                <asp:Button ID="BtnAddlistItem" runat="server" Text="AddListItem" Width="118px" OnClick="BtnAddlistItem_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td class="td">
                                &nbsp;
                            </td>
                            <td class="td1">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td rowspan="2">
                                <asp:ListBox ID="LstAddItem" runat="server" Height="91px" Width="125px" SelectionMode="Multiple">
                                </asp:ListBox>
                            </td>
                            <td class="td">
                                <asp:Button ID="BtnAdd" runat="server" Text="&gt;" Width="49px" OnClick="BtnAdd_Click" />
                            </td>
                            <td class="td1" rowspan="2">
                                <asp:ListBox ID="LstAddListItems" runat="server" Height="97px" Width="120px" SelectionMode="Multiple">
                                </asp:ListBox>
                            </td>
                        </tr>
                        <tr>
                            <td class="td">
                                <asp:Button ID="BtnDisplay" runat="server" Text="&lt;" Width="50px" OnClick="BtnDisplay_Click" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td class="td">
                                &nbsp;
                            </td>
                            <td class="td1">
                                &nbsp;
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <asp:Button ID="BtnRemoveItem" runat="server" Text="Remove Items" Width="128px" OnClick="BtnRemoveItem_Click" />
                            </td>
                            <td class="td">
                                &nbsp;
                            </td>
                            <td class="td1">
                                <asp:ScriptManager ID="sc" runat="server" />
                            </td>
                        </tr>
                        <tr>
                            <td>
                                &nbsp;
                            </td>
                            <td class="td">
                                &nbsp;
                            </td>
                            <td class="td1">
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </asp:Panel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
