<%@ Page Language="C#" MasterPageFile="~/Frames.Master" AutoEventWireup="true" CodeBehind="DeprtmentContentFrame.aspx.cs"
    Inherits="UserControlPage.DeprtmentContentFrame" Title="Department Detail Content Page" %>

<%@ Register Src="TableUserControl.ascx" TagName="TableUserControl" TagPrefix="uc1" %>
<asp:Content ID="ContentPage" ContentPlaceHolderID="MasterContentPlaceHolder" runat="server">
    <asp:Button ID="BtnshowDepartmentdetails" runat="server" Text="Show Department Details"
        Width="160px" OnClick="BtnshowDepartmentdetails_Click" />
    <asp:Panel runat="server" ID="pnl" Visible="false" Font-Size="12px" Width="250px"
        Height="250px" ScrollBars="Vertical">
        <asp:Label ID="LblMsg" runat="server" CssClass="lblMsg" Visible="False"></asp:Label>
    </asp:Panel>
</asp:Content>
