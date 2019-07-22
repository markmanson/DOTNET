<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CounterDefault.aspx.cs" Inherits="BASICASPNETProject.CounterDefault" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
      <title>CounterDefault</title>
    <style type="text/css">
        .style1
        {
            width: 47%;
            border-style: solid;
            border-width: 1px;
            background-color:Gray;
        }
        .style2
        {
            width: 131px;
        }
        .style3
        {
            width: 50px;
        }
        .style4
        {
            width: 107px;
        }
        .style5
        {
            width: 50px;
            height: 21px;
        }
        .style6
        {
            width: 131px;
            height: 21px;
        }
        .style7
        {
            width: 107px;
            height: 21px;
        }
        .style8
        {
            height: 21px;
        }
         .span
        {
            azimuth:center;
           color:#FF0000;
           font-size:larger;
            margin-top:auto;
           margin-left:auto;
           margin-right:auto;
           
          
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Label ID="LblErrorMessage"  CssClass="span" runat="server"></asp:Label>
    <asp:Panel ID="PnlPanel" runat="server" 
            GroupingText="Session Counter And Application Counter"  Width="428px">
        <table bgcolor="#CCCCCC" class="style1">
            <tr>
                <td class="style3">
                    <asp:Label ID="LblName"  runat="server" Text="Name:"></asp:Label>
                </td>
                <td class="style2">
                    <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
                </td>
                <td class="style4">
                    <asp:Label ID="Lblsession" runat="server" Text="Session Value:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="TxtSession" runat="server" ReadOnly="True"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    <asp:Label ID="LblCounter1" runat="server" Text="Session Counter"></asp:Label>
                </td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    <asp:Label ID="LblCounter2" runat="server" Text="Application Counter"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style5">
                    </td>
                <td class="style6">
                </td>
                <td class="style7">
                    <asp:Button ID="BtnSubmit" runat="server" onclick="BtnSubmit_Click" 
                        Text="Submit" Width="104px" />
                </td>
                <td class="style8">
                </td>
            </tr>
            <tr>
                <td class="style3">
                    &nbsp;</td>
                <td class="style2">
                    &nbsp;</td>
                <td class="style4">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
    </asp:Panel>
    </div>
    </form>
</body>

</html>
