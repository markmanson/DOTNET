<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditCustomers.aspx.cs" Inherits="Day_5_9.EditCustomers" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EditCustomers</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblUpdate" runat="server" Visible="false" ></asp:Label>
    </div>
    <asp:Table ID="TblEditCstmr" runat="server" BorderWidth="1px" 
        HorizontalAlign="Center">
        <asp:TableRow ID="TRw1" runat="server">
        <asp:TableCell><asp:Label ID="lblCustomerId" runat="server" Text="CustomerId"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtCustomerID" runat="server" ></asp:TextBox>
        </asp:TableCell>     
        </asp:TableRow>
        
        <asp:TableRow ID="TRw2" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblCompanyName" runat="server" Text="CompanyName"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtCompanyName" runat="server"></asp:TextBox>
        </asp:TableCell>        
        </asp:TableRow>
        
        
        
        <asp:TableRow ID="Trw3" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblContactName" runat="server" Text="ContactName"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtContactName" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow  ID="Trw4" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblContactTitle" runat="server" Text="ContactTitle"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtContactTitle" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw5" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblAddress" runat="server" Text="Address"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw6" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw7" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblRegion" runat="server" Text="Region"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtRegion" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw8" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblPostalCode" runat="server" Text="PostalCode"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtPostalCode" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw9" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblCountry" runat="server" Text="Country"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtCountry" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw10" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblPhone" runat="server" Text="Phone"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtPhone" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        
        <asp:TableRow ID="Trw11" runat="server">
        <asp:TableCell>
        <asp:Label ID="lblFax" runat="server" Text="Fax"></asp:Label>
        </asp:TableCell>
        <asp:TableCell>
        <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
        </asp:TableCell>
        </asp:TableRow>
        
        <asp:TableRow ID="Trw12" runat="server">
        <asp:TableCell>
        <asp:Button ID="btnAdd" Text="ADD" runat="server" onclick="btnAdd_Click" ></asp:Button>
        </asp:TableCell>
        <asp:TableCell>
        <asp:Button ID= "btnCancel" Text="CANCEL" runat="server"></asp:Button >
        <asp:Button ID="btnBack" Text="BACK" runat="server" onclick="btnBack_Click"></asp:Button >
        </asp:TableCell>
        </asp:TableRow>
    </asp:Table>    
   
    </form>
</body>
</html>
