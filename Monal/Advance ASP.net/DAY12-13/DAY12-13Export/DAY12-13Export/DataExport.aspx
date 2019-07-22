<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DataExport.aspx.cs" Inherits="DAY12_13Export._DataExport" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Export Data From Excel File</title>
    <link href="Stylesheet.css" rel="Stylesheet" type="text/css" />
   
</head>
<body>
    <form id="form1" runat="server">
    <asp:Panel ID="PanelGrid" runat="server" CssClass="Panel" GroupingText="Employee Details">
        <span lang="en-us">&nbsp;</span><asp:Label ID="LblMsg" runat="server" CssClass="lblMsg"
            Visible="false" Font-Bold="true"></asp:Label>
        <br />
         
        <div align="left">
            <asp:Button ID="BtnExportToExcel" runat="server" Text="Export To Excel" OnClick="BtnExportToExcel_Click" />
            <span lang="en-us">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span>
            <asp:Label ID="LblUpload" runat="server" CssClass="lblMsg" Font-Bold="true" 
                Text="File Upload:"></asp:Label>
            <asp:FileUpload ID="FileUpload" runat="server" Width="201px" />
            <asp:Button ID="BtnFileUpload" runat="server" Height="22px" 
                OnClick="BtnFileUpload_Click" Text="Upload" Width="84px" />
        </div>
       
        <asp:GridView ID="EmployeeGrid" runat="server" AutoGenerateColumns="false" CssClass="GridView"
            Font-Bold="true" GridLines="Both" HorizontalAlign="Center" CaptionAlign="Top">
            <HeaderStyle CssClass="GridViewHeaderStyle" HorizontalAlign="Center" VerticalAlign="Top"
                Font-Bold="True" ForeColor="CadetBlue" Font-Underline="false" Wrap="True" />
            <AlternatingRowStyle Font-Bold="True" CssClass="GridViewAlternaterowstyle" ForeColor="CadetBlue"
                HorizontalAlign="Left" VerticalAlign="Top" />
            <RowStyle HorizontalAlign="Left" VerticalAlign="Top" />
            <Columns>
                <asp:BoundField DataField="Name" HeaderText="Name" />
                <asp:BoundField DataField="BirthDate" HeaderText="BirthDate" ItemStyle-CssClass="textalign" />
                <asp:BoundField DataField="Address" HeaderText="Address" />
                <asp:BoundField DataField="PostalCode" HeaderText="PostalCode" ItemStyle-CssClass="textalign" />
            </Columns>
        </asp:GridView>
        <br />
    </asp:Panel>
    </form>
</body>
</html>
