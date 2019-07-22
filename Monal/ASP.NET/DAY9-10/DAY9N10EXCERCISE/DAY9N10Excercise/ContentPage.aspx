<%@ Page Language="C#" MasterPageFile="~/NestedNewMasterPage.master" AutoEventWireup="true"
    CodeBehind="ContentPage.aspx.cs" Inherits="DAY9N10Excercise.ContentPage" Title="Content Page" %>

<asp:Content ID="ContentPage" ContentPlaceHolderID="NestedContent" runat="server">
    <asp:Panel runat="server" ID="pnl" class="Panel">
        <table id="ContentTable" align="center">
            <tr>
                <td>
                    <asp:Label ID="lblContentMsg" runat="server" CssClass="lblcontrol"></asp:Label>
                </td>
            </tr>
        </table>
    </asp:Panel>
</asp:Content>
