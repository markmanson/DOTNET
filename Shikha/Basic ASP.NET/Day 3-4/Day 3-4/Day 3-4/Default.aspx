<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Day_3_4._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>AddItem WebPage</title>
    <link rel="stylesheet" type="text/css" href="PageStyle.css">
   
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center">
            <tr>
                <td class="style3">
                </td>
                <td class="style7">
                    <asp:TextBox ID="txtTextBox1" runat="server" Height="28px"></asp:TextBox>
                </td>
                <td class="style16">
                    &nbsp;</td>
                <td class="style13">
                    <asp:Button ID="btnAddItem" runat="server" Height="34px" Text="AddList" 
                        Width="114px" onclick="btnAddItem_Click" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8" rowspan="4">
                    <asp:ListBox ID="listLeft" runat="server" Height="124px" Width="121px"></asp:ListBox>
                </td>
                <td class="style17" rowspan="2">
                    <asp:Button ID="btnMoveRight" runat="server" BackColor="#99CCFF" Font-Bold="True" 
                        Text="&gt;" Width="54px" onclick="btnMoveRight_Click" />
                </td>
                <td class="style14" rowspan="4">
                    <asp:ListBox ID="listRight" runat="server" Height="126px" Width="117px"></asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style17" rowspan="2">
                    <asp:Button ID="btnMoveLeft" runat="server" BackColor="#99CCFF" Font-Bold="True" 
                        Text="&lt;" Width="55px" onclick="btnMoveLeft_Click" />
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style9">
                </td>
                <td class="style11">
                    <asp:Button ID="btnRemove" runat="server" Height="31px" Text="RemoveItems" 
                        Width="107px" onclick="btnRemove_Click"  />
                </td>
                <td class="style18">
                </td>
                <td class="style15">
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style17">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    &nbsp;</td>
                <td class="style17">
                    &nbsp;</td>
                <td class="style14">
                    &nbsp;</td>
            </tr>
        </table>
 
    </div>
    </form>
</body>
</html>
