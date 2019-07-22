<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserDetails_Form.aspx.cs" Inherits="ASP_Day5.UserDetails_Form" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<script type="text/javascript">

    function checkDate(sender, args) 
    {
        if (sender._selectedDate > new Date()) 
        {
            alert("You cannot select a Future Date!");
            sender._textbox.set_Value("");          
        }
    }
    </script>

<style type="text/css">
    .table1
    {
        background-color:#A9A9A9;
        margin-top: 70px;
        margin-bottom: 100px;
        margin-left: 50px;
        border: 2px solid black;
    }
    .td1
    {
        border: 2px solid black;
        background-color:White;
    }        
</style>

    <title>UserDetails_Form</title>
</head>
<body>
    <form id="FrmUserDetails_Form" runat="server" defaultfocus="TxtName">
    <div align="center">
    <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
    <table width="30%" cellpadding="1" class="table1">
        
    <caption><h3 align="center">Exercise no : 4</h3></caption>
        <tr>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblName" Text="Name"></asp:Label>
                <font color="Red">*</font>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtName"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ID="RfvName" ControlToValidate="TxtName" ErrorMessage="Enter Name" Text="*" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ID="RgxvName" ControlToValidate="TxtName" ValidationExpression="^[^0-9]+$" ErrorMessage="Digit Not Allowed as Name" Text="*" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblSex" Text="Sex"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtSex" MaxLength="1"></asp:TextBox>                                
                    <asp:RegularExpressionValidator runat="server" ID="RgxvSex" ControlToValidate="TxtSex" ValidationExpression="^[MmFf]+$" ErrorMessage="Enter Sex as M/F" Text="*" Display="Dynamic" ForeColor="Red"></asp:RegularExpressionValidator>
            </td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblEmail" Text="Email Id"></asp:Label><font color="Red">*</font>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtEmail"></asp:TextBox>                
                <asp:RequiredFieldValidator runat="server" ID="RfvEmailID" ControlToValidate="TxtEmail" ErrorMessage="Enter Email ID" Text="*" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ID="RgxvEmailID" 
                    ControlToValidate="TxtEmail" ErrorMessage="Invalid EmailID" ForeColor="Red" Text="*" Display="Dynamic" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                <br />
            </td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblDOB" Text="DOB"></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtDOB" MaxLength="10"></asp:TextBox>
                <asp:CalendarExtender ID="TxtDOB_CalendarExtender" runat="server" 
                    TargetControlID="TxtDOB" Format="yyyy-MM-dd" OnClientDateSelectionChanged="checkDate"></asp:CalendarExtender>
            </td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblPassword" Text="Password"></asp:Label><font color="Red">*</font>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtPassword" TextMode="Password"></asp:TextBox>                
                <asp:RequiredFieldValidator runat="server" ID="RfvPassword" ControlToValidate="TxtPassword" ErrorMessage="Enter Password" Text="*" Display="Dynamic" ForeColor="Red"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ID="RgxvPassword" 
                    ControlToValidate="TxtPassword" 
                    ErrorMessage="Password Content minimum 8 characters with two Digit" ForeColor="Red" Text="*" Display="Dynamic"
                    ValidationExpression="^(?=(.*\d){2})[0-9a-zA-Z!@#$%]{8,}$"></asp:RegularExpressionValidator>
                    <br />
            </td>           
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblFaxNo" Text="Fax No."></asp:Label>
            </td>
            <td>
                <asp:TextBox runat="server" ID="TxtFaxNo" MaxLength="13"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ID="RgxvFaxNo" 
                    ControlToValidate="TxtFaxNo" ErrorMessage="Valid Format for Fax No: (###)###-####" ForeColor="Red" Text="*" Display="Dynamic"
                    ValidationExpression="^\(?\d{3}[\)\-]?\d{3}[\-]?\d{4}$"></asp:RegularExpressionValidator>
            </td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                <asp:Label runat="server" ID="LblMarried" Text="Married"></asp:Label><font color="Red">*</font>
            </td>
            <td>
                <asp:DropDownList runat="server" ID="DdlMarried">
                    <asp:ListItem Value="0">SELECT</asp:ListItem>
                    <asp:ListItem Value="1">Yes</asp:ListItem>
                    <asp:ListItem Value="2">No</asp:ListItem>
                </asp:DropDownList>
                <asp:RequiredFieldValidator runat="server" ID="RfvMarried" ControlToValidate="DdlMarried" InitialValue="0" ErrorMessage="Please Select Yes/No" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>                
            </td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>
                    <asp:Label runat="server" ID="LblLanguage" Text="Languages Known"></asp:Label><font color="Red">*</font>
            </td>
            <td>
                <asp:ListBox runat="server" ID="LstLanguage" SelectionMode="Multiple" 
                    Width="130px">
                    <asp:ListItem Value="0">Gujarati</asp:ListItem>
                    <asp:ListItem Value="1">Hindi</asp:ListItem>
                    <asp:ListItem Value="2">English</asp:ListItem>
                    <asp:ListItem Value="3">Japanese</asp:ListItem>
                </asp:ListBox>
                <asp:RequiredFieldValidator runat="server" ID="RfvLanguage" ControlToValidate="LstLanguage" InitialValue="" ErrorMessage="Please Select at least One Language" ForeColor="Red" Text="*" Display="Dynamic"></asp:RequiredFieldValidator>
            </td>            
        </tr>
        <tr>
            <td>            
                &nbsp;</td>
            <td>                
                &nbsp;</td>
            <td>
                &nbsp;</td>            
        </tr>
        <tr>
            <td>            
            </td>
            <td>                
            </td>
            <td>
                <asp:Button runat="server" ID="BtnSubmit" Text="Submit" Width="130px" 
                    style="font-weight: 700" onclick="BtnSubmit_Click"/>
            </td>            
        </tr>
        <tr>
            <td></td>
        </tr>
        <tr>   
        <td>     
        </td>
        <td class="td1" colspan="2">
            <asp:Label runat="server" ID="LblErrorSummary"
                Text="Please Fix The Following Errors:" Width="260px" 
                style="font-weight: 700"></asp:Label>
            <asp:ValidationSummary runat="server" ID="VSErrorSummary" ForeColor="Red"/>
        </td>
        <td></td>
        </tr>
        <tr>
            <td></td>
        </tr>
        </table>    
    </div>
    </form>
</body>
</html>
