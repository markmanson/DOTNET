<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise15.aspx.cs" Inherits="Day_14._Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EMail WebPage</title>
    <style type="text/css">
        .style1
        {
            width: 83%;
            height: 516px;
        }
        .style2
        {
            width: 51px;
        }
        .style4
        {
            width: 51px;
            height: 44px;
        }
        .style7
        {
            width: 530px;
            height: 44px;
        }
        .style8
        {
            width: 530px;
        }
        .style9
        {
            width: 51px;
            height: 58px;
        }
        .style10
        {
            width: 530px;
            height: 58px;
        }
    </style>
</head>
<body onload="fnLoad();">
<script language=javascript>

function fnLoad(){
document.getElementById('txtFrom').focus();

}
</script>
    <form id="form1" runat="server" 
    style="border-style: solid; border-color: #008080; background-color: #FFCCCC;">
    <div style="height: 546px; margin-left: 1px">

        <table class="style1">
            <tr>
                <td class="style4">
                </td>
                <td class="style7">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="ComposeMessage" Font-Bold="True" 
                        Font-Italic="True" Font-Names="Monotype Corsiva" Font-Size="XX-Large" 
                        ForeColor="#6600CC"></asp:Label>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    From :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
                        ID="txtFrom" runat="server" Width="402px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="rfvFrom" ControlToValidate="txtFrom" runat="server"  SetFocusOnError="True" ErrorMessage="Please fill the sender ID"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                                        To:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                     
                                        <asp:TextBox ID="txtTo" runat="server" Width="403px"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1"  SetFocusOnError="True" ControlToValidate="txtTo" runat="server" ErrorMessage="Please fill the Receiver ID"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    CCc :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox 
                        ID="txtCc" runat="server" Width="402px" 
                        style="margin-left: 0px"></asp:TextBox>
                        
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                                        Bcc :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                     
                    <asp:TextBox ID="txtBcc" runat="server" 
                        Width="403px"></asp:TextBox>
                        
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    Subject :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                     
                    <asp:TextBox ID="txtSubject" runat="server" Width="405px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    Message :<tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    Attachment:&nbsp;&nbsp;
                    <asp:FileUpload ID="inpAttachment1" runat="server" Height="31px" 
                        Width="407px" />
            <tr>
                <td class="style2">
                    &nbsp;</td>
                <td class="style8">
                    <asp:TextBox ID="txtMsg" runat="server" Height="147px" TextMode="MultiLine" 
                        Width="489px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style9">
                    <br />
                    <br />
                    <br />
                </td>
                <td class="style10">
                    <asp:Button ID="btnClear" runat="server" Height="34px" 
                        style="margin-left: 18px" Text="Clear" Width="92px" 
                        onclick="btnClear_Click" CausesValidation="false" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSend" runat="server" Height="31px" Text="Send &gt;&gt;" 
                        Width="76px" onclick="btnSend_Click" />
                    <br />
                    <asp:Label ID="lblStatus" runat="server" BackColor="#CC99FF" Font-Bold="True" 
                        Font-Italic="True" Font-Names="Monotype Corsiva" Font-Size="XX-Large" 
                        Font-Strikeout="False" ForeColor="#660066"></asp:Label>
&nbsp;
                    <br />
                    <br />
                    <br />
                    <br />
                </td>
            </tr>
        </table>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
 



    </div>
    </form>
</body>
</html>
