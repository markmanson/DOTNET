<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateDropDown.aspx.cs"
    Inherits="DAY3Exercise.CreateDropDown" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Dynamic DropDownList</title>
    <link rel="Stylesheet" href="Stylesheet.css" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <asp:UpdatePanel runat="server" ID="UpdatePanel" UpdateMode="Conditional">
        <ContentTemplate>
            <div>
                <asp:Label ID="LblErrorMessageId" runat="server" CssClass="span"></asp:Label>
                <asp:Panel ID="Panel1" runat="server" CssClass="panel2" GroupingText="Create DropDownList">
                    <table class="table">
                        <tr>
                            <td class="td3">
                                <asp:TextBox ID="TxtDropDownItems" runat="server" Width="240px"></asp:TextBox>
                            </td>
                            <td class="td4">
                                <asp:Button ID="BtnCreateDropDown" runat="server" Text="Create DropDown" Width="120px"
                                    OnClick="BtnCreateDropDown_Click" />
                            </td>
                            <td>
                                <asp:ScriptManager ID="sc" runat="server" />
                            </td>
                        </tr>
                    </table>
                    <asp:Panel ID="Panel2" runat="server" ScrollBars="Vertical" CssClass="panel2" GroupingText="Selected DropDown Value">
                    </asp:Panel>
                </asp:Panel>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
    </form>
</body>
</html>
