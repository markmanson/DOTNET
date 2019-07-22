<%@ Page Language="C#" MasterPageFile="~/Frames.Master" AutoEventWireup="true" CodeBehind="ContentFrame.aspx.cs"
    Inherits="UserControlPage.ContentFrame" Title="Employee Detail Content Page" %>

<%@ Register Src="TableUserControl.ascx" TagName="TableUserControl" TagPrefix="uc1" %>
<asp:Content ID="ContentPage" ContentPlaceHolderID="MasterContentPlaceHolder" runat="server">
    <asp:Button ID="BtnShowEmployee" runat="server" Text="Show Employee Details" Width="160px"
        OnClick="BtnShowEmployee_Click" />
    <asp:Panel ID="pnl" runat="server" Font-Size="12px" Visible="false" Width="250px"
        Height="250px" ScrollBars="Vertical">
        <asp:Label ID="LblMsg" runat="server" CssClass="lblMsg" Visible="False"></asp:Label>
    </asp:Panel>
</asp:Content>
