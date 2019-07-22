<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="DAY5Exercise._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register Form(Default)</title>
    <link href="Stylesheet.css" type="text/css" rel="Stylesheet" />
</head>
<body>
    <form id="form1" runat="server" method="post">
    <div align="center">
        <asp:Panel ID="PanelRegister" GroupingText="New User" runat="server" CssClass="Panel">
            <table class="table" align="left">
                <tr>
                    <td colspan="3">
                        <asp:Label ID="LblRegister" runat="server" CssClass="label" Text="Registration Form"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblName" runat="server" CssClass="labelControl" Text="Name" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtName" runat="server" Width="154px"></asp:TextBox>
                    </td>
                    <td class="td">
                        <asp:RequiredFieldValidator ID="RfvName" runat="server" ErrorMessage="Name Can't Be Blank"
                            Font-Bold="True" ControlToValidate="TxtName" Display="Dynamic" ToolTip="Please Enter Name"
                            SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblMFValue" runat="server" CssClass="labelControl" Text="Sex" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtMF" runat="server" Width="76px"></asp:TextBox>
                    </td>
                    <td align="left" class="td">
                        <asp:Label ID="LblSexMSG" runat="server" CssClass="lblMsg" Font-Bold="True" Height="16px"
                            Text="M/F" Width="25px"></asp:Label>
                        <asp:RegularExpressionValidator ID="RgxvSex" runat="server" ControlToValidate="TxtMF"
                            Display="Dynamic" ErrorMessage="Please Enter only M/F" Font-Bold="True" SetFocusOnError="True"
                            ValidationExpression="M|F">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblEmailId" runat="server" Text="EmailID" CssClass="labelControl"
                            Font-Bold="True"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtEmail" runat="server" Width="154px"></asp:TextBox>
                    </td>
                    <td class="td">
                        <asp:RegularExpressionValidator ID="RgxvEmail" runat="server" ControlToValidate="TxtEmail"
                            Display="Dynamic" ErrorMessage="Please enter Valid EmailId" Font-Bold="True"
                            ToolTip="Please enter Valid Email Id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
                        <asp:RequiredFieldValidator ID="RfvEmail" runat="server" ControlToValidate="TxtEmail"
                            ErrorMessage="EmailId Can't Be Blank.">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblDOB" runat="server" Text="DOB" CssClass="labelControl" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtDob" runat="server" Width="154px"></asp:TextBox>
                    </td>
                    <td class="td" align="left">
                        <asp:RegularExpressionValidator ID="RgxvDOB" runat="server" ControlToValidate="TxtDob"
                            Display="Dynamic" ErrorMessage="Enter Date in YYYY/MM/DD Format" Font-Bold="True"
                            Height="12px" SetFocusOnError="True" ValidationExpression="\d{4}/\d{1,2}/\d{1,2}">*</asp:RegularExpressionValidator>
                        <asp:Label ID="LblDOBMSG" runat="server" CssClass="lblMsg" Font-Bold="True" Width="95px"
                            Height="16px" Text="YYYY/MM/DD"></asp:Label>
                        <asp:RangeValidator ID="RvDOB" runat="server" ControlToValidate="TxtDob" Display="Dynamic"
                            ErrorMessage="Birth Date is Not Greater Than Current Date" Font-Bold="True" Height="16px"
                            SetFocusOnError="True" Type="Date">*</asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblPwd" runat="server" Text="Password" CssClass="labelControl" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtPwd" runat="server" Width="156px" TextMode="Password"></asp:TextBox>
                    </td>
                    <td class="td" align="left">
                        <asp:RequiredFieldValidator ID="RfvPassword" runat="server" ControlToValidate="TxtPwd"
                            Display="Dynamic" ErrorMessage="Password Can't be blank" Font-Bold="True" SetFocusOnError="True"
                            ToolTip="Please enter Password">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RgxvPWD" runat="server" ControlToValidate="TxtPwd"
                            ErrorMessage="Please enter only 8 Characters with atleast 2 numbers in password."
                            Font-Bold="True" SetFocusOnError="True" ValidationExpression="(?!^[0-9]*$)(?!^[a-zA-Z]*$)^([a-zA-Z0-9]{8})$"
                            Display="Dynamic">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblFax" runat="server" Text="Fax No." CssClass="labelControl" Font-Bold="True"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:TextBox ID="TxtFax" runat="server" Width="154px"></asp:TextBox>
                    </td>
                    <td class="td" align="left">
                        <asp:Label ID="LblFaxFormat" runat="server" CssClass="lblMsg" Font-Bold="True" Text="(555)222-9999"
                            Width="95px" Height="16px"></asp:Label>
                        <asp:RegularExpressionValidator ID="RgxvFAX" runat="server" ControlToValidate="TxtFax"
                            Display="Dynamic" ErrorMessage="Please enter Valid Fax Number." Font-Bold="True"
                            SetFocusOnError="True" ValidationExpression="^[01]?[- .]?(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblMarried" runat="server" CssClass="labelControl" Font-Bold="True"
                            Text="Married"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:DropDownList ID="DdlMarried" runat="server" Font-Bold="True" Height="16px" Width="154px"
                            DataValueField="Yes/No">
                            <asp:ListItem Selected="True">---Select---</asp:ListItem>
                            <asp:ListItem>Yes</asp:ListItem>
                            <asp:ListItem>No</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td class="td">
                        <asp:RegularExpressionValidator ID="RgxvLanguage" runat="server" ControlToValidate="DdlMarried"
                            ErrorMessage="Please Select Yes/No  For  Married status." Font-Bold="True" SetFocusOnError="True"
                            ValidationExpression="Yes|No">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        <asp:Label ID="LblLanguage" runat="server" CssClass="labelControl" Font-Bold="True"
                            Text="Language Known"></asp:Label>
                    </td>
                    <td class="td">
                        <asp:ListBox ID="LstLanguage" runat="server" Font-Bold="True" SelectionMode="Multiple"
                            Width="155px">
                            <asp:ListItem>English</asp:ListItem>
                            <asp:ListItem>Japanees</asp:ListItem>
                            <asp:ListItem>Hindi</asp:ListItem>
                            <asp:ListItem>Gujarati</asp:ListItem>
                        </asp:ListBox>
                    </td>
                    <td class="td">
                        <asp:RequiredFieldValidator ID="RfvLanguage" runat="server" ControlToValidate="LstLanguage"
                            Display="Dynamic" ErrorMessage="AtLeast One Language Should be Selected" Font-Bold="True"
                            SetFocusOnError="True">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        &nbsp;
                    </td>
                    <td class="td">
                    </td>
                    <td class="td">
                    </td>
                </tr>
                <tr align="center">
                    <td class="td">
                        &nbsp;
                    </td>
                    <td class="td">
                        <asp:Button ID="BtnSubmit" runat="server" Text="Submit" Width="131px" OnClick="BtnSubmit_Click" />
                    </td>
                    <td class="td" align="center">
                        <asp:Button ID="BtnReset" runat="server" CausesValidation="False" OnClick="BtnReset_Click"
                            Text="Reset" Width="131px" />
                    </td>
                </tr>
                <tr>
                    <td class="td">
                        &nbsp;
                    </td>
                    <td class="td">
                        &nbsp;
                    </td>
                    <td class="td">
                        &nbsp;
                    </td>
                </tr>
                <tr>
                    <td class="td" colspan="3" align="left">
                        <asp:ValidationSummary ID="VSErrors" runat="server" Font-Bold="True" HeaderText="Please fix this following Errors:"
                            Width="393px" BackColor="White" CssClass="labelControl" Height="78px" />
                    </td>
                </tr>
            </table>
        </asp:Panel>
    </div>
    </form>
</body>
</html>
