<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_5._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="C" %>  
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>UserDetails</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
   
<asp:table runat="server" HorizontalAlign="Center" BorderColor="Black" BorderWidth="2px" BackColor="BlanchedAlmond">
    <asp:TableHeaderRow runat="server">
        <asp:TableHeaderCell ColumnSpan="2">
            <asp:Label ID="lblHeader" runat="server" Text="User Information"></asp:Label>
        </asp:TableHeaderCell>
    </asp:TableHeaderRow>
    
    <asp:TableRow runat="server" >
    <asp:TableCell>
        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
         <asp:RequiredFieldValidator ID="Name" ControlToValidate="txtName" ErrorMessage="Name can't be blank" Text="*" runat="server"></asp:RequiredFieldValidator>
             </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblSex" runat="server" Text="Sex"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
         <asp:RegularExpressionValidator   ID="ValSex" ControlToValidate="txtSex" ValidationExpression="[mMfF]"  ErrorMessage="Write F or M only into Sex" runat="server" Display="None"></asp:RegularExpressionValidator>

    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblEmail" runat="server" Text="Email"></asp:Label>        
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="valEmail" ControlToValidate="txtEmail" ErrorMessage="Email can't be blank" Text="*" runat="server"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="regvalEmail" ValidationExpression=".*@.{2,}\..{2,}" ControlToValidate="txtEmail" ErrorMessage="Email is not valid" Display="None" runat="server"></asp:RegularExpressionValidator>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblDOB" runat="server" Text="Date of Birth"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:TextBox ID="txtDOB" runat="server"></asp:TextBox>
         <C:CalendarExtender ID="CalDOB" TargetControlID="txtDOB" runat="server" Format="yyyy/MM/dd"></C:CalendarExtender>             
          <asp:CompareValidator ID="CmpvDOB" runat="server" ErrorMessage="Date of birth Less than Current date"
                            SetFocusOnError="true" ControlToValidate="txtDOB" Display="None" Type="Date"
                            Operator="LessThan"></asp:CompareValidator>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblPass" runat="server" Text="Password"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:TextBox ID="txtPass" runat="server" TextMode="Password" ></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqvalPass" runat="server" ControlToValidate="txtPass" ErrorMessage="Password can not be blank" Text="*" Display="None"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="regvalPass1" runat="server" ControlToValidate="txtPass" ErrorMessage="Password should contain atleast 2 numeric values and minimum length is 8 " ValidationExpression=	"(?!^(\d{2}).*$)^([a-zA-Z0-9]{8})$" Display="None"></asp:RegularExpressionValidator>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblFax" runat="server" Text="Fax"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:TextBox ID="txtFax" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="regvalFax" runat="server" ControlToValidate="txtFax" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ErrorMessage="Fax should be in the form of (###)###-####" Display="None"></asp:RegularExpressionValidator>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblMarried" runat="server" Text="Married"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:DropDownList ID="ddlMarried" runat="server" Width="120" >
            <asp:ListItem Text="Yes"></asp:ListItem>
            <asp:ListItem Text="No"></asp:ListItem>
        </asp:DropDownList>
            <asp:RequiredFieldValidator ID="reqvalMarried"   runat="server" ErrorMessage="Yes or No should be selected in married" Text="*" ControlToValidate="ddlMarried"></asp:RequiredFieldValidator>
    </asp:TableCell>
    </asp:TableRow>
    
    
    <asp:TableRow runat="server">
     <asp:TableCell>
        <asp:Label ID="lblLang" runat="server" Text="Language Known"></asp:Label>
    </asp:TableCell>
    
    <asp:TableCell>
        <asp:ListBox ID="lstLang" runat="server" SelectionMode="Multiple" Width="120"> 
        <asp:ListItem Text="English"></asp:ListItem>       
        <asp:ListItem Text="Hindi"></asp:ListItem>
        <asp:ListItem Text="Japanese"></asp:ListItem>
        <asp:ListItem Text="chinese"></asp:ListItem>
        <asp:ListItem Text="Spanish"></asp:ListItem>
        <asp:ListItem Text="French"></asp:ListItem>
        </asp:ListBox>      
        <asp:RequiredFieldValidator ID="reqvalLang" runat="server" ControlToValidate="lstLang" Display="None" ErrorMessage="Atleast one language should be selected" ></asp:RequiredFieldValidator>
    </asp:TableCell>
    </asp:TableRow>
    
    <asp:TableRow runat="server">
    <asp:TableCell HorizontalAlign="Center" ColumnSpan="2">             
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" ForeColor="Blue" onclick="btnSubmit_Click" BackColor="Brown"  />
    </asp:TableCell>
    </asp:TableRow>
    </asp:table>

      
    <asp:Table ID="tblError" runat="server" HorizontalAlign="Center" >
    <asp:TableRow><asp:TableCell>
    <asp:ValidationSummary ID="ValidationSummary1"
    HeaderText="Please fix the following errors..."
    DisplayMode="BulletList"
    EnableClientScript="true" 
    runat="server"/>
    </asp:TableCell></asp:TableRow>
    </asp:Table>
   
   
    </form>
</body>
</html>
