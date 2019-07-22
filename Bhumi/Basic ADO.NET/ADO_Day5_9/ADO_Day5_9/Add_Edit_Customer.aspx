<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Add_Edit_Customer.aspx.cs" Inherits="ADO_Day5_9.Add_Edit_Customer" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add_Edit_Customer</title>
    <style type="text/css">
        .style1
        {
            width: 100%;
        }
        .style4
        {
            width: 130px;
        }
        .style6
        {
            width: 302px;
        }
        .style7
        {
            font-weight: bold;
        }
        .style8
        {
            width: 302px;
            height: 66px;
        }
        .style9
        {
            height: 66px;
        }
        .style10
        {
        }
        .style11
        {
            width: 133px;
        }
        .style12
        {
            width: 302px;
            height: 26px;
        }
        .style13
        {
            width: 133px;
            height: 26px;
        }
        .style14
        {
            width: 130px;
            height: 26px;
        }
        .style15
        {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <table class="style1">
        <tr>
            <td class="style8">
                <h2>&nbsp;</h2>
                </td>
            <td colspan="2" align="center" class="style9">
                &nbsp;</td>
            <td class="style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style8">
                <h2>&nbsp;</h2>
                </td>
            <td colspan="2" align="center" class="style9">
                <h2><asp:Label ID="LblHHeader" runat="server" Text="Customers Details"></asp:Label></h2>
            </td>
            <td class="style9">
                </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="LblHCustomerID" runat="server" Text="CustomerID" 
                    CssClass="style7"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TxtCustomerID" runat="server" MaxLength="5"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCustomerID" runat="server" 
                    ErrorMessage="Enter CustomerID" ForeColor="Red" 
                    ControlToValidate="TxtCustomerID"></asp:RequiredFieldValidator></td>
        </tr>
        <tr>
            <td class="style12">
                </td>
            <td class="style13">
                <asp:Label ID="LblHCompanyName" runat="server" Text="Comapany Name" 
                    CssClass="style7"></asp:Label>
            &nbsp;</td>
            <td class="style14">
                <asp:TextBox ID="TxtCompanyName" runat="server"></asp:TextBox>
            </td>
            <td class="style15">
                <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" 
                    ErrorMessage="Enter Comapany Name" ForeColor="Red" 
                    ControlToValidate="TxtCompanyName"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="LblHContactTitle" runat="server" Text="Contact Title" 
                    CssClass="style7"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TxtContactTitle" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="LblHCity" runat="server" Text="City" CssClass="style7"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TxtCity" runat="server"></asp:TextBox>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="LblHPostalCode" runat="server" Text="Postal Code" 
                    CssClass="style7"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TxtPostalCode" runat="server"></asp:TextBox>
                
            </td>
            <td>
                <asp:RegularExpressionValidator ID="RgxvPostalCode" runat="server" 
                        ControlToValidate="TxtPostalCode" ErrorMessage="Invalid Postal Code" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="\d{6}"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="LblHPhone" runat="server" Text="Phone No." CssClass="style7"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TxtPhoneNo" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RegularExpressionValidator ID="rfvPhoneNo" runat="server" 
                        ControlToValidate="TxtPhoneNo" ErrorMessage="Invalid Phone No" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="^(\([0-9]|[0-9])(\d{2}|\d{2}\))(-|.|\s)?\d{3}(-|.|\s)?\d{4}$"></asp:RegularExpressionValidator></td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11">
                <asp:Label ID="LblHFax" runat="server" Text="Fax No." CssClass="style7"></asp:Label>
            </td>
            <td class="style4">
                <asp:TextBox ID="TxtFax" runat="server"></asp:TextBox>
                </td>
                <td>
                <asp:RegularExpressionValidator ID="rgxvFax" runat="server" 
                        ControlToValidate="TxtFax" ErrorMessage="Invalid Fax No" ForeColor="Red" 
                        SetFocusOnError="True" ValidationExpression="^(\([0-9]|[0-9])(\d{2}|\d{2}\))(-|.|\s)?\d{3}(-|.|\s)?\d{4}$"></asp:RegularExpressionValidator></td>         
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11" align="center">
                &nbsp;</td>
            <td class="style4" align="center">
                &nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style11" align="center">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="BtnHUpdate" runat="server" Text="Update" CssClass="style7" 
                    Visible="False" onclick="BtnHUpdate_Click" />
            </td>
            <td class="style4" align="center">
                <asp:Button ID="BtnHCancel" runat="server" Text="Cancel" CssClass="style7" 
                    Visible="False" onclick="BtnHCancel_Click" CausesValidation="False" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="style6">
                &nbsp;</td>
            <td class="style10" colspan="2" align="center">
                <asp:Button ID="BtnHAdd" runat="server" Text="ADD" CssClass="style7" 
                    Visible="False" Width="30%" onclick="BtnHAdd_Click" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <div>
    
    </div>
    </form>
</body>
</html>
