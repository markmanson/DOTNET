<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditTerritories.aspx.cs" Inherits="Day_5_9.EditTerritories" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="c1" %>  

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EditTerritories</title>
</head>
<body>
    <form id="form1" runat="server">
    <div><asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    
    </div>
    
    <asp:Table ID="tblEditEmpTerr" runat="server" HorizontalAlign="Center" BorderColor="Black" BorderWidth="1">
        
        <asp:TableHeaderRow>
        <asp:TableHeaderCell><asp:Label ID="lblHeader" Text="ADD DETAILS" runat="server"></asp:Label>
        </asp:TableHeaderCell>
        </asp:TableHeaderRow>   
    
        <asp:TableRow ID="TableRo6" runat="server"  >     
        <asp:TableCell ><asp:Label ID="lblEmployeeID" runat="server" Text="EmployeeID"></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtEmployeeID" runat="server" ReadOnly="true"></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRo2" runat="server" >
        <asp:TableCell ><asp:Label ID="lblFirstName" runat="server" Text="FirstName" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtFirstName" runat="server" MaxLength=10 ></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow1" runat="server" >
        <asp:TableCell ><asp:Label ID="lblLastName" runat="server" Text="LastName" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtLastName" runat="server" MaxLength=20></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="lblddlTtlcrtsy" runat="server">
        <asp:TableCell ><asp:Label ID="Label1" runat="server" Text="TitleOfCourtesy" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:DropDownList ID="ddlTtlcrtsy" Width="130" runat="server">
        <asp:ListItem  Text="Mr." Value="Mr."></asp:ListItem>
        <asp:ListItem Text="Mrs." Value="Mrs."></asp:ListItem>
        <asp:ListItem Text="Ms." Value="Ms."></asp:ListItem>
        <asp:ListItem Text="Dr." Value="Dr."></asp:ListItem>
        </asp:DropDownList> 
         </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow2" runat="server">
        <asp:TableCell ><asp:Label ID="lblTitle" runat="server" Text="Title"  ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:DropDownList ID="ddlTitle" runat="server" Width="130">
        <asp:ListItem  Text="Sales Representative" Value="Sales Representative"></asp:ListItem>
        <asp:ListItem Text="Vice President, Sales" Value="Vice President, Sales"></asp:ListItem>
        <asp:ListItem Text="Sales Manager" Value="Sales Manager"></asp:ListItem>
        <asp:ListItem Text="Inside Sales Coordinator" Value="Inside Sales Coordinator"></asp:ListItem>
        </asp:DropDownList> 
        
         </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="TableRow3" runat="server">
        <asp:TableCell ><asp:Label ID="lblBirthDate" runat="server" Text="BirthDate" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtBirthDate" runat="server" ReadOnly="true" ></asp:TextBox> </asp:TableCell>          
                      
        </asp:TableRow>
       
         <asp:TableRow ID="TableRow4" runat="server">
        <asp:TableCell ><asp:Label ID="lblHireDate" runat="server" Text="HireDate" ></asp:Label></asp:TableCell>
        <asp:TableCell ><asp:TextBox ID="txtHireDate" runat="server"  ReadOnly="true"></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow5" runat="server">
        <asp:TableCell ><asp:Label ID="lblAddress" runat="server" Text="Address" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtAddress" runat="server" MaxLength=60  ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="TableRow6" runat="server">
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
         
         <asp:TableRow>
         <asp:TableCell><asp:Label ID="lblDes" runat="server" Text="Description"></asp:Label>
         </asp:TableCell>
         <asp:TableCell><asp:ListBox ID="lstDes" runat="server" DataTextField="TerritoryDescription" SelectionMode="Multiple" Width="130"></asp:ListBox>
         </asp:TableCell>
         </asp:TableRow>
         
        <asp:TableRow ID="TableRow16" runat="server">
        <asp:TableCell ><asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click"  />
            </asp:TableCell>
            <asp:TableCell >
            <asp:Button ID="btnBack" runat="server" Text="Back" />
    </asp:TableCell>
        </asp:TableRow>   
    
    </asp:Table>
    <c1:CalendarExtender ID="cal1" runat="server" TargetControlID="txtHireDate"></c1:CalendarExtender>
    
    <c1:CalendarExtender ID="cal2" runat="server" TargetControlID="txtBirthDate" ></c1:CalendarExtender>
    
    </form>
</body>
</html>
