<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Employee.aspx.cs" Inherits="ADO_Day5_9.Add_Employee" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript">

    function checkDate(sender, args) {
        if (sender._selectedDate > new Date()) {
            alert("You cannot select a Future Date!");
            sender._selectedDate = new Date();
            // set the date back to the current date
            sender._textbox.set_Value(sender._selectedDate.format(sender._format))
        }
    }
    </script>
 
    <title>Add_Employee</title>
    <style type="text/css">
        .style1
        {
            width: 97%;
        }
        .style3
        {
            width: 251px;
        }
        .style4
        {
            width: 160px;
        }
        .style5
        {
        }
        .style6
        {
            width: 378px;
        }
        .style7
        {
            width: 117px;
        }
        .style8
        {
            width: 378px;
            height: 19px;
        }
        .style9
        {
            width: 117px;
            height: 19px;
        }
        .style10
        {
            width: 251px;
            height: 19px;
        }
        .style11
        {
            width: 160px;
            height: 19px;
        }
        .style12
        {
            width: 183px;
        }
        .style13
        {
            width: 183px;
            height: 19px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server" enctype="multipart/form-data">
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="LblHHeader" runat="server" Text="<h2>Employee Details</h2>" 
                        Width="185px"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <table class="style1" cellpadding="2">                
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHSalutation" runat="server" Text="Salutation" 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td class="style12">
                <asp:DropDownList ID="ddlHSalutation" runat="server">
                        <asp:ListItem>Mr.</asp:ListItem>
                        <asp:ListItem>Mrs.</asp:ListItem>
                        <asp:ListItem>Ms.</asp:ListItem>
                    </asp:DropDownList>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHFirstname" runat="server" Text="First Name" 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="TxtHFirstName" runat="server"></asp:TextBox>
            </td>
            <td class="style4">
                <asp:RequiredFieldValidator ID="RfvFirstName" runat="server" 
                    ControlToValidate="TxtHFirstName" ErrorMessage="Enter FirstName" 
                    ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHLastName" runat="server" Text="Last Name" 
                    style="font-weight: 700"></asp:Label></td>
            <td class="style12">
                <asp:TextBox ID="TxtHLastName" runat="server"></asp:TextBox></td>
            <td class="style4">
                <asp:RequiredFieldValidator ID="RfvLastName" runat="server" 
                    ControlToValidate="TxtHLastName" ErrorMessage="Enter LastName" ForeColor="Red" 
                    SetFocusOnError="True"></asp:RequiredFieldValidator>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHBirthDate" runat="server" Text="BirthDate"  
                    style="font-weight: 700"></asp:Label></td>
            <td class="style12">
                <asp:TextBox ID="TxtHBirthDate" runat="server" MaxLength="10"></asp:TextBox>
                <asp:CalendarExtender ID="TxtHBirthDate_CalendarExtender" runat="server" OnClientDateSelectionChanged="checkDate" 
                    TargetControlID="TxtHBirthDate" Format="MM/dd/yyyy"></asp:CalendarExtender>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHCity" runat="server" Text="City" style="font-weight: 700"></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="TxtHCity" runat="server"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHCountry" runat="server" Text="Country" 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="TxtHCountry" runat="server"></asp:TextBox>
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                <asp:Label ID="LblHPhoneNo" runat="server" Text="Contact No" 
                    style="font-weight: 700"></asp:Label>
            </td>
            <td class="style12">
                <asp:TextBox ID="TxtHPhoneNo" runat="server"></asp:TextBox>
                
            </td>
            <td class="style4">
                <asp:RegularExpressionValidator ID="RgxvPhoneNo" runat="server" 
                    ControlToValidate="TxtHPhoneNo" ErrorMessage="Invalid Phone Number" ForeColor="Red" 
                    SetFocusOnError="True" ValidationExpression="^(\([0-9]|[0-9])(\d{2}|\d{2}\))(-|.|\s)?\d{3}(-|.|\s)?\d{4}$"></asp:RegularExpressionValidator>
            </td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style7">
                &nbsp;</td>
            <td class="style12">
                &nbsp;</td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style5" colspan="2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnHAdd" runat="server" Text="ADD NEW" onclick="BtnHAdd_Click" 
                    style="font-weight: 700" />
            </td>
            <td class="style4">
                &nbsp;</td>
            <td class="style3">
                &nbsp;</td>
        </tr>
    </table>
    <div>
    
                <asp:ScriptManager ID="ScriptManager1" runat="server">
                </asp:ScriptManager>
    
    </div>
    </form>
</body>
</html>
