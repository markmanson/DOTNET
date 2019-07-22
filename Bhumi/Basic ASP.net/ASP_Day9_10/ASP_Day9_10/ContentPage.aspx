<%@ Page Title="" Language="C#" MasterPageFile="~/First.Master" AutoEventWireup="true" CodeBehind="ContentPage.aspx.cs" Inherits="ASP_Day9_10.ContentPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 align="center"><asp:Label ID="LblContent" runat="server" Text="This is the Content" 
                style="font-weight: 700"></asp:Label></h2>
</asp:Content>
