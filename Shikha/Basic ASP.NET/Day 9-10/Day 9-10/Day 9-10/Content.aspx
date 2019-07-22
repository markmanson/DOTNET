<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="Day_9_10.Content" MasterPageFile="~/NestedMasterPage.master" %>

<asp:Content ID="Content" runat="server" ContentPlaceHolderID="ContentPlaceHolderNested">
    <asp:Table ID="tblContent" runat="server"  HorizontalAlign="Center" BorderColor="ControlDarkDark" BorderWidth="2" BorderStyle="Ridge"><asp:TableHeaderRow>
                <asp:TableHeaderCell>
                        <asp:Label ID="lblContent" runat="server" Text="This is content" Font-Bold="true" Font-Italic="true" ForeColor="Blue" Font-Size="XX-Large"></asp:Label>                           
                </asp:TableHeaderCell>
</asp:TableHeaderRow></asp:Table>
</asp:Content>
