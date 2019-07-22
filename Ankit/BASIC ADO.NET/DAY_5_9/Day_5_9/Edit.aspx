<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Day_5_9.Edit" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc2" %>  

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Edit</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="lblUpdate" runat="server" Visible="false" ></asp:Label>
    </div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:Panel ID="Panel1" runat="server" ScrollBars="Auto" Height=560 Width=1350>
    <asp:Table ID="tblDefault" runat="server" HorizontalAlign="Center" BorderWidth="1" BorderColor="Black" >
    <asp:TableHeaderRow ID=Head1 runat="server" ><asp:TableHeaderCell><asp:Label ID="lblHeader" runat="server" Text="Employee Details"></asp:Label></asp:TableHeaderCell></asp:TableHeaderRow>
     <asp:TableRow ID="Tblrow6" runat="server"  >
     
        <asp:TableCell ><asp:Label ID="lblEmployeeID" runat="server" Text="EmployeeID"></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtEmployeeID" runat="server" ReadOnly="true"></asp:TextBox> </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="Tblrow" runat="server" >
        <asp:TableCell ><asp:Label ID="lblFirstName" runat="server" Text="FirstName" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtFirstName" runat="server"  ></asp:TextBox></asp:TableCell><asp:TableCell>
        
            <asp:RequiredFieldValidator ID="reqFN" runat="server" ErrorMessage="Please enter FirstName"
             ControlToValidate="txtFirstName" Display="Dynamic"></asp:RequiredFieldValidator>
              
          <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
            ControlToValidate="txtFirstName"
             ErrorMessage="FirstName should be less than 10 characters"
            ValidationExpression="[a-zA-Z]{1,10}."  Display="Dynamic" /> 
                
        </asp:TableCell>  
        </asp:TableRow>
        
        <asp:TableRow ID="Tblrow1" runat="server" >
        <asp:TableCell ><asp:Label ID="lblLastName" runat="server" Text="LastName" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtLastName" runat="server" MaxLength=20></asp:TextBox> </asp:TableCell>
        <asp:TableCell>
             <asp:RegularExpressionValidator ID="valLastName" ControlToValidate="txtLastName" runat="server" 
             ErrorMessage="You can not enter more than 20 characters" Display="Dynamic" ValidationExpression= "[a-zA-Z]{1,20}."></asp:RegularExpressionValidator>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Please enter LastName"
             ControlToValidate="txtLastName" Display="Dynamic"></asp:RequiredFieldValidator>
         </asp:TableCell>  
        </asp:TableRow>
        <asp:TableRow ID="lblddlTtlcrtsy" runat="server">
        <asp:TableCell ><asp:Label ID="Label1" runat="server" Text="TitleOfCourtesy" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:DropDownList ID="ddlTtlcrtsy" Width="125" runat="server">
        <asp:ListItem  Text="Mr." Value="Mr."></asp:ListItem>
        <asp:ListItem Text="Mrs." Value="Mrs."></asp:ListItem>
        <asp:ListItem Text="Ms." Value="Ms."></asp:ListItem>
        <asp:ListItem Text="Dr." Value="Dr."></asp:ListItem>
        </asp:DropDownList> 
         </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="Tblrow2" runat="server">
        <asp:TableCell ><asp:Label ID="lblTitle" runat="server" Text="Title"  ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:DropDownList ID="ddlTitle" runat="server" Width="125">
        <asp:ListItem  Text="Sales Representative" Value="Sales Representative"></asp:ListItem>
        <asp:ListItem Text="Vice President, Sales" Value="Vice President, Sales"></asp:ListItem>
        <asp:ListItem Text="Sales Manager" Value="Sales Manager"></asp:ListItem>
        <asp:ListItem Text="Inside Sales Coordinator" Value="Inside Sales Coordinator"></asp:ListItem>
        </asp:DropDownList> 
        
         </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow ID="Tblrow3" runat="server">
        <asp:TableCell ><asp:Label ID="lblBirthDate" runat="server" Text="BirthDate" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtBirthDate" runat="server" ReadOnly="true" ></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
         <asp:TableRow ID="Tblrow4" runat="server">
        <asp:TableCell ><asp:Label ID="lblHireDate" runat="server" Text="HireDate" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtHireDate" runat="server"  ReadOnly="true"></asp:TextBox> </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="Tblrow5" runat="server">
        <asp:TableCell ><asp:Label ID="lblAddress" runat="server" Text="Address" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtAddress" runat="server"   ></asp:TextBox> </asp:TableCell>
         <asp:TableCell>
             <asp:RegularExpressionValidator ID="valAddress" ControlToValidate="txtAddress" runat="server" 
             ErrorMessage="You can not enter more than 60 characters" Display="Dynamic" ValidationExpression= ".{1,60}."></asp:RegularExpressionValidator>
         </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="Tblro" runat="server">
        <asp:TableCell ><asp:Label ID="lblCity" runat="server" Text="City" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtCity" runat="server"  ></asp:TextBox> </asp:TableCell>        
        <asp:TableCell>
             <asp:RegularExpressionValidator ID="valCity" ControlToValidate="txtCity" runat="server" 
             ErrorMessage="You can not enter more than 15 characters" Display="Dynamic" ValidationExpression= "[a-zA-Z]{1,15}."></asp:RegularExpressionValidator>
         </asp:TableCell>  
        </asp:TableRow>
         <asp:TableRow ID="Tblrow7" runat="server">
        <asp:TableCell ><asp:Label ID="lblRegion" runat="server" Text="Region" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtRegion" runat="server" ></asp:TextBox> </asp:TableCell>  
         <asp:TableCell>
             <asp:RegularExpressionValidator ID="valRegion" ControlToValidate="txtRegion" runat="server" 
             ErrorMessage="You can not enter more than 15 characters" Display="Dynamic" ValidationExpression= "[a-zA-Z]{1,15}."></asp:RegularExpressionValidator>
         </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="Tblrow14" runat="server">
        <asp:TableCell ><asp:Label ID="lblPostalCode" runat="server" Text="PostalCode" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtPostalCode" runat="server"  ></asp:TextBox> </asp:TableCell>  
          <asp:TableCell>
             <asp:RegularExpressionValidator ID="valPostalCode" Display="Dynamic" ControlToValidate="txtPostalCode" runat="server" 
             ErrorMessage="You can not enter more than 10 characters" ValidationExpression= "[0-9]{1,10}."></asp:RegularExpressionValidator>
         </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="Tblrow15" runat="server">
        <asp:TableCell ><asp:Label ID="lblCountry" runat="server" Text="Country" ></asp:Label></asp:TableCell>
         <asp:TableCell ><asp:TextBox ID="txtCountry" runat="server"  ></asp:TextBox> </asp:TableCell>  
          <asp:TableCell>
             <asp:RegularExpressionValidator ID="valCountry" Display="Dynamic" ControlToValidate="txtCountry" runat="server" 
             ErrorMessage="You can not enter more than 15 characters" ValidationExpression= "[a-zA-Z]{1,15}."></asp:RegularExpressionValidator>
         </asp:TableCell>        
        </asp:TableRow>
        <asp:TableRow ID="Tblrow8" runat="server">
        <asp:TableCell ><asp:Label ID="lblHomePhone" runat="server" Text="HomePhone" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtHomePhone" runat="server"  ></asp:TextBox> </asp:TableCell> 
         <asp:TableCell>
             <asp:RegularExpressionValidator ID="valHomePhone" Display="Dynamic" ControlToValidate="txtHomePhone" runat="server" 
             ErrorMessage="You can not enter more than 24 characters" ValidationExpression= "[0-9]{1,24}."></asp:RegularExpressionValidator>
         </asp:TableCell>         
        </asp:TableRow>
        <asp:TableRow ID="Tblrow9" runat="server">
        <asp:TableCell ><asp:Label ID="lblExtension" runat="server" Text="Extension" ></asp:Label></asp:TableCell> 
        <asp:TableCell ><asp:TextBox ID="txtExtension" runat="server"  ></asp:TextBox> </asp:TableCell> 
         <asp:TableCell>
             <asp:RegularExpressionValidator ID="valExtension" ControlToValidate="txtExtension" runat="server" 
             ErrorMessage="You can not enter more than 4 characters" Display="Dynamic" ValidationExpression= "[0-9]{1,4}."></asp:RegularExpressionValidator>
         </asp:TableCell>   
        </asp:TableRow>
         
         <asp:TableRow ID="Tblrow11" runat="server">
        <asp:TableCell ><asp:Label ID="lblNotes" runat="server" Text="Notes" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtNotes" runat="server" ></asp:TextBox> </asp:TableCell>  
        </asp:TableRow>
         <asp:TableRow ID="Tblrow12" runat="server">
        <asp:TableCell ><asp:Label ID="lblReportsTo" runat="server" Text="ReportsTo" ></asp:Label></asp:TableCell> <asp:TableCell ><asp:TextBox ID="txtReportsTo" runat="server" ></asp:TextBox> </asp:TableCell>  
         <asp:TableCell>
             <asp:RegularExpressionValidator ID="valReportsTo" ControlToValidate="txtReportsTo" runat="server" 
             ErrorMessage="You  enter number only" Display="Dynamic" ValidationExpression= "[0-9]"></asp:RegularExpressionValidator>
         </asp:TableCell>  
        </asp:TableRow>
         
        <asp:TableRow ID="Tblrow16" runat="server">
        <asp:TableCell >
            <asp:Button ID="btnAdd" runat="server" Text="Add" onclick="btnAdd_Click" /></asp:TableCell>
            <asp:TableCell ><%--<asp:Button ID="btnReset" runat="server" Text="Reset"  onclick="btnReset_Click"  />--%>
                <input id="Reset1" type="reset" value="reset" />
    </asp:TableCell>
        </asp:TableRow>
        
         
    </asp:Table>
    </asp:Panel>
    <cc2:CalendarExtender ID="calDOB" TargetControlID="txtBirthDate" runat="server" >    
    </cc2:CalendarExtender>
    <cc2:CalendarExtender ID="calHireDate" TargetControlID="txtHireDate" runat="server" >    
    </cc2:CalendarExtender>
   
    </form>
</body>
</html>
