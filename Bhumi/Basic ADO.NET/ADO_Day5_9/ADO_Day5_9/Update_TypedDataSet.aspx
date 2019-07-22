<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Update_TypedDataSet.aspx.cs" Inherits="ADO_Day5_9.Update_TypedDataSet" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Update_TypedDataSet</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style2
        {
            height: 23px;
        }
        .style3
        {
            height: 23px;
            width: 170px;
        }
        .style4
        {
        }
        .style7
        {
            height: 23px;
            width: 338px;
        }
        .style8
        {
            width: 338px;
        }
        .style9
        {
            height: 23px;
            width: 537px;
        }
        .style10
        {
            width: 537px;
        }
        .style11
        {
            width: 170px;
        }
        .style12
        {
            font-weight: bold;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div align="center">
    <asp:Label ID="LblEmployeeID" runat="server" ForeColor="Red" Visible="false">*Please Select Employee Id</asp:Label>
    <h3><asp:Label runat="server">Employee Details</asp:Label></h3>
        <table class="style1">
            <tr>
                <td class="style9">
                    </td>
                <td class="style3">
                    <asp:Label ID="LblHEmployeeID" runat="server" CssClass="style12" Text="Employee ID"></asp:Label>
                </td>
                <td class="style7">
                    <asp:DropDownList ID="DdlHEmployeeID" runat="server" AppendDataBoundItems="True" 
                        AutoPostBack="True" 
                        onselectedindexchanged="DdlHEmployeeID_SelectedIndexChanged">
                        <asp:ListItem Value="0" Text="---SELECT---"></asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td class="style2">
                    </td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style11">
                    <asp:Label ID="LblHFirstName" runat="server" CssClass="style12" Text="First Name"></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="TxtHFirstName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFirstname" runat="server" 
                        ErrorMessage="Enter FirstName" ControlToValidate="TxtHFirstName" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style11">
                    <asp:Label ID="LblHLastName" runat="server" CssClass="style12" Text="LastName"></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="TxtHLastName" runat="server"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                        ErrorMessage="Enter LastName" ControlToValidate="TxtHLastName" 
                        ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style11">
                    <asp:Label ID="LblHHomePhone" runat="server" CssClass="style12" Text="Home Phone"></asp:Label>
                </td>
                <td class="style8">
                    <asp:TextBox ID="TxtHHomePhone" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="rgxvPhoneNo" runat="server" 
                        ControlToValidate="TxtHHomePhone" ErrorMessage="Invalid Phone No" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="^(\([0-9]|[0-9])(\d{2}|\d{2}\))(-|.|\s)?\d{3}(-|.|\s)?\d{4}$"></asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                    &nbsp;</td>
                <td class="style3">
                    <asp:Label ID="LblHCity" runat="server" CssClass="style12" Text="City"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="TxtHCity" runat="server"></asp:TextBox>
                </td>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                    </td>
                <td class="style3">
                    <asp:Label ID="LblHPostalCode" runat="server" CssClass="style12" Text="Postal Code"></asp:Label>
                </td>
                <td class="style7">
                    <asp:TextBox ID="TxtHPostalCode" runat="server"></asp:TextBox>
                    <asp:RegularExpressionValidator ID="rgxvPostalCode" runat="server" 
                        ControlToValidate="TxtHPostalCode" ErrorMessage="Invalid Postal Code" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="\d{6}"></asp:RegularExpressionValidator>
                </td>
                <td class="style2">
                    </td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style11">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style10">
                    &nbsp;</td>
                <td class="style4" colspan="2">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="BtnHUpdate" runat="server" Text="Update" 
                        onclick="BtnHUpdate_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
