<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CacheEmployee.aspx.cs" Inherits="Day_5_6.CacheEmployee" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Cache WebPage</title>
    <style type="text/css">
        .style1
        {
            height: 41px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
      
    <table align="center" 
            
            style= "border-style: solid; border-color: #000080; background-color: #008080; width: 333px;" 
            #008080"><tr>
           <td class="style1">  <asp:PlaceHolder ID="PlaceHolderList" runat="server"></asp:PlaceHolder>
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
               <asp:Label ID="lblCache" runat="server" visible="false"></asp:Label></td></tr>
               <tr><td>
                   <asp:Button ID="btnDetails" runat="server" Text="Details" 
             Style="height: 26px" Width="78px" onclick="btnDetails_Click"  /></td></tr>
              <br />
        <br />
        <tr><td>
        <asp:GridView ID="gvEmp" runat="server" BackColor="AliceBlue" BorderColor="#999999"
            BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" 
                Width="260px">
            <AlternatingRowStyle BackColor="Aquamarine"/>
            <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
            <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
            <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
            
        </asp:GridView></td></tr>
        </table>
    </div>
    </form>
</body>
</html>
