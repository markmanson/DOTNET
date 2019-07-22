<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Day2_4.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>  
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EDIT</title>
</head>
<body>
    <form id="frmEdit" runat="server"  >
    <div>
        <asp:Label ID="lblUpdate" runat="server" Visible="false" ></asp:Label>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
    <asp:Table ID="tblEdit" runat="server" HorizontalAlign="Center" BorderWidth="1" BorderColor="Black" >
    <asp:TableHeaderRow ID=Head1 runat="server" ><asp:TableHeaderCell><asp:Label ID="lblHeader" runat="server" Text="Employee Details"></asp:Label></asp:TableHeaderCell></asp:TableHeaderRow>
     <asp:TableRow ID="TableRow6" runat="server"  >
     
        <asp:TableCell ><asp:Label ID="lblEmployeeID" runat="server" Text="EmployeeID"></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtEmployeeID" runat="server" ReadOnly="true"></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow2" runat="server" >
        <asp:TableCell ><asp:Label ID="lblFirstName" runat="server" Text="FirstName" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtFirstName" runat="server" MaxLength=10 ></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server" >
        <asp:TableCell ><asp:Label ID="lblLastName" runat="server" Text="LastName" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtLastName" runat="server" MaxLength=20></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="lblddlTtlcrtsy" runat="server">
        <asp:TableCell ><asp:Label ID="Label1" runat="server" Text="TitleOfCourtesy" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:DropDownList ID="ddlTtlcrtsy" runat="server">
        <asp:ListItem  Text="Mr." Value="Mr."></asp:ListItem>
        <asp:ListItem Text="Mrs." Value="Mrs."></asp:ListItem>
        <asp:ListItem Text="Ms." Value="Ms."></asp:ListItem>
        <asp:ListItem Text="Dr." Value="Dr."></asp:ListItem>
        </asp:DropDownList> 
         </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow runat="server">
        <asp:TableCell ><asp:Label ID="lblTitle" runat="server" Text="Title"  ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:DropDownList ID="ddlTitle" runat="server">
        <asp:ListItem  Text="Sales Representative" Value="Sales Representative"></asp:ListItem>
        <asp:ListItem Text="Vice President, Sales" Value="Vice President, Sales"></asp:ListItem>
        <asp:ListItem Text="Sales Manager" Value="Sales Manager"></asp:ListItem>
        <asp:ListItem Text="Inside Sales Coordinator" Value="Inside Sales Coordinator"></asp:ListItem>
        </asp:DropDownList> 
        
         </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow1" runat="server">
        <asp:TableCell ><asp:Label ID="lblBirthDate" runat="server" Text="BirthDate" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtBirthDate" runat="server" ReadOnly="true" ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
         <asp:TableRow ID="TableRow3" runat="server">
        <asp:TableCell ><asp:Label ID="lblHireDate" runat="server" Text="HireDate" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtHireDate" runat="server"  ReadOnly="true"></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow4" runat="server">
        <asp:TableCell ><asp:Label ID="lblAddress" runat="server" Text="Address" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtAddress" runat="server" MaxLength=60  ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow5" runat="server">
        <asp:TableCell ><asp:Label ID="lblCity" runat="server" Text="City" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtCity" runat="server" MaxLength=15 ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
         <asp:TableRow ID="TableRow7" runat="server">
        <asp:TableCell ><asp:Label ID="lblRegion" runat="server" Text="Region" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtRegion" runat="server" MaxLength=15></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow14" runat="server">
        <asp:TableCell ><asp:Label ID="lblPostalCode" runat="server" Text="PostalCode" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtPostalCode" runat="server" MaxLength=10 ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow15" runat="server">
        <asp:TableCell ><asp:Label ID="lblCountry" runat="server" Text="Country" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtCountry" runat="server" MaxLength=15 ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow8" runat="server">
        <asp:TableCell ><asp:Label ID="lblHomePhone" runat="server" Text="HomePhone" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtHomePhone" runat="server" MaxLength=24 ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow9" runat="server">
        <asp:TableCell ><asp:Label ID="lblExtension" runat="server" Text="Extension" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtExtension" runat="server" MaxLength=4 ></asp:TextBox> </asp:TableCell>  
        </asp:TableRow>
         
         <asp:TableRow ID="TableRow11" runat="server">
        <asp:TableCell ><asp:Label ID="lblNotes" runat="server" Text="Notes" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtNotes" runat="server" ></asp:TextBox> </asp:TableCell>  
        </asp:TableRow>
         <asp:TableRow ID="TableRow12" runat="server">
        <asp:TableCell ><asp:Label ID="lblReportsTo" runat="server" Text="ReportsTo" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtReportsTo" runat="server" ></asp:TextBox> </asp:TableCell>  
        </asp:TableRow>
         
        <asp:TableRow ID="TableRow16" runat="server">
        <asp:TableCell >
            <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" /></asp:TableCell>
            <asp:TableCell ><asp:Button ID="btnReset" runat="server" Text="Reset"  onclick="btnReset_Click"  />
            <asp:Button ID="btnBack" runat="server" Text="Back" onclick="btnBack_Click" />
    </asp:TableCell>
        </asp:TableRow>
        
         
    </asp:Table>
    </asp:Panel>
    <cc1:CalendarExtender ID="calDOB" TargetControlID="txtBirthDate" runat="server" >    
    </cc1:CalendarExtender>
     <cc1:CalendarExtender ID="calHireDate" TargetControlID="txtHireDate" runat="server" >    
    </cc1:CalendarExtender>
    </form>
</body>
</html>
