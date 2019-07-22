<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY4RadioButtoncontrol._Default" %>

<%@ Register Assembly="DAY4ServerControl" Namespace="DAY4ServerControl" TagPrefix="cc1" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Radio Button Custom Control Page</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnl" runat="server" CssClass="panel" GroupingText="RadioListButton Render Control">
            <table class="Dynamictable">
                <tr>
                    <td class="Bodytd" colspan="2">
                        <asp:Label ID="LblTextMsg" runat="server" Font-Bold="True" CssClass="lblMsg"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="Bodytd" colspan="2">
                        <asp:Label ID="LblClick" runat="server" Font-Bold="true" Visible="false" CssClass="lblControl"></asp:Label>
                        <asp:Label ID="LblChange" runat="server" Font-Bold="true" Visible="false" CssClass="lblControl"></asp:Label>
                    </td>
                </tr>
                
                <tr>              
                    <td class="Bodytd" colspan="2">
                      <hr />
                        <cc1:RadioServerControl runat="server" ID="RadioRenderControl" Height="153px" OnSelectedIndexChanged="RadioBtnLst_SelectedIndexChanged"
                            OnClick="BtnCastVote_Click" Width="297px"></cc1:RadioServerControl>
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
