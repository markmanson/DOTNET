<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Topics.aspx.cs" Inherits="DAY6Excercise.Topics" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LinkButton Values</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <span lang="en-us">.</span><asp:Panel ID="Panel1" CssClass="Panel" GroupingText="Selected Values" runat="server"
            Width="154px">
            <table class="table">
                <tr>
                    <td class="td">
                        <asp:Label ID="LblOption" runat="server" Text="Selected Values Are:" CssClass="lblMsg"></asp:Label>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
